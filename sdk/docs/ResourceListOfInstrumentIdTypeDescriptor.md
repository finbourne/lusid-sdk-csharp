# Lusid.Sdk.Model.ResourceListOfInstrumentIdTypeDescriptor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;InstrumentIdTypeDescriptor&gt;**](InstrumentIdTypeDescriptor.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<InstrumentIdTypeDescriptor> values = new List<InstrumentIdTypeDescriptor>();
string href = "example href";
List<Link> links = new List<Link>();
string nextPage = "example nextPage";
string previousPage = "example previousPage";

ResourceListOfInstrumentIdTypeDescriptor resourceListOfInstrumentIdTypeDescriptorInstance = new ResourceListOfInstrumentIdTypeDescriptor(
    values: values,
    href: href,
    links: links,
    nextPage: nextPage,
    previousPage: previousPage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
