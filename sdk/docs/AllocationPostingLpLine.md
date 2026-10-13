# Lusid.Sdk.Model.AllocationPostingLpLine
One instrument event a booking writes on an investor's commitment line.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The deterministic identifier of the posting: the booking reference, investor record, commitment line, component and side. | [optional] 
**Instrument** | **string** | The commitment-line instrument the event is written on. | [optional] 
**Portfolio** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Event** | **string** | The instrument event type written, for instance CapitalCallEvent. | [optional] 
**Amount** | **decimal** | The amount posted, in the event currency. | [optional] 
**Component** | **string** | The component of the event the posting carries. | [optional] 
**InvestorRecordId** | **string** | The investor record the posting is for. | [optional] 
**OriginMemberShortCode** | **string** | The member of the structure the component originates from, when it is not the map&#39;s own member. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "example id";
string instrument = "example instrument";
ResourceId? portfolio = new ResourceId();

string event = "example event";decimal? amount = "example amount";
string component = "example component";
string investorRecordId = "example investorRecordId";
string originMemberShortCode = "example originMemberShortCode";

AllocationPostingLpLine allocationPostingLpLineInstance = new AllocationPostingLpLine(
    id: id,
    instrument: instrument,
    portfolio: portfolio,
    event: event,
    amount: amount,
    component: component,
    investorRecordId: investorRecordId,
    originMemberShortCode: originMemberShortCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
