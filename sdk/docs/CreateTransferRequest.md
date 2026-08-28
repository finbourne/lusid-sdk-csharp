# Lusid.Sdk.Model.CreateTransferRequest
A request to create a transfer: the paired transaction legs that move a position, and the Transfer entity  recording them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransferId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioIdOut** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioIdIn** | [**ResourceId**](ResourceId.md) |  | 
**InstrumentIdentifierOut** | **string** |  | 
**InstrumentIdentifierIn** | **string** |  | 
**PricingMethod** | **string** | Available values: AtCost, AtPrice. | 
**TaxLotStructure** | **string** | Available values: Consolidate, Preserve. | [optional] 
**UnitsOut** | **decimal** |  | 
**UnitsIn** | **decimal** |  | 
**AmountOut** | **decimal?** |  | [optional] 
**WeightOut** | **decimal?** |  | [optional] 
**TradeDateOut** | **DateTimeOffset** |  | 
**TradeDateIn** | **DateTimeOffset** |  | 
**SettlementDateOut** | **DateTimeOffset** |  | 
**SettlementDateIn** | **DateTimeOffset?** |  | [optional] 
**ExchangeRateOut** | **decimal?** |  | [optional] 
**ExchangeRateIn** | **decimal?** |  | [optional] 
**TransactionPriceOut** | **decimal?** |  | [optional] 
**TransactionPriceIn** | **decimal?** |  | [optional] 
**CounterpartyIdOut** | **string** |  | [optional] 
**CounterpartyIdIn** | **string** |  | [optional] 
**CustodianAccountIdOut** | [**ResourceId**](ResourceId.md) |  | [optional] 
**CustodianAccountIdIn** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Source** | **string** |  | 
**AccountingMethod** | **string** | Available values: AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency. | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) |  | [optional] 
**PropertiesIn** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) |  | [optional] 

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
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
Dictionary<string, PerpetualProperty> propertiesIn = new Dictionary<string, PerpetualProperty>();

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
    properties: properties,
    propertiesIn: propertiesIn);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
