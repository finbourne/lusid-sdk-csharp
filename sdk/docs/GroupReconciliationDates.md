# Lusid.Sdk.Model.GroupReconciliationDates

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**GroupReconciliationDatePair**](GroupReconciliationDatePair.md) |  | [optional] 
**Right** | [**GroupReconciliationDatePair**](GroupReconciliationDatePair.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

GroupReconciliationDatePair? left = new GroupReconciliationDatePair();

GroupReconciliationDatePair? right = new GroupReconciliationDatePair();


GroupReconciliationDates groupReconciliationDatesInstance = new GroupReconciliationDates(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
