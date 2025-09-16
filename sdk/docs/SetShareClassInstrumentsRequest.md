# Lusid.Sdk.Model.SetShareClassInstrumentsRequest
The request used to create a Fund.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassInstrumentScopes** | **List&lt;string&gt;** | The scopes in which the instruments lie, currently limited to one. | 
**ShareClassInstruments** | [**List&lt;InstrumentResolutionDetail&gt;**](InstrumentResolutionDetail.md) | Details the user-provided instrument identifiers and the instrument resolved from them. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> shareClassInstrumentScopes = new List<string>();
List<InstrumentResolutionDetail> shareClassInstruments = new List<InstrumentResolutionDetail>();

SetShareClassInstrumentsRequest setShareClassInstrumentsRequestInstance = new SetShareClassInstrumentsRequest(
    shareClassInstrumentScopes: shareClassInstrumentScopes,
    shareClassInstruments: shareClassInstruments);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
