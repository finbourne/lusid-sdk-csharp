# Lusid.Sdk.Model.UpsertWithholdingTaxConfigurationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnomalyDataset** | [**ResourceId**](ResourceId.md) |  | 
**MainDataset** | [**ResourceId**](ResourceId.md) |  | 
**SourcePriority** | **List&lt;string&gt;** | The rule sources in priority order, most preferred first. Optional: a single-source customer configures none and leaves ruleSource blank on every rate row, in which case no source filter is applied and specificity alone decides. | [optional] 
**ValueSources** | [**List&lt;WithholdingTaxValueSource&gt;**](WithholdingTaxValueSource.md) | One declaration per customer-defined matching dimension across both datasets, naming where the engine reads that dimension&#39;s value from. A dataset column name cannot imply a storage location, so a declaration is required for every customer dimension: an unmapped dimension is never supplied by the matching request, so no row ever matches on it and the customer silently gets a broader rate than they configured. No declaration is required for taxCountry or profileType, which the engine fills from the waterfall, nor for ruleSource, which is compared against SourcePriority. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId anomalyDataset = new ResourceId();
ResourceId mainDataset = new ResourceId();
List<string> sourcePriority = new List<string>();
List<WithholdingTaxValueSource> valueSources = new List<WithholdingTaxValueSource>();

UpsertWithholdingTaxConfigurationRequest upsertWithholdingTaxConfigurationRequestInstance = new UpsertWithholdingTaxConfigurationRequest(
    anomalyDataset: anomalyDataset,
    mainDataset: mainDataset,
    sourcePriority: sourcePriority,
    valueSources: valueSources);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
