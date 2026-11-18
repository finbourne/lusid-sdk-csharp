# Lusid.Sdk.Model.PartnershipTypeCheckResult
The outcome of checking a fund's transaction types against the type contract of its partnership configuration  pack: the pack checked against and every type whose register balance deltas are not its contract.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pack** | [**PartnershipConfigPack**](PartnershipConfigPack.md) |  | 
**Status** | **string** | The outcome of the check. Available values: Ok, Differences. | 
**Differences** | [**List&lt;PartnershipTypeDifference&gt;**](PartnershipTypeDifference.md) | The transaction types whose register balance deltas are not their contract in the pack, or whose movements book through a side the fund&#39;s transaction type scope does not define; empty when the status is Ok. | 

```csharp
using Lusid.Sdk.Model;
using System;

PartnershipConfigPack pack = new PartnershipConfigPack();
string status = "status";
List<PartnershipTypeDifference> differences = new List<PartnershipTypeDifference>();

PartnershipTypeCheckResult partnershipTypeCheckResultInstance = new PartnershipTypeCheckResult(
    pack: pack,
    status: status,
    differences: differences);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
