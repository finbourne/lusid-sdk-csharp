# Lusid.Sdk.Model.CounterpartySignatory
The counterpartyAgreement is signed by two parties, one of which is implicitly the LUSID user.  The CounterpartySignatory represents the 'other side' of the agreement.  It comprises a name and identifier for a Legal Entity in LUSID.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A user-defined name or label for the counterparty signatory.  There is no requirement for this to match the \&quot;displayName\&quot; of the legal entity. | 
**LegalEntityIdentifier** | [**TypedResourceId**](TypedResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
TypedResourceId legalEntityIdentifier = new TypedResourceId();

CounterpartySignatory counterpartySignatoryInstance = new CounterpartySignatory(
    name: name,
    legalEntityIdentifier: legalEntityIdentifier);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
