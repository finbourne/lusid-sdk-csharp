# Lusid.Sdk.Model.GroupReconciliationAggregateAttributeValues

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeftAggregateAttributes** | [**List&lt;ComparisonAttributeValuePair&gt;**](ComparisonAttributeValuePair.md) | Aggregate attribute names and values for the left hand entity being reconciled. | 
**RightAggregateAttributes** | [**List&lt;ComparisonAttributeValuePair&gt;**](ComparisonAttributeValuePair.md) | Aggregate attribute names and values for the right hand entity being reconciled. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<ComparisonAttributeValuePair> leftAggregateAttributes = new List<ComparisonAttributeValuePair>();
List<ComparisonAttributeValuePair> rightAggregateAttributes = new List<ComparisonAttributeValuePair>();

GroupReconciliationAggregateAttributeValues groupReconciliationAggregateAttributeValuesInstance = new GroupReconciliationAggregateAttributeValues(
    leftAggregateAttributes: leftAggregateAttributes,
    rightAggregateAttributes: rightAggregateAttributes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
