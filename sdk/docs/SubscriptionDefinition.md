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
**TimelineProperty** | **string** | A portfolio property key (Portfolio/scope/code) naming a perpetual portfolio property whose value  (scope/code) identifies the timeline for each portfolio. Mutually exclusive with timelineId.  The property must be defined, with a data type of value type ResourceId or String. | [optional] 
**PortfolioFilter** | **string** | A filter, in the syntax of the list portfolios filter, that narrows a wildcard portfolioId to the portfolios  of the scope that match it. Only valid when portfolioId.code is \&quot;*\&quot;. It may use the portfolio&#39;s own fields and  its perpetual Portfolio properties; time-variant and derived properties and relationships are not supported.  A portfolio that starts or stops matching joins or leaves the subscription. | [optional] 
**AddressKeys** | **List&lt;string&gt;** | The set of addresses the subscriber wishes to receive. | [optional] 
**ByTaxLots** | **bool** |  | [optional] 
**SubscriptionType** | **string** | Required. The kind of data the subscription streams: before/after effects per  holding (holdings), the transactions themselves (transactions), or each changed holding&#39;s  complete current state (positions). Address keys and byTaxLots are not valid for a  transactions subscription. Available values: Holdings, Transactions, Positions. | 
**StartEffectiveAt** | **DateTimeOffset?** |  | [optional] 
**EndEffectiveAt** | **DateTimeOffset?** | Deprecated and no longer honoured: a fixed forward date stops being a forward view once  the live edge passes it. Use effectiveForwardDays instead. Still accepted and echoed back  so existing subscriptions keep round-tripping. | [optional] 
**EffectiveForwardDays** | **int?** | How far forward the subscription reports, as a number of calendar days past the live  edge — a rolling forward view that advances as time passes. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string displayName = "example displayName";
string description = "example description";
ResourceId portfolioId = new ResourceId();
ResourceId? timelineId = new ResourceId();

string timelineProperty = "example timelineProperty";
string portfolioFilter = "example portfolioFilter";
List<string> addressKeys = new List<string>();
bool byTaxLots = //"True";
string subscriptionType = "subscriptionType";

SubscriptionDefinition subscriptionDefinitionInstance = new SubscriptionDefinition(
    scope: scope,
    code: code,
    displayName: displayName,
    description: description,
    portfolioId: portfolioId,
    timelineId: timelineId,
    timelineProperty: timelineProperty,
    portfolioFilter: portfolioFilter,
    addressKeys: addressKeys,
    byTaxLots: byTaxLots,
    subscriptionType: subscriptionType,
    startEffectiveAt: startEffectiveAt,
    endEffectiveAt: endEffectiveAt,
    effectiveForwardDays: effectiveForwardDays);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
