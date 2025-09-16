# Lusid.Sdk.Model.BatchUpsertPropertyDefinitionPropertiesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties that have been successfully upserted | 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The properties that could not be upserted along with a reason for their failure. | 
**AsAtDate** | **DateTimeOffset** | The as-at datetime at which properties were created or updated. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Property> values = new Dictionary<string, Property>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

BatchUpsertPropertyDefinitionPropertiesResponse batchUpsertPropertyDefinitionPropertiesResponseInstance = new BatchUpsertPropertyDefinitionPropertiesResponse(
    values: values,
    failed: failed,
    asAtDate: asAtDate,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
