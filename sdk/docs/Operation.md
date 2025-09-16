# Lusid.Sdk.Model.Operation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **Object** |  | [optional] 
**Path** | **string** |  | 
**Op** | **string** |  | 
**From** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string path = "path";
string op = "op";
string from = "example from";

Operation operationInstance = new Operation(
    value: value,
    path: path,
    op: op,
    from: from);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
