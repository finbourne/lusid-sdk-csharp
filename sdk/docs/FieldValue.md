# Lusid.Sdk.Model.FieldValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** |  | 
**Fields** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**NumericFields** | **Dictionary&lt;string, decimal&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string value = "value";
Dictionary<string, string> fields = new Dictionary<string, string>();
Dictionary<string, decimal> numericFields = new Dictionary<string, decimal>();

FieldValue fieldValueInstance = new FieldValue(
    value: value,
    fields: fields,
    numericFields: numericFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
