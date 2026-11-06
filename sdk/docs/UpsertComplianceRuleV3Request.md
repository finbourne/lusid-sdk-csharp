# Lusid.Sdk.Model.UpsertComplianceRuleV3Request
A request to create or update a V3 compliance rule. A V3 rule's own record fully describes what it  checks: the subject it runs over, the filter selecting rows, the grouping and measure reducing them to a  number, and the check that number must satisfy. Shares no type with ComplianceV1/V2.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Active** | **bool** |  | 
**Subject** | **string** | Available values: Holdings, Orders. | 
**Filter** | [**ComplianceRuleV3FilterNode**](ComplianceRuleV3FilterNode.md) |  | [optional] 
**GroupBy** | **List&lt;string&gt;** |  | [optional] 
**Measure** | [**ComplianceRuleV3Measure**](ComplianceRuleV3Measure.md) |  | 
**Check** | [**ComplianceRuleV3Check**](ComplianceRuleV3Check.md) |  | 
**ComputedFilter** | [**ComplianceRuleV3ComputedFilter**](ComplianceRuleV3ComputedFilter.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string name = "example name";
string description = "example description";
bool active = //"True";
string subject = "subject";
ComplianceRuleV3FilterNode? filter = new ComplianceRuleV3FilterNode();

List<string> groupBy = new List<string>();
ComplianceRuleV3Measure measure = new ComplianceRuleV3Measure();
ComplianceRuleV3Check check = new ComplianceRuleV3Check();
ComplianceRuleV3ComputedFilter? computedFilter = new ComplianceRuleV3ComputedFilter();


UpsertComplianceRuleV3Request upsertComplianceRuleV3RequestInstance = new UpsertComplianceRuleV3Request(
    id: id,
    name: name,
    description: description,
    active: active,
    subject: subject,
    filter: filter,
    groupBy: groupBy,
    measure: measure,
    check: check,
    computedFilter: computedFilter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
