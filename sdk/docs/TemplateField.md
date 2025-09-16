# Lusid.Sdk.Model.TemplateField

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** |  | 
**Specificity** | **string** |  | 
**Description** | **string** |  | 
**Type** | **string** |  | 
**Availability** | **string** |  | 
**Usage** | **List&lt;string&gt;** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string fieldName = "fieldName";
string specificity = "specificity";
string description = "description";
string type = "type";
string availability = "availability";
List<string> usage = new List<string>();

TemplateField templateFieldInstance = new TemplateField(
    fieldName: fieldName,
    specificity: specificity,
    description: description,
    type: type,
    availability: availability,
    usage: usage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
