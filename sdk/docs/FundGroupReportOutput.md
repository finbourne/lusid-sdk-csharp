# Lusid.Sdk.Model.FundGroupReportOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **string** | Available values: NonConsolidated (each fund&#39;s rows returned as they are, tagged with the fund and valuation point). Consolidated is not yet supported. Defaults to NonConsolidated. Available values: NonConsolidated, Consolidated. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string mode = "example mode";

FundGroupReportOutput fundGroupReportOutputInstance = new FundGroupReportOutput(
    mode: mode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
