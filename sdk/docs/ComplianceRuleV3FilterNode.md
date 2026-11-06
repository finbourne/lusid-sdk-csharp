# Lusid.Sdk.Model.ComplianceRuleV3FilterNode
A node in a rule's filter tree: either a group combining child nodes with all/any, or a leaf condition.  The concrete kind is named by the FilterNodeType property.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FilterNodeType** | **string** | Available values: ComplianceRuleV3FilterGroup, ComplianceRuleV3FilterCondition. | 

```csharp
using Lusid.Sdk.Model;
using System;

string filterNodeType = "filterNodeType";

ComplianceRuleV3FilterNode complianceRuleV3FilterNodeInstance = new ComplianceRuleV3FilterNode(
    filterNodeType: filterNodeType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
