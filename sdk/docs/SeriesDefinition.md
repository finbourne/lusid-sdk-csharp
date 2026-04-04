# Lusid.Sdk.Model.SeriesDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesIdentifier** | **string** | The identifier that uniquely identifies this Series within the Share Class. | 
**SeriesType** | **string** | The type of the Series. Valid values are: Lead, Standard. | 
**LaunchDate** | **DateTimeOffset** | The date on which the Series was launched. | 
**LaunchPriceType** | **string** | The type of launch price for the Series. Valid values are: Manual, Calculated. | 
**DomCcy** | **string** | The denomination currency of the Series. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | An optional set of properties to associate with the Series. Only applied if createInstrument is set to true on the parent Fund. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string seriesIdentifier = "seriesIdentifier";
string seriesType = "seriesType";
string launchPriceType = "launchPriceType";
string domCcy = "domCcy";
Dictionary<string, Property> properties = new Dictionary<string, Property>();

SeriesDefinition seriesDefinitionInstance = new SeriesDefinition(
    seriesIdentifier: seriesIdentifier,
    seriesType: seriesType,
    launchDate: launchDate,
    launchPriceType: launchPriceType,
    domCcy: domCcy,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
