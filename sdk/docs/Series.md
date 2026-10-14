# Lusid.Sdk.Model.Series

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassShortCode** | **string** | The short code of the share class the Series belongs to. A series identifier is unique only within its share class. | [optional] 
**SeriesIdentifier** | **string** | The identifier that uniquely identifies this Series within the Share Class. | 
**SeriesType** | **string** | The type of the Series. Available values: Lead, Standard. | 
**LaunchDate** | **DateTimeOffset** | The date on which the Series was launched. | 
**LaunchPriceType** | **string** | The type of launch price for the Series. Available values: Manual, Calculated. | 
**DomCcy** | **string** | The denomination currency of the Series. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | An optional set of properties to associate with the Series. Only applied if createInstrument is set to true on the parent Fund. | [optional] 
**LaunchPrice** | **decimal?** | The launch price of the Series. Required when LaunchPriceType is Manual; ignored when it is Calculated. | [optional] 
**Status** | **string** | The lifecycle status of the Series: Open, Closed or Rolled. Defaults to Open. Available values: Open, Closed, Rolled. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string shareClassShortCode = "example shareClassShortCode";
string seriesIdentifier = "seriesIdentifier";
string seriesType = "seriesType";
string launchPriceType = "launchPriceType";
string domCcy = "domCcy";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string status = "example status";

Series seriesInstance = new Series(
    shareClassShortCode: shareClassShortCode,
    seriesIdentifier: seriesIdentifier,
    seriesType: seriesType,
    launchDate: launchDate,
    launchPriceType: launchPriceType,
    domCcy: domCcy,
    properties: properties,
    launchPrice: launchPrice,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
