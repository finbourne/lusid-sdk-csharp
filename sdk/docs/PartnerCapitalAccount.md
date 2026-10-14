# Lusid.Sdk.Model.PartnerCapitalAccount
A partner's capital account statement (PCAP) over a reporting period, in the ILPA row order, with quarter-,  year- and inception-to-date columns and a memo block of commitment balances from the register.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**InvestorRecordId** | **string** | The investor record identifier of the partner. | 
**Currency** | **string** | The currency the capital account is expressed in, being the fund&#39;s base currency. | 
**PeriodStart** | **DateTimeOffset** | The exclusive start of the reporting period. | 
**PeriodEnd** | **DateTimeOffset** | The inclusive end of the reporting period. | 
**Status** | **string** | Whether the figures are an Estimate or Final. Figures are Final only once a valuation point covering the period end has been finalised. | 
**Rows** | [**List&lt;PartnerCapitalAccountRow&gt;**](PartnerCapitalAccountRow.md) | The capital account rows, from beginning capital through to ending capital, each with quarter-to-date, year-to-date and inception-to-date columns. | 
**Memo** | [**PartnerCapitalAccountMemo**](PartnerCapitalAccountMemo.md) |  | 
**Foots** | **bool** | Whether the ending capital agrees across the quarter-to-date, year-to-date and inception-to-date columns within tolerance. | 
**FootingDifference** | **decimal** | The largest difference between the ending capital of any two columns. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId fundId = new ResourceId();
string investorRecordId = "investorRecordId";
string currency = "currency";
string status = "status";
List<PartnerCapitalAccountRow> rows = new List<PartnerCapitalAccountRow>();
PartnerCapitalAccountMemo memo = new PartnerCapitalAccountMemo();
bool foots = //"True";decimal footingDifference = "footingDifference";


PartnerCapitalAccount partnerCapitalAccountInstance = new PartnerCapitalAccount(
    fundId: fundId,
    investorRecordId: investorRecordId,
    currency: currency,
    periodStart: periodStart,
    periodEnd: periodEnd,
    status: status,
    rows: rows,
    memo: memo,
    foots: foots,
    footingDifference: footingDifference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
