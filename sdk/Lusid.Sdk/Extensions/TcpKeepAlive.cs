using System;
using System.Net;
using System.Net.Sockets;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using Lusid.Sdk.Client;

namespace Lusid.Sdk.Extensions;

internal static class TcpKeepAlive
{
    public static HttpMessageHandler CreateTcpKeepAliveMessageHandler(ClientOptions options)
    {
        var handler = new SocketsHttpHandler
        {
            SslOptions = new SslClientAuthenticationOptions()
        };
        // this stuff is mostly copied from RestClient to set options on the handler
        if (!OperatingSystem.IsBrowser()) {
            handler.UseCookies             = false;
#if NET
            handler.AutomaticDecompression = DecompressionMethods.All;
#else
            handler.AutomaticDecompression = DecompressionMethods.GZip;
#endif
            handler.PreAuthenticate        = false;
            if (options.ClientCertificates != null) {
                handler.SslOptions.ClientCertificates.AddRange(options.ClientCertificates);
                // removed ClientCertificateOption - all HttpClientHandler does is call LocalCertificateSelectionCallback without passing a list of certs.
            }
        }
        handler.AllowAutoRedirect = true;

        if (!OperatingSystem.IsBrowser() && !OperatingSystem.IsIOS() && !OperatingSystem.IsTvOS()) {
            handler.Proxy = options.Proxy;
        }
        // a fair chunk of this certificate stuff came directly from the HttpClientHandler class.
        // unfortunately, had to be a copy paste thing as the socket handler for that class was not made public, so 
        // couldn't modify it to set the TCP keepalive without some truely horrific reflection. So here we are
        // with a configuration method that does enough to set the keepalive and knowingly doesn't break under non-certificate use.
        // further testing will be needed if client-side certificates are used anywhere
        // It mostly validates that the certs can be used (they are valid, have a private key, etc)
        // currently DOES NOT support loading certs from a certificate store (which is the default for HttpClientHandler and RestClient)
        handler.SslOptions.LocalCertificateSelectionCallback = (sender, targetHost, localCertificates,
            remoteCertificate, acceptableIssuers) =>
        {
            bool IsValidForClientAuthenticationEKU(X509EnhancedKeyUsageExtension eku)
            {
                foreach (Oid oid in eku.EnhancedKeyUsages)
                {
                    if (oid.Value == "1.3.6.1.5.5.7.3.2")
                    {
                        return true;
                    }
                }

                return false;
            }

            bool IsValidForDigitalSignatureUsage(X509KeyUsageExtension ku)
            {
                const X509KeyUsageFlags RequiredUsages = X509KeyUsageFlags.DigitalSignature;
                return (ku.KeyUsages & RequiredUsages) == RequiredUsages;
            }

            bool IsValidClientCertificate(X509Certificate2 cert)
            {
                foreach (X509Extension extension in cert.Extensions)
                {
                    if ((extension is X509EnhancedKeyUsageExtension eku) &&
                        !IsValidForClientAuthenticationEKU(eku))
                    {
                        return false;
                    }
                    else if ((extension is X509KeyUsageExtension ku) && !IsValidForDigitalSignatureUsage(ku))
                    {
                        return false;
                    }
                }

                return true;
            }

            if (localCertificates.Count == 0)
            {
                return null;
            }

            foreach (X509Certificate2 cert in localCertificates)
            {
                if (!cert.HasPrivateKey)
                {
                    continue;
                }

                if (IsValidClientCertificate(cert))
                {
                    return cert;
                }
            }

            return null;
        };
        handler.ConnectCallback = async (ctx, ct) =>
        {
            var s = new Socket(SocketType.Stream, ProtocolType.Tcp) { NoDelay = true };
            try
            {
                s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                s.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.NoDelay, true);

                // we did have the interval and keepalivetime set at 30 a piece and the following line to 
                // set the number of retries, giving us a total of 50m.
                // s.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveRetryCount, 100);
                // However as stated originally, that line doesn't work on some windows versions, and
                // as it turns out, specifically doesn't work on Windows versions of Azure Functions, so 
                // isn't appropriate here. Instead, increasing both 30s keepalives to 300s achieves the same
                // 50m threshold without blowing up Azure Functions, so I think we're good.
                s.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveTime, 300);
                s.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.TcpKeepAliveInterval, 300);

                var addresses = await Dns.GetHostAddressesAsync(ctx.DnsEndPoint.Host, ct);
                var endpoint = new IPEndPoint(addresses[0], ctx.DnsEndPoint.Port);
                await s.ConnectAsync(endpoint, ct);
                return new NetworkStream(s, ownsSocket: true);
            }
            catch (Exception e)
            {
                // if we make it in here, there's a pretty good chance we've hit a DNS lookup error.  Not much to be done
                // other than rethrow.
                s.Dispose();

                if (Environment.GetEnvironmentVariable("SDK_LOGGING") != null)
                {
                    Console.WriteLine($"Socket Callback error - rethrowing: {e}");
                }

                throw;
            }
        };
        return handler;
    }

}
