# Lusid.Sdk.Model.VendorDependency
For indicating a dependency on some opaque market data requested by an outside vendor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DependencyType** | **string** | The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency | 
**VendorName** | **string** | The name of the outside vendor | 
**VendorPath** | **List&lt;string&gt;** | The specific dependency path | 
**Date** | **DateTimeOffset** | The effectiveDate of the entity that this is a dependency for. | 

```csharp
using Lusid.Sdk.Model;
using System;

string vendorName = "vendorName";
List<string> vendorPath = new List<string>();

VendorDependency vendorDependencyInstance = new VendorDependency(
    vendorName: vendorName,
    vendorPath: vendorPath,
    date: date);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
