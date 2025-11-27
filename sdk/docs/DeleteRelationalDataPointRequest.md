# Lusid.Sdk.Model.DeleteRelationalDataPointRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSeries** | [**DataSeries**](DataSeries.md) |  | 
**EffectiveAt** | **string** | The effectiveAt or cut-label datetime of the DataPoint. | 

```csharp
using Lusid.Sdk.Model;
using System;

DataSeries dataSeries = new DataSeries();
string effectiveAt = "effectiveAt";

DeleteRelationalDataPointRequest deleteRelationalDataPointRequestInstance = new DeleteRelationalDataPointRequest(
    dataSeries: dataSeries,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
