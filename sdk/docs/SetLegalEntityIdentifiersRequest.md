# Lusid.Sdk.Model.SetLegalEntityIdentifiersRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifiers** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Identifiers to set for a Legal Entity. Identifiers not included in the request will not be amended. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Property> identifiers = new Dictionary<string, Property>();

SetLegalEntityIdentifiersRequest setLegalEntityIdentifiersRequestInstance = new SetLegalEntityIdentifiersRequest(
    identifiers: identifiers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
