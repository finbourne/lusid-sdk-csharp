# Lusid.Sdk.Model.FacilityPayableDifference
A date on which a Facility's principal balance and its payable differ.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTimeOffset** | The date the principal balance and the payable differ on. | 
**Balance** | **decimal** | The principal balance at the end of the date. | 
**Payable** | **decimal** | The principal on the payable at the end of the date. | 
**Difference** | **decimal** | The principal balance less the payable. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal balance = "balance";
decimal payable = "payable";
decimal difference = "difference";


FacilityPayableDifference facilityPayableDifferenceInstance = new FacilityPayableDifference(
    date: date,
    balance: balance,
    payable: payable,
    difference: difference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
