using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Finbourne.Sdk.Core.RestSharp;

namespace Lusid.Sdk.Client;

internal static class RestSharpExtensions
{
    internal static RestRequest ToRestSharpRequest(this Request request)
    {
        var method = request.Method switch
        {
            HttpMethod.Get => Method.Get,
            HttpMethod.Post => Method.Post,
            HttpMethod.Put => Method.Put,
            HttpMethod.Delete => Method.Delete,
            HttpMethod.Head => Method.Head,
            HttpMethod.Options => Method.Options,
            HttpMethod.Patch => Method.Patch,
            _ => throw new ArgumentOutOfRangeException(
                nameof(request.Method), 
                request.Method, 
                "unexpected value")
        };
        var requestFormat = request.RequestFormat switch
        {
            DataFormat.Json => Finbourne.Sdk.Core.RestSharp.DataFormat.Json,
            DataFormat.Xml => Finbourne.Sdk.Core.RestSharp.DataFormat.Xml,
            DataFormat.Binary => Finbourne.Sdk.Core.RestSharp.DataFormat.Binary,
            DataFormat.None => Finbourne.Sdk.Core.RestSharp.DataFormat.None,
            _ => throw new ArgumentOutOfRangeException(
                nameof(request.RequestFormat), 
                request.RequestFormat, 
                "unexpected value")
        };
        var restRequest = new RestRequest()
        {
            Method = method,
            RequestFormat = requestFormat,
            Resource = request.Resource,
            Timeout = request.Timeout,
        };
        if (request.Body != null)
        {
            switch (request.RequestFormat)
            {
                case DataFormat.Json:
                    restRequest.AddJsonBody(request.Body);
                    break;
                case DataFormat.Binary:
                    restRequest.AddBody(request.Body, request.Headers["Content-Type"][0]);
                    break;
                default:
                    restRequest.AddBody(request.Body);
                    break;
            }
        }
        foreach (var header in request.Headers)
        {
            foreach (var value in header.Value)
            {
                restRequest.AddHeader(header.Key, value);
            }
        }
        foreach (var param in request.QueryParameters)
        {
            foreach (var value in param.Value)
            {
                restRequest.AddQueryParameter(param.Key, value);
            }
        }
        foreach (var param in request.PathParameters)
        {
            var segmentParameter = new UrlSegmentParameter(param.Key, param.Value, replaceEncodedSlash: false);
            restRequest.AddParameter(segmentParameter);
        }
        foreach (var param in request.FormParameters)
        {
            restRequest.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);
        }
        foreach (var param in request.FileParameters)
        {
            foreach (var file in param.Value)
            {
                var bytes = ClientUtils.ReadAsBytes(file);
                var fileStream = file as FileStream;
                restRequest.AddFile(param.Key, bytes,
                    fileStream != null ? Path.GetFileName(fileStream.Name) : "no_file_name_provided");
            }
        }
        return restRequest;
    }

    internal static Request ToSdkRequest(this RestRequest restRequest)
    {
        var method = restRequest.Method switch
        {
            Method.Get => HttpMethod.Get,
            Method.Post => HttpMethod.Post,
            Method.Put => HttpMethod.Put,
            Method.Delete => HttpMethod.Delete,
            Method.Head => HttpMethod.Head,
            Method.Options => HttpMethod.Options,
            Method.Patch => HttpMethod.Patch,
            _ => throw new ArgumentOutOfRangeException(
                nameof(restRequest.Method), 
                restRequest.Method, 
                "unexpected value")
        };
        var requestFormat = restRequest.RequestFormat switch
        {
            Finbourne.Sdk.Core.RestSharp.DataFormat.Json => DataFormat.Json,
            Finbourne.Sdk.Core.RestSharp.DataFormat.Xml => DataFormat.Xml,
            Finbourne.Sdk.Core.RestSharp.DataFormat.Binary => DataFormat.Binary,
            Finbourne.Sdk.Core.RestSharp.DataFormat.None => DataFormat.None,
            _ => throw new ArgumentOutOfRangeException(
                nameof(restRequest.RequestFormat),
                restRequest.RequestFormat,
                "unexpected value")
        };
        var request = new Request()
        {
            Method = method,
            RequestFormat = requestFormat,
            Resource = restRequest.Resource,
            Timeout = restRequest.Timeout
        };
        foreach (var parameter in restRequest.Parameters)
        {
            switch (parameter.Type)
            {
                case ParameterType.GetOrPost:
                    request.FormParameters.Add(parameter.Name, parameter.Value?.ToString());
                    break;
                case ParameterType.UrlSegment: 
                    request.PathParameters.Add(parameter.Name, parameter.Value?.ToString());
                    break;
                case ParameterType.HttpHeader:
                    request.Headers.Add(parameter.Name, parameter.Value?.ToString());
                    break;
                case ParameterType.RequestBody:
                    request.Body = parameter.Value;
                    break;
                case ParameterType.QueryString:
                    request.QueryParameters.Add(parameter.Name, parameter.Value?.ToString());
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(parameter.Type), parameter.Type, "unexpected value");
            };
        }

        foreach (var file in restRequest.Files)
        {
            request.FileParameters.Add(file.Name, file.GetFile());
        }
    
        return request;
    }
    
    internal static Response<T> ToSdkResponse<T>(this RestResponse<T> restResponse)
    {
        return new Response<T>(restResponse.Request.ToSdkRequest())
        {
            Content = restResponse.Content,
            StatusCode = restResponse.StatusCode,
            IsSuccessStatusCode = restResponse.IsSuccessStatusCode,
            StatusDescription = restResponse.StatusDescription,
            RawBytes = restResponse.RawBytes,
            Headers = GetHeadersFromRestResponse(restResponse),
            ResponseStatus = restResponse.ResponseStatus switch
            {
                Finbourne.Sdk.Core.RestSharp.ResponseStatus.None => ResponseStatus.None,
                Finbourne.Sdk.Core.RestSharp.ResponseStatus.Completed => ResponseStatus.Completed,
                Finbourne.Sdk.Core.RestSharp.ResponseStatus.Error => ResponseStatus.Error,
                Finbourne.Sdk.Core.RestSharp.ResponseStatus.TimedOut => ResponseStatus.TimedOut,
                Finbourne.Sdk.Core.RestSharp.ResponseStatus.Aborted => ResponseStatus.Aborted,
                _ => throw new ArgumentOutOfRangeException(
                    nameof(restResponse.ResponseStatus), 
                    restResponse.ResponseStatus, 
                    "unexpected value")
            },
            ErrorMessage = restResponse.ErrorMessage,
            ErrorException = restResponse.ErrorException,
            Data = restResponse.Data
        };
    }

    // In Finbourne.Sdk.Core.RestSharp the headers and content headers are separated. Merge them back into a single collection
    private static List<Header> GetHeadersFromRestResponse<T>(RestResponse<T> restResponse)
    {
        var headers = restResponse.Headers?.Select(x => new Header(x.Name, x.Value)).ToList() ?? new List<Header>();
        if (restResponse.ContentHeaders != null)
        {
            headers.AddRange(restResponse.ContentHeaders.Select(x => new Header(x.Name, x.Value)));
        }
        return headers;
    }
}