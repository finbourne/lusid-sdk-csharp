# Lusid.Sdk.Model.ResourceListOfListComplexMarketDataWithMetaDataResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;ListComplexMarketDataWithMetaDataResponse&gt;**](ListComplexMarketDataWithMetaDataResponse.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ListComplexMarketDataWithMetaDataResponse> values = new List<ListComplexMarketDataWithMetaDataResponse>();
string href = "example href";
List<Link> links = new List<Link>();
string nextPage = "example nextPage";
string previousPage = "example previousPage";

ResourceListOfListComplexMarketDataWithMetaDataResponse resourceListOfListComplexMarketDataWithMetaDataResponseInstance = new ResourceListOfListComplexMarketDataWithMetaDataResponse(
    values: values,
    href: href,
    links: links,
    nextPage: nextPage,
    previousPage: previousPage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
