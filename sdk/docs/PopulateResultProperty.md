# Lusid.Sdk.Model.PopulateResultProperty

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyKey** | **string** | The property the formula populates. Must be an existing, single-valued property in the RecResult domain, and may appear only once. | 
**Formula** | **string** | The formula gives the value of the property. The value must be of the property&#39;s type. A formula cannot populate an Int property, because its numbers are decimal. A null value means that the property has no value. The formula can read resultType, resultCardinality, resultLifecycle, exception.status, exception.closureType, exception.asAtClosed, exception.asAtClosureInvalidated, review.status, review.decision and review.decisionGroup.groupNumber. It reads rules by name as CoreRules[name] and AggregateRules[name]. Each rule has .leftValue, .rightValue and .appliedTolerance.toleranceType. A numeric aggregate rule also has .difference. You can compare CoreRules[name] with no side by eq, in or startswith. The comparison is true if either side matches. With neq, not in or not startswith, it is true if no side matches. Ordering comparisons must name the side. Comparisons ignore case and accents. | 
**OverwriteManualEditsOnReRun** | **bool?** | Whether a run replaces a value that a user has set or removed on the property. After a run replaces it, later runs populate it again, even if this flag is then false. Defaults to false. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string propertyKey = "propertyKey";
string formula = "formula";
bool? overwriteManualEditsOnReRun = //"True";

PopulateResultProperty populateResultPropertyInstance = new PopulateResultProperty(
    propertyKey: propertyKey,
    formula: formula,
    overwriteManualEditsOnReRun: overwriteManualEditsOnReRun);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
