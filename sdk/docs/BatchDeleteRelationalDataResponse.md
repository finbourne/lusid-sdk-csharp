# Lusid.Sdk.Model.BatchDeleteRelationalDataResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | **Dictionary&lt;string, string&gt;** | A list of data points that were successfully upserted. | 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A list of data points that failed to be upserted, along with the associated error message. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> values = new Dictionary<string, string>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
string href = "example href";

BatchDeleteRelationalDataResponse batchDeleteRelationalDataResponseInstance = new BatchDeleteRelationalDataResponse(
    values: values,
    failed: failed,
    href: href);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
