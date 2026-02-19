# Lusid.Sdk.Model.NavTypeDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**PostingModuleCodes** | **List&lt;string&gt;** |  | [optional] 
**CleardownModuleCodes** | **List&lt;string&gt;** |  | [optional] 
**ValuationRecipeId** | [**ResourceId**](ResourceId.md) |  | 
**HoldingRecipeId** | [**ResourceId**](ResourceId.md) |  | 
**AccountingMethod** | **string** |  | 
**SubHoldingKeys** | **List&lt;string&gt;** | Set of unique holding identifiers, e.g. trader, desk, strategy. | [optional] 
**AmortisationMethod** | **string** |  | 
**TransactionTypeScope** | **string** |  | 
**CashGainLossCalculationDate** | **string** |  | 
**AmortisationRuleSetId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**LeaderNavTypeCode** | **string** |  | [optional] 
**TransactionTemplateScope** | **string** |  | [optional] 

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
