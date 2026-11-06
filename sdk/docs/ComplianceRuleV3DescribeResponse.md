# Lusid.Sdk.Model.ComplianceRuleV3DescribeResponse
A plain-English description of a V3 compliance rule. This is a minimal placeholder shape: the plain-English  generator is delivered separately, so the Lines property is currently empty and only the rule's identity  and subject are populated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Subject** | **string** | Available values: Holdings, Orders. | [optional] 
**Lines** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? id = new ResourceId();

string subject = "example subject";
List<string> lines = new List<string>();

ComplianceRuleV3DescribeResponse complianceRuleV3DescribeResponseInstance = new ComplianceRuleV3DescribeResponse(
    id: id,
    subject: subject,
    lines: lines);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
