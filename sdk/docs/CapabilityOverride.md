# Lusid.Sdk.Model.CapabilityOverride

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capability** | **string** | Available values: RecallableDistributions, RecallCalls, ReturnOfExcessContributions, SubsequentCloseEqualisation, PartnerPnlAllocation, DistributionMechanism, DistributionCharacterSource, SecondaryTransfer, ExcuseExclude, DealScopedPnl, NettedCallAndDistribution. | 
**Setting** | **string** | Available values: Allowed, Forbidden. | 
**Reason** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string capability = "capability";
string setting = "setting";
string reason = "example reason";

CapabilityOverride capabilityOverrideInstance = new CapabilityOverride(
    capability: capability,
    setting: setting,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
