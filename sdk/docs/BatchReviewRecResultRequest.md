# Lusid.Sdk.Model.BatchReviewRecResultRequest
One item of a batch review request: applies review content to its targeted rec result(s). Exactly  one target, except FixAsGroup/ForceMatch which require two or more. A result id is unique within one  instance. Every item names the rec type of its targets, so a group decision covers results of one rec type  only.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceId** | [**RecInstanceId**](RecInstanceId.md) |  | 
**RecType** | **string** | The rec type whose results this item targets (e.g. Holding). Available values: Holding, CashHolding, Valuation, InputTransaction, OutputTransaction, SettlementActivity, External, Instrument. | 
**RecResultIds** | **List&lt;string&gt;** | The rec results targeted by this batch item. Exactly one, except FixAsGroup/ForceMatch which require two or more. | 
**Decision** | [**RecResultDecisionUpdate**](RecResultDecisionUpdate.md) |  | [optional] 
**AssignedUser** | [**RecResultAssignmentUpdate**](RecResultAssignmentUpdate.md) |  | [optional] 
**AssignedRole** | [**RecResultAssignmentUpdate**](RecResultAssignmentUpdate.md) |  | [optional] 
**AddCommentText** | **string** | Optional comment text to add to each targeted result. | [optional] 
**Properties** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) | Properties in the RecResult domain to set on each result. A property with a null value is deleted and omitted properties are left unchanged. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

RecInstanceId instanceId = new RecInstanceId();
string recType = "recType";
List<string> recResultIds = new List<string>();
RecResultDecisionUpdate? decision = new RecResultDecisionUpdate();

RecResultAssignmentUpdate? assignedUser = new RecResultAssignmentUpdate();

RecResultAssignmentUpdate? assignedRole = new RecResultAssignmentUpdate();

string addCommentText = "example addCommentText";
List<PerpetualProperty> properties = new List<PerpetualProperty>();

BatchReviewRecResultRequest batchReviewRecResultRequestInstance = new BatchReviewRecResultRequest(
    instanceId: instanceId,
    recType: recType,
    recResultIds: recResultIds,
    decision: decision,
    assignedUser: assignedUser,
    assignedRole: assignedRole,
    addCommentText: addCommentText,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
