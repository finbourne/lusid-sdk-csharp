# Lusid.Sdk.Model.DealingLineNotValued
A dealing line read for a swing decision that could not be valued into its share class currency, and why.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | The identifier of the dealing order that could not be valued, as scope/code. | 
**ShareClass** | **string** | The share class the order deals in, keyed as the valuation point&#39;s share classes are. | [optional] 
**Currency** | **string** | The currency the order&#39;s amount is in. Absent when the line carries no amount. | [optional] 
**Reason** | **string** | Why the line could not be valued into the share class currency. | 

```csharp
using Lusid.Sdk.Model;
using System;

string orderId = "orderId";
string shareClass = "example shareClass";
string currency = "example currency";
string reason = "reason";

DealingLineNotValued dealingLineNotValuedInstance = new DealingLineNotValued(
    orderId: orderId,
    shareClass: shareClass,
    currency: currency,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
