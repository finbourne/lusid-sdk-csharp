using System;
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Utilities
{
    public class TestDataUtilities
    {
        public const string TutorialScope = "Testdemo";
        
        //    Specific key used to denote cash in LUSID
        public const string LusidCashIdentifier = "Instrument/default/Currency";
        public const string LusidInstrumentIdentifier = "Instrument/default/LusidInstrumentId";
        
        private readonly ITransactionPortfoliosApi _transactionPortfoliosApi;

        public TestDataUtilities(ITransactionPortfoliosApi transactionPortfoliosApi)
        {
            _transactionPortfoliosApi = transactionPortfoliosApi;
        }

        public string CreateTransactionPortfolio(string scope)
        {
            var uuid = Guid.NewGuid().ToString();
            
            //    Effective date of the portfolio, this is the date the portfolio was created and became live.  All dates/times
            //    must be supplied in UTC
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            
            //    Details of the new portfolio to be created, created here with the minimum set of mandatory fields
            var request = new CreateTransactionPortfolioRequest(
                code: $"id-{uuid}",
                displayName: $"Portfolio-{uuid}",                 
                baseCurrency: "GBP",
                created: effectiveDate
            );
            
            //    Create the portfolio in LUSID
            var portfolio = _transactionPortfoliosApi.CreatePortfolio(scope, request);

            Assert.That(portfolio?.Id.Code, Is.EqualTo(request.Code));

            return portfolio.Id.Code;
        }


        public TransactionRequest BuildTransactionRequest(
            string instrumentId,
            decimal units, 
            decimal price,
            string currency,
            DateTimeOffset tradeDate, 
            string transactionType)
        {
            return new TransactionRequest(
                transactionId: Guid.NewGuid().ToString(),
                type: transactionType,
                instrumentIdentifiers: new Dictionary<string, string>
                {
                    ["Instrument/default/LusidInstrumentId"] = instrumentId
                },
                transactionDate: tradeDate,
                settlementDate: tradeDate,
                units: units,
                transactionPrice: new TransactionPrice(price, TransactionPrice.TypeEnum.Price),
                totalConsideration: new CurrencyAndAmount(price*units, currency),
                source: "Broker");
        }

        public TransactionRequest BuildCashFundsInTransactionRequest(
            decimal units,
            string currency,
            DateTimeOffset tradeDate)
        {
            return new TransactionRequest(
                transactionId: Guid.NewGuid().ToString(),
                
                //    Set the transaction type to denote cash being added to the portfolio
                type: "FundsIn",
                instrumentIdentifiers: new Dictionary<string, string>
                {
                    [LusidCashIdentifier] = currency
                },
                transactionDate: tradeDate,
                settlementDate: tradeDate,
                units: units,
                totalConsideration: new CurrencyAndAmount(0, "GBP"),
                transactionPrice: new TransactionPrice(0.0M),
                source: "Client");
        }
    }
}