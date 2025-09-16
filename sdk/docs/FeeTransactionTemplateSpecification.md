# Lusid.Sdk.Model.FeeTransactionTemplateSpecification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SpecificationTypeName** | **string** |  | 
**SupportedTemplateFields** | [**List&lt;TemplateField&gt;**](TemplateField.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string specificationTypeName = "specificationTypeName";
List<TemplateField> supportedTemplateFields = new List<TemplateField>();

FeeTransactionTemplateSpecification feeTransactionTemplateSpecificationInstance = new FeeTransactionTemplateSpecification(
    specificationTypeName: specificationTypeName,
    supportedTemplateFields: supportedTemplateFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
