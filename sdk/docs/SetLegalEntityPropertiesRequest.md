# Lusid.Sdk.Model.SetLegalEntityPropertiesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Properties to set for a Legal Entity. All time-variant properties must have same EffectiveFrom date. Properties not included in the request will not be amended. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Property> properties = new Dictionary<string, Property>();

SetLegalEntityPropertiesRequest setLegalEntityPropertiesRequestInstance = new SetLegalEntityPropertiesRequest(
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
