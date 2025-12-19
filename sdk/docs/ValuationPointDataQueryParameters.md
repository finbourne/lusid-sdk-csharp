# Lusid.Sdk.Model.ValuationPointDataQueryParameters
The parameters used in getting the ValuationPointData.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**End** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | 
**Variant** | **string** | Optional variant code. Only required when it is necessary to choose between scenarios with multiple estimates. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateOrDiaryEntry? start = new DateOrDiaryEntry();

DateOrDiaryEntry end = new DateOrDiaryEntry();
string variant = "example variant";

ValuationPointDataQueryParameters valuationPointDataQueryParametersInstance = new ValuationPointDataQueryParameters(
    start: start,
    end: end,
    variant: variant);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
