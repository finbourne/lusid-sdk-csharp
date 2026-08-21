# Lusid.Sdk.Model.PaymentDetailsApplicableEntity
Identifies the LUSID entity that holds the payment details (e.g. an InvestorRecord or Portfolio).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of the LUSID entity holding the payment details. e.g. \&quot;InvestorRecord\&quot;, \&quot;InvestmentAccount\&quot;, \&quot;Portfolio\&quot;. | 
**EntityScope** | **string** | The scope of the entity. Optional, and narrows the match when supplied. Required for a Portfolio. | [optional] 
**IdentifierType** | **string** | The identifier type used to identify the entity. e.g. \&quot;lusidInvestmentAccountId\&quot;. | 
**IdentifierScope** | **string** | The scope of the identifier used to identify the entity. Optional, and narrows the match when supplied. | [optional] 
**IdentifierValue** | **string** | The identifier value for the entity. e.g. \&quot;LUID_00003DNL\&quot;. | 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
string entityScope = "example entityScope";
string identifierType = "identifierType";
string identifierScope = "example identifierScope";
string identifierValue = "identifierValue";

PaymentDetailsApplicableEntity paymentDetailsApplicableEntityInstance = new PaymentDetailsApplicableEntity(
    entityType: entityType,
    entityScope: entityScope,
    identifierType: identifierType,
    identifierScope: identifierScope,
    identifierValue: identifierValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
