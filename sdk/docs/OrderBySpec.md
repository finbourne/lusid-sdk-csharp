# Lusid.Sdk.Model.OrderBySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key that uniquely identifies a queryable address in Lusid. | 
**SortOrder** | **string** | The available values are: Ascending, Descending | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string sortOrder = "sortOrder";

OrderBySpec orderBySpecInstance = new OrderBySpec(
    key: key,
    sortOrder: sortOrder);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
