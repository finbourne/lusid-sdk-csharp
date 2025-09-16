# Lusid.Sdk.Model.AddressKeyOptionDefinition
The definition of an Address Key Option

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the option | 
**Type** | **string** | The type of the option | 
**Description** | **string** | The description of the option | 
**Optional** | **bool** | Is this option required or optional? | 
**AllowedValueSet** | **List&lt;string&gt;** | If the option is a string or enum, the allowed set of values it can take. | [optional] 
**DefaultValue** | **string** | If the option is not required, what is the default value? | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
string type = "type";
string description = "description";
bool optional = //"True";
List<string> allowedValueSet = new List<string>();
string defaultValue = "example defaultValue";

AddressKeyOptionDefinition addressKeyOptionDefinitionInstance = new AddressKeyOptionDefinition(
    name: name,
    type: type,
    description: description,
    optional: optional,
    allowedValueSet: allowedValueSet,
    defaultValue: defaultValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
