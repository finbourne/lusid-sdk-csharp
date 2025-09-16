# Lusid.Sdk.Model.UpdateStagingRuleSetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the staging rule set. | 
**Description** | **string** | A description for the staging rule set. | [optional] 
**Rules** | [**List&lt;StagingRule&gt;**](StagingRule.md) | The list of staging rules that apply to a specific entity type. | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
List<StagingRule> rules = new List<StagingRule>();

UpdateStagingRuleSetRequest updateStagingRuleSetRequestInstance = new UpdateStagingRuleSetRequest(
    displayName: displayName,
    description: description,
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
