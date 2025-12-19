# Lusid.Sdk.Model.SingleValuationPointQueryParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateOrDiaryEntry** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | 
**Variant** | **string** | Optional variant code. Only required when it is necessary to choose between scenarios with multiple estimates. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateOrDiaryEntry dateOrDiaryEntry = new DateOrDiaryEntry();
string variant = "example variant";

SingleValuationPointQueryParameters singleValuationPointQueryParametersInstance = new SingleValuationPointQueryParameters(
    dateOrDiaryEntry: dateOrDiaryEntry,
    variant: variant);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
