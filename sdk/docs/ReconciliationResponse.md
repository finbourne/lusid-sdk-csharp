# Lusid.Sdk.Model.ReconciliationResponse
Class representing the set of comparisons that result from comparing holdings and their valuations between two separate evaluations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comparisons** | [**List&lt;ReconciliationLine&gt;**](ReconciliationLine.md) | List of comparisons of left to right hand sides. | [optional] 
**DataSchema** | [**ResultDataSchema**](ResultDataSchema.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ReconciliationLine> comparisons = new List<ReconciliationLine>();
ResultDataSchema? dataSchema = new ResultDataSchema();


ReconciliationResponse reconciliationResponseInstance = new ReconciliationResponse(
    comparisons: comparisons,
    dataSchema: dataSchema);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
