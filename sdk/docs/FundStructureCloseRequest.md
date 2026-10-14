# Lusid.Sdk.Model.FundStructureCloseRequest
The request to close a fund structure: finalise the named valuation point on every member, members first.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValuationPointCode** | **string** | The code of the valuation point to finalise on every member fund. | 
**NavTypeCode** | **string** | The NAV type to finalise under. Defaults to each fund&#39;s primary NAV type. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string valuationPointCode = "valuationPointCode";
string navTypeCode = "example navTypeCode";

FundStructureCloseRequest fundStructureCloseRequestInstance = new FundStructureCloseRequest(
    valuationPointCode: valuationPointCode,
    navTypeCode: navTypeCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
