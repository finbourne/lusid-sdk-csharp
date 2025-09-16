# Lusid.Sdk.Model.UpsertCustomEntityAccessMetadataRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadata** | [**List&lt;AccessMetadataValue&gt;**](AccessMetadataValue.md) | The access control metadata to assign to a CustomEntity that matches the identifier | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<AccessMetadataValue> metadata = new List<AccessMetadataValue>();

UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequestInstance = new UpsertCustomEntityAccessMetadataRequest(
    metadata: metadata);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
