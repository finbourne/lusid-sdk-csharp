# Lusid.Sdk.Model.UpsertIndexConventionRequest
Index convention that is to be stored in the convention data store.  Only one of these must be present.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IndexConvention** | [**IndexConvention**](IndexConvention.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

IndexConvention? indexConvention = new IndexConvention();


UpsertIndexConventionRequest upsertIndexConventionRequestInstance = new UpsertIndexConventionRequest(
    indexConvention: indexConvention);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
