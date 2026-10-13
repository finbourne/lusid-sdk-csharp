# Lusid.Sdk.Model.AllocationEventUseOfProceeds
One row of a CapitalCall Allocation Event's use of proceeds: what part of the call pays for what.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Purpose** | **string** | What the row pays for: Investment, FacilityRepayment, FacilityInterest, ManagementFee or Expenses. Available values: Investment, FacilityRepayment, FacilityInterest, ManagementFee, Expenses. | 
**DealId** | **string** | The deal the row funds, or whose facility draw it repays. Required for an Investment row. | [optional] 
**Amount** | **decimal** | The part of the call the row takes, in the event currency. Greater than zero. | 
**FacilityId** | **string** | The facility the row repays. Required for a FacilityRepayment row; on an Investment row it is filled in from the deal&#39;s funding when the call is computed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string purpose = "purpose";
string dealId = "example dealId";decimal amount = "amount";

string facilityId = "example facilityId";

AllocationEventUseOfProceeds allocationEventUseOfProceedsInstance = new AllocationEventUseOfProceeds(
    purpose: purpose,
    dealId: dealId,
    amount: amount,
    facilityId: facilityId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
