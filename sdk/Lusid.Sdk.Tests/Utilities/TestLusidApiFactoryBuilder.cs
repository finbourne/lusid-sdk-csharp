using System;
using System.IO;
using Lusid.Sdk.Utilities;

namespace Lusid.Sdk.Tests.Utilities
{
    public class TestLusidApiFactoryBuilder
    {
        public static ILusidApiFactory CreateApiFactory(string secretsFile)
        {
            return File.Exists(secretsFile)
                ? LusidApiFactoryBuilder.Build(secretsFile)
                : LusidApiFactoryBuilder.Build(null);
        }
        
        public static ApiConfiguration CreateApiConfiguration(string secretsFile)
        {
            return File.Exists(secretsFile)
                ? ApiConfigurationBuilder.Build(secretsFile)
                : ApiConfigurationBuilder.Build(null);
        }
    }
}