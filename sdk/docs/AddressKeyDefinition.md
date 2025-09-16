# Lusid.Sdk.Model.AddressKeyDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressKey** | **string** | The address key of the address key definition. | 
**Type** | **string** | The type of the address key definition | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string addressKey = "addressKey";
string type = "type";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

AddressKeyDefinition addressKeyDefinitionInstance = new AddressKeyDefinition(
    addressKey: addressKey,
    type: type,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
