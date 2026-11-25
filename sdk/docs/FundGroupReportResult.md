# Lusid.Sdk.Model.FundGroupReportResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**NavTypeCode** | **string** | The code of the NAV type the row, or result, was produced for. | [optional] 
**Status** | **string** | Whether the fund was reported. Available values: Succeeded, Failed. | [optional] 
**ValuationPoints** | [**List&lt;FundGroupReportValuationPoint&gt;**](FundGroupReportValuationPoint.md) | The valuation points reported for the fund and NAV type, oldest first. Empty when it failed. | [optional] 
**Error** | [**ErrorDetail**](ErrorDetail.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

string navTypeCode = "example navTypeCode";
string status = "example status";
List<FundGroupReportValuationPoint> valuationPoints = new List<FundGroupReportValuationPoint>();
ErrorDetail? error = new ErrorDetail();


FundGroupReportResult fundGroupReportResultInstance = new FundGroupReportResult(
    fundId: fundId,
    navTypeCode: navTypeCode,
    status: status,
    valuationPoints: valuationPoints,
    error: error);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
