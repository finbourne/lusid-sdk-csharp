# Lusid.Sdk.Model.IndexProjectionDependencyAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | The currency of the corresponding IndexConvention. E.g. this would be USD for a convention named USD.6M.LIBOR | 
**Tenor** | **string** | The tenor of the corresponding IndexConvention. E.g. this would be \&quot;6M\&quot; for a convention named USD.6M.LIBOR | 
**IndexName** | **string** | The IndexName of the corresponding IndexConvention. E.g. this would be \&quot;LIBOR\&quot; for a convention named USD.6M.LIBOR | 
**Date** | **DateTimeOffset** | The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date. | 
**DependencyType** | **string** | The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

