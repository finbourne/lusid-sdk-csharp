# Lusid.Sdk.Model.VirtualDocument
Virtual document consists of (potentially several) upserted documents.                The documents get parsed according to the provided data map on upsert, the collection of resulting values in  aggregated in a virtual document

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentId** | [**StructuredResultDataId**](StructuredResultDataId.md) |  | [optional] 
**Data** | [**List&lt;VirtualDocumentRow&gt;**](VirtualDocumentRow.md) | The data inside the document | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

StructuredResultDataId? documentId = new StructuredResultDataId();

List<VirtualDocumentRow> data = new List<VirtualDocumentRow>();

VirtualDocument virtualDocumentInstance = new VirtualDocument(
    documentId: documentId,
    data: data);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
