# Lusid.Sdk.Model.DataMapKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | The version of the mappings. It is possible that a client will wish to update mappings over time. The version identifies the MAJOR.MINOR.PATCH version  of the mappings that the client assigns it. | [optional] 
**Code** | **string** | A unique name to semantically identify the mapping set. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string varVersion = "example varVersion";
string code = "example code";

DataMapKey dataMapKeyInstance = new DataMapKey(
    varVersion: varVersion,
    code: code);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
