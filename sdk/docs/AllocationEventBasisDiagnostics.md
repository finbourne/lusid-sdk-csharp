# Lusid.Sdk.Model.AllocationEventBasisDiagnostics
What the basis source found when it read the register for an Allocation Event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParticipantCount** | **int** | The number of investor records whose basis values were read. | [optional] 
**Excluded** | **List&lt;string&gt;** | The investor records the map&#39;s exceptions kept out of the event. | [optional] 
**Warnings** | [**List&lt;AllocationEventBasisWarning&gt;**](AllocationEventBasisWarning.md) | Anything the source had to work around, for example MissingFeeRate on a line without a management fee rate. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> excluded = new List<string>();
List<AllocationEventBasisWarning> warnings = new List<AllocationEventBasisWarning>();

AllocationEventBasisDiagnostics allocationEventBasisDiagnosticsInstance = new AllocationEventBasisDiagnostics(
    participantCount: participantCount,
    excluded: excluded,
    warnings: warnings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
