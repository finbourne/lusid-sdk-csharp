# Lusid.Sdk.Model.SimpleRoundingConvention
Certain bonds will follow certain rounding conventions.  For example, Thai government bonds will round accrued interest and cashflow values 2dp, whereas for  French government bonds, the rounding is to 7dp.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Precision** | **int** | The precision of the rounding. The decimal places or significant figures to which the rounding takes place.  Defaults to 0 if not set. | [optional] 
**RoundingType** | **string** | The type of rounding.  e.g. Round Up, Round Down    Supported string (enumeration) values are: [Down, Up, Nearest].  Defaults to \&quot;None\&quot; if not set. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string roundingType = "example roundingType";

SimpleRoundingConvention simpleRoundingConventionInstance = new SimpleRoundingConvention(
    precision: precision,
    roundingType: roundingType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
