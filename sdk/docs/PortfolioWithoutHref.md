# Lusid.Sdk.Model.PortfolioWithoutHref
A list of portfolios.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Type** | **string** | The type of the portfolio. Available values: Transaction, Reference, DerivedTransaction, SimplePosition. | 
**DisplayName** | **string** | The name of the portfolio. | 
**Description** | **string** | The long form description of the portfolio. | [optional] 
**Created** | **DateTimeOffset** | The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date. | 
**EnablementDate** | **DateTimeOffset?** | The effective datetime from which transactions or holdings booked to the portfolio begin contributing to holdings, valuations and other computed results. Data with an earlier effective date is still accepted and stored, but does not affect any computed results until this date. Defaults to the portfolio&#39;s creation date when not explicitly set. | [optional] 
**ParentPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**StagedModifications** | [**StagedModificationsInfo**](StagedModificationsInfo.md) |  | [optional] 
**IsDerived** | **bool** | Whether or not this is a derived portfolio. | [optional] 
**BaseCurrency** | **string** | The base currency of the portfolio. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain. | [optional] 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | A set of relationships associated to the portfolio. | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The instrument scope resolution strategy of this portfolio. | [optional] 
**AccountingMethod** | **string** | The AccountingMethod used for the portfolio. Available values: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency. | [optional] 
**AmortisationMethod** | **string** | The amortisation method used by the portfolio for the calculation. Available values: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate. | [optional] 
**TransactionTypeScope** | **string** | The scope of the transaction types. | [optional] 
**CashGainLossCalculationDate** | **string** | The scope of the transaction types. | [optional] 
**InstrumentEventConfiguration** | [**InstrumentEventConfiguration**](InstrumentEventConfiguration.md) |  | [optional] 
**AmortisationRuleSetId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TaxRuleSetScope** | **string** | The scope of the tax rule sets for this portfolio. | [optional] 
**SettlementConfiguration** | [**PortfolioSettlementConfiguration**](PortfolioSettlementConfiguration.md) |  | [optional] 
**TransactionExclusionFilter** | **string** | A filter expression that identifies transactions to exclude when building the transaction portfolio&#39;s transactions and holdings. Transactions matching this filter are flagged as excluded. | [optional] 
**TaxLotSelectionCostBasis** | **string** | The cost figure that cost-referencing accounting methods evaluate when selecting tax lots for a disposal. This can be: Cost or AmortisedCost. Defaults to Cost if not specified. Available values: Cost, AmortisedCost. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string type = "type";
string displayName = "displayName";
string description = "example description";
ResourceId? parentPortfolioId = new ResourceId();

ModelVersion? varVersion = new ModelVersion();

StagedModificationsInfo? stagedModifications = new StagedModificationsInfo();

bool isDerived = //"True";
string baseCurrency = "example baseCurrency";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Relationship> relationships = new List<Relationship>();
List<string> instrumentScopes = new List<string>();
string accountingMethod = "example accountingMethod";
string amortisationMethod = "example amortisationMethod";
string transactionTypeScope = "example transactionTypeScope";
string cashGainLossCalculationDate = "example cashGainLossCalculationDate";
InstrumentEventConfiguration? instrumentEventConfiguration = new InstrumentEventConfiguration();

ResourceId? amortisationRuleSetId = new ResourceId();

string taxRuleSetScope = "example taxRuleSetScope";
PortfolioSettlementConfiguration? settlementConfiguration = new PortfolioSettlementConfiguration();

string transactionExclusionFilter = "example transactionExclusionFilter";
string taxLotSelectionCostBasis = "example taxLotSelectionCostBasis";
List<Link> links = new List<Link>();

PortfolioWithoutHref portfolioWithoutHrefInstance = new PortfolioWithoutHref(
    id: id,
    type: type,
    displayName: displayName,
    description: description,
    created: created,
    enablementDate: enablementDate,
    parentPortfolioId: parentPortfolioId,
    varVersion: varVersion,
    stagedModifications: stagedModifications,
    isDerived: isDerived,
    baseCurrency: baseCurrency,
    properties: properties,
    relationships: relationships,
    instrumentScopes: instrumentScopes,
    accountingMethod: accountingMethod,
    amortisationMethod: amortisationMethod,
    transactionTypeScope: transactionTypeScope,
    cashGainLossCalculationDate: cashGainLossCalculationDate,
    instrumentEventConfiguration: instrumentEventConfiguration,
    amortisationRuleSetId: amortisationRuleSetId,
    taxRuleSetScope: taxRuleSetScope,
    settlementConfiguration: settlementConfiguration,
    transactionExclusionFilter: transactionExclusionFilter,
    taxLotSelectionCostBasis: taxLotSelectionCostBasis,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
