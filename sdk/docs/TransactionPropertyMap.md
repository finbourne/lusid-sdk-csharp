# Lusid.Sdk.Model.TransactionPropertyMap

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyKey** | **string** | The key that uniquely identifies the property. It has the format {domain}/{scope}/{code}. | [optional] 
**Value** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string propertyKey = "example propertyKey";
string value = "example value";

TransactionPropertyMap transactionPropertyMapInstance = new TransactionPropertyMap(
    propertyKey: propertyKey,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
