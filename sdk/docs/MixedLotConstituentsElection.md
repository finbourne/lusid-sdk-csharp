# Lusid.Sdk.Model.MixedLotConstituentsElection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** |  | 
**IsDefault** | **bool** |  | [optional] 
**IsChosen** | **bool** |  | [optional] 
**SecuritiesConstituents** | [**List&lt;SecurityOfferConstituent&gt;**](SecurityOfferConstituent.md) |  | [optional] 
**CashConstituents** | [**List&lt;CashOfferConstituent&gt;**](CashOfferConstituent.md) |  | [optional] 
**CostFactor** | **decimal?** |  | [optional] 
**ConsentFeePrice** | **decimal?** | Optional. The consent fee paid to holders who consent, on top of the exchange consideration. Quoted per 1,000 of face for bonds, using the current notional at the effective date of the event, and per unit for other instruments. Must be greater than 0. Required together with ConsentFeeCurrency, and only supported on an ExchangeOfferEvent. | [optional] 
**ConsentFeeCurrency** | **string** | Optional. Currency of the consent fee. Required if a consent fee price is provided, and only supported on an ExchangeOfferEvent. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string electionKey = "electionKey";
bool isDefault = //"True";
bool isChosen = //"True";
List<SecurityOfferConstituent> securitiesConstituents = new List<SecurityOfferConstituent>();
List<CashOfferConstituent> cashConstituents = new List<CashOfferConstituent>();
string consentFeeCurrency = "example consentFeeCurrency";

MixedLotConstituentsElection mixedLotConstituentsElectionInstance = new MixedLotConstituentsElection(
    electionKey: electionKey,
    isDefault: isDefault,
    isChosen: isChosen,
    securitiesConstituents: securitiesConstituents,
    cashConstituents: cashConstituents,
    costFactor: costFactor,
    consentFeePrice: consentFeePrice,
    consentFeeCurrency: consentFeeCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
