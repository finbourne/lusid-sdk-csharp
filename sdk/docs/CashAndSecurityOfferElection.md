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

```csharp
using Lusid.Sdk.Model;
using System;

string cashOfferCurrency = "cashOfferCurrency";decimal cashOfferPrice = "cashOfferPrice";

string electionKey = "electionKey";
bool isChosen = //"True";
bool isDefault = //"True";
UnitsRatio unitsRatio = new UnitsRatio();

CashAndSecurityOfferElection cashAndSecurityOfferElectionInstance = new CashAndSecurityOfferElection(
    cashOfferCurrency: cashOfferCurrency,
    cashOfferPrice: cashOfferPrice,
    costFactor: costFactor,
    electionKey: electionKey,
    isChosen: isChosen,
    isDefault: isDefault,
    unitsRatio: unitsRatio);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
