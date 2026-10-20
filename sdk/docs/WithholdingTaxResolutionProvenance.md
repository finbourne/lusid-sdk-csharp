# Lusid.Sdk.Model.WithholdingTaxResolutionProvenance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MatchScore** | **decimal?** | The share of the main dataset&#39;s dimensions that the row matches, from 0 to 1. Null on an anomaly match. | [optional] 
**MatchedFieldCount** | **int?** | The number of the main dataset&#39;s dimensions that the row matches. Null on an anomaly match. | [optional] 
**SourceFilterApplied** | **string** | The rule source level that matched. Null when no source priority applies. | [optional] 
**TieBroken** | **bool** | True when another row matched as well as the winner, so the tie-break order chose: the latest effective date, then the rule id. | 

```csharp
using Lusid.Sdk.Model;
using System;

string sourceFilterApplied = "example sourceFilterApplied";
bool tieBroken = //"True";

WithholdingTaxResolutionProvenance withholdingTaxResolutionProvenanceInstance = new WithholdingTaxResolutionProvenance(
    matchScore: matchScore,
    matchedFieldCount: matchedFieldCount,
    sourceFilterApplied: sourceFilterApplied,
    tieBroken: tieBroken);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
