# Lusid.Sdk.Model.EligibilityCalculation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntitlementDate** | **string** |  | 
**EligibleUnits** | **string** |  | 
**DateModifiableByInstruction** | **bool** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entitlementDate = "entitlementDate";
string eligibleUnits = "eligibleUnits";
bool dateModifiableByInstruction = //"True";

EligibilityCalculation eligibilityCalculationInstance = new EligibilityCalculation(
    entitlementDate: entitlementDate,
    eligibleUnits: eligibleUnits,
    dateModifiableByInstruction: dateModifiableByInstruction);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
