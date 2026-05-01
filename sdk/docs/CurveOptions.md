# Lusid.Sdk.Model.CurveOptions
Options for configuring how ComplexMarketData representing a 'curve' is interpreted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataOptionsType** | **string** | Available values: CurveOptions. Available values: CurveOptions. | 
**DayCountConvention** | **string** | Day count convention of the curve. Default value: Act360. Available values: Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM, Invalid. | [optional] 
**FrontExtrapolationType** | **string** | What type of extrapolation is used to build the curve  Imagine that the curve is facing the observer(you), then the \&quot;front\&quot; direction is the closest point on the curve onward.    example: 0D tenor to past  Default value: Flat. Available values: None, Flat, Linear. | [optional] 
**BackExtrapolationType** | **string** | What type of extrapolation is used to build the curve.    Imagine that the curve is facing the observer(you), then the \&quot;back\&quot; direction is the furthest point on the curve onward.  example: 30Y tenor to infinity    Default value: Flat. Available values: None, Flat, Linear. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string dayCountConvention = "example dayCountConvention";
string frontExtrapolationType = "example frontExtrapolationType";
string backExtrapolationType = "example backExtrapolationType";

CurveOptions curveOptionsInstance = new CurveOptions(
    dayCountConvention: dayCountConvention,
    frontExtrapolationType: frontExtrapolationType,
    backExtrapolationType: backExtrapolationType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
