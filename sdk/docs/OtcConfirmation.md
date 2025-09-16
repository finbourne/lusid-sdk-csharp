# Lusid.Sdk.Model.OtcConfirmation
For the storage of any information pertinent to the confirmation of an OTC trade. e.g the Counterparty Agreement Code

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CounterpartyAgreementId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? counterpartyAgreementId = new ResourceId();


OtcConfirmation otcConfirmationInstance = new OtcConfirmation(
    counterpartyAgreementId: counterpartyAgreementId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
