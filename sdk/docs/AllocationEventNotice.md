# Lusid.Sdk.Model.AllocationEventNotice
A capital call or distribution notice for one partner on an allocation event: the lines allocated to the  partner, the net amount due, the partner's unfunded commitment rolled through the event, cumulative balances  for the partner and the general partner, and a DRAFT watermark while the event is not yet booked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fund** | [**ResourceId**](ResourceId.md) |  | 
**Event** | [**AllocationEventNoticeEvent**](AllocationEventNoticeEvent.md) |  | 
**Partner** | [**AllocationEventNoticePartner**](AllocationEventNoticePartner.md) |  | 
**Currency** | **string** | The currency the notice amounts are expressed in. | 
**Lines** | [**List&lt;AllocationEventNoticeLine&gt;**](AllocationEventNoticeLine.md) | The notice lines, one per component of the partner&#39;s allocation. | 
**NetAmountDue** | **decimal** | The net amount due, positive when the partner pays the fund and negative when the fund pays the partner. | 
**UnfundedReconciliation** | [**AllocationEventNoticeUnfundedReconciliation**](AllocationEventNoticeUnfundedReconciliation.md) |  | 
**Cumulative** | [**AllocationEventNoticeCumulative**](AllocationEventNoticeCumulative.md) |  | 
**GpColumn** | [**AllocationEventNoticeCumulative**](AllocationEventNoticeCumulative.md) |  | [optional] 
**Wire** | [**AllocationEventNoticeWire**](AllocationEventNoticeWire.md) |  | [optional] 
**PaymentHold** | [**AllocationPaymentHold**](AllocationPaymentHold.md) |  | [optional] 
**Watermark** | **string** | DRAFT until the allocation event is booked, otherwise null. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId fund = new ResourceId();
AllocationEventNoticeEvent event = new AllocationEventNoticeEvent();
AllocationEventNoticePartner partner = new AllocationEventNoticePartner();
string currency = "currency";
List<AllocationEventNoticeLine> lines = new List<AllocationEventNoticeLine>();decimal netAmountDue = "netAmountDue";

AllocationEventNoticeUnfundedReconciliation unfundedReconciliation = new AllocationEventNoticeUnfundedReconciliation();
AllocationEventNoticeCumulative cumulative = new AllocationEventNoticeCumulative();
AllocationEventNoticeCumulative? gpColumn = new AllocationEventNoticeCumulative();

AllocationEventNoticeWire? wire = new AllocationEventNoticeWire();

AllocationPaymentHold? paymentHold = new AllocationPaymentHold();

string watermark = "example watermark";

AllocationEventNotice allocationEventNoticeInstance = new AllocationEventNotice(
    fund: fund,
    event: event,
    partner: partner,
    currency: currency,
    lines: lines,
    netAmountDue: netAmountDue,
    unfundedReconciliation: unfundedReconciliation,
    cumulative: cumulative,
    gpColumn: gpColumn,
    wire: wire,
    paymentHold: paymentHold,
    watermark: watermark);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
