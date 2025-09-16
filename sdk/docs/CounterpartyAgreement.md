# Lusid.Sdk.Model.CounterpartyAgreement
Represents the legal agreement between two parties engaged in an OTC transaction.  A typical example would be a 2002 ISDA Master Agreement, signed by two legal entities on a given date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | A user-defined display label for the Counterparty Agreement. | 
**AgreementType** | **string** | A user-defined field to capture the type of agreement this represents. Examples might be \&quot;ISDA 2002 Master Agreement\&quot; or \&quot;ISDA 1992 Master Agreement\&quot;. | 
**CounterpartySignatory** | [**CounterpartySignatory**](CounterpartySignatory.md) |  | 
**DatedAsOf** | **DateTimeOffset** | The date on which the CounterpartyAgreement was signed by both parties. | 
**CreditSupportAnnexId** | [**ResourceId**](ResourceId.md) |  | 
**Id** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string agreementType = "agreementType";
CounterpartySignatory counterpartySignatory = new CounterpartySignatory();
ResourceId creditSupportAnnexId = new ResourceId();
ResourceId id = new ResourceId();

CounterpartyAgreement counterpartyAgreementInstance = new CounterpartyAgreement(
    displayName: displayName,
    agreementType: agreementType,
    counterpartySignatory: counterpartySignatory,
    datedAsOf: datedAsOf,
    creditSupportAnnexId: creditSupportAnnexId,
    id: id);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
