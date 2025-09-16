# Lusid.Sdk.Model.NextValueInSequenceResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | **List&lt;string&gt;** | The next set of values for the specified Sequence. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> values = new List<string>();
List<Link> links = new List<Link>();

NextValueInSequenceResponse nextValueInSequenceResponseInstance = new NextValueInSequenceResponse(
    values: values,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
