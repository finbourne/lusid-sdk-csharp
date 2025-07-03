# Lusid.Sdk.Model.NavTypeDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**ValuationRecipeId** | [**ResourceId**](ResourceId.md) |  | 
**HoldingRecipeId** | [**ResourceId**](ResourceId.md) |  | 
**AccountingMethod** | **string** |  | 
**SubHoldingKeys** | **List&lt;string&gt;** | Set of unique holding identifiers, e.g. trader, desk, strategy. | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The resolution strategy used to resolve instruments of transactions/holdings upserted to the portfolios. | [optional] 
**AmortisationMethod** | **string** |  | 
**TransactionTypeScope** | **string** |  | [optional] 
**CashGainLossCalculationDate** | **string** |  | [optional] 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**PostingModuleCodes** | **List&lt;string&gt;** |  | [optional] 
**CleardownModuleCodes** | **List&lt;string&gt;** |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

