# Lusid.Sdk.Model.SeriesConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassShortCode** | **string** |  | 
**SeriesLaunchPrice** | **decimal?** |  | [optional] 
**DistributionSeriesSelection** | **string** | Available values: ProRataByNav, FIFO, SpecifiedSeries. | [optional] 
**DealLinkedSeries** | **bool?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string shareClassShortCode = "shareClassShortCode";
string distributionSeriesSelection = "example distributionSeriesSelection";
bool? dealLinkedSeries = //"True";

SeriesConfiguration seriesConfigurationInstance = new SeriesConfiguration(
    shareClassShortCode: shareClassShortCode,
    seriesLaunchPrice: seriesLaunchPrice,
    distributionSeriesSelection: distributionSeriesSelection,
    dealLinkedSeries: dealLinkedSeries);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
