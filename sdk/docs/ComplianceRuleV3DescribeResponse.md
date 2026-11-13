# Lusid.Sdk.Model.ComplianceRuleV3DescribeResponse
A plain-English description of a V3 compliance rule: its identity, the kind of entity it examines, and a  single sentence describing what it checks. The sentence is empty for a rule the generator cannot fully  express.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Subject** | **string** | Available values: Holdings, Orders. | [optional] 
**PlainEnglish** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? id = new ResourceId();

string subject = "example subject";
string plainEnglish = "example plainEnglish";

ComplianceRuleV3DescribeResponse complianceRuleV3DescribeResponseInstance = new ComplianceRuleV3DescribeResponse(
    id: id,
    subject: subject,
    plainEnglish: plainEnglish);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
