# Lusid.Sdk.Model.WithholdingTaxReliefAtSourceFlags

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TreatyRas** | **bool** | Whether relief at source applies at the treaty rate. | 
**BetterRas** | **bool** | Whether relief at source applies at the better rate. | 
**EnhancedRas** | **bool** | Whether relief at source applies at the enhanced rate. | 

```csharp
using Lusid.Sdk.Model;
using System;

bool treatyRas = //"True";
bool betterRas = //"True";
bool enhancedRas = //"True";

WithholdingTaxReliefAtSourceFlags withholdingTaxReliefAtSourceFlagsInstance = new WithholdingTaxReliefAtSourceFlags(
    treatyRas: treatyRas,
    betterRas: betterRas,
    enhancedRas: enhancedRas);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
