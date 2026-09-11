# Lusid.Sdk.Model.ConsentAndTenderElection
Election to both grant consent and tender the holding (CTEN), optionally for a tender offer price and consent fee.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** | Unique key associated to this election. | 
**IsDefault** | **bool** | Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided. | [optional] 
**IsChosen** | **bool** | Is this the election that has been explicitly chosen from multiple options. | [optional] 
**TenderOfferPrice** | **decimal?** | Optional. Price per unit offered for the tendered holding. | [optional] 
**TenderOfferCurrency** | **string** | Optional. Currency of the tender offer. Required if a tender offer price is provided. | [optional] 
**ConsentFeePrice** | **decimal?** | Optional. The consent fee paid per unit for granting consent. | [optional] 
**ConsentFeeCurrency** | **string** | Optional. Currency of the consent fee. Required if a consent fee price is provided. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string electionKey = "electionKey";
bool isDefault = //"True";
bool isChosen = //"True";
string tenderOfferCurrency = "example tenderOfferCurrency";
string consentFeeCurrency = "example consentFeeCurrency";

ConsentAndTenderElection consentAndTenderElectionInstance = new ConsentAndTenderElection(
    electionKey: electionKey,
    isDefault: isDefault,
    isChosen: isChosen,
    tenderOfferPrice: tenderOfferPrice,
    tenderOfferCurrency: tenderOfferCurrency,
    consentFeePrice: consentFeePrice,
    consentFeeCurrency: consentFeeCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
