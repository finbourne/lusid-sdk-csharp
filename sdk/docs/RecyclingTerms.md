# Lusid.Sdk.Model.RecyclingTerms

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** |  | 
**CapPercentageOfCommitments** | **decimal?** |  | [optional] 
**RecyclingEndDate** | **DateTimeOffset?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool enabled = //"True";

RecyclingTerms recyclingTermsInstance = new RecyclingTerms(
    enabled: enabled,
    capPercentageOfCommitments: capPercentageOfCommitments,
    recyclingEndDate: recyclingEndDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
