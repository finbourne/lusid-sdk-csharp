# Lusid.Sdk.Model.FundDetails
The details of a Fund.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | The currency of the fund which is the same as the base currency of all the portfolios of the fund&#39;s Abor. | [optional] 
**PricingBasis** | **string** | The side of the quote the NAV type valued the fund on: Mid, Bid or Ask. Absent when the NAV type defers to the valuation recipe&#39;s own pricing basis. When the NAV type has a swing pricing rule this is the basis the rule applied. | [optional] 
**SwingPricing** | [**SwingPricingDecision**](SwingPricingDecision.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "example currency";
string pricingBasis = "example pricingBasis";
SwingPricingDecision? swingPricing = new SwingPricingDecision();


FundDetails fundDetailsInstance = new FundDetails(
    currency: currency,
    pricingBasis: pricingBasis,
    swingPricing: swingPricing);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
