# Lusid.Sdk.Model.PartnershipTypeDifference
A transaction type a fund's portfolios resolve whose register deltas are not its contract, whose sides its scope does not define, or whose line legs lack the option that books them into the registry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | The source the transaction type is defined in. | 
**Type** | **string** | The transaction type. | 
**Scope** | **string** | The transaction type scope the fund&#39;s portfolio resolves the type in. | 
**Expected** | [**List&lt;PackRegisterDelta&gt;**](PackRegisterDelta.md) | The register balance deltas the pack&#39;s contract expects of the type. | 
**Actual** | [**List&lt;RegisterDeltaMovement&gt;**](RegisterDeltaMovement.md) | The register balance deltas the type&#39;s movements carry, each named by its movement. | 
**MissingSides** | **List&lt;string&gt;** | The sides the type&#39;s movements book through that the fund&#39;s transaction type scope does not define, so the type cannot be booked there; empty when every side is defined. | 
**MissingOptions** | [**List&lt;MissingMovementOption&gt;**](MissingMovementOption.md) | The movement options the type&#39;s line legs must carry to book the register and do not, each named by its movement. A leg that moves a register balance, or books the line&#39;s units and cost, without the &#39;Registry&#39; option books into the portfolio&#39;s holdings, where the register never looks; empty when every line leg carries it. | 

```csharp
using Lusid.Sdk.Model;
using System;

string source = "source";
string type = "type";
string scope = "scope";
List<PackRegisterDelta> expected = new List<PackRegisterDelta>();
List<RegisterDeltaMovement> actual = new List<RegisterDeltaMovement>();
List<string> missingSides = new List<string>();
List<MissingMovementOption> missingOptions = new List<MissingMovementOption>();

PartnershipTypeDifference partnershipTypeDifferenceInstance = new PartnershipTypeDifference(
    source: source,
    type: type,
    scope: scope,
    expected: expected,
    actual: actual,
    missingSides: missingSides,
    missingOptions: missingOptions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
