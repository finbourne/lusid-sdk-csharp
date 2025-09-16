# Lusid.Sdk.Model.QueryInstrumentEventsRequest
Instrument event query.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The time of the system at which to query for bucketed cashflows. | [optional] 
**WindowStart** | **DateTimeOffset** | The start date of the window. | 
**WindowEnd** | **DateTimeOffset** | The end date of the window. | 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolios and portfolio groups to which the instrument events must belong. | 
**EffectiveAt** | **DateTimeOffset** | The Effective date used in the valuation of the cashflows. | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**FilterInstrumentEvents** | **string** | Expression to filter the result set. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<PortfolioEntityId> portfolioEntityIds = new List<PortfolioEntityId>();
ResourceId recipeId = new ResourceId();
string filterInstrumentEvents = "example filterInstrumentEvents";

QueryInstrumentEventsRequest queryInstrumentEventsRequestInstance = new QueryInstrumentEventsRequest(
    asAt: asAt,
    windowStart: windowStart,
    windowEnd: windowEnd,
    portfolioEntityIds: portfolioEntityIds,
    effectiveAt: effectiveAt,
    recipeId: recipeId,
    filterInstrumentEvents: filterInstrumentEvents);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
