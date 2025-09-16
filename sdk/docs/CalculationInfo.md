# Lusid.Sdk.Model.CalculationInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalculationMethod** | **string** | Method of calculating the fees or commission among: BasisPoints, Percentage, Rate, Flat etc. | 
**Multiplier** | **string** | Field by which to multiply the numerical amount. Eg: Quantity, Value | 
**CalculationAmount** | **decimal** | Numerical fee amount | 

```csharp
using Lusid.Sdk.Model;
using System;

string calculationMethod = "calculationMethod";
string multiplier = "multiplier";decimal calculationAmount = "calculationAmount";


CalculationInfo calculationInfoInstance = new CalculationInfo(
    calculationMethod: calculationMethod,
    multiplier: multiplier,
    calculationAmount: calculationAmount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
