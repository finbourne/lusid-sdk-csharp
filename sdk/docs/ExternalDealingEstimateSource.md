# Lusid.Sdk.Model.ExternalDealingEstimateSource
The system that sent an external order set, and its own reference for the batch.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**System** | **string** |  | 
**Reference** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string system = "system";
string reference = "example reference";

ExternalDealingEstimateSource externalDealingEstimateSourceInstance = new ExternalDealingEstimateSource(
    system: system,
    reference: reference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
