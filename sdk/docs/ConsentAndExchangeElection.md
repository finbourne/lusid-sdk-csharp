# Lusid.Sdk.Model.ConsentAndExchangeElection
Election to both grant consent and exchange the holding (CEXC), at a given units ratio.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** | Unique key associated to this election. | 
**IsDefault** | **bool** | Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided. | [optional] 
**IsChosen** | **bool** | Is this the election that has been explicitly chosen from multiple options. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string electionKey = "electionKey";
bool isDefault = //"True";
bool isChosen = //"True";
UnitsRatio unitsRatio = new UnitsRatio();

ConsentAndExchangeElection consentAndExchangeElectionInstance = new ConsentAndExchangeElection(
    electionKey: electionKey,
    isDefault: isDefault,
    isChosen: isChosen,
    unitsRatio: unitsRatio);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
