# Lusid.Sdk.Model.DecimalComplianceParameter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComplianceParameterType** | **string** | The parameter type. Available values: BoolComplianceParameter, StringComplianceParameter, DecimalComplianceParameter, DateTimeComplianceParameter, PropertyKeyComplianceParameter, AddressKeyComplianceParameter, PortfolioIdComplianceParameter, PortfolioGroupIdComplianceParameter, StringListComplianceParameter, BoolListComplianceParameter, DateTimeListComplianceParameter, DecimalListComplianceParameter, PropertyKeyListComplianceParameter, AddressKeyListComplianceParameter, PortfolioIdListComplianceParameter, PortfolioGroupIdListComplianceParameter, InstrumentListComplianceParameter, FilterPredicateComplianceParameter, GroupFilterPredicateComplianceParameter, GroupBySelectorComplianceParameter, PropertyListComplianceParameter, GroupCalculationComplianceParameter. | 
**Value** | **decimal** |  | 
**InclusiveBounds** | **bool** | Whether the bound is inclusive of the value; when true a candidate landing exactly on the bound satisfies it. Defaults to false (exclusive). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal value = "value";

bool inclusiveBounds = //"True";

DecimalComplianceParameter decimalComplianceParameterInstance = new DecimalComplianceParameter(
    value: value,
    inclusiveBounds: inclusiveBounds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
