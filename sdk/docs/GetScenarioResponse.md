# Lusid.Sdk.Model.GetScenarioResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**Value** | [**ScenarioDefinition**](ScenarioDefinition.md) |  | [optional] 
**Failed** | [**ErrorDetail**](ErrorDetail.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ScenarioDefinition? value = new ScenarioDefinition();

ErrorDetail? failed = new ErrorDetail();

List<Link> links = new List<Link>();

GetScenarioResponse getScenarioResponseInstance = new GetScenarioResponse(
    href: href,
    value: value,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
