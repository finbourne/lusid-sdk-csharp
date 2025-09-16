# Lusid.Sdk.Model.FeeRuleUpsertResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, FeeRule&gt;**](FeeRule.md) |  | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, FeeRule> values = new Dictionary<string, FeeRule>();
List<Link> links = new List<Link>();

FeeRuleUpsertResponse feeRuleUpsertResponseInstance = new FeeRuleUpsertResponse(
    values: values,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
