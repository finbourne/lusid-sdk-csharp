# Lusid.Sdk.Model.GroupReconciliationFilters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | **string** | The filters for the left-side portfolio or portfolio group related data. | [optional] 
**Right** | **string** | The filters for the right-side portfolio or portfolio group related data. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string left = "example left";
string right = "example right";

GroupReconciliationFilters groupReconciliationFiltersInstance = new GroupReconciliationFilters(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
