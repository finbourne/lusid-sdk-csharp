# Lusid.Sdk.Model.FeeType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the fee type. | 
**Description** | **string** | The description of the fee type. | 
**ComponentTransactions** | [**List&lt;ComponentTransaction&gt;**](ComponentTransaction.md) | A set of component transactions that relate to the fee type to be created. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "description";
List<ComponentTransaction> componentTransactions = new List<ComponentTransaction>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

FeeType feeTypeInstance = new FeeType(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    componentTransactions: componentTransactions,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
