# Lusid.Sdk.Model.RunCheckResponse
Response containing the results of running data quality checks

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataQualityCheckResults** | [**List&lt;DataQualityCheckResult&gt;**](DataQualityCheckResult.md) | Collection of data quality check results | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<DataQualityCheckResult> dataQualityCheckResults = new List<DataQualityCheckResult>();

RunCheckResponse runCheckResponseInstance = new RunCheckResponse(
    dataQualityCheckResults: dataQualityCheckResults);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
