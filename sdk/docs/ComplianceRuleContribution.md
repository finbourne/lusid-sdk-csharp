# Lusid.Sdk.Model.ComplianceRuleContribution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**OrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Instrument** | **string** | The LUSID instrument identifier (LUID) of the instrument for this contribution. | 
**InstrumentType** | **string** | Optional. The economic type of the instrument for this contribution. | [optional] 
**HoldingType** | **string** | Optional. The holding type of this contribution. | [optional] 
**HoldingId** | **string** | Optional. The internal holding identifier encoding the detail of what the holding includes. | [optional] 
**HeldBy** | **string** | Optional. Where this holding sits relative to the rule&#39;s benchmark: portfolio, benchmark or both.  Meaningful only for benchmark-relative rules. | [optional] 
**KeysUsed** | [**List&lt;ComplianceKeyUsed&gt;**](ComplianceKeyUsed.md) | The keys this holding contributed to the rule: each key the rule read (plus the portfolio NAV key), with the  role(s) it played, the holding&#39;s own value for it, and which bag the value came from. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
ResourceId? orderId = new ResourceId();

string instrument = "instrument";
string instrumentType = "example instrumentType";
string holdingType = "example holdingType";
string holdingId = "example holdingId";
string heldBy = "example heldBy";
List<ComplianceKeyUsed> keysUsed = new List<ComplianceKeyUsed>();

ComplianceRuleContribution complianceRuleContributionInstance = new ComplianceRuleContribution(
    portfolioId: portfolioId,
    orderId: orderId,
    instrument: instrument,
    instrumentType: instrumentType,
    holdingType: holdingType,
    holdingId: holdingId,
    heldBy: heldBy,
    keysUsed: keysUsed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
