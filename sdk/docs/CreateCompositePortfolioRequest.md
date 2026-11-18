# Lusid.Sdk.Model.CreateCompositePortfolioRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the composite portfolio. | 
**Description** | **string** | A description for the composite portfolio. | [optional] 
**Code** | **string** | The code of the composite portfolio. Together with the scope this uniquely identifies the composite portfolio. | 
**Constituents** | [**List&lt;CompositePortfolioConstituentRequest&gt;**](CompositePortfolioConstituentRequest.md) | The portfolios that the composite portfolio composes. At least one is required. Each constituent contributes its whole history. | 
**Created** | **DateTimeOffset?** | The original creation date. Defaults to the earliest creation date of the constituents if not specified, because the composite portfolio cannot exist before the first of the portfolios it composes. A constituent created later contributes from its own creation date. | [optional] 
**EnablementDate** | **DateTimeOffset?** | The effective datetime from which instrument events and corporate actions are generated and applied to the composite portfolio. Transactions contribute to holdings, valuations and other computed results from the portfolio&#39;s creation date whatever the enablement date. Defaults to the portfolio&#39;s creation date if not specified. | [optional] 
**BaseCurrency** | **string** | The base currency of the composite portfolio. Every constituent must have the same base currency. | 
**AccountingMethod** | **string** | Determines the accounting treatment given to the composite portfolio&#39;s tax lots. Default value: AverageCost. Available values: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency. | [optional] 
**SubHoldingKeys** | **List&lt;string&gt;** | A set of unique transaction properties to group the composite portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. See https://support.lusid.com/docs/how-do-i-register-sub-holding-keys-shks-with-a-portfolio for more information. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Properties to add to the composite portfolio. Each property must be from the &#39;Portfolio&#39; domain. | [optional] 
**AmortisationMethod** | **string** | The amortisation method used by the portfolio for the calculation. Available values: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate. | [optional] 
**CashGainLossCalculationDate** | **string** | The option when the Cash Gain Loss to be calulated. Default value: SettlementDate. Available values: Default, SettlementDate, TransactionDate. | [optional] 
**AmortisationRuleSetId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentEventConfiguration** | [**InstrumentEventConfiguration**](InstrumentEventConfiguration.md) |  | [optional] 
**TransactionExclusionFilter** | **string** | A filter expression that identifies transactions to exclude when building the transaction portfolio&#39;s transactions and holdings. Transactions matching this filter are flagged as excluded. | [optional] 
**TaxLotSelectionCostBasis** | **string** | The cost figure that cost-referencing accounting methods evaluate when selecting tax lots for a disposal. This can be: Cost or AmortisedCost. Defaults to Cost if not specified. Supply Default to explicitly reset it; a reset or never-configured basis reads back as absent. Available values: Default, Cost, AmortisedCost. | [optional] 
**FractionalUnitsTrueUpConfiguration** | [**FractionalUnitsTrueUpConfiguration**](FractionalUnitsTrueUpConfiguration.md) |  | [optional] 
**HoldingsFungibility** | **string** | Whether the portfolio&#39;s holdings are fungible across the currencies of a currency group. This can be: Default or Enabled. Defaults to Default if not specified, which currently means holdings fungibility is not applied. Supply Default to explicitly reset it; a reset or never-configured flag reads back as absent. Available values: Default, Enabled. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
string code = "code";
List<CompositePortfolioConstituentRequest> constituents = new List<CompositePortfolioConstituentRequest>();
string baseCurrency = "baseCurrency";
string accountingMethod = "example accountingMethod";
List<string> subHoldingKeys = new List<string>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string amortisationMethod = "example amortisationMethod";
string cashGainLossCalculationDate = "example cashGainLossCalculationDate";
ResourceId? amortisationRuleSetId = new ResourceId();

InstrumentEventConfiguration? instrumentEventConfiguration = new InstrumentEventConfiguration();

string transactionExclusionFilter = "example transactionExclusionFilter";
string taxLotSelectionCostBasis = "example taxLotSelectionCostBasis";
FractionalUnitsTrueUpConfiguration? fractionalUnitsTrueUpConfiguration = new FractionalUnitsTrueUpConfiguration();

string holdingsFungibility = "example holdingsFungibility";

CreateCompositePortfolioRequest createCompositePortfolioRequestInstance = new CreateCompositePortfolioRequest(
    displayName: displayName,
    description: description,
    code: code,
    constituents: constituents,
    created: created,
    enablementDate: enablementDate,
    baseCurrency: baseCurrency,
    accountingMethod: accountingMethod,
    subHoldingKeys: subHoldingKeys,
    properties: properties,
    amortisationMethod: amortisationMethod,
    cashGainLossCalculationDate: cashGainLossCalculationDate,
    amortisationRuleSetId: amortisationRuleSetId,
    instrumentEventConfiguration: instrumentEventConfiguration,
    transactionExclusionFilter: transactionExclusionFilter,
    taxLotSelectionCostBasis: taxLotSelectionCostBasis,
    fractionalUnitsTrueUpConfiguration: fractionalUnitsTrueUpConfiguration,
    holdingsFungibility: holdingsFungibility);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
