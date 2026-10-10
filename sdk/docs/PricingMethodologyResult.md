# Lusid.Sdk.Model.PricingMethodologyResult
What a share class deals at under the fund's pricing methodology at a valuation point, the working behind it, and  the reporting prices the fund publishes for it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dealing** | [**SinglePriceDealing**](SinglePriceDealing.md) |  | [optional] 
**Audit** | [**PricingMethodologyAudit**](PricingMethodologyAudit.md) |  | [optional] 
**DualDealing** | [**DualPriceDealing**](DualPriceDealing.md) |  | [optional] 
**Reporting** | **Dictionary&lt;string, decimal?&gt;** | The Fund&#39;s reporting prices for the share class, keyed by label and rounded as the unit price is. A price is absent when the class has no units in issue or the valuation recipe does not publish it. Absent when the Fund has no reporting prices. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

SinglePriceDealing? dealing = new SinglePriceDealing();

PricingMethodologyAudit? audit = new PricingMethodologyAudit();

DualPriceDealing? dualDealing = new DualPriceDealing();

Dictionary<string, decimal?> reporting = new Dictionary<string, decimal?>();

PricingMethodologyResult pricingMethodologyResultInstance = new PricingMethodologyResult(
    dealing: dealing,
    audit: audit,
    dualDealing: dualDealing,
    reporting: reporting);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
