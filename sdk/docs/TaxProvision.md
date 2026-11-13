# Lusid.Sdk.Model.TaxProvision
The deferred tax provision struck for a fund at a valuation point: the realised and notionally realised  (deemed disposal) gains it is built from, the indexation and loss relief applied, the rate, the resulting  provision amount, its movement since the previous valuation point and, once approved, who approved it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Fund** | [**ResourceId**](ResourceId.md) |  | 
**NavTypeCode** | **string** | The NAV type the provision was struck for. | 
**DiaryEntryCode** | **string** | The diary entry code of the valuation point the provision was struck at. | 
**EffectiveAt** | **DateTimeOffset** | The effective date of the valuation point the provision was struck at. | 
**AsAt** | **DateTimeOffset** | The asAt datetime at which this version of the provision was recorded. | 
**Status** | **string** | Whether the provision is an Estimate or has been Approved. An approved provision has been posted to the fund as an accrual. | 
**RealisedGains** | **decimal** | The chargeable gains realised by disposals since the start of the tax period, after indexation allowance. | 
**UnrealisedGains** | **decimal** | The chargeable gains that would arise on a notional deemed disposal of the fund&#39;s holdings at the valuation point. | 
**IndexationAllowance** | **decimal** | The indexation allowance taken against the gains in this provision. | 
**LossesBroughtForward** | **decimal** | The allowable losses standing at the start of the tax period and available to offset gains. | 
**LossesUsed** | **decimal** | The losses brought forward that were used against the gains in this provision. | 
**LossesCarriedForward** | **decimal** | The allowable losses remaining after this provision, to be carried forward to the next tax period. Only realised losses are carried; a notional loss on the deemed disposal is not. | 
**RateApplied** | **decimal** | The tax rate applied to the net chargeable gains to arrive at the provision amount. | 
**ProvisionAmount** | **decimal** | The deferred tax provision amount at the valuation point. | 
**Movement** | [**TaxProvisionMovement**](TaxProvisionMovement.md) |  | 
**ApprovedBy** | **string** | The user who approved the provision, if it has been approved. | [optional] 
**ApprovedAt** | **DateTimeOffset?** | The asAt datetime at which the provision was approved, if it has been approved. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId fund = new ResourceId();
string navTypeCode = "navTypeCode";
string diaryEntryCode = "diaryEntryCode";
string status = "status";decimal realisedGains = "realisedGains";
decimal unrealisedGains = "unrealisedGains";
decimal indexationAllowance = "indexationAllowance";
decimal lossesBroughtForward = "lossesBroughtForward";
decimal lossesUsed = "lossesUsed";
decimal lossesCarriedForward = "lossesCarriedForward";
decimal rateApplied = "rateApplied";
decimal provisionAmount = "provisionAmount";

TaxProvisionMovement movement = new TaxProvisionMovement();
string approvedBy = "example approvedBy";
List<Link> links = new List<Link>();

TaxProvision taxProvisionInstance = new TaxProvision(
    href: href,
    fund: fund,
    navTypeCode: navTypeCode,
    diaryEntryCode: diaryEntryCode,
    effectiveAt: effectiveAt,
    asAt: asAt,
    status: status,
    realisedGains: realisedGains,
    unrealisedGains: unrealisedGains,
    indexationAllowance: indexationAllowance,
    lossesBroughtForward: lossesBroughtForward,
    lossesUsed: lossesUsed,
    lossesCarriedForward: lossesCarriedForward,
    rateApplied: rateApplied,
    provisionAmount: provisionAmount,
    movement: movement,
    approvedBy: approvedBy,
    approvedAt: approvedAt,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
