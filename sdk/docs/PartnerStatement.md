# Lusid.Sdk.Model.PartnerStatement
A partner's statement: the figures of their position on the fund over a period, fingerprinted so a later  statement can be compared against it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatementId** | **string** | The identifier of the statement. | 
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**InvestorRecordId** | **string** | The investor record the statement is for. | 
**PeriodStart** | **DateTimeOffset** | The start of the statement period, exclusive. | 
**PeriodEnd** | **DateTimeOffset** | The end of the statement period, inclusive. | 
**NavTypeCode** | **string** | The NAV type to produce the statement under. Defaults to the fund&#39;s primary NAV type. | 
**Currency** | **string** | The currency of the statement. | 
**Lines** | [**List&lt;PartnerStatementLine&gt;**](PartnerStatementLine.md) | The figures on the statement. | 
**Fingerprint** | **string** | A hash of the statement&#39;s content, so two statements can be told apart. | 
**ProducedAsAt** | **DateTimeOffset** | When the statement was produced. | 

```csharp
using Lusid.Sdk.Model;
using System;

string statementId = "statementId";
ResourceId fundId = new ResourceId();
string investorRecordId = "investorRecordId";
string navTypeCode = "navTypeCode";
string currency = "currency";
List<PartnerStatementLine> lines = new List<PartnerStatementLine>();
string fingerprint = "fingerprint";

PartnerStatement partnerStatementInstance = new PartnerStatement(
    statementId: statementId,
    fundId: fundId,
    investorRecordId: investorRecordId,
    periodStart: periodStart,
    periodEnd: periodEnd,
    navTypeCode: navTypeCode,
    currency: currency,
    lines: lines,
    fingerprint: fingerprint,
    producedAsAt: producedAsAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
