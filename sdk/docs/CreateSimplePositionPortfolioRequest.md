# Lusid.Sdk.Model.CreateSimplePositionPortfolioRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the simple position portfolio. | 
**Description** | **string** | A description for the simple position portfolio. | [optional] 
**Code** | **string** | The code of the simple position portfolio. Together with the scope this uniquely identifies the simple position portfolio. | 
**Created** | **DateTimeOffset?** | The effective datetime at which to create the simple position portfolio. No holdings can be set on the simple position portfolio before this date. Defaults to the current LUSID system datetime if not specified. | [optional] 
**BaseCurrency** | **string** | The base currency of the simple position portfolio in ISO 4217 currency code format. | 
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AccountingMethod** | **string** | . The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency | [optional] 
**SubHoldingKeys** | **List&lt;string&gt;** | A set of unique transaction properties to group the simple position portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. See https://support.lusid.com/knowledgebase/article/KA-01879/en-us for more information. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of unique portfolio properties to add custom data to the simple position portfolio. Each property must be from the &#39;Portfolio&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Note these properties must be pre-defined. | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The resolution strategy used to resolve instruments of holdings upserted to this portfolio. | [optional] 
**AmortisationMethod** | **string** | The amortisation method used by the portfolio for the calculation. The available values are: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate | [optional] 
**TransactionTypeScope** | **string** | The scope of the transaction types. | [optional] 
**CashGainLossCalculationDate** | **string** | The option when the Cash Gain Loss to be calulated, TransactionDate/SettlementDate. Defaults to SettlementDate. | [optional] 
**InstrumentEventConfiguration** | [**InstrumentEventConfiguration**](InstrumentEventConfiguration.md) |  | [optional] 
**AmortisationRuleSetId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
string code = "code";
string baseCurrency = "baseCurrency";
ResourceId? corporateActionSourceId = new ResourceId();

string accountingMethod = "example accountingMethod";
List<string> subHoldingKeys = new List<string>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<string> instrumentScopes = new List<string>();
string amortisationMethod = "example amortisationMethod";
string transactionTypeScope = "example transactionTypeScope";
string cashGainLossCalculationDate = "example cashGainLossCalculationDate";
InstrumentEventConfiguration? instrumentEventConfiguration = new InstrumentEventConfiguration();

ResourceId? amortisationRuleSetId = new ResourceId();


CreateSimplePositionPortfolioRequest createSimplePositionPortfolioRequestInstance = new CreateSimplePositionPortfolioRequest(
    displayName: displayName,
    description: description,
    code: code,
    created: created,
    baseCurrency: baseCurrency,
    corporateActionSourceId: corporateActionSourceId,
    accountingMethod: accountingMethod,
    subHoldingKeys: subHoldingKeys,
    properties: properties,
    instrumentScopes: instrumentScopes,
    amortisationMethod: amortisationMethod,
    transactionTypeScope: transactionTypeScope,
    cashGainLossCalculationDate: cashGainLossCalculationDate,
    instrumentEventConfiguration: instrumentEventConfiguration,
    amortisationRuleSetId: amortisationRuleSetId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
