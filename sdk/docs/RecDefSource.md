# Lusid.Sdk.Model.RecDefSource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceType** | **string** | The type of entity that this source refers to. One of: Portfolio, PortfolioGroup, Fund. Available values: Portfolio, PortfolioGroup, Fund. | 
**Id** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string sourceType = "sourceType";
ResourceId id = new ResourceId();

RecDefSource recDefSourceInstance = new RecDefSource(
    sourceType: sourceType,
    id: id);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
