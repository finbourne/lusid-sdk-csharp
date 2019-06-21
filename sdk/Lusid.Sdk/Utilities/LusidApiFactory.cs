using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Lusid.Sdk.Client;

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

            var tokenProvider = new ClientCredentialsFlowTokenProvider(apiConfiguration);
            var configuration = new TokenProviderConfiguration(tokenProvider)
            {
                BasePath = apiConfiguration.ApiUrl,
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