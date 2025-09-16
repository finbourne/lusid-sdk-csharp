# Lusid.Sdk.Model.LusidProblemDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**ErrorDetails** | **List&lt;Dictionary&lt;string, string&gt;&gt;** |  | [optional] 
**Code** | **int** |  | 
**Type** | **string** |  | [optional] 
**Title** | **string** |  | [optional] 
**Status** | **int?** |  | [optional] 
**Detail** | **string** |  | [optional] 
**Instance** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
List<Dictionary<string, string>> errorDetails = new List<Dictionary<string, string>>();
string type = "example type";
string title = "example title";
string detail = "example detail";
string instance = "example instance";

LusidProblemDetails lusidProblemDetailsInstance = new LusidProblemDetails(
    name: name,
    errorDetails: errorDetails,
    code: code,
    type: type,
    title: title,
    status: status,
    detail: detail,
    instance: instance);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
