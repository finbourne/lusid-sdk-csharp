# Lusid.Sdk.Model.GroupReconciliationCoreAttributeValues

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeftCoreAttributes** | [**List&lt;ComparisonAttributeValuePair&gt;**](ComparisonAttributeValuePair.md) | Core attribute names and values for the left hand entity being reconciled. | 
**RightCoreAttributes** | [**List&lt;ComparisonAttributeValuePair&gt;**](ComparisonAttributeValuePair.md) | Core attribute names and values for the right hand entity being reconciled. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<ComparisonAttributeValuePair> leftCoreAttributes = new List<ComparisonAttributeValuePair>();
List<ComparisonAttributeValuePair> rightCoreAttributes = new List<ComparisonAttributeValuePair>();

GroupReconciliationCoreAttributeValues groupReconciliationCoreAttributeValuesInstance = new GroupReconciliationCoreAttributeValues(
    leftCoreAttributes: leftCoreAttributes,
    rightCoreAttributes: rightCoreAttributes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
