# Lusid.Sdk.Model.IrVolDependency
Economic dependency required to price interest rate products that contain optionality, for example swaptions.  For example, can indicate a dependency on an IrVolCubeData.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DependencyType** | **string** | The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency | 
**Currency** | **string** | The domestic currency of the instrument declaring this dependency. | 
**VolType** | **string** | Volatility type e.g. \&quot;LN\&quot; and \&quot;N\&quot; for log-normal and normal volatility. | 
**Date** | **DateTimeOffset** | The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date. | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

