# Lusid.Sdk.Model.NavType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The Status of the Nav Type. Available values: Active, Inactive. | 
**Code** | **string** | The Code for the Nav Type. Must be unique within the Fund. | [optional] 
**DisplayName** | **string** | The Display Name for the Nav Type. Must be unique within the Fund. | [optional] 
**Description** | **string** | The Description for the Nav Type. | [optional] 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**PostingModuleCodes** | **List&lt;string&gt;** | The Posting Module Codes from which the rules to be applied are retrieved. | [optional] 
**CleardownModuleCodes** | **List&lt;string&gt;** | The Cleardown Module Codes from which the rules to be applied are retrieved. | [optional] 
**SettlementConfiguration** | [**NavSettlementConfiguration**](NavSettlementConfiguration.md) |  | 
**ValuationRecipeId** | [**ResourceId**](ResourceId.md) |  | 
**HoldingRecipeId** | [**ResourceId**](ResourceId.md) |  | 
**AccountingMethod** | **string** | Determines the accounting treatment given to the simple position portfolio&#39;s tax lots. A non-default value is required. Available values: AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency. | 
**SubHoldingKeys** | **List&lt;string&gt;** | A set of unique transaction properties to group the derived transaction portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. See https://support.lusid.com/docs/how-do-i-register-sub-holding-keys-shks-with-a-portfolio for more information. | [optional] 
**AmortisationMethod** | **string** | The amortisation method used by the portfolio for the calculation. Available values: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate. | 
**TransactionTypeScope** | **string** | The scope of the transaction types. | 
**CashGainLossCalculationDate** | **string** | The option when the Cash Gain Loss to be calulated, TransactionDate/SettlementDate. A non-default value is required. Available values: SettlementDate, TransactionDate. | 
**AmortisationRuleSetId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**LeaderNavTypeCode** | **string** | The code of the Nav Type that this Nav Type will follow when set. | [optional] 
**TransactionTemplateScope** | **string** | The Transaction Template Scope used by the NavType. | 
**TransactionExclusionFilter** | **string** | Optional filter expression to exclude specific transactions from this NavType&#39;s derived portfolios. The filter can reference Transaction, Portfolio, or Instrument fields and properties. The filter can be changed by patching the NavType, which propagates it to the NavType&#39;s derived portfolios. A NavType never inherits the filter of the Fund&#39;s portfolios: omitting the filter, or setting it to an empty string, means no filter. A transaction amended across a Final valuation point so that it newly matches the filter is reversed in the next valuation point, and one amended so that it stops matching is posted in the next valuation point as a true-up. | [optional] 
**PricingBasis** | **string** | The side of the quote this Nav Type values the fund on: Mid, Bid or Ask. Overrides the pricing basis of the valuation recipe&#39;s market options for this Nav Type only, so a bid NAV and an ask NAV can share one recipe. Omit it to value on the recipe&#39;s own pricing basis. Available values: Mid, Bid, Ask. | [optional] 
**SwingPricing** | [**SwingPricingRule**](SwingPricingRule.md) |  | [optional] 
**NotionalDealingCostTableId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ValuationTemplateId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ChargeableGainsRegime** | **string** | The chargeable gains regime the Nav Type&#39;s derived portfolio is elected into. This can be: Default or UkChargeableGains. Omit it, or supply Default, to leave the derived portfolio inheriting its parent portfolio&#39;s regime. Under UkChargeableGains, in-scope holdings in the derived portfolio are depleted under the UK chargeable gains rules regardless of the Nav Type&#39;s accounting method; it requires the Fund&#39;s base currency to be GBP. Available values: Default, UkChargeableGains. | [optional] 
**CashCostReliefMethod** | **string** | How this Nav Type relieves base cost when a cash position&#39;s local balance reduces towards zero. This can be: AverageCost or SettlementAmount. Omit it, or supply AverageCost, and a cash disposal releases the position&#39;s average base cost and posts the difference to the contra leg as realised FX on the settlement date. Under SettlementAmount, a cash disposal releases the base amount at which the contra leg of the same transaction is posted, so the settlement nets to nil in base currency and no realised FX is posted on the cash leg; the cash position then carries the unrecognised FX in its base cost until the deemed exposure event recognises it. It cannot be combined with calculateTradeDateToSettlementFxPnL, whether set on the Nav Type&#39;s settlement configuration or inherited from a portfolio&#39;s; a valuation point on the Nav Type fails while a transaction type in its scope turns calculateTradeDateToSettlementFxPnL on for a movement; and it can be changed on an existing Nav Type only while the Nav Type has no positions. Available values: AverageCost, SettlementAmount. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
string code = "example code";
string displayName = "example displayName";
string description = "example description";
ResourceId chartOfAccountsId = new ResourceId();
List<string> postingModuleCodes = new List<string>();
List<string> cleardownModuleCodes = new List<string>();
NavSettlementConfiguration settlementConfiguration = new NavSettlementConfiguration();
ResourceId valuationRecipeId = new ResourceId();
ResourceId holdingRecipeId = new ResourceId();
string accountingMethod = "accountingMethod";
List<string> subHoldingKeys = new List<string>();
string amortisationMethod = "amortisationMethod";
string transactionTypeScope = "transactionTypeScope";
string cashGainLossCalculationDate = "cashGainLossCalculationDate";
ResourceId? amortisationRuleSetId = new ResourceId();

string leaderNavTypeCode = "example leaderNavTypeCode";
string transactionTemplateScope = "transactionTemplateScope";
string transactionExclusionFilter = "example transactionExclusionFilter";
string pricingBasis = "example pricingBasis";
SwingPricingRule? swingPricing = new SwingPricingRule();

ResourceId? notionalDealingCostTableId = new ResourceId();

ResourceId? valuationTemplateId = new ResourceId();

string chargeableGainsRegime = "example chargeableGainsRegime";
string cashCostReliefMethod = "example cashCostReliefMethod";

NavType navTypeInstance = new NavType(
    status: status,
    code: code,
    displayName: displayName,
    description: description,
    chartOfAccountsId: chartOfAccountsId,
    postingModuleCodes: postingModuleCodes,
    cleardownModuleCodes: cleardownModuleCodes,
    settlementConfiguration: settlementConfiguration,
    valuationRecipeId: valuationRecipeId,
    holdingRecipeId: holdingRecipeId,
    accountingMethod: accountingMethod,
    subHoldingKeys: subHoldingKeys,
    amortisationMethod: amortisationMethod,
    transactionTypeScope: transactionTypeScope,
    cashGainLossCalculationDate: cashGainLossCalculationDate,
    amortisationRuleSetId: amortisationRuleSetId,
    leaderNavTypeCode: leaderNavTypeCode,
    transactionTemplateScope: transactionTemplateScope,
    transactionExclusionFilter: transactionExclusionFilter,
    pricingBasis: pricingBasis,
    swingPricing: swingPricing,
    notionalDealingCostTableId: notionalDealingCostTableId,
    valuationTemplateId: valuationTemplateId,
    chargeableGainsRegime: chargeableGainsRegime,
    cashCostReliefMethod: cashCostReliefMethod);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
