# Lusid.Sdk.Model.EqualisationTerms

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** |  | 
**InterestRate** | **decimal?** |  | [optional] 
**DayCountConvention** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool enabled = //"True";
string dayCountConvention = "example dayCountConvention";

EqualisationTerms equalisationTermsInstance = new EqualisationTerms(
    enabled: enabled,
    interestRate: interestRate,
    dayCountConvention: dayCountConvention);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
