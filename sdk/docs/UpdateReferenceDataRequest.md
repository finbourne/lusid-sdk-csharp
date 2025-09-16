# Lusid.Sdk.Model.UpdateReferenceDataRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestDefinitions** | [**List&lt;FieldDefinition&gt;**](FieldDefinition.md) | Definition of a reference data field. | 
**RequestValues** | [**List&lt;FieldValue&gt;**](FieldValue.md) | Reference data. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<FieldDefinition> requestDefinitions = new List<FieldDefinition>();
List<FieldValue> requestValues = new List<FieldValue>();

UpdateReferenceDataRequest updateReferenceDataRequestInstance = new UpdateReferenceDataRequest(
    requestDefinitions: requestDefinitions,
    requestValues: requestValues);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
