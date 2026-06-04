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

```csharp
using Lusid.Sdk.Model;
using System;

string electionKey = "electionKey";
bool isDefault = //"True";
bool isChosen = //"True";
List<SecurityOfferConstituent> securitiesConstituents = new List<SecurityOfferConstituent>();
List<CashOfferConstituent> cashConstituents = new List<CashOfferConstituent>();

MixedLotConstituentsElection mixedLotConstituentsElectionInstance = new MixedLotConstituentsElection(
    electionKey: electionKey,
    isDefault: isDefault,
    isChosen: isChosen,
    securitiesConstituents: securitiesConstituents,
    cashConstituents: cashConstituents,
    costFactor: costFactor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
