using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Lusid.Sdk.Utilities;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Utilities
{
    public class ApiConfigurationBuilderTest
    {
        private string _cachedTokenUrl;
        private string _cachedApiUrl;
        private string _cachedClientId;
        private string _cachedClientSecret;
        private string _cachedUsername;
        private string _cachedPassword;
        private string _cachedApplicationName;
        private string _cachedPersonalAccessToken;

        [OneTimeSetUp]
        public void Setup()
        {
            _cachedTokenUrl = Environment.GetEnvironmentVariable("FBN_TOKEN_URL") ??
                              Environment.GetEnvironmentVariable("fbn_token_url");
            _cachedApiUrl = Environment.GetEnvironmentVariable("FBN_LUSID_API_URL") ??
                            Environment.GetEnvironmentVariable("fbn_lusid_api_url");
            _cachedClientId = Environment.GetEnvironmentVariable("FBN_CLIENT_ID") ??
                              Environment.GetEnvironmentVariable("fbn_client_id");
            _cachedClientSecret = Environment.GetEnvironmentVariable("FBN_CLIENT_SECRET") ??
                                  Environment.GetEnvironmentVariable("fbn_client_secret");
            _cachedUsername = Environment.GetEnvironmentVariable("FBN_USERNAME") ??
                              Environment.GetEnvironmentVariable("fbn_username");
            _cachedPassword = Environment.GetEnvironmentVariable("FBN_PASSWORD") ??
                              Environment.GetEnvironmentVariable("fbn_password");
            _cachedApplicationName = Environment.GetEnvironmentVariable("FBN_APP_NAME") ??
                                     Environment.GetEnvironmentVariable("fbn_app_name");
            _cachedPersonalAccessToken = Environment.GetEnvironmentVariable("FBN_ACCESS_TOKEN") ??
                                         Environment.GetEnvironmentVariable("fbn_access_token");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Environment.SetEnvironmentVariable("FBN_TOKEN_URL", _cachedTokenUrl);
            Environment.SetEnvironmentVariable("FBN_LUSID_API_URL", _cachedApiUrl);
            Environment.SetEnvironmentVariable("FBN_CLIENT_ID", _cachedClientId);
            Environment.SetEnvironmentVariable("FBN_CLIENT_SECRET", _cachedClientSecret);
            Environment.SetEnvironmentVariable("FBN_USERNAME", _cachedUsername);
            Environment.SetEnvironmentVariable("FBN_PASSWORD", _cachedPassword);
            Environment.SetEnvironmentVariable("FBN_APP_NAME", _cachedApplicationName);
            Environment.SetEnvironmentVariable("FBN_ACCESS_TOKEN", _cachedPersonalAccessToken);
        }

        [TestCase(null)]
        [TestCase("invalidFileName.json")]
        public void Fallback_To_Env_Variables_When_Missing_Secrets_File(string fileName)
        {
            try
            {
                var result = ApiConfigurationBuilder.Build(fileName);
                // assuming env variables are set:
                Assert.IsFalse(result.HasMissingConfig());
            }
            catch (MissingConfigException e)
            {
                // note: this test is likely to fail when run locally if you're missing the env variables but they are set on the build server so allowing the failure as well:
                Assert.AreEqual(e.Message,"The following required environment variables are not set: ['FBN_TOKEN_URL', 'FBN_USERNAME', 'FBN_PASSWORD', 'FBN_CLIENT_ID', 'FBN_CLIENT_SECRET', 'FBN_LUSID_API_URL']");
            }
        }

        [Test]
        public void Use_Secrets_File_If_It_Exists()
        {
            var secretsFile = PopulateDummySecretsFile(new Dictionary<string, string>
            {
                {"tokenUrl", "<tokenUrl - Use_Secrets_File_If_It_Exists>"},
                {"username", "<username - Use_Secrets_File_If_It_Exists>"},
                {"password", "<password - Use_Secrets_File_If_It_Exists>"},
                {"clientId", "<clientId - Use_Secrets_File_If_It_Exists>"},
                {"clientSecret", "<clientSecret - Use_Secrets_File_If_It_Exists>"},
                {"apiUrl", "<apiUrl - Use_Secrets_File_If_It_Exists>"},
            });

            var apiConfiguration = ApiConfigurationBuilder.Build(secretsFile);

            Assert.That(apiConfiguration.TokenUrl, Is.EqualTo("<tokenUrl - Use_Secrets_File_If_It_Exists>"));
            Assert.That(apiConfiguration.Username, Is.EqualTo("<username - Use_Secrets_File_If_It_Exists>"));
            Assert.That(apiConfiguration.Password, Is.EqualTo("<password - Use_Secrets_File_If_It_Exists>"));
            Assert.That(apiConfiguration.ClientId, Is.EqualTo("<clientId - Use_Secrets_File_If_It_Exists>"));
            Assert.That(apiConfiguration.ClientSecret, Is.EqualTo("<clientSecret - Use_Secrets_File_If_It_Exists>"));
            Assert.That(apiConfiguration.ApiUrl, Is.EqualTo("<apiUrl - Use_Secrets_File_If_It_Exists>"));
            
            File.Delete(secretsFile); // cleanup
        }

        [Test]
        public void Throw_Exception_If_Secrets_File_Incomplete()
        {
            var secretsFile = PopulateDummySecretsFile(new Dictionary<string, string>
            {
                {"tokenUrl", "<tokenUrl - Throw_Exception_If_Secrets_File_Incomplete>"},
                // {"username", "<username - Throw_Exception_If_Secrets_File_Incomplete>"},
                {"password", "<password - Throw_Exception_If_Secrets_File_Incomplete>"},
                // {"clientId", "<clientId - Throw_Exception_If_Secrets_File_Incomplete>"},
                {"clientSecret", "<clientSecret - Throw_Exception_If_Secrets_File_Incomplete>"},
                {"apiUrl", "<apiUrl - Throw_Exception_If_Secrets_File_Incomplete>"},
            });

            var exception = Assert.Throws<MissingConfigException>(() => ApiConfigurationBuilder.Build(secretsFile));
            Assert.That(exception.Message,
                Is.EqualTo(
                    "The provided secrets file is missing the following required values: ['username', 'clientId']"));
            File.Delete(secretsFile); // cleanup
        }

        [Test]
        public void Use_Environment_Variables_If_No_Secrets_File_Provided()
        {
            Environment.SetEnvironmentVariable("FBN_TOKEN_URL", "<env.tokenUrl>");
            Environment.SetEnvironmentVariable("FBN_LUSID_API_URL", "<env.apiUrl>");
            Environment.SetEnvironmentVariable("FBN_CLIENT_ID", "<env.clientId>");
            Environment.SetEnvironmentVariable("FBN_CLIENT_SECRET", "<env.clientSecret>");
            Environment.SetEnvironmentVariable("FBN_USERNAME", "<env.username>");
            Environment.SetEnvironmentVariable("FBN_PASSWORD", "<env.password>");
            Environment.SetEnvironmentVariable("FBN_APP_NAME", "<env.app_name>");

            var apiConfiguration = ApiConfigurationBuilder.Build(null);
            Assert.That(apiConfiguration.TokenUrl, Is.EqualTo("<env.tokenUrl>"));
            Assert.That(apiConfiguration.Username, Is.EqualTo("<env.username>"));
            Assert.That(apiConfiguration.Password, Is.EqualTo("<env.password>"));
            Assert.That(apiConfiguration.ClientId, Is.EqualTo("<env.clientId>"));
            Assert.That(apiConfiguration.ClientSecret, Is.EqualTo("<env.clientSecret>"));
            Assert.That(apiConfiguration.ApiUrl, Is.EqualTo("<env.apiUrl>"));
        }

        [Test]
        public void Throw_Exception_If_Environment_Variables_Incomplete()
        {
            Environment.SetEnvironmentVariable("FBN_TOKEN_URL", "<env.tokenUrl>");
            Environment.SetEnvironmentVariable("FBN_LUSID_API_URL", "<env.apiUrl>");
            Environment.SetEnvironmentVariable("FBN_CLIENT_ID", "<env.clientId>");
            Environment.SetEnvironmentVariable("FBN_CLIENT_SECRET", "");
            Environment.SetEnvironmentVariable("FBN_USERNAME", "<env.username>");
            Environment.SetEnvironmentVariable("FBN_PASSWORD", "");
            Environment.SetEnvironmentVariable("FBN_APP_NAME", "<env.app_name>");
            Environment.SetEnvironmentVariable("FBN_ACCESS_TOKEN", "");

            var exception = Assert.Throws<MissingConfigException>(() => ApiConfigurationBuilder.Build(null));
            Assert.That(exception.Message,
                Is.EqualTo(
                    "The following required environment variables are not set: ['FBN_PASSWORD', 'FBN_CLIENT_SECRET']"));
        }

        [Test]
        public void Use_Configuration_Section_If_Supplied()
        {
            var settings = new Dictionary<string, string>
            {
                { "api:TokenUrl", "<tokenUrl>" },
                { "api:ApiUrl", "<apiUrl>" },
                { "api:ClientId", "<clientId>" },
                { "api:ClientSecret", "<clientSecret>" },
                { "api:Username", "<username>" },
                { "api:Password", "<password>" },
                { "api:ApplicationName", "<app_name>" }
            };

            var config = new ConfigurationBuilder()
                .AddInMemoryCollection(settings)
                .Build();
            var section = config.GetSection("api");
            var apiConfiguration = ApiConfigurationBuilder.BuildFromConfiguration(section);

            Assert.That(apiConfiguration.TokenUrl, Is.EqualTo("<tokenUrl>"));
            Assert.That(apiConfiguration.Username, Is.EqualTo("<username>"));
            Assert.That(apiConfiguration.Password, Is.EqualTo("<password>"));
            Assert.That(apiConfiguration.ClientId, Is.EqualTo("<clientId>"));
            Assert.That(apiConfiguration.ClientSecret, Is.EqualTo("<clientSecret>"));
            Assert.That(apiConfiguration.ApiUrl, Is.EqualTo("<apiUrl>"));
        }

        [Test]
        public void Throw_Exception_If_Configuration_Section_Is_Null()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => ApiConfigurationBuilder.BuildFromConfiguration(null));
            Assert.That(exception.Message, Is.EqualTo("Value cannot be null. (Parameter 'config')"));
        }

        [Test]
        public void Throw_Exception_If_Configuration_Section_Incomplete()
        {
            var settings = new Dictionary<string, string>
            {
                { "api:TokenUrl", "<tokenUrl>" },
                { "api:ApiUrl", "<apiUrl>" },
                { "api:ClientId", "<clientId>" },
                { "api:ClientSecret", "" },
                { "api:Username", "<username>" },
                { "api:Password", "" },
                { "api:ApplicationName", "<app_name>" }
            };

            var config = new ConfigurationBuilder()
                .AddInMemoryCollection(settings)
                .Build();
            var section = config.GetSection("api");
            var exception = Assert.Throws<MissingConfigException>(() => ApiConfigurationBuilder.BuildFromConfiguration(section));
            Assert.That(exception.Message,
                Is.EqualTo(
                    "The provided configuration section is missing the following required values: ['Password', 'ClientSecret']"));
        }

        private String PopulateDummySecretsFile(Dictionary<string, string> config)
        {
            var secretsFile = Path.GetTempFileName();

            var secrets = new Dictionary<string, object>
            {
                ["api"] = config
            };
            var json = JsonSerializer.Serialize(secrets);
            File.WriteAllText(secretsFile, json);
            return secretsFile;
        }
    }
}