# Lusid.Sdk.Model.CorporateActionTransitionComponent
A single transition component, when grouped with other components a corporate action transition is formed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentScope** | **string** | The scope in which the instrument lies. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | 
**InstrumentUid** | **string** | LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers | 
**UnitsFactor** | **decimal** | The factor to scale units by | 
**CostFactor** | **decimal** | The factor to scale cost by | 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentScope = "instrumentScope";
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string instrumentUid = "instrumentUid";decimal unitsFactor = "unitsFactor";
decimal costFactor = "costFactor";


CorporateActionTransitionComponent corporateActionTransitionComponentInstance = new CorporateActionTransitionComponent(
    instrumentScope: instrumentScope,
    instrumentIdentifiers: instrumentIdentifiers,
    instrumentUid: instrumentUid,
    unitsFactor: unitsFactor,
    costFactor: costFactor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
