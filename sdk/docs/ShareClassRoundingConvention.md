# Lusid.Sdk.Model.ShareClassRoundingConvention

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Precision** | **int** | The precision of the rounding: the number of decimal places, or of significant figures when PrecisionType is SignificantFigures. At most 28, and at least 1 for SignificantFigures. Defaults to 0. | [optional] 
**RoundingType** | **string** | The type of rounding, applied at the last decimal place or significant figure. Defaults to None, which leaves the value unrounded. Available values: None, Down, Up, Nearest. | [optional] 
**PrecisionType** | **string** | What Precision counts: DecimalPlaces (the default) or SignificantFigures. A SignificantFigures convention is not copied onto an instrument created for the share class. Available values: DecimalPlaces, SignificantFigures. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string roundingType = "example roundingType";
string precisionType = "example precisionType";

ShareClassRoundingConvention shareClassRoundingConventionInstance = new ShareClassRoundingConvention(
    precision: precision,
    roundingType: roundingType,
    precisionType: precisionType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
