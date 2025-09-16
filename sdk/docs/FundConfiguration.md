# Lusid.Sdk.Model.FundConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the FundConfiguration. | [optional] 
**Description** | **string** | A description for the FundConfiguration. | [optional] 
**DealingFilters** | [**List&lt;ComponentFilter&gt;**](ComponentFilter.md) | The set of filters used to decide which JE lines are included in the dealing. | [optional] 
**PnlFilters** | [**List&lt;ComponentFilter&gt;**](ComponentFilter.md) | The set of filters used to decide which JE lines are included in the PnL. | [optional] 
**BackOutFilters** | [**List&lt;ComponentFilter&gt;**](ComponentFilter.md) | The set of filters used to decide which JE lines are included in the back outs. | [optional] 
**ExternalFeeFilters** | [**List&lt;ExternalFeeComponentFilter&gt;**](ExternalFeeComponentFilter.md) | The set of filters used to decide which JE lines are used for inputting fees from an external source. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Fund Configuration. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "example displayName";
string description = "example description";
List<ComponentFilter> dealingFilters = new List<ComponentFilter>();
List<ComponentFilter> pnlFilters = new List<ComponentFilter>();
List<ComponentFilter> backOutFilters = new List<ComponentFilter>();
List<ExternalFeeComponentFilter> externalFeeFilters = new List<ExternalFeeComponentFilter>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

FundConfiguration fundConfigurationInstance = new FundConfiguration(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    dealingFilters: dealingFilters,
    pnlFilters: pnlFilters,
    backOutFilters: backOutFilters,
    externalFeeFilters: externalFeeFilters,
    properties: properties,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
