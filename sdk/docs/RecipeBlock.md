# Lusid.Sdk.Model.RecipeBlock
An atomic operation used in Recipe composer to compose a Configuration Recipe

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**RecipeValue**](RecipeValue.md) |  | [optional] 
**Path** | **string** | Path of the Value that the operation is to be performed on. | [optional] 
**Op** | **string** | Operation to be performed on the part of the value. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

RecipeValue? value = new RecipeValue();

string path = "example path";
string op = "example op";

RecipeBlock recipeBlockInstance = new RecipeBlock(
    value: value,
    path: path,
    op: op);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
