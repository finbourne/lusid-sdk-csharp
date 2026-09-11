# Lusid.Sdk.Model.ConsentGrantedElection
Election to grant consent to the proposed action (CONY), optionally in return for a consent fee.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** | Unique key associated to this election. | 
**IsDefault** | **bool** | Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided. | [optional] 
**IsChosen** | **bool** | Is this the election that has been explicitly chosen from multiple options. | [optional] 
**ConsentFeePrice** | **decimal?** | Optional. The consent fee paid per unit for granting consent. | [optional] 
**ConsentFeeCurrency** | **string** | Optional. Currency of the consent fee. Required if a consent fee price is provided. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string electionKey = "electionKey";
bool isDefault = //"True";
bool isChosen = //"True";
string consentFeeCurrency = "example consentFeeCurrency";

ConsentGrantedElection consentGrantedElectionInstance = new ConsentGrantedElection(
    electionKey: electionKey,
    isDefault: isDefault,
    isChosen: isChosen,
    consentFeePrice: consentFeePrice,
    consentFeeCurrency: consentFeeCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
