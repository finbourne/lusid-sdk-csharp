# Lusid.Sdk.Model.EquityVolDependency
Economic dependency required to price Equity derivative products that contain optionality.  Equity Vol surface is a grid of implied volatilities for an array of strikes and tenors,  derived from vanilla option prices in the market.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DependencyType** | **string** | The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency | 
**Code** | **string** | The code identifying the corresponding equity, e.g. US0378331005 if the MarketIdentifier was set to ISIN | 
**DomesticCurrency** | **string** | The domestic currency of the instrument declaring this dependency. | 
**VolType** | **string** | Volatility type e.g. \&quot;LN\&quot; and \&quot;N\&quot; for log-normal and normal volatility. | 
**Date** | **DateTimeOffset** | The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

