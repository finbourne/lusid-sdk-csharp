# Lusid.Sdk.Model.UnitisationData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharesInIssue** | **decimal** | The number of shares in issue at a valuation point. | 
**UnitPrice** | **decimal** | The price of one unit of the share class at a valuation point. | 
**NetDealingUnits** | **decimal** | The net dealing in units for the share class at a valuation point. This could be the sum of negative redemptions (in units) and positive subscriptions (in units). | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal sharesInIssue = "sharesInIssue";
decimal unitPrice = "unitPrice";
decimal netDealingUnits = "netDealingUnits";


UnitisationData unitisationDataInstance = new UnitisationData(
    sharesInIssue: sharesInIssue,
    unitPrice: unitPrice,
    netDealingUnits: netDealingUnits);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
