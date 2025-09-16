# Lusid.Sdk.Model.ResourceListOfAccessMetadataValueOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | **List&lt;List&lt;AccessMetadataValue&gt;&gt;** |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<List<AccessMetadataValue>> values = new List<List<AccessMetadataValue>>();
string href = "example href";
List<Link> links = new List<Link>();
string nextPage = "example nextPage";
string previousPage = "example previousPage";

ResourceListOfAccessMetadataValueOf resourceListOfAccessMetadataValueOfInstance = new ResourceListOfAccessMetadataValueOf(
    values: values,
    href: href,
    links: links,
    nextPage: nextPage,
    previousPage: previousPage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
