# Lusid.Sdk.Model.WithholdingTaxRateTiers

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountryRate** | **decimal** | The statutory rate of the matched row, before relief. | 
**TreatyRate** | **decimal?** | The treaty rate of the matched row. Null when the tier does not apply. | [optional] 
**BetterRate** | **decimal?** | The better rate of the matched row. Null when the tier does not apply. | [optional] 
**EnhancedRate** | **decimal?** | The enhanced rate of the matched row. Null when the tier does not apply. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal countryRate = "countryRate";


WithholdingTaxRateTiers withholdingTaxRateTiersInstance = new WithholdingTaxRateTiers(
    countryRate: countryRate,
    treatyRate: treatyRate,
    betterRate: betterRate,
    enhancedRate: enhancedRate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
