# Lusid.Sdk.Model.PartnershipTypeDifference
A transaction type a fund's portfolios resolve whose register deltas are not its contract, or whose sides its scope does not define.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | The source the transaction type is defined in. | 
**Type** | **string** | The transaction type. | 
**Scope** | **string** | The transaction type scope the fund&#39;s portfolio resolves the type in. | 
**Expected** | [**List&lt;PackRegisterDelta&gt;**](PackRegisterDelta.md) | The register balance deltas the pack&#39;s contract expects of the type. | 
**Actual** | [**List&lt;RegisterDeltaMovement&gt;**](RegisterDeltaMovement.md) | The register balance deltas the type&#39;s movements carry, each named by its movement. | 
**MissingSides** | **List&lt;string&gt;** | The sides the type&#39;s movements book through that the fund&#39;s transaction type scope does not define, so the type cannot be booked there; empty when every side is defined. | 

```csharp
using Lusid.Sdk.Model;
using System;

string source = "source";
string type = "type";
string scope = "scope";
List<PackRegisterDelta> expected = new List<PackRegisterDelta>();
List<RegisterDeltaMovement> actual = new List<RegisterDeltaMovement>();
List<string> missingSides = new List<string>();

PartnershipTypeDifference partnershipTypeDifferenceInstance = new PartnershipTypeDifference(
    source: source,
    type: type,
    scope: scope,
    expected: expected,
    actual: actual,
    missingSides: missingSides);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
