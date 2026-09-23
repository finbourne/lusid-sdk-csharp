# Lusid.Sdk.Model.WithholdingTaxDataset

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope of the relational dataset definition. | 
**Code** | **string** | The code of the relational dataset definition. Together with the scope this uniquely identifies the definition. | 
**Dimensions** | [**List&lt;SeriesIdentifierField&gt;**](SeriesIdentifierField.md) | The dimensions created on this dataset as series identifiers, as stored. The mandatory core is not returned here; read the full field schema from the relational dataset definition at Href. | 
**Href** | **string** | The specific Uri of the relational dataset definition. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
List<SeriesIdentifierField> dimensions = new List<SeriesIdentifierField>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

WithholdingTaxDataset withholdingTaxDatasetInstance = new WithholdingTaxDataset(
    scope: scope,
    code: code,
    dimensions: dimensions,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
