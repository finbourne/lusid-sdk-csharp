using System;
using System.IO;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Lusid.Sdk.Tests
{
    [TestFixture]
    public class LusidApiFactoryTests
    {
        private ILusidApiFactory _factory = new LusidApiFactory(new Configuration());

        [OneTimeSetUp]
        public void SetUp()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("secrets.json")
                .Build();
            
            ApiConfiguration apiConfiguration = new ApiConfiguration();

            config.GetSection("api").Bind(apiConfiguration);           

            Assert.That(apiConfiguration, Is.Not.Null);
            
            _factory = new LusidApiFactory(apiConfiguration);
        }

        [Test]
        public void Create_PortfoliosApi()
        {
            var api = _factory.Api<PortfoliosApi>();
            
            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<PortfoliosApi>());
        }
        
        [Test]
        public void Create_TransactionPortfoliosApi()
        {
            var api = _factory.Api<TransactionPortfoliosApi>();
            
            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<TransactionPortfoliosApi>());
        }

        class InvalidApi : IApiAccessor
        {
            public Configuration Configuration { get; set; }
            public string GetBasePath()
            {
                throw new NotImplementedException();
            }

            public ExceptionFactory ExceptionFactory { get; set; }
        }
        
        [Test]
        public void Invalid_Requested_Api_Throws()
        {
            Assert.That(() => _factory.Api<InvalidApi>(), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Api_From_Interface()
        {
            var api = _factory.Api<ITransactionPortfoliosApi>();
            
            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<TransactionPortfoliosApi>());
        }

        [Test]
        public void Api_From_Implementation()
        {
            var api = _factory.Api<TransactionPortfoliosApi>();
            
            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<TransactionPortfoliosApi>());
        }

        [Test]
        public void ApiException_Converts_To_ErrorResponse()
        {
            try
            {
                var api = _factory.Api<PortfoliosApi>().GetPortfolio("doesnt", "exist");
            }
            catch (ApiException e)
            {
                //    ApiException.ErrorContent contains a JSON serialized ErrorResponse
                ErrorResponse errorResponse = e.ErrorResponse();
                
                Assert.That(errorResponse.DetailedMessage, Does.Match("Portfolio with id exist in scope doesnt effective.*does not exist"));
                Assert.That(errorResponse.Code, Is.EqualTo(ErrorResponse.CodeEnum.PortfolioNotFound));
            }            
        }

    }
}