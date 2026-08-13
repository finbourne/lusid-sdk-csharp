# Lusid.Sdk.Model.RecResultItemDetails
The individual items that make up a rec result, split by side. Zero counts and empty arrays for  results that have cleared.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountLeft** | **int** | The number of items grouped on the left side. | 
**CountRight** | **int** | The number of items grouped on the right side. | 
**Left** | [**List&lt;RecResultItem&gt;**](RecResultItem.md) | The left-side items. | [optional] 
**Right** | [**List&lt;RecResultItem&gt;**](RecResultItem.md) | The right-side items. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<RecResultItem> left = new List<RecResultItem>();
List<RecResultItem> right = new List<RecResultItem>();

RecResultItemDetails recResultItemDetailsInstance = new RecResultItemDetails(
    countLeft: countLeft,
    countRight: countRight,
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
