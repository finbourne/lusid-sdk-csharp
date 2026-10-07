# Lusid.Sdk.Model.ApiEndpoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **string** |  | [optional] 
**HttpMethod** | **string** |  | 
**Path** | **string** |  | 
**Status** | **string** |  | [optional] 
**Summary** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string operation = "example operation";
string httpMethod = "httpMethod";
string path = "path";
string status = "example status";
string summary = "example summary";
string description = "example description";

ApiEndpoint apiEndpointInstance = new ApiEndpoint(
    operation: operation,
    httpMethod: httpMethod,
    path: path,
    status: status,
    summary: summary,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
