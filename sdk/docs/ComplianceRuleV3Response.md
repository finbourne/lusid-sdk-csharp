# Lusid.Sdk.Model.ComplianceRuleV3Response
A V3 compliance rule as returned by the API: its identity and administrative fields, its full  definition, and its version.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Active** | **bool** |  | [optional] 
**Subject** | **string** | Available values: Holdings, Orders. | [optional] 
**Filter** | [**ComplianceRuleV3FilterNode**](ComplianceRuleV3FilterNode.md) |  | [optional] 
**GroupBy** | **List&lt;string&gt;** |  | [optional] 
**Measure** | [**ComplianceRuleV3Measure**](ComplianceRuleV3Measure.md) |  | [optional] 
**Check** | [**ComplianceRuleV3Check**](ComplianceRuleV3Check.md) |  | [optional] 
**ComputedFilter** | [**ComplianceRuleV3ComputedFilter**](ComplianceRuleV3ComputedFilter.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? id = new ResourceId();

string name = "example name";
string description = "example description";
bool active = //"True";
string subject = "example subject";
ComplianceRuleV3FilterNode? filter = new ComplianceRuleV3FilterNode();

List<string> groupBy = new List<string>();
ComplianceRuleV3Measure? measure = new ComplianceRuleV3Measure();

ComplianceRuleV3Check? check = new ComplianceRuleV3Check();

ComplianceRuleV3ComputedFilter? computedFilter = new ComplianceRuleV3ComputedFilter();

ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

ComplianceRuleV3Response complianceRuleV3ResponseInstance = new ComplianceRuleV3Response(
    id: id,
    name: name,
    description: description,
    active: active,
    subject: subject,
    filter: filter,
    groupBy: groupBy,
    measure: measure,
    check: check,
    computedFilter: computedFilter,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
