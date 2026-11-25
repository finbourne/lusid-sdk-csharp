# Lusid.Sdk.Model.FacilityPayableCheck
A Facility's principal balance checked against the facility payable in the Fund's journal, at every date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The outcome. Available values: Agrees (the principal balance equals the payable at every date), Differs (they differ on at least one date, listed in differences, or payable lines name the Facility in another currency, listed in otherCurrencyLines), NotAvailable (the Fund&#39;s journal could not be read; see reason). | 
**PayableAccounts** | **List&lt;string&gt;** | The general ledger accounts the Fund&#39;s posting rules mapped the Facility&#39;s principal lines to. | 
**Balance** | **decimal** | The Facility&#39;s principal balance after its last movement, events in Booking status left out. | 
**Payable** | **decimal** | The principal on the facility payable naming the Facility after its last line, the lines of events in Booking status left out. | 
**Differences** | [**List&lt;FacilityPayableDifference&gt;**](FacilityPayableDifference.md) | Every date on which the principal balance and the payable differ, each as it stands at the end of that date. | 
**InFlightLines** | [**List&lt;FacilityPayableLine&gt;**](FacilityPayableLine.md) | The payable lines of events still in Booking status, left out of the comparison as their movements are. | 
**UnexplainedLines** | [**List&lt;FacilityPayableLine&gt;**](FacilityPayableLine.md) | Principal lines naming the Facility that no facility event or allocation event booked, such as hand-keyed principal. They are in the comparison, so they show as differences. | 
**UnattributedLines** | [**List&lt;FacilityPayableLine&gt;**](FacilityPayableLine.md) | Principal lines of the Fund that name no Facility, so no Facility&#39;s balance carries them. Listed as breaks; they are not compared. | 
**Reason** | **string** | Why the check could not be made, when the status is NotAvailable; or, otherwise, that the Fund&#39;s journal could not be read to the asAt and was read only to the Facility&#39;s last movement, so a payable line after it is not seen. | [optional] 
**OtherCurrencyLines** | [**List&lt;FacilityPayableLine&gt;**](FacilityPayableLine.md) | Principal lines naming the Facility in a currency other than the Facility&#39;s. A Facility is drawn and repaid in its own currency, so they are not converted or compared, and make the status Differs. | 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
List<string> payableAccounts = new List<string>();decimal balance = "balance";
decimal payable = "payable";

List<FacilityPayableDifference> differences = new List<FacilityPayableDifference>();
List<FacilityPayableLine> inFlightLines = new List<FacilityPayableLine>();
List<FacilityPayableLine> unexplainedLines = new List<FacilityPayableLine>();
List<FacilityPayableLine> unattributedLines = new List<FacilityPayableLine>();
string reason = "example reason";
List<FacilityPayableLine> otherCurrencyLines = new List<FacilityPayableLine>();

FacilityPayableCheck facilityPayableCheckInstance = new FacilityPayableCheck(
    status: status,
    payableAccounts: payableAccounts,
    balance: balance,
    payable: payable,
    differences: differences,
    inFlightLines: inFlightLines,
    unexplainedLines: unexplainedLines,
    unattributedLines: unattributedLines,
    reason: reason,
    otherCurrencyLines: otherCurrencyLines);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
