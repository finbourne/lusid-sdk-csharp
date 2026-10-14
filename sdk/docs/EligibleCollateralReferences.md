# Lusid.Sdk.Model.EligibleCollateralReferences
The eligible collateral schedule each party's posting is checked against.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WePost** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TheyPost** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? wePost = new ResourceId();

ResourceId? theyPost = new ResourceId();


EligibleCollateralReferences eligibleCollateralReferencesInstance = new EligibleCollateralReferences(
    wePost: wePost,
    theyPost: theyPost);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
