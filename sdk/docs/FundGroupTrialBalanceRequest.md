# Lusid.Sdk.Model.FundGroupTrialBalanceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunType** | **string** | How the valuation point is chosen for each fund and NAV type. Available values: LatestApprovedNav (the latest Final valuation point on or before effectiveAt), LatestNav (the latest Final, Estimate or Candidate valuation point on or before effectiveAt), DateRange (every valuation point ending between start and end). AdHoc is not supported for the trial balance. Available values: LatestApprovedNav, LatestNav, AdHoc, DateRange. | 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The date, or cut label, the valuation point is chosen for: the latest valuation point whose effective end is on or before this instant. Required for LatestApprovedNav and LatestNav; ignored for DateRange. | [optional] 
**Start** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The first effective end date, or cut label, a DateRange run includes. Required for DateRange. | [optional] 
**End** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The last effective end date, or cut label, a DateRange run includes. Required for DateRange. | [optional] 
**NavTypeCode** | **string** | When provided, every fund in the group is reported on this NAV type and a fund without it is reported as a failure. Otherwise each fund&#39;s NAV type comes from the reference list&#39;s NAV type codes hint, or its primary NAV type. | [optional] 
**Statuses** | **List&lt;string&gt;** | Narrows the valuation point statuses a LatestNav or DateRange run considers. Defaults to all three. Available values: Final, Estimate, Candidate. | [optional] 
**Output** | [**FundGroupReportOutput**](FundGroupReportOutput.md) |  | [optional] 
**GeneralLedgerProfileCode** | **string** | The optional code of a General Ledger Profile used to decorate the rows with levels; it must exist in each fund&#39;s chart of accounts. | [optional] 
**ExcludeCleardownModule** | **bool** | If this is set to true, no Cleardown Module will be applied to the Trial Balances. Defaults to false. | [optional] 
**Variant** | **string** | The optional valuation point variant to report for each fund. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string runType = "runType";
DateTimeOrCutLabel effectiveAt = "example effectiveAt";
DateTimeOrCutLabel start = "example start";
DateTimeOrCutLabel end = "example end";
string navTypeCode = "example navTypeCode";
List<string> statuses = new List<string>();
FundGroupReportOutput? output = new FundGroupReportOutput();

string generalLedgerProfileCode = "example generalLedgerProfileCode";
bool excludeCleardownModule = //"True";
string variant = "example variant";

FundGroupTrialBalanceRequest fundGroupTrialBalanceRequestInstance = new FundGroupTrialBalanceRequest(
    runType: runType,
    effectiveAt: effectiveAt,
    start: start,
    end: end,
    navTypeCode: navTypeCode,
    statuses: statuses,
    output: output,
    generalLedgerProfileCode: generalLedgerProfileCode,
    excludeCleardownModule: excludeCleardownModule,
    variant: variant);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
