# Lusid.Sdk.Model.EligibleCollateralScheduleRequest
The request used to create an Eligible Collateral Schedule.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Eligible Collateral Schedule. | 
**Description** | **string** | A description of the Eligible Collateral Schedule. Optional. | [optional] 
**Rows** | [**List&lt;EligibleCollateralRowRequest&gt;**](EligibleCollateralRowRequest.md) | The classes of collateral that may be posted, each with the valuation percentage it is accepted at. At least one and at most 200 rows. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties to decorate onto the Eligible Collateral Schedule. Filterable. | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The effective datetime from which the Eligible Collateral Schedule applies. Defaults to the beginning of time if not specified, so that the schedule is visible at every effective datetime. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string description = "example description";
List<EligibleCollateralRowRequest> rows = new List<EligibleCollateralRowRequest>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();

EligibleCollateralScheduleRequest eligibleCollateralScheduleRequestInstance = new EligibleCollateralScheduleRequest(
    code: code,
    description: description,
    rows: rows,
    properties: properties,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
