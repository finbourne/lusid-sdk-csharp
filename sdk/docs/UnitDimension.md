# Lusid.Sdk.Model.UnitDimension
One factor of a result's unit, modelled as dimensional analysis rather than a label, e.g. a  rates delta is GBP^1 . GBP.LIBOR.3M^-1 - \"GBP per basis point\". A result's `units` is a  flat list of these; the count tracks the order of the derivative (a ratio), not the result's  axes, and must not be indexed by axis.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnitDomain** | **string** | The domain this factor is drawn from, e.g. \&quot;Ccy\&quot;, \&quot;Rate\&quot;, \&quot;Vol\&quot;, \&quot;Security\&quot;. | [optional] 
**Name** | **string** | The name within the domain, e.g. a currency code or a curve identifier. | [optional] 
**Power** | **int** | The exponent this factor is raised to. | [optional] 
**Scale** | **decimal** | The scale of one unit of this factor, e.g. 1e-4 for a basis point. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string unitDomain = "example unitDomain";
string name = "example name";decimal? scale = "example scale";

UnitDimension unitDimensionInstance = new UnitDimension(
    unitDomain: unitDomain,
    name: name,
    power: power,
    scale: scale);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
