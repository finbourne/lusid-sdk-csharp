using System;

// ReSharper disable once CheckNamespace
namespace Lusid.Sdk.Client
{
    // DEV-7152: Bug in .NET Core 2.2 means any un-disposed HttpClients will leak sockets
    // https://github.com/dotnet/corefx/pull/38499
    // https://github.com/dotnet/runtime/issues/29327
    // Use a finalizer to ensure RestClient (and thus HttpClient) instances are always disposed

    public partial class ApiClient : IDisposable
    {
        /// <summary />
        public void Dispose()
        {
            DisposeImpl();
            GC.SuppressFinalize(this);
        }

        /// <summary />
        ~ApiClient()
        {
            DisposeImpl();
        }

        private void DisposeImpl()
        {
            RestClient?.Dispose();
        }
    }
}
