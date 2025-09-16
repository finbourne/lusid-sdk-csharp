# Lusid.Sdk.Model.InstrumentEventConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionTemplateScopes** | **List&lt;string&gt;** |  | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> transactionTemplateScopes = new List<string>();
ResourceId? recipeId = new ResourceId();


InstrumentEventConfiguration instrumentEventConfigurationInstance = new InstrumentEventConfiguration(
    transactionTemplateScopes: transactionTemplateScopes,
    recipeId: recipeId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
