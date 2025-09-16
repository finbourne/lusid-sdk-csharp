# Lusid.Sdk.Model.ValuationPointDataQueryParameters
The parameters used in getting the ValuationPointData.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**End** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | 
**ExcludeCleardownModule** | **bool** | By deafult this flag is set to false, if this is set to true, no cleardown module will be applied to the trial balance. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateOrDiaryEntry? start = new DateOrDiaryEntry();

DateOrDiaryEntry end = new DateOrDiaryEntry();
bool excludeCleardownModule = //"True";

ValuationPointDataQueryParameters valuationPointDataQueryParametersInstance = new ValuationPointDataQueryParameters(
    start: start,
    end: end,
    excludeCleardownModule: excludeCleardownModule);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
