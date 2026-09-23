# Lusid.Sdk.Model.WithholdingTaxConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**AnomalyDataset** | [**ResourceId**](ResourceId.md) |  | 
**MainDataset** | [**ResourceId**](ResourceId.md) |  | 
**SourcePriority** | **List&lt;string&gt;** | The rule sources in priority order, most preferred first. Optional: a single-source customer configures none and leaves ruleSource blank on every rate row, in which case no source filter is applied and specificity alone decides. | [optional] 
**ValueSources** | [**List&lt;WithholdingTaxValueSource&gt;**](WithholdingTaxValueSource.md) | One declaration per customer-defined matching dimension across both datasets, naming where the engine reads that dimension&#39;s value from. A dataset column name cannot imply a storage location, so a declaration is required for every customer dimension: an unmapped dimension is never supplied by the matching request, so no row ever matches on it and the customer silently gets a broader rate than they configured. No declaration is required for taxCountry or profileType, which the engine fills from the waterfall, nor for ruleSource, which is compared against SourcePriority. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
ResourceId anomalyDataset = new ResourceId();
ResourceId mainDataset = new ResourceId();
List<string> sourcePriority = new List<string>();
List<WithholdingTaxValueSource> valueSources = new List<WithholdingTaxValueSource>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

WithholdingTaxConfiguration withholdingTaxConfigurationInstance = new WithholdingTaxConfiguration(
    href: href,
    id: id,
    anomalyDataset: anomalyDataset,
    mainDataset: mainDataset,
    sourcePriority: sourcePriority,
    valueSources: valueSources,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
