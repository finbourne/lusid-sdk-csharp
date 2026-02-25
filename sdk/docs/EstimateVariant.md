# Lusid.Sdk.Model.EstimateVariant

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Variant** | **string** | The Variant of the Calendar Entry. Together with the valuation point code marks the unique branch for the NavType. | [optional] 
**DisplayName** | **string** | The name of the Fund Calendar entry. | 
**Description** | **string** | A description for the Fund Calendar entry. | [optional] 
**AsAt** | **DateTimeOffset** | The asAt datetime for the Calendar Entry. | 
**HoldingsAsAtOverride** | **DateTimeOffset?** | The optional AsAt Override to use for building holdings in the Valuation Point. Defaults to Latest. | [optional] 
**ValuationsAsAtOverride** | **DateTimeOffset?** | The optional AsAt Override to use for performing valuations in the Valuation Point. Defaults to Latest. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties for the Calendar Entry. These will be from the &#39;ClosedPeriod&#39; domain. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string variant = "example variant";
string displayName = "displayName";
string description = "example description";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion varVersion = new ModelVersion();

EstimateVariant estimateVariantInstance = new EstimateVariant(
    variant: variant,
    displayName: displayName,
    description: description,
    asAt: asAt,
    holdingsAsAtOverride: holdingsAsAtOverride,
    valuationsAsAtOverride: valuationsAsAtOverride,
    properties: properties,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
