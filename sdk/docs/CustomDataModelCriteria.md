# Lusid.Sdk.Model.CustomDataModelCriteria

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Conditions** | **List&lt;string&gt;** | The conditions that the bound entity must meet to be valid. | [optional] 
**Properties** | [**List&lt;CustomDataModelPropertySpecificationWithDisplayName&gt;**](CustomDataModelPropertySpecificationWithDisplayName.md) | The properties that are required or allowed on the bound entity. | [optional] 
**IdentifierTypes** | [**List&lt;CustomDataModelIdentifierTypeSpecificationWithDisplayName&gt;**](CustomDataModelIdentifierTypeSpecificationWithDisplayName.md) | The identifier types that are required or allowed on the bound entity. | [optional] 
**AttributeAliases** | [**List&lt;Alias&gt;**](Alias.md) | The aliases for property keys, identifier types, and fields on the bound entity. | [optional] 
**RecommendedSortBy** | [**List&lt;RecommendedSortBy&gt;**](RecommendedSortBy.md) | The preferred default sorting instructions. | [optional] 
**SupplementalPropertyKeys** | **List&lt;string&gt;** | Additional property keys that should be decorated on the bound entity. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> conditions = new List<string>();
List<CustomDataModelPropertySpecificationWithDisplayName> properties = new List<CustomDataModelPropertySpecificationWithDisplayName>();
List<CustomDataModelIdentifierTypeSpecificationWithDisplayName> identifierTypes = new List<CustomDataModelIdentifierTypeSpecificationWithDisplayName>();
List<Alias> attributeAliases = new List<Alias>();
List<RecommendedSortBy> recommendedSortBy = new List<RecommendedSortBy>();
List<string> supplementalPropertyKeys = new List<string>();

CustomDataModelCriteria customDataModelCriteriaInstance = new CustomDataModelCriteria(
    conditions: conditions,
    properties: properties,
    identifierTypes: identifierTypes,
    attributeAliases: attributeAliases,
    recommendedSortBy: recommendedSortBy,
    supplementalPropertyKeys: supplementalPropertyKeys);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
