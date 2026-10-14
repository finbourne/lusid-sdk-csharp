# Lusid.Sdk.Model.PartnerStatementRequest
The request to produce a partner statement over a period.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeriodStart** | **DateTimeOffset** | The start of the statement period, exclusive. | 
**PeriodEnd** | **DateTimeOffset** | The end of the statement period, inclusive. | 
**NavTypeCode** | **string** | The NAV type to produce the statement under. Defaults to the fund&#39;s primary NAV type. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string navTypeCode = "example navTypeCode";

PartnerStatementRequest partnerStatementRequestInstance = new PartnerStatementRequest(
    periodStart: periodStart,
    periodEnd: periodEnd,
    navTypeCode: navTypeCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
