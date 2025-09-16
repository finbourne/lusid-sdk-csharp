# Lusid.Sdk.Model.ContractDetails
Set of identifiers of an existing FlexibleLoan contract.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers. | 
**LusidInstrumentId** | **string** | LUSID&#39;s internal unique instrument identifier - readonly field, resolved from the instrument identifiers. | [optional] [readonly] 
**InstrumentScope** | **string** | The scope in which the FlexibleLoan instrument lies - readonly field, resolved from the instrument identifiers. | [optional] [readonly] 
**InstrumentName** | **string** | The name of the FlexibleLoan instrument - readonly field, resolved from the instrument identifiers. | [optional] [readonly] 
**DomCcy** | **string** | The domestic currency of the instrument - readonly field, resolved from the instrument identifiers. | [optional] [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> identifiers = new Dictionary<string, string>();
string lusidInstrumentId = "example lusidInstrumentId";
string instrumentScope = "example instrumentScope";
string instrumentName = "example instrumentName";
string domCcy = "example domCcy";

ContractDetails contractDetailsInstance = new ContractDetails(
    identifiers: identifiers,
    lusidInstrumentId: lusidInstrumentId,
    instrumentScope: instrumentScope,
    instrumentName: instrumentName,
    domCcy: domCcy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
