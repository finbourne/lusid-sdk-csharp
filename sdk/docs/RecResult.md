# Lusid.Sdk.Model.RecResult
An individual reconciliation result — the aggregate result for a set of core rule values within a  rec type, with its type/status, review and exception axes, rule values and item-level detail.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The system-generated identifier for the rec result. Comprises the rec definition id, the instance id, the rec type and the core rule values. | 
**RecType** | **string** | The type of rec that the result belongs to (e.g. Holding). Available values: Holding, CashHolding, Valuation, InputTransaction, OutputTransaction, SettlementActivity. | 
**InstanceId** | [**RecInstanceId**](RecInstanceId.md) |  | 
**RecDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**RunNumber** | **int** | The run number within the instance. Increments with each re-run. | 
**RunAsAt** | **DateTimeOffset** | The asAt datetime at which the run happened. | 
**DatesReconciled** | [**RecDatesReconciled**](RecDatesReconciled.md) |  | 
**ResultType** | **string** | The type of result. Exceptions: PartialMatch, PartialCross, Break. Non-exceptions: Match, Cross. Available values: Match, Cross, PartialMatch, PartialCross, Break. | 
**ResultCardinality** | **string** | The item cardinality of the result, read left to right (e.g. OneToOne, ManyToNone). Available values: OneToOne, OneToMany, ManyToOne, ManyToMany, OneToNone, ManyToNone, NoneToOne, NoneToMany, NoneToNone. | 
**ResultLifeCycle** | **string** | The run-over-run change in the result, evaluated each run against the prior run. Available values: New, Unchanged, Changed, Cleared. | 
**Exception** | [**RecResultException**](RecResultException.md) |  | [optional] 
**Review** | [**RecResultReview**](RecResultReview.md) |  | 
**CoreRules** | [**List&lt;CoreRuleValues&gt;**](CoreRuleValues.md) | The core matching rules and the values that pin this result to its reconciled position. | 
**AggregateRules** | [**List&lt;AggregateRuleValues&gt;**](AggregateRuleValues.md) | The aggregate matching rules and their measured values. | 
**SupplementalAttributes** | [**List&lt;SupplementalAttributeValues&gt;**](SupplementalAttributeValues.md) | Additional attribute values carried on the result for context. Do not contribute to matching or the result id. | 
**Items** | [**RecResultItemDetails**](RecResultItemDetails.md) |  | 
**Comments** | [**List&lt;RecUserComment&gt;**](RecUserComment.md) | User-authored comments attached to the result. Carried forward across runs. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Properties in the RecResult domain. Filterable and sortable. | [optional] 
**AssignedUser** | **string** | The LUSID user id assigned to the result. | [optional] 
**AssignedRole** | **string** | The LUSID IAM role id assigned to the result. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "id";
string recType = "recType";
RecInstanceId instanceId = new RecInstanceId();
ResourceId recDefinitionId = new ResourceId();
RecDatesReconciled datesReconciled = new RecDatesReconciled();
string resultType = "resultType";
string resultCardinality = "resultCardinality";
string resultLifeCycle = "resultLifeCycle";
RecResultException? exception = new RecResultException();

RecResultReview review = new RecResultReview();
List<CoreRuleValues> coreRules = new List<CoreRuleValues>();
List<AggregateRuleValues> aggregateRules = new List<AggregateRuleValues>();
List<SupplementalAttributeValues> supplementalAttributes = new List<SupplementalAttributeValues>();
RecResultItemDetails items = new RecResultItemDetails();
List<RecUserComment> comments = new List<RecUserComment>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
string assignedUser = "example assignedUser";
string assignedRole = "example assignedRole";
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

RecResult recResultInstance = new RecResult(
    id: id,
    recType: recType,
    instanceId: instanceId,
    recDefinitionId: recDefinitionId,
    runNumber: runNumber,
    runAsAt: runAsAt,
    datesReconciled: datesReconciled,
    resultType: resultType,
    resultCardinality: resultCardinality,
    resultLifeCycle: resultLifeCycle,
    exception: exception,
    review: review,
    coreRules: coreRules,
    aggregateRules: aggregateRules,
    supplementalAttributes: supplementalAttributes,
    items: items,
    comments: comments,
    properties: properties,
    assignedUser: assignedUser,
    assignedRole: assignedRole,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
