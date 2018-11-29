using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web;
using Lusid.Sdk.Client;
using Newtonsoft.Json;

namespace Lusid.Sdk.Utilities
{
    public interface ILusidApiFactory
    {
        TApi Api<TApi>() where TApi : class, IApiAccessor;
    }

    public class LusidApiFactory : ILusidApiFactory
    {
        private Dictionary<Type, IApiAccessor> _apis;
            
        public LusidApiFactory(ApiConfiguration apiConfiguration)
        {
            if (apiConfiguration == null) throw new ArgumentNullException(nameof(apiConfiguration));

            string apiToken;
            using (var httpClient = new HttpClient())
            {
                //Only accept JSON
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // gets the response
                
                var tokenRequestBody = 
                    $@"grant_type=password&username={HttpUtility.UrlEncode(apiConfiguration.Username)}&password={HttpUtility.UrlEncode(apiConfiguration.Password)}&scope=openid client groups&client_id={apiConfiguration.ClientId}&client_secret={apiConfiguration.ClientSecret}";                
                var tokenRequest =
                    new HttpRequestMessage(HttpMethod.Post, apiConfiguration.TokenUrl) {Content = new StringContent(tokenRequestBody)};
                tokenRequest.Content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                var response = httpClient.SendAsync(tokenRequest).Result;
                var body = response.Content.ReadAsStringAsync().Result;
                response.EnsureSuccessStatusCode();
                apiToken = JsonConvert.DeserializeObject<Dictionary<string, string>>(body)["access_token"];                
            }

            var configuration = new Configuration
            {
                BasePath = apiConfiguration.ApiUrl,
                AccessToken = apiToken
            };
            
            Init(configuration);
        }
                
        public LusidApiFactory(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            
            Init(configuration);
        }

        private void Init(Configuration configuration)
        {   
            IEnumerable<Type> apis = Assembly.GetAssembly(typeof(ApiClient))
                .GetTypes()
                .Where(t => typeof(IApiAccessor).IsAssignableFrom(t) && t.IsClass);

            _apis = new Dictionary<Type, IApiAccessor>();
            foreach (var api in apis)
            {
                if (!(Activator.CreateInstance(api, configuration) is IApiAccessor impl))
                {
                    throw new Exception($"Unable to create type {api}");
                }

                var @interface = api.GetInterfaces()
                    .First(i => typeof(IApiAccessor).IsAssignableFrom(i));

                _apis[api] = impl;
                _apis[@interface] = impl;
            }
        }

        public TApi Api<TApi>() where TApi : class, IApiAccessor
        {
            _apis.TryGetValue(typeof(TApi), out var api);

            if (api == null)
            {
                throw new InvalidOperationException($"Unable to find api: {typeof(TApi)}");
            }
            return api as TApi;
        }
    }
}