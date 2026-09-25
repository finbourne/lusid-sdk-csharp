# Lusid.Sdk.Model.RecDefByTaxLots
Per-side tax-lot granularity for a Holding entry of a rec definition's rulesets.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | **bool?** | Whether the left side splits holdings by tax lot. Must be omitted when the left side is relational, and reads as null there. | [optional] 
**Right** | **bool?** | Whether the right side splits holdings by tax lot. Must be omitted when the right side is relational, and reads as null there. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool? left = //"True";
bool? right = //"True";

RecDefByTaxLots recDefByTaxLotsInstance = new RecDefByTaxLots(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
