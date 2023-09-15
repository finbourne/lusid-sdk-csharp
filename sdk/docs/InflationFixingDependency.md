# Lusid.Sdk.Model.InflationFixingDependency
For indicating a dependency upon an inflation fixing

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DependencyType** | **string** | The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency | 
**Type** | **string** | The Type of fixing (index, ratio or assumption) | 
**Code** | **string** | The Code of the fixing, typically the index name | 
**Date** | **DateTimeOffset** | The effectiveAt of the inflation fixing | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

