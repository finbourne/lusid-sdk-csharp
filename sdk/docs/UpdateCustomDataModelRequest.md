# Lusid.Sdk.Model.UpdateCustomDataModelRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the Custom Data Model. | 
**Description** | **string** | A description for the Custom Data Model. | 
**ParentDataModel** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Conditions** | **string** | The conditions that the bound entity must meet to be valid. | [optional] 
**Properties** | [**List&lt;CustomDataModelPropertySpecification&gt;**](CustomDataModelPropertySpecification.md) | The properties that are required or allowed on the bound entity. | [optional] 
**IdentifierTypes** | [**List&lt;CustomDataModelIdentifierTypeSpecification&gt;**](CustomDataModelIdentifierTypeSpecification.md) | The identifier types that are required or allowed on the bound entity. | [optional] 
**AttributeAliases** | [**List&lt;Alias&gt;**](Alias.md) | The aliases for property keys, identifier types, and fields on the bound entity. | [optional] 
**RecommendedSortBy** | [**List&lt;RecommendedSortBy&gt;**](RecommendedSortBy.md) | The preferred default sorting instructions. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "description";
ResourceId? parentDataModel = new ResourceId();

string conditions = "example conditions";
List<CustomDataModelPropertySpecification> properties = new List<CustomDataModelPropertySpecification>();
List<CustomDataModelIdentifierTypeSpecification> identifierTypes = new List<CustomDataModelIdentifierTypeSpecification>();
List<Alias> attributeAliases = new List<Alias>();
List<RecommendedSortBy> recommendedSortBy = new List<RecommendedSortBy>();

UpdateCustomDataModelRequest updateCustomDataModelRequestInstance = new UpdateCustomDataModelRequest(
    displayName: displayName,
    description: description,
    parentDataModel: parentDataModel,
    conditions: conditions,
    properties: properties,
    identifierTypes: identifierTypes,
    attributeAliases: attributeAliases,
    recommendedSortBy: recommendedSortBy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
