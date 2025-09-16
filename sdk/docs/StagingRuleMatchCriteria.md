# Lusid.Sdk.Model.StagingRuleMatchCriteria

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionIn** | **List&lt;string&gt;** |  | [optional] 
**RequestingUser** | **string** |  | [optional] 
**EntityAttributes** | **string** |  | [optional] 
**ChangedAttributeNameIn** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> actionIn = new List<string>();
string requestingUser = "example requestingUser";
string entityAttributes = "example entityAttributes";
List<string> changedAttributeNameIn = new List<string>();

StagingRuleMatchCriteria stagingRuleMatchCriteriaInstance = new StagingRuleMatchCriteria(
    actionIn: actionIn,
    requestingUser: requestingUser,
    entityAttributes: entityAttributes,
    changedAttributeNameIn: changedAttributeNameIn);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
