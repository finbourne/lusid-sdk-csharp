# Lusid.Sdk.Model.CreateTransferRequest
A request to create a transfer: the paired transaction legs that move a position, and the Transfer entity  recording them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransferId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioIdOut** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioIdIn** | [**ResourceId**](ResourceId.md) |  | 
**InstrumentIdentifierOut** | **string** | The LUSID instrument id of the instrument moving out. A position in this instrument must exist in the outgoing portfolio on the outgoing trade date. | 
**InstrumentIdentifierIn** | **string** | The LUSID instrument id of the instrument moving in. Equal to InstrumentIdentifierOut for a transfer between portfolios. | 
**PricingMethod** | **string** | How the legs are priced. &#39;AtCost&#39; uses the cost per unit of the outgoing holding; &#39;AtPrice&#39; uses the supplied TransactionPriceOut, which is then required. Available values: AtCost, AtPrice. | 
**TaxLotStructure** | **string** | What happens to the tax lots of the outgoing position. Only &#39;Consolidate&#39; is currently supported; &#39;Preserve&#39; is rejected. Defaults to &#39;Consolidate&#39;. Available values: Consolidate, Preserve. | [optional] 
**UnitsOut** | **decimal** | The number of units to move out. Must be greater than zero. | 
**UnitsIn** | **decimal** | The number of units to move in. Must be greater than zero. | 
**AmountOut** | **decimal?** | The total consideration of the outgoing leg. Recorded, not applied. | [optional] 
**WeightOut** | **decimal?** | The weighting factor of the outgoing leg. Recorded, not applied. | [optional] 
**TradeDateOut** | **DateTimeOffset** | The trade date of the outgoing leg. Must not be later than TradeDateIn. | 
**TradeDateIn** | **DateTimeOffset** | The trade date of the incoming leg. | 
**SettlementDateOut** | **DateTimeOffset** | The settlement date of the outgoing leg. Must not be later than SettlementDateIn. | 
**SettlementDateIn** | **DateTimeOffset?** | The settlement date of the incoming leg. Defaults to SettlementDateOut when not supplied. | [optional] 
**ExchangeRateOut** | **decimal?** | The FX rate to apply to the outgoing leg. | [optional] 
**ExchangeRateIn** | **decimal?** | The FX rate to apply to the incoming leg. | [optional] 
**TransactionPriceOut** | **decimal?** | The unit price of the outgoing leg. Required when PricingMethod is &#39;AtPrice&#39;, and ignored when it is &#39;AtCost&#39;. | [optional] 
**TransactionPriceIn** | **decimal?** | The unit price of the incoming leg. Ignored for a transfer, which carries the outgoing price across; defaults to the outgoing price for a switch. | [optional] 
**CounterpartyIdOut** | **string** | The counterparty identifier of the outgoing leg. | [optional] 
**CounterpartyIdIn** | **string** | The counterparty identifier of the incoming leg. Defaults to CounterpartyIdOut. | [optional] 
**CustodianAccountIdOut** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CustodianAccountIdIn** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Source** | **string** | The transaction source the generated legs are booked against. | 
**AccountingMethod** | **string** | An accounting method to record against the transfer. Available values: AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency. | [optional] 
**PropertiesOut** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Transaction Properties to set on the outgoing transaction leg, and on the incoming transaction leg when PropertiesIn is absent. Supplying an empty collection for PropertiesIn leaves the incoming leg with no properties. | [optional] 
**PropertiesIn** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Transaction Properties to set on the incoming transaction leg, replacing rather than adding to PropertiesOut. | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Properties to set on the transfer itself, in the Transfer domain. These are separate from PropertiesOut and PropertiesIn, which are Transaction domain and land on the legs. | [optional] 
**TransactionToPortfolioRateOut** | **decimal?** | The rate from the outgoing leg&#39;s trade currency to the outgoing portfolio&#39;s base currency, applied whenever supplied. | [optional] 
**TransactionToPortfolioRateIn** | **decimal?** | The rate from the incoming leg&#39;s trade currency to the incoming portfolio&#39;s base currency. Required when the two portfolios have different base currencies, and applied whenever supplied. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId transferId = new ResourceId();
ResourceId portfolioIdOut = new ResourceId();
ResourceId portfolioIdIn = new ResourceId();
string instrumentIdentifierOut = "instrumentIdentifierOut";
string instrumentIdentifierIn = "instrumentIdentifierIn";
string pricingMethod = "pricingMethod";
string taxLotStructure = "example taxLotStructure";decimal unitsOut = "unitsOut";
decimal unitsIn = "unitsIn";

string counterpartyIdOut = "example counterpartyIdOut";
string counterpartyIdIn = "example counterpartyIdIn";
ResourceId? custodianAccountIdOut = new ResourceId();

ResourceId? custodianAccountIdIn = new ResourceId();

string source = "source";
string accountingMethod = "example accountingMethod";
Dictionary<string, PerpetualProperty> propertiesOut = new Dictionary<string, PerpetualProperty>();
Dictionary<string, PerpetualProperty> propertiesIn = new Dictionary<string, PerpetualProperty>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

CreateTransferRequest createTransferRequestInstance = new CreateTransferRequest(
    transferId: transferId,
    portfolioIdOut: portfolioIdOut,
    portfolioIdIn: portfolioIdIn,
    instrumentIdentifierOut: instrumentIdentifierOut,
    instrumentIdentifierIn: instrumentIdentifierIn,
    pricingMethod: pricingMethod,
    taxLotStructure: taxLotStructure,
    unitsOut: unitsOut,
    unitsIn: unitsIn,
    amountOut: amountOut,
    weightOut: weightOut,
    tradeDateOut: tradeDateOut,
    tradeDateIn: tradeDateIn,
    settlementDateOut: settlementDateOut,
    settlementDateIn: settlementDateIn,
    exchangeRateOut: exchangeRateOut,
    exchangeRateIn: exchangeRateIn,
    transactionPriceOut: transactionPriceOut,
    transactionPriceIn: transactionPriceIn,
    counterpartyIdOut: counterpartyIdOut,
    counterpartyIdIn: counterpartyIdIn,
    custodianAccountIdOut: custodianAccountIdOut,
    custodianAccountIdIn: custodianAccountIdIn,
    source: source,
    accountingMethod: accountingMethod,
    propertiesOut: propertiesOut,
    propertiesIn: propertiesIn,
    properties: properties,
    transactionToPortfolioRateOut: transactionToPortfolioRateOut,
    transactionToPortfolioRateIn: transactionToPortfolioRateIn);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
