# Lusid.Sdk.Model.MarketDataFieldConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataCategory** | **string** | The category of market data this configuration applies to. Available values: Quote, Complex. | 
**Scope** | **string** | The scope of the market data field configuration. | 
**MetadataFieldSchema** | [**List&lt;MetadataFieldDefinition&gt;**](MetadataFieldDefinition.md) | The metadata field definitions for this configuration. | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string marketDataCategory = "marketDataCategory";
string scope = "scope";
List<MetadataFieldDefinition> metadataFieldSchema = new List<MetadataFieldDefinition>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

MarketDataFieldConfiguration marketDataFieldConfigurationInstance = new MarketDataFieldConfiguration(
    marketDataCategory: marketDataCategory,
    scope: scope,
    metadataFieldSchema: metadataFieldSchema,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
