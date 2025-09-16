# Lusid.Sdk.Model.RecommendedSortBy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributeName** | **string** | The property key, identifier type, or field to be sorted by. | 
**SortOrder** | **string** | The sorting direction. Either ascending (ASC) or descending (DESC). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string attributeName = "attributeName";
string sortOrder = "example sortOrder";

RecommendedSortBy recommendedSortByInstance = new RecommendedSortBy(
    attributeName: attributeName,
    sortOrder: sortOrder);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
