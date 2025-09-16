# Lusid.Sdk.Model.SideDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Security** | **string** | The field or property key defining the side&#39;s security, or instrument. | 
**Currency** | **string** | The field or property key defining the side&#39;s currency. | 
**Rate** | **string** | The field or property key defining the side&#39;s rate. | 
**Units** | **string** | The value, field or property key defining the side&#39;s units. | 
**Amount** | **string** | The value, field or property key defining the side&#39;s amount | 
**NotionalAmount** | **string** | The value, field or property key defining the side&#39;s notional amount | [optional] 
**CurrentFace** | **string** | The value, field or property key defining the side&#39;s current face / outstanding notional. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string security = "security";
string currency = "currency";
string rate = "rate";
string units = "units";
string amount = "amount";
string notionalAmount = "example notionalAmount";
string currentFace = "example currentFace";

SideDefinitionRequest sideDefinitionRequestInstance = new SideDefinitionRequest(
    security: security,
    currency: currency,
    rate: rate,
    units: units,
    amount: amount,
    notionalAmount: notionalAmount,
    currentFace: currentFace);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
