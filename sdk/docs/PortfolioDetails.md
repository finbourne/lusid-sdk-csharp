# Lusid.Sdk.Model.PortfolioDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**OriginPortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**BaseCurrency** | **string** | The base currency of the transaction portfolio. | 
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**SubHoldingKeys** | **List&lt;string&gt;** |  | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The resolution strategy used to resolve instruments of transactions/holdings upserted to the transaction portfolio. | [optional] 
**AccountingMethod** | **string** | The AccountingMethod used for the portfolio. Available values: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency. | [optional] 
**AmortisationMethod** | **string** | The amortisation method used by the portfolio for the calculation. Available values: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate. | [optional] 
**TransactionTypeScope** | **string** | The scope of the transaction types. | [optional] 
**CashGainLossCalculationDate** | **string** | The option when the Cash Gain Loss to be calulated. Default value: SettlementDate. | [optional] 
**InstrumentEventConfiguration** | [**InstrumentEventConfiguration**](InstrumentEventConfiguration.md) |  | [optional] 
**AmortisationRuleSetId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TaxRuleSetScope** | **string** | The scope of the tax rule sets for this portfolio. | [optional] 
**SettlementConfiguration** | [**PortfolioSettlementConfiguration**](PortfolioSettlementConfiguration.md) |  | [optional] 
**StagedModifications** | [**StagedModificationsInfo**](StagedModificationsInfo.md) |  | [optional] 
**TransactionExclusionFilter** | **string** | A filter expression that identifies transactions to exclude when building the transaction portfolio&#39;s transactions and holdings. Transactions matching this filter are flagged as excluded. | [optional] 
**TaxLotSelectionCostBasis** | **string** | The cost figure that cost-referencing accounting methods evaluate when selecting tax lots for a disposal. This can be: Cost or AmortisedCost. Defaults to Cost if not specified. Supply Default to explicitly reset it; a reset or never-configured basis reads back as absent. Available values: Default, Cost, AmortisedCost. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId originPortfolioId = new ResourceId();
ModelVersion varVersion = new ModelVersion();
string baseCurrency = "baseCurrency";
ResourceId? corporateActionSourceId = new ResourceId();

List<string> subHoldingKeys = new List<string>();
List<string> instrumentScopes = new List<string>();
string accountingMethod = "example accountingMethod";
string amortisationMethod = "example amortisationMethod";
string transactionTypeScope = "example transactionTypeScope";
string cashGainLossCalculationDate = "example cashGainLossCalculationDate";
InstrumentEventConfiguration? instrumentEventConfiguration = new InstrumentEventConfiguration();

ResourceId? amortisationRuleSetId = new ResourceId();

string taxRuleSetScope = "example taxRuleSetScope";
PortfolioSettlementConfiguration? settlementConfiguration = new PortfolioSettlementConfiguration();

StagedModificationsInfo? stagedModifications = new StagedModificationsInfo();

string transactionExclusionFilter = "example transactionExclusionFilter";
string taxLotSelectionCostBasis = "example taxLotSelectionCostBasis";
List<Link> links = new List<Link>();

PortfolioDetails portfolioDetailsInstance = new PortfolioDetails(
    href: href,
    originPortfolioId: originPortfolioId,
    varVersion: varVersion,
    baseCurrency: baseCurrency,
    corporateActionSourceId: corporateActionSourceId,
    subHoldingKeys: subHoldingKeys,
    instrumentScopes: instrumentScopes,
    accountingMethod: accountingMethod,
    amortisationMethod: amortisationMethod,
    transactionTypeScope: transactionTypeScope,
    cashGainLossCalculationDate: cashGainLossCalculationDate,
    instrumentEventConfiguration: instrumentEventConfiguration,
    amortisationRuleSetId: amortisationRuleSetId,
    taxRuleSetScope: taxRuleSetScope,
    settlementConfiguration: settlementConfiguration,
    stagedModifications: stagedModifications,
    transactionExclusionFilter: transactionExclusionFilter,
    taxLotSelectionCostBasis: taxLotSelectionCostBasis,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
