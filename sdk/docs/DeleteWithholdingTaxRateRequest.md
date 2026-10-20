# Lusid.Sdk.Model.DeleteWithholdingTaxRateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesIdentifiers** | **Dictionary&lt;string, Object&gt;** | The series identifiers that, with effectiveAt, identify the rate row: taxCountry, profileType and the dataset&#39;s own matching dimensions, structured according to its field schema. ruleSource is not accepted here: pass it as the ruleSource query parameter, which applies it to every row in the batch, and omit it for rows that apply at every source. | [optional] 
**EffectiveAt** | **string** | The effectiveAt or cut-label datetime of the DataPoint. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Object> seriesIdentifiers = new Dictionary<string, Object>();
string effectiveAt = "effectiveAt";

DeleteWithholdingTaxRateRequest deleteWithholdingTaxRateRequestInstance = new DeleteWithholdingTaxRateRequest(
    seriesIdentifiers: seriesIdentifiers,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
