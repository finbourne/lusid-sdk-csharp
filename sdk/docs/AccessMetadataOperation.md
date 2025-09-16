# Lusid.Sdk.Model.AccessMetadataOperation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | [**List&lt;AccessMetadataValue&gt;**](AccessMetadataValue.md) |  | 
**Path** | **string** |  | 
**Op** | **string** | The available values are: add, remove | 
**From** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<AccessMetadataValue> value = new List<AccessMetadataValue>();
string path = "path";
string op = "op";
string from = "example from";

AccessMetadataOperation accessMetadataOperationInstance = new AccessMetadataOperation(
    value: value,
    path: path,
    op: op,
    from: from);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
