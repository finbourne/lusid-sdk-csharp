# Lusid.Sdk.Model.WhtParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WhtConfig** | [**ResourceId**](ResourceId.md) |  | 
**TaxCountry** | **string** | The holder&#39;s country of tax residence, matched against the taxCountry field of the rate datasets. | 
**ProfileType** | **string** | The holder&#39;s tax profile, matched against the profileType field of the rate datasets. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId whtConfig = new ResourceId();
string taxCountry = "taxCountry";
string profileType = "profileType";

WhtParameters whtParametersInstance = new WhtParameters(
    whtConfig: whtConfig,
    taxCountry: taxCountry,
    profileType: profileType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
