# Lusid.Sdk.Model.CounterpartyIdentifier
The legal entity a collateral agreement is made with.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdTypeScope** | **string** | The scope of the identifier type, e.g. the scope of the LEI identifier. | 
**IdTypeCode** | **string** | The code of the identifier type, e.g. LEI. | 
**Code** | **string** | The value of the identifier. | 

```csharp
using Lusid.Sdk.Model;
using System;

string idTypeScope = "idTypeScope";
string idTypeCode = "idTypeCode";
string code = "code";

CounterpartyIdentifier counterpartyIdentifierInstance = new CounterpartyIdentifier(
    idTypeScope: idTypeScope,
    idTypeCode: idTypeCode,
    code: code);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
