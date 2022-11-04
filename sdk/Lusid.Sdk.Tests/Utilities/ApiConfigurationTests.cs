using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Utilities
{
    [TestFixture]
    public class ApiConfigurationTest
    {
        [Test]
        public void TestHasMissingPersonalAccessTokenConfig()
        {
            var config = new ApiConfiguration() {PersonalAccessToken = "token"};
            Assert.IsTrue(config.HasMissingConfig());
            Assert.AreEqual("ApiUrl", string.Join(",", config.GetMissingConfig()));
        }

        [Test]
        public void TestHasCompletePersonalAccessTokenConfig()
        {
            var config = new ApiConfiguration() {PersonalAccessToken = "token", ApiUrl = "http://bla.com"};
            Assert.IsFalse(config.HasMissingConfig());
            Assert.AreEqual("", string.Join(",", config.GetMissingConfig()));
        }

        [Test]
        public void TestHasMissingSecretsConfig()
        {
            var config = new ApiConfiguration() {ApiUrl = "http://bla.com"};
            Assert.IsTrue(config.HasMissingConfig());
            Assert.AreEqual("TokenUrl,Username,Password,ClientId,ClientSecret", string.Join(",", config.GetMissingConfig()));
        }

        [Test]
        public void TestHasCompleteSecretsConfig()
        {
            var config = new ApiConfiguration() {ApiUrl = "http://bla.com", Username = "un", Password = "pwd", ClientId = "cid", ClientSecret = "cs", TokenUrl = "tu"};
            Assert.IsFalse(config.HasMissingConfig());
            Assert.AreEqual(string.Empty, string.Join(",", config.GetMissingConfig()));
        }
    }
} 