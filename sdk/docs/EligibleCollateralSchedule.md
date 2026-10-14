# Lusid.Sdk.Model.EligibleCollateralSchedule
An eligible collateral schedule: the collateral a party may post under a margin arrangement and the valuation  percentage each class of collateral is accepted at.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Description** | **string** | A description of the Eligible Collateral Schedule. Optional. | [optional] 
**Rows** | [**List&lt;EligibleCollateralRow&gt;**](EligibleCollateralRow.md) | The classes of collateral that may be posted, each with the valuation percentage it is accepted at. At least one and at most 200 rows. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties to decorate onto the Eligible Collateral Schedule. Filterable. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string description = "example description";
List<EligibleCollateralRow> rows = new List<EligibleCollateralRow>();
ModelVersion? varVersion = new ModelVersion();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Link> links = new List<Link>();

EligibleCollateralSchedule eligibleCollateralScheduleInstance = new EligibleCollateralSchedule(
    href: href,
    id: id,
    description: description,
    rows: rows,
    varVersion: varVersion,
    properties: properties,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
