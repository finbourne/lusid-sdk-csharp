# Lusid.Sdk.Model.UpsertCustomEntitiesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, CustomEntityResponse&gt;**](CustomEntityResponse.md) | The custom-entities which have been successfully updated or created. | [optional] 
**Staged** | [**Dictionary&lt;string, CustomEntityResponse&gt;**](CustomEntityResponse.md) | The custom-entities that have been staged for update or creation. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The custom-entities that could not be updated or created or were left unchanged without error along with a reason for their failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, CustomEntityResponse> values = new Dictionary<string, CustomEntityResponse>();
Dictionary<string, CustomEntityResponse> staged = new Dictionary<string, CustomEntityResponse>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

UpsertCustomEntitiesResponse upsertCustomEntitiesResponseInstance = new UpsertCustomEntitiesResponse(
    href: href,
    values: values,
    staged: staged,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
