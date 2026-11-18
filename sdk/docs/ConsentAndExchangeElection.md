# Lusid.Sdk.Model.ConsentAndExchangeElection
Election to both grant consent and exchange the holding (CEXC), at a given units ratio.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** | Unique key associated to this election. | 
**IsDefault** | **bool** | Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided. | [optional] 
**IsChosen** | **bool** | Is this the election that has been explicitly chosen from multiple options. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**ConsentFeePrice** | **decimal?** | Optional. The consent fee paid to holders who consent, on top of the exchange consideration. Quoted per 1,000 of face for bonds, using the current notional at the effective date of the event, and per unit for other instruments. Must be greater than 0. Required together with ConsentFeeCurrency, and only supported on an ExchangeOfferEvent. | [optional] 
**ConsentFeeCurrency** | **string** | Optional. Currency of the consent fee. Required if a consent fee price is provided, and only supported on an ExchangeOfferEvent. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string electionKey = "electionKey";
bool isDefault = //"True";
bool isChosen = //"True";
UnitsRatio unitsRatio = new UnitsRatio();
string consentFeeCurrency = "example consentFeeCurrency";

ConsentAndExchangeElection consentAndExchangeElectionInstance = new ConsentAndExchangeElection(
    electionKey: electionKey,
    isDefault: isDefault,
    isChosen: isChosen,
    unitsRatio: unitsRatio,
    consentFeePrice: consentFeePrice,
    consentFeeCurrency: consentFeeCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
