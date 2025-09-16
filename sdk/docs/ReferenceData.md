# Lusid.Sdk.Model.ReferenceData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldDefinitions** | [**List&lt;FieldDefinition&gt;**](FieldDefinition.md) |  | 
**Values** | [**List&lt;FieldValue&gt;**](FieldValue.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<FieldDefinition> fieldDefinitions = new List<FieldDefinition>();
List<FieldValue> values = new List<FieldValue>();

ReferenceData referenceDataInstance = new ReferenceData(
    fieldDefinitions: fieldDefinitions,
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
