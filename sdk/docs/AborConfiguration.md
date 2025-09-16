# Lusid.Sdk.Model.AborConfiguration
An AborConfiguration entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Abor Configuration. | [optional] 
**Description** | **string** | A description for the Abor Configuration. | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**PostingModuleCodes** | **List&lt;string&gt;** | The Posting Module Codes from which the rules to be applied are retrieved. | [optional] 
**CleardownModuleCodes** | **List&lt;string&gt;** | The Cleardown Module Codes from which the rules to be applied are retrieved. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Abor Configuration. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "example displayName";
string description = "example description";
ResourceId? recipeId = new ResourceId();

ResourceId chartOfAccountsId = new ResourceId();
List<string> postingModuleCodes = new List<string>();
List<string> cleardownModuleCodes = new List<string>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

AborConfiguration aborConfigurationInstance = new AborConfiguration(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    recipeId: recipeId,
    chartOfAccountsId: chartOfAccountsId,
    postingModuleCodes: postingModuleCodes,
    cleardownModuleCodes: cleardownModuleCodes,
    properties: properties,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
