# Lusid.Sdk.Model.FacilityReseedResult
The outcome of re-seeding a Facility's balance from the draws and repayments booked on it, or of a dry run of it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FacilityCode** | **string** | The code of the Facility re-seeded. | 
**Currency** | **string** | The currency of the Facility, which every amount in the result is in. | 
**DryRun** | **bool** | Whether this was a dry run, which writes nothing. | 
**Status** | **string** | The outcome. Available values: Reseeded (the balance was written from the booked draws and repayments), Unchanged (the balance already matched them, so nothing was written), WouldReseed (a dry run that would write the balance), Unattributable (a dry run that found draws or repayments naming the Facility on allocation maps whose structureMemberId is not their member fund; a re-seed is refused with 409 FacilityFlowsUnattributable until the maps are fixed). | 
**DrawnBefore** | **decimal?** | What the stored balance had outstanding before the re-seed. Absent when the Facility had no balance. | [optional] 
**SeedVersionBefore** | **int?** | The seed rule the stored balance was seeded by before the re-seed; 0 for a balance stored before re-seeding existed, which the first draw or repayment on the Facility re-seeds. Absent when the Facility had no balance. | [optional] 
**Drawn** | **decimal** | What the booked draws and repayments have outstanding, including events still in Booking status: the balance the Facility&#39;s limit is judged on. | 
**MovementCount** | **int** | How many draws and repayments are booked on the Facility. | 
**BookingInProgress** | [**List&lt;FacilityReseedFlow&gt;**](FacilityReseedFlow.md) | The draws and repayments of events still in Booking status. They count in the balance and the headroom, are left out of both sides of the payable check as in flight, and are reported with a FacilityBookingInProgress warning. | 
**UnattributableFlows** | [**List&lt;FacilityReseedFlow&gt;**](FacilityReseedFlow.md) | The draws and repayments naming the Facility on allocation maps whose structureMemberId is not their member fund: not a fund, or not the fund the map&#39;s fund structure places it on. Only listed by a dry run; empty otherwise. | 
**AsAt** | **DateTimeOffset** | The asAt the balance was written at, or the asAt a dry run or an unchanged re-seed read at. | 
**Warnings** | [**List&lt;Warning&gt;**](Warning.md) | Warnings about the re-seed: FacilityBookingInProgress, or FacilityPayableBreak when the payable check finds breaks. | [optional] 
**PayableCheck** | [**FacilityPayableCheck**](FacilityPayableCheck.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string facilityCode = "facilityCode";
string currency = "currency";
bool dryRun = //"True";
string status = "status";decimal drawn = "drawn";

List<FacilityReseedFlow> bookingInProgress = new List<FacilityReseedFlow>();
List<FacilityReseedFlow> unattributableFlows = new List<FacilityReseedFlow>();
List<Warning> warnings = new List<Warning>();
FacilityPayableCheck payableCheck = new FacilityPayableCheck();

FacilityReseedResult facilityReseedResultInstance = new FacilityReseedResult(
    facilityCode: facilityCode,
    currency: currency,
    dryRun: dryRun,
    status: status,
    drawnBefore: drawnBefore,
    seedVersionBefore: seedVersionBefore,
    drawn: drawn,
    movementCount: movementCount,
    bookingInProgress: bookingInProgress,
    unattributableFlows: unattributableFlows,
    asAt: asAt,
    warnings: warnings,
    payableCheck: payableCheck);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
