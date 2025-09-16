# Lusid.Sdk.Model.UpsertPersonsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, Person&gt;**](Person.md) | The Person(s) that have been successfully upserted | 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The Person(s) that could not be upserted along with a reason for their failure. | 
**AsAtDate** | **DateTimeOffset** | The as-at datetime at which Person(s) were created or updated. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Person> values = new Dictionary<string, Person>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

UpsertPersonsResponse upsertPersonsResponseInstance = new UpsertPersonsResponse(
    values: values,
    failed: failed,
    asAtDate: asAtDate,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
