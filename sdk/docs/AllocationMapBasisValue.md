# Lusid.Sdk.Model.AllocationMapBasisValue
The value one investor record is weighted by when an Allocation Map is resolved.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the basis value belongs to. | 
**BasisValue** | **decimal** | The value the investor record is weighted by, for example its commitment. | 
**Currency** | **string** | The currency the basis value is held in. Absent means the base currency of the map&#39;s member fund. When the basis values span more than one currency, each is translated into the fund&#39;s base currency at the spot rate on the event date, from the fund&#39;s ABOR recipe, before it weights the allocation. The rate on the event date is the latest quote at or before 00:00 UTC on that date. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal basisValue = "basisValue";

string currency = "example currency";

AllocationMapBasisValue allocationMapBasisValueInstance = new AllocationMapBasisValue(
    investorRecordId: investorRecordId,
    basisValue: basisValue,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
