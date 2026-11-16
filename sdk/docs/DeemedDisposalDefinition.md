# Lusid.Sdk.Model.DeemedDisposalDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the deemed disposal definition. | 
**Description** | **string** | The description of the deemed disposal definition. | [optional] 
**Filter** | **string** | Selects the holdings the definition deems disposed of and re-acquired at market value at a valuation point. Written in the holding filter grammar of the portfolio cash flow endpoints (holdingType, holdingTypeName, instrumentUid, instrumentScope, units, settledUnits, unsettledUnits, overdueUnits, currentFace, cost.amount, cost.currency, costPortfolioCcy.amount, custodianAccountId, custodianAccount, subHoldingKeys[...] and properties[...]), for example \&quot;holdingType eq &#39;B&#39; and cost.currency eq &#39;USD&#39;\&quot;, with the additional system field &#39;InNavTypeBaseCurrency&#39; (true when the holding is in the NAV type&#39;s base currency). The GetHoldings fields &#39;currency&#39; and &#39;transaction&#39; are not accepted. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
string filter = "filter";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

DeemedDisposalDefinition deemedDisposalDefinitionInstance = new DeemedDisposalDefinition(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    filter: filter,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
