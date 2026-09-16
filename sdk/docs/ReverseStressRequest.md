# Lusid.Sdk.Model.ReverseStressRequest
Request to solve a reverse stress test: instead of asking what a given market move does to a  portfolio, it asks how far the market has to move along a given direction to produce a given  loss. The direction is a stored scenario; the answer is the factor its shifts are multiplied by.                A single effective date is solved, not a schedule. \"How far must the market move to lose this  much\" has one answer per date, and returning a factor per date under one target would invite the  answer being read as a single portfolio-wide number when it is not.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The portfolios or portfolio groups whose value the target loss is measured against. | 
**EffectiveAt** | **DateTimeOffset** | The effective date to value at. | 
**AsAt** | **DateTimeOffset?** | The as-at time to read portfolios, instruments, market data and the scenario definition at.  Defaults to the latest. | [optional] 
**Scenario** | [**ScenarioReference**](ScenarioReference.md) |  | 
**TargetPnl** | **decimal** | The change in value to solve for, signed and in the report currency: negative for a loss.  Expressed as an amount rather than a percentage so that the same target can be stated against  a portfolio whose base value is not known to the caller. | 
**Metric** | **string** | The measure the target is expressed in. Defaults to Valuation/PV. Must be a measure that  supports scenario decoration, which the request is rejected for if it is not. | [optional] 
**ReportCurrency** | **string** | Three letter ISO currency string to report in. If absent the portfolio&#39;s own currency is used,  which makes the target ambiguous across a multi-currency portfolio group - supply it there. | [optional] 
**Filters** | [**List&lt;PropertyFilter&gt;**](PropertyFilter.md) | Filters reducing the holdings the target is measured over, matching the valuation endpoint&#39;s. | [optional] 
**MaxScale** | **decimal** | The largest factor to evaluate. A target beyond the loss reached at this factor is reported as  out of reach rather than extrapolated to: extrapolating past the evaluated range is exactly  where a locally linear P&amp;L stops being linear. | [optional] 
**LadderPoints** | **int** | How many factors to evaluate between zero and MaxScale. All of them are valued in  one request - the rungs share market data resolution - so a finer ladder costs far less than  its rung count suggests, and a coarse one is the main source of a missed bracket. | [optional] 
**Tolerance** | **decimal** | How close the achieved loss must be to the target, relative to the target&#39;s own size. Relative  rather than absolute because the same reverse stress is asked of books whose value differs by  orders of magnitude. | [optional] 
**MaxIterations** | **int** | How many refinement rounds are allowed after the opening ladder. Each round costs one  valuation; on a near-linear P&amp;L the first interpolation is usually already inside tolerance,  so the default exists for the mildly curved case rather than the normal one. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId recipeId = new ResourceId();
List<PortfolioEntityId> portfolioEntityIds = new List<PortfolioEntityId>();
ScenarioReference scenario = new ScenarioReference();decimal targetPnl = "targetPnl";

string metric = "example metric";
string reportCurrency = "example reportCurrency";
List<PropertyFilter> filters = new List<PropertyFilter>();decimal? maxScale = "example maxScale";decimal? tolerance = "example tolerance";

ReverseStressRequest reverseStressRequestInstance = new ReverseStressRequest(
    recipeId: recipeId,
    portfolioEntityIds: portfolioEntityIds,
    effectiveAt: effectiveAt,
    asAt: asAt,
    scenario: scenario,
    targetPnl: targetPnl,
    metric: metric,
    reportCurrency: reportCurrency,
    filters: filters,
    maxScale: maxScale,
    ladderPoints: ladderPoints,
    tolerance: tolerance,
    maxIterations: maxIterations);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
