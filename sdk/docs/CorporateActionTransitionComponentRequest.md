# Lusid.Sdk.Model.CorporateActionTransitionComponentRequest
A single transition component request, when grouped with other transition component requests a corporate action  transition request is formed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | 
**UnitsFactor** | **decimal** | The factor to scale units by | 
**CostFactor** | **decimal** | The factor to scale cost by | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();decimal unitsFactor = "unitsFactor";
decimal costFactor = "costFactor";


CorporateActionTransitionComponentRequest corporateActionTransitionComponentRequestInstance = new CorporateActionTransitionComponentRequest(
    instrumentIdentifiers: instrumentIdentifiers,
    unitsFactor: unitsFactor,
    costFactor: costFactor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
