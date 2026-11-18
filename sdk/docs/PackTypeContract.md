# Lusid.Sdk.Model.PackTypeContract
The register deltas a transaction type must carry for the partner register to read right.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The transaction type the contract is for. | 
**RequiredDeltas** | [**List&lt;PackRegisterDelta&gt;**](PackRegisterDelta.md) | The register balance deltas the type must carry, counted with repeats. | 
**OptionalDeltas** | [**List&lt;PackRegisterDelta&gt;**](PackRegisterDelta.md) | The register balance deltas the type may carry, each at most once, in the direction given and from the source given. | 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
List<PackRegisterDelta> requiredDeltas = new List<PackRegisterDelta>();
List<PackRegisterDelta> optionalDeltas = new List<PackRegisterDelta>();

PackTypeContract packTypeContractInstance = new PackTypeContract(
    type: type,
    requiredDeltas: requiredDeltas,
    optionalDeltas: optionalDeltas);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
