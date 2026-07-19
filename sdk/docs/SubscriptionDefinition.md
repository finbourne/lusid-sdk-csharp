# Lusid.Sdk.Model.SubscriptionDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** |  | 
**Code** | **string** |  | 
**DisplayName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**TimelineId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AddressKeys** | **List&lt;string&gt;** | The set of addresses the subscriber wishes to receive. | [optional] 
**ByTaxLots** | **bool** |  | [optional] 
**StartEffectiveAt** | **DateTimeOffset?** |  | [optional] 
**EndEffectiveAt** | **DateTimeOffset?** |  | [optional] 
**StartAsAt** | **DateTimeOffset?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string displayName = "example displayName";
string description = "example description";
ResourceId portfolioId = new ResourceId();
ResourceId? timelineId = new ResourceId();

List<string> addressKeys = new List<string>();
bool byTaxLots = //"True";

SubscriptionDefinition subscriptionDefinitionInstance = new SubscriptionDefinition(
    scope: scope,
    code: code,
    displayName: displayName,
    description: description,
    portfolioId: portfolioId,
    timelineId: timelineId,
    addressKeys: addressKeys,
    byTaxLots: byTaxLots,
    startEffectiveAt: startEffectiveAt,
    endEffectiveAt: endEffectiveAt,
    startAsAt: startAsAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
