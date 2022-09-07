using System;
using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;

namespace Examples
{
    public class HelloWorld
    {
        static void Main(string[] args)
        {
            new HelloWorld().Run();
        }

        public List<PortfolioHolding> Run()
        {
            // tag::create-client-factory[]
            var secretsFile = "secrets.json";
            var apiFactory = LusidApiFactoryBuilder.Build(secretsFile);
            // end::create-client-factory[]

            // tag::create-tx-portfolios-api[]
            var txPortoliosApi = apiFactory.Api<ITransactionPortfoliosApi>();
            // end::create-tx-portfolios-api[]

            // tag::create-portfolio[]
            var scope = "GettingStartedScope";
            var uuid = Guid.NewGuid().ToString();
            var portfolioRequest = new CreateTransactionPortfolioRequest(
                displayName: $"Portfolio-{uuid}",
                code: $"id-{uuid}",
                created: new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero),
                baseCurrency: "GBP"
            );
            var portfolio = txPortoliosApi.CreatePortfolio(scope, portfolioRequest);
            var portfolioCode = portfolio.Id.Code;
            Console.WriteLine($"Portfolio Code: {portfolioCode}");
            // end::create-portfolio[]

            // tag::upsert-instruments[]
            var instrumentsApi = apiFactory.Api<IInstrumentsApi>();
            var figsiToCreate = new Dictionary<string, InstrumentDefinition>
            {
                ["BBG000C6K6G9"] = new InstrumentDefinition(
                    name: "VODAFONE GROUP PLC",
                    identifiers: new Dictionary<string, InstrumentIdValue>
                        {["Figi"] = new InstrumentIdValue(value: "BBG000C6K6G9")})
            };
            instrumentsApi.UpsertInstruments(figsiToCreate);
            // end::upsert-instruments[]

            // tag::get-instruments[]
            var instrumentsResponse =
                instrumentsApi.GetInstruments(identifierType: "Figi", requestBody: figsiToCreate.Keys.ToList());
            var luidToName =
                instrumentsResponse.Values.ToDictionary(value => value.Value.LusidInstrumentId,
                    value => value.Value.Name);
            var nameToLuid =
                instrumentsResponse.Values.ToDictionary(value => value.Value.Name,
                    value => value.Value.LusidInstrumentId);
            // end::get-instruments[]

            // tag::upsert-transactions[]
            var transactions = new List<TransactionRequest>()
            {
                new TransactionRequest(
                    transactionId: Guid.NewGuid().ToString(),
                    type: "StockIn",
                    instrumentIdentifiers: new Dictionary<string, string>
                    {
                        ["Instrument/default/LusidInstrumentId"] = nameToLuid["VODAFONE GROUP PLC"]
                    },
                    transactionDate: new DateTimeOffset(2021, 3, 27, 0, 0, 0, TimeSpan.Zero),
                    settlementDate: new DateTimeOffset(2021, 3, 28, 0, 0, 0, TimeSpan.Zero),
                    transactionPrice: new TransactionPrice(103),
                    units: 100,
                    totalConsideration: new CurrencyAndAmount(amount: 103 * 100, currency: "GBP"),
                    source: "Broker"
                )
            };

            txPortoliosApi.UpsertTransactions(scope: scope, code: portfolioCode, transactionRequest: transactions);
            // end::upsert-transactions[]

            // tag::get-holdings[]
            var holdingsResponse = txPortoliosApi.GetHoldings(scope: scope, code: portfolioCode,
                propertyKeys: new List<String>() {"Instrument/default/Name"});
            foreach (var holding in holdingsResponse.Values)
            {
                Console.WriteLine($"{luidToName[holding.InstrumentUid]}, {holding.Units}, {holding.Cost.Amount}");
            }
            // end::get-holdings[]

            return holdingsResponse.Values;
        }
    }
}