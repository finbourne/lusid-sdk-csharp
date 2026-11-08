# Lusid.Sdk.Model.AllocationReceivable
One investor's position on a booked capital call, on one register.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record. | [optional] 
**Called** | **decimal** | What the investor record was called for. | [optional] 
**Received** | **decimal** | What has been received and applied so far. | [optional] 
**Outstanding** | **decimal** | What is still owed. Never negative: an overpayment becomes a refund payable instead. | [optional] 
**DaysPastDue** | **int** | How many days past the due date the outstanding amount is, or zero when not yet due or nothing is owed. | [optional] 
**Bucket** | **string** | The ageing bucket: Current, 1-30, 31-60, 61-90 or 90+. | [optional] 
**Portfolio** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Side** | **string** | Whether the record owes on its own line (LP) or as a feeder&#39;s roll-up on the master (ROLLUP). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "example investorRecordId";decimal? called = "example called";decimal? received = "example received";decimal? outstanding = "example outstanding";
string bucket = "example bucket";
ResourceId? portfolio = new ResourceId();

string side = "example side";

AllocationReceivable allocationReceivableInstance = new AllocationReceivable(
    investorRecordId: investorRecordId,
    called: called,
    received: received,
    outstanding: outstanding,
    daysPastDue: daysPastDue,
    bucket: bucket,
    portfolio: portfolio,
    side: side);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
