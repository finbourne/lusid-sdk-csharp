# Lusid.Sdk.Model.UpsertSingleStructuredDataResponse
Response from upserting structured data document

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Value** | **DateTimeOffset** | The value that was successfully retrieved. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
List<Link> links = new List<Link>();

UpsertSingleStructuredDataResponse upsertSingleStructuredDataResponseInstance = new UpsertSingleStructuredDataResponse(
    href: href,
    value: value,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
