# Lusid.Sdk.Model.SecurityOfferElection
Election for events that result in cash via a merger or acquisition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** | Unique key associated to this election. | 
**IsChosen** | **bool** | Is this the election that has been explicitly chosen from multiple options. | [optional] 
**IsDefault** | **bool** | Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**PaymentDate** | **DateTimeOffset?** | Optional. The date this option pays. On MergerEvent, RepurchaseOfferEvent, BonusIssueEvent and  ExchangeOfferEvent it sets the settlement date of this option&#39;s transactions; when omitted, the  event-level date applies. Not supported on other events. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string electionKey = "electionKey";
bool isChosen = //"True";
bool isDefault = //"True";
UnitsRatio unitsRatio = new UnitsRatio();

SecurityOfferElection securityOfferElectionInstance = new SecurityOfferElection(
    electionKey: electionKey,
    isChosen: isChosen,
    isDefault: isDefault,
    unitsRatio: unitsRatio,
    paymentDate: paymentDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
