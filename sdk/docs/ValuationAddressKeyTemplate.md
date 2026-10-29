# Lusid.Sdk.Model.ValuationAddressKeyTemplate
A set of valuation metrics and grouping keys. Funds and NAV Types reference a template by its id.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Valuation Template. | [optional] 
**Description** | **string** | A description of the Valuation Template. | [optional] 
**Metrics** | [**List&lt;AggregateSpec&gt;**](AggregateSpec.md) | The metrics to calculate in a valuation that uses this template. Each metric is an address key, an operation and optional key options. Valuation Templates do not support returnAs. | [optional] 
**IsDefault** | **bool** | True if this is the default Valuation Template, which applies when neither the Fund nor the NAV Type references a template. A domain has one default. Set isDefault on UpsertValuationAddressKeyTemplate to change it. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "example displayName";
string description = "example description";
List<AggregateSpec> metrics = new List<AggregateSpec>();
bool isDefault = //"True";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

ValuationAddressKeyTemplate valuationAddressKeyTemplateInstance = new ValuationAddressKeyTemplate(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    metrics: metrics,
    isDefault: isDefault,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
