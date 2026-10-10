# Lusid.Sdk.Model.ShareClassData
The data for a Share Class. Includes Valuation Point Data and instrument information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassBreakdown** | [**ShareClassBreakdown**](ShareClassBreakdown.md) |  | 
**ShareClassDetails** | [**ShareClassDetails**](ShareClassDetails.md) |  | [optional] 
**PricingMethodology** | [**PricingMethodologyResult**](PricingMethodologyResult.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ShareClassBreakdown shareClassBreakdown = new ShareClassBreakdown();
ShareClassDetails? shareClassDetails = new ShareClassDetails();

PricingMethodologyResult? pricingMethodology = new PricingMethodologyResult();


ShareClassData shareClassDataInstance = new ShareClassData(
    shareClassBreakdown: shareClassBreakdown,
    shareClassDetails: shareClassDetails,
    pricingMethodology: pricingMethodology);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
