# Lusid.Sdk.Model.NavTypeDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The Code for the Nav Type. Must be unique within the Fund. | [optional] 
**DisplayName** | **string** | The Display Name for the Nav Type. Must be unique within the Fund. | [optional] 
**Description** | **string** | The Description for the Nav Type. | [optional] 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**PostingModuleCodes** | **List&lt;string&gt;** | The Posting Module Codes from which the rules to be applied are retrieved. | [optional] 
**CleardownModuleCodes** | **List&lt;string&gt;** | The Cleardown Module Codes from which the rules to be applied are retrieved. | [optional] 
**ValuationRecipeId** | [**ResourceId**](ResourceId.md) |  | 
**HoldingRecipeId** | [**ResourceId**](ResourceId.md) |  | 
**AccountingMethod** | **string** | Determines the accounting treatment given to the simple position portfolio&#39;s tax lots. A non-default value is required. | 
**SubHoldingKeys** | **List&lt;string&gt;** | A set of unique transaction properties to group the derived transaction portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. See https://support.lusid.com/knowledgebase/article/KA-01879/en-us for more information. | [optional] 
**AmortisationMethod** | **string** | The amortisation method used by the portfolio for the calculation. The available values are: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate | 
**TransactionTypeScope** | **string** | The scope of the transaction types. | 
**CashGainLossCalculationDate** | **string** | The option when the Cash Gain Loss to be calulated, TransactionDate/SettlementDate. A non-default value is required. | 
**AmortisationRuleSetId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**LeaderNavTypeCode** | **string** | The code of the Nav Type that this Nav Type will follow when set. | [optional] 
**TransactionTemplateScope** | **string** | The Transaction Template Scope used by the NavType. Will default to the scope set on the parent portfolio. If the fund has multiple parent portfolios, then the Transaction Template Scope must be provided. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "example code";
string displayName = "example displayName";
string description = "example description";
ResourceId chartOfAccountsId = new ResourceId();
List<string> postingModuleCodes = new List<string>();
List<string> cleardownModuleCodes = new List<string>();
ResourceId valuationRecipeId = new ResourceId();
ResourceId holdingRecipeId = new ResourceId();
string accountingMethod = "accountingMethod";
List<string> subHoldingKeys = new List<string>();
string amortisationMethod = "amortisationMethod";
string transactionTypeScope = "transactionTypeScope";
string cashGainLossCalculationDate = "cashGainLossCalculationDate";
ResourceId? amortisationRuleSetId = new ResourceId();

string leaderNavTypeCode = "example leaderNavTypeCode";
string transactionTemplateScope = "example transactionTemplateScope";

NavTypeDefinition navTypeDefinitionInstance = new NavTypeDefinition(
    code: code,
    displayName: displayName,
    description: description,
    chartOfAccountsId: chartOfAccountsId,
    postingModuleCodes: postingModuleCodes,
    cleardownModuleCodes: cleardownModuleCodes,
    valuationRecipeId: valuationRecipeId,
    holdingRecipeId: holdingRecipeId,
    accountingMethod: accountingMethod,
    subHoldingKeys: subHoldingKeys,
    amortisationMethod: amortisationMethod,
    transactionTypeScope: transactionTypeScope,
    cashGainLossCalculationDate: cashGainLossCalculationDate,
    amortisationRuleSetId: amortisationRuleSetId,
    leaderNavTypeCode: leaderNavTypeCode,
    transactionTemplateScope: transactionTemplateScope);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
