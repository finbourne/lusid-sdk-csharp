# Lusid.Sdk.Model.UpsertStructuredResultDataRequest
The details of the structured unit result data item to upsert into Lusid.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**StructuredResultDataId**](StructuredResultDataId.md) |  | 
**Data** | [**StructuredResultData**](StructuredResultData.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

StructuredResultDataId id = new StructuredResultDataId();
StructuredResultData? data = new StructuredResultData();


UpsertStructuredResultDataRequest upsertStructuredResultDataRequestInstance = new UpsertStructuredResultDataRequest(
    id: id,
    data: data);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
