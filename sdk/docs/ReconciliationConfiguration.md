# Lusid.Sdk.Model.ReconciliationConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**ReconciliationSideConfiguration**](ReconciliationSideConfiguration.md) |  | [optional] 
**Right** | [**ReconciliationSideConfiguration**](ReconciliationSideConfiguration.md) |  | [optional] 
**MappingId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ReconciliationSideConfiguration? left = new ReconciliationSideConfiguration();

ReconciliationSideConfiguration? right = new ReconciliationSideConfiguration();

ResourceId? mappingId = new ResourceId();


ReconciliationConfiguration reconciliationConfigurationInstance = new ReconciliationConfiguration(
    left: left,
    right: right,
    mappingId: mappingId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
