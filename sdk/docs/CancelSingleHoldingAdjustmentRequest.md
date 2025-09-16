# Lusid.Sdk.Model.CancelSingleHoldingAdjustmentRequest
This request specifies single target holding. i.e. holding data that the  system should match. And deletes previous adjustment made to that holding

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | A set of instrument identifiers that can resolve the holding adjustment to a unique instrument. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property must be from the &#39;Transaction&#39; domain. | [optional] 
**Currency** | **string** | The Holding currency. | [optional] 
**CustodianAccountId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
string currency = "example currency";
ResourceId? custodianAccountId = new ResourceId();


CancelSingleHoldingAdjustmentRequest cancelSingleHoldingAdjustmentRequestInstance = new CancelSingleHoldingAdjustmentRequest(
    instrumentIdentifiers: instrumentIdentifiers,
    subHoldingKeys: subHoldingKeys,
    currency: currency,
    custodianAccountId: custodianAccountId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
