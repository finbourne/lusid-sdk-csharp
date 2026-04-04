# Lusid.Sdk.Model.OverrideVirtualTransactionsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Contains warnings related to unresolved instruments or non-existent transaction types for the override transactions. | [optional] 
**InstrumentEventId** | **string** | The identifier of the instrument event that was overridden. | 
**CancelInstructionId** | **string** | The identifier of the cancel instruction that was created for the overridden instrument event. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion varVersion = new ModelVersion();
string href = "example href";
Dictionary<string, List<ResponseMetaData>> metadata = new Dictionary<string, List<ResponseMetaData>>();
string instrumentEventId = "instrumentEventId";
string cancelInstructionId = "cancelInstructionId";
List<Link> links = new List<Link>();

OverrideVirtualTransactionsResponse overrideVirtualTransactionsResponseInstance = new OverrideVirtualTransactionsResponse(
    varVersion: varVersion,
    href: href,
    metadata: metadata,
    instrumentEventId: instrumentEventId,
    cancelInstructionId: cancelInstructionId,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
