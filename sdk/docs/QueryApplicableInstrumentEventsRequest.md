# Lusid.Sdk.Model.QueryApplicableInstrumentEventsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WindowStart** | **DateTimeOffset** | The start date of the window. | 
**WindowEnd** | **DateTimeOffset** | The end date of the window. | 
**EffectiveAt** | **DateTimeOffset?** | The Effective date that splits query window into two parts: factual period and forecast period. Optional - a timeline (with an optional closed period) may be supplied instead to derive the effective date. | [optional] 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolios and portfolio groups to which the instrument events must belong. | 
**ForecastingRecipeId** | [**ResourceId**](ResourceId.md) |  | 
**TimelineScope** | **string** | The scope of the timeline to be used when building the instrument events. | [optional] 
**TimelineCode** | **string** | The code of the timeline to be used when building the instrument events. This can optionally include a colon, followed by the Closed Period Id to use at the head of the timeline, for a timeline with unconfirmed periods. | [optional] 
**ClosedPeriodId** | **string** | The id of the closed period, on the given timeline, to be used when building the instrument events. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<PortfolioEntityId> portfolioEntityIds = new List<PortfolioEntityId>();
ResourceId forecastingRecipeId = new ResourceId();
string timelineScope = "example timelineScope";
string timelineCode = "example timelineCode";
string closedPeriodId = "example closedPeriodId";

QueryApplicableInstrumentEventsRequest queryApplicableInstrumentEventsRequestInstance = new QueryApplicableInstrumentEventsRequest(
    windowStart: windowStart,
    windowEnd: windowEnd,
    effectiveAt: effectiveAt,
    portfolioEntityIds: portfolioEntityIds,
    forecastingRecipeId: forecastingRecipeId,
    timelineScope: timelineScope,
    timelineCode: timelineCode,
    closedPeriodId: closedPeriodId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
