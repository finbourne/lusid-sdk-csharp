# Lusid.Sdk.Model.ElectionProrationRate
The proration rate the issuer applies to one option of a multi-option event, keyed by the option's election key.  An entry overrides the event-level proration rate for that election only.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** | The election key of the option this proration rate applies to. | 
**ProrationRate** | **decimal** | The fraction of the quantity instructed on this option that the issuer accepts. Must be in (0, 1]. | 

```csharp
using Lusid.Sdk.Model;
using System;

string electionKey = "electionKey";decimal prorationRate = "prorationRate";


ElectionProrationRate electionProrationRateInstance = new ElectionProrationRate(
    electionKey: electionKey,
    prorationRate: prorationRate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
