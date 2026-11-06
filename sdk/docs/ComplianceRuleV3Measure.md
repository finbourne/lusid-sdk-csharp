# Lusid.Sdk.Model.ComplianceRuleV3Measure
How a rule reduces its filtered (and optionally grouped) subject rows to the single number a check is  applied to: a metric field, the aggregate combining its values, and what it is expressed relative to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metric** | **string** |  | [optional] 
**Aggregate** | **string** | Available values: Sum, Min, Max, Average, Count, CountDistinct, WeightedSum, SumAbsolute. | 
**Denominator** | **string** | Available values: None, PortfolioValue, GrossValue, NetValue, FilteredSubsetTotal, GroupNav, GroupGrossExposure, GroupFilteredSubsetTotal. | [optional] 
**DenominatorMetric** | **string** |  | [optional] 
**WeightMetric** | **string** |  | [optional] 
**DenominatorProperty** | **string** |  | [optional] 
**Filter** | [**ComplianceRuleV3FilterNode**](ComplianceRuleV3FilterNode.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string metric = "example metric";
string aggregate = "aggregate";
string denominator = "example denominator";
string denominatorMetric = "example denominatorMetric";
string weightMetric = "example weightMetric";
string denominatorProperty = "example denominatorProperty";
ComplianceRuleV3FilterNode? filter = new ComplianceRuleV3FilterNode();


ComplianceRuleV3Measure complianceRuleV3MeasureInstance = new ComplianceRuleV3Measure(
    metric: metric,
    aggregate: aggregate,
    denominator: denominator,
    denominatorMetric: denominatorMetric,
    weightMetric: weightMetric,
    denominatorProperty: denominatorProperty,
    filter: filter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
