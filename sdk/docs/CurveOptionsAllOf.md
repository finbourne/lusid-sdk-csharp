# Lusid.Sdk.Model.CurveOptionsAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DayCountConvention** | **string** | Day count convention of the curve. Defaults to \&quot;Act360\&quot;. | [optional] 
**FrontExtrapolationType** | **string** | What type of extrapolation is used to build the curve  Imagine that the curve is facing the observer(you), then the \&quot;front\&quot; direction is the closest point on the curve onward. &lt;br /&gt;  example: 0D tenor to past  Defaults to \&quot;Flat\&quot;. Supported string (enumeration) values are: [None, Flat, Linear]. | [optional] 
**BackExtrapolationType** | **string** | What type of extrapolation is used to build the curve.  &lt;br /&gt;  Imagine that the curve is facing the observer(you), then the \&quot;back\&quot; direction is the furthest point on the curve onward. &lt;br /&gt;  example: 30Y tenor to infinity  Defaults to \&quot;Flat\&quot;. Supported string (enumeration) values are: [None, Flat, Linear]. | [optional] 
**MarketDataOptionsType** | **string** | The available values are: CurveOptions | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

