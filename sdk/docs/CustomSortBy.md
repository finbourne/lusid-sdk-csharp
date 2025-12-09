# Lusid.Sdk.Model.CustomSortBy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The name of the field to sort by. | 
**PriorityValues** | **List&lt;string&gt;** | An optional list of priority field values to sort by, in the order they should be prioritized. | [optional] 
**RemainderOrder** | **string** | The sorting direction for the remaining field values. Either ascending (ASC) or descending (DESC). | 

```csharp
using Lusid.Sdk.Model;
using System;

string fieldName = "fieldName";
List<string> priorityValues = new List<string>();
string remainderOrder = "remainderOrder";

CustomSortBy customSortByInstance = new CustomSortBy(
    fieldName: fieldName,
    priorityValues: priorityValues,
    remainderOrder: remainderOrder);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
