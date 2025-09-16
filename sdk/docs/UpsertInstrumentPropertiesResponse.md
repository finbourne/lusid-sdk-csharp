# Lusid.Sdk.Model.UpsertInstrumentPropertiesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAtDate** | **DateTimeOffset** | The as-at datetime at which properties were created or updated. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<Link> links = new List<Link>();

UpsertInstrumentPropertiesResponse upsertInstrumentPropertiesResponseInstance = new UpsertInstrumentPropertiesResponse(
    asAtDate: asAtDate,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
