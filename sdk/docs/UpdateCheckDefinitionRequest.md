# Lusid.Sdk.Model.UpdateCheckDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the Check Definition. | 
**Description** | **string** | A description for the Check Definition. | 
**DatasetSchema** | [**CheckDefinitionDatasetSchema**](CheckDefinitionDatasetSchema.md) |  | [optional] 
**RuleSets** | [**List&lt;UpdateCheckDefinitionRuleSet&gt;**](UpdateCheckDefinitionRuleSet.md) | A collection of rule sets for the Check Definition. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Check Definition. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "description";
CheckDefinitionDatasetSchema? datasetSchema = new CheckDefinitionDatasetSchema();

List<UpdateCheckDefinitionRuleSet> ruleSets = new List<UpdateCheckDefinitionRuleSet>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();

UpdateCheckDefinitionRequest updateCheckDefinitionRequestInstance = new UpdateCheckDefinitionRequest(
    displayName: displayName,
    description: description,
    datasetSchema: datasetSchema,
    ruleSets: ruleSets,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
