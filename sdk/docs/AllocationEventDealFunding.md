# Lusid.Sdk.Model.AllocationEventDealFunding
The details of a DealFunding Allocation Event: the deal the vehicle funds, where the money came from and which  investor records are excused from it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DealId** | **string** | The deal the vehicle funds. A later capital call names it in an Investment row of its use of proceeds. | 
**FacilityId** | **string** | The subscription facility the funding was drawn from. Absent means the deal was paid from cash. | [optional] 
**ExcludedInvestorRecordIds** | **List&lt;string&gt;** | The investor records excused from the deal. They pay nothing towards it when it is called and the others take up their share. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string dealId = "dealId";
string facilityId = "example facilityId";
List<string> excludedInvestorRecordIds = new List<string>();

AllocationEventDealFunding allocationEventDealFundingInstance = new AllocationEventDealFunding(
    dealId: dealId,
    facilityId: facilityId,
    excludedInvestorRecordIds: excludedInvestorRecordIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
