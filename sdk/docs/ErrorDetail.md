# Lusid.Sdk.Model.ErrorDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the failed item that this error relates to. | [optional] 
**Type** | **string** | The type of failure that occurred. | [optional] 
**Detail** | **string** | Description of the failure that occurred. | [optional] 
**ErrorDetails** | **List&lt;Dictionary&lt;string, string&gt;&gt;** | Information about the particular instance of the failure (supplied information depends on the type of failure). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "example id";
string type = "example type";
string detail = "example detail";
List<Dictionary<string, string>> errorDetails = new List<Dictionary<string, string>>();

ErrorDetail errorDetailInstance = new ErrorDetail(
    id: id,
    type: type,
    detail: detail,
    errorDetails: errorDetails);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
