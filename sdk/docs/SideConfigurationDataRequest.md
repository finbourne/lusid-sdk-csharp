# Lusid.Sdk.Model.SideConfigurationDataRequest
Configuration needed to define a side. Sides are referenced by Label. Beyond that, other properties  can be used to reference either transaction fields, or transaction properties.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Side** | **string** | The side&#39;s label. | 
**Security** | **string** | The security, or instrument. | 
**Currency** | **string** | The currency. | 
**Rate** | **string** | The rate. | 
**Units** | **string** | The units. | 
**Amount** | **string** | The amount. | 

```csharp
using Lusid.Sdk.Model;
using System;

string side = "side";
string security = "security";
string currency = "currency";
string rate = "rate";
string units = "units";
string amount = "amount";

SideConfigurationDataRequest sideConfigurationDataRequestInstance = new SideConfigurationDataRequest(
    side: side,
    security: security,
    currency: currency,
    rate: rate,
    units: units,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
