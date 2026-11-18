# Lusid.Sdk.Model.CashAndSecurityOfferElection
Election for events that result in both cash and equity via a merger or acquisition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CashOfferCurrency** | **string** | Currency of the cash offer | 
**CashOfferPrice** | **decimal** | Price per share of the cash offer | 
**CostFactor** | **decimal?** | Optional. The fraction of cost that is transferred from the existing shares to the new shares. | [optional] 
**ElectionKey** | **string** | Unique key associated to this election. | 
**IsChosen** | **bool** | Is this the election that has been explicitly chosen from multiple options. | [optional] 
**IsDefault** | **bool** | Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**ConsentFeePrice** | **decimal?** | Optional. The consent fee paid to holders who consent, on top of the exchange consideration. Quoted per 1,000 of face for bonds, using the current notional at the effective date of the event, and per unit for other instruments. Must be greater than 0. Required together with ConsentFeeCurrency, and only supported on an ExchangeOfferEvent. | [optional] 
**ConsentFeeCurrency** | **string** | Optional. Currency of the consent fee. Required if a consent fee price is provided, and only supported on an ExchangeOfferEvent. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string cashOfferCurrency = "cashOfferCurrency";decimal cashOfferPrice = "cashOfferPrice";

string electionKey = "electionKey";
bool isChosen = //"True";
bool isDefault = //"True";
UnitsRatio unitsRatio = new UnitsRatio();
string consentFeeCurrency = "example consentFeeCurrency";

CashAndSecurityOfferElection cashAndSecurityOfferElectionInstance = new CashAndSecurityOfferElection(
    cashOfferCurrency: cashOfferCurrency,
    cashOfferPrice: cashOfferPrice,
    costFactor: costFactor,
    electionKey: electionKey,
    isChosen: isChosen,
    isDefault: isDefault,
    unitsRatio: unitsRatio,
    consentFeePrice: consentFeePrice,
    consentFeeCurrency: consentFeeCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
