# Lusid.Sdk.Model.CreateDerivedTransactionPortfolioRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the derived transaction portfolio. | 
**Description** | **string** | A description for the derived transaction portfolio. | [optional] 
**Code** | **string** | The code of the derived transaction portfolio. Together with the scope this uniquely identifies the derived transaction portfolio. | 
**ParentPortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**Created** | **DateTimeOffset?** | This will be auto-populated to be the parent portfolio creation date. | [optional] 
**EnablementDate** | **DateTimeOffset?** | The effective datetime from which transactions booked to the derived transaction portfolio begin contributing to holdings, valuations and other computed results. Transactions with an earlier effective date are still accepted and stored, but do not affect any computed results until this date. Defaults to the portfolio&#39;s creation date if not specified. | [optional] 
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AccountingMethod** | **string** | Determines the accounting treatment given to the transaction portfolio&#39;s tax lots. Default value: AverageCost. Available values: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency. | [optional] 
**SubHoldingKeys** | **List&lt;string&gt;** | A set of unique transaction properties to group the derived transaction portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. See https://support.lusid.com/knowledgebase/article/KA-01879/en-us for more information. | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The resolution strategy used to resolve instruments of transactions/holdings upserted to this derived portfolio. | [optional] 
**AmortisationMethod** | **string** | The amortisation method used by the portfolio for the calculation. Available values: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate. | [optional] 
**TransactionTypeScope** | **string** | The scope of the transaction types. | [optional] 
**CashGainLossCalculationDate** | **string** | The option when the Cash Gain Loss to be calulated. Default value: SettlementDate. Available values: Default, SettlementDate, TransactionDate. | [optional] 
**AmortisationRuleSetId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentEventConfiguration** | [**InstrumentEventConfiguration**](InstrumentEventConfiguration.md) |  | [optional] 
**SettlementConfiguration** | [**PortfolioSettlementConfiguration**](PortfolioSettlementConfiguration.md) |  | [optional] 
**TransactionExclusionFilter** | **string** | A filter expression that identifies transactions to exclude when building the transaction portfolio&#39;s transactions and holdings. Transactions matching this filter are flagged as excluded. | [optional] 
**TaxLotSelectionCostBasis** | **string** | The cost figure that cost-referencing accounting methods evaluate when selecting tax lots for a disposal. This can be: Cost or AmortisedCost. Defaults to Cost if not specified. Supply Default to explicitly reset it; a reset or never-configured basis reads back as absent. Available values: Default, Cost, AmortisedCost. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
string code = "code";
ResourceId parentPortfolioId = new ResourceId();
ResourceId? corporateActionSourceId = new ResourceId();

string accountingMethod = "example accountingMethod";
List<string> subHoldingKeys = new List<string>();
List<string> instrumentScopes = new List<string>();
string amortisationMethod = "example amortisationMethod";
string transactionTypeScope = "example transactionTypeScope";
string cashGainLossCalculationDate = "example cashGainLossCalculationDate";
ResourceId? amortisationRuleSetId = new ResourceId();

InstrumentEventConfiguration? instrumentEventConfiguration = new InstrumentEventConfiguration();

PortfolioSettlementConfiguration? settlementConfiguration = new PortfolioSettlementConfiguration();

string transactionExclusionFilter = "example transactionExclusionFilter";
string taxLotSelectionCostBasis = "example taxLotSelectionCostBasis";

CreateDerivedTransactionPortfolioRequest createDerivedTransactionPortfolioRequestInstance = new CreateDerivedTransactionPortfolioRequest(
    displayName: displayName,
    description: description,
    code: code,
    parentPortfolioId: parentPortfolioId,
    created: created,
    enablementDate: enablementDate,
    corporateActionSourceId: corporateActionSourceId,
    accountingMethod: accountingMethod,
    subHoldingKeys: subHoldingKeys,
    instrumentScopes: instrumentScopes,
    amortisationMethod: amortisationMethod,
    transactionTypeScope: transactionTypeScope,
    cashGainLossCalculationDate: cashGainLossCalculationDate,
    amortisationRuleSetId: amortisationRuleSetId,
    instrumentEventConfiguration: instrumentEventConfiguration,
    settlementConfiguration: settlementConfiguration,
    transactionExclusionFilter: transactionExclusionFilter,
    taxLotSelectionCostBasis: taxLotSelectionCostBasis);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
