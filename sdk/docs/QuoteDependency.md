# Lusid.Sdk.Model.QuoteDependency
For indicating a dependency on the value of an asset at a point in time.  If the time is omitted, then the dependency is interpreted as the latest value with respect to anything observing it.  E.g. An EquitySwap will declare a dependency on the current price of the underlying equity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DependencyType** | **string** | Available values: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency. | 
**MarketIdentifier** | **string** | Type of the code identifying the asset, e.g. ISIN or CUSIP | 
**Code** | **string** | The code identifying the corresponding equity, e.g. US0378331005 if the MarketIdentifier was set to ISIN | 
**Date** | **DateTimeOffset** | The effectiveAt of the quote for the identified entity. | 
**Descriptor** | **List&lt;string&gt;** | Optional additional description of the quote being depended upon, e.g. the model or lineage that produced it.  When matching a dependency against supplied market data overrides, the descriptor must match as well as the identifier and code.  If omitted, the dependency has no descriptor. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string marketIdentifier = "marketIdentifier";
string code = "code";
List<string> descriptor = new List<string>();

QuoteDependency quoteDependencyInstance = new QuoteDependency(
    marketIdentifier: marketIdentifier,
    code: code,
    date: date,
    descriptor: descriptor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
