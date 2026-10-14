# Lusid.Sdk.Model.UpsertEligibleCollateralScheduleRequest
The request used to create or replace the definition of an Eligible Collateral Schedule from an effective date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A description of the Eligible Collateral Schedule. Optional. | [optional] 
**Rows** | [**List&lt;EligibleCollateralRowRequest&gt;**](EligibleCollateralRowRequest.md) | The classes of collateral that may be posted, each with the valuation percentage it is accepted at. At least one and at most 200 rows. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties to decorate onto the Eligible Collateral Schedule. Filterable. | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The effective datetime or cut label from which the change applies. Defaults to the current LUSID system datetime if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string description = "example description";
List<EligibleCollateralRowRequest> rows = new List<EligibleCollateralRowRequest>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();

UpsertEligibleCollateralScheduleRequest upsertEligibleCollateralScheduleRequestInstance = new UpsertEligibleCollateralScheduleRequest(
    description: description,
    rows: rows,
    properties: properties,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
