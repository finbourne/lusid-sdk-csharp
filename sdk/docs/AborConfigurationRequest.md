# Lusid.Sdk.Model.AborConfigurationRequest
The request used to create an AborConfiguration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the Abor Configuration. | 
**DisplayName** | **string** | The name of the Abor Configuration. | [optional] 
**Description** | **string** | A description for the Abor Configuration. | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**PostingModuleCodes** | **List&lt;string&gt;** | The Posting Module Codes from which the rules to be applied are retrieved. | [optional] 
**CleardownModuleCodes** | **List&lt;string&gt;** | The Cleardown Module Codes from which the rules to be applied are retrieved. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Abor Configuration. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "example displayName";
string description = "example description";
ResourceId recipeId = new ResourceId();
ResourceId chartOfAccountsId = new ResourceId();
List<string> postingModuleCodes = new List<string>();
List<string> cleardownModuleCodes = new List<string>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();

AborConfigurationRequest aborConfigurationRequestInstance = new AborConfigurationRequest(
    code: code,
    displayName: displayName,
    description: description,
    recipeId: recipeId,
    chartOfAccountsId: chartOfAccountsId,
    postingModuleCodes: postingModuleCodes,
    cleardownModuleCodes: cleardownModuleCodes,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
