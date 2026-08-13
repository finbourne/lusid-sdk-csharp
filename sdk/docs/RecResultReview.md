# Lusid.Sdk.Model.RecResultReview
The per-result review axis: the workflow state and the recorded review decision. Always present,  including on Match and Cross.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The review workflow state: NotRequired, Required or Reviewed. Available values: NotRequired, Required, Reviewed. | 
**Decision** | **string** | The recorded review decision. Null until a decision is made. Available values: Acknowledge, FixAtSource, FixAsGroup, Accept, ForceMatch, Tolerate. | [optional] 
**DecisionGroup** | [**RecResultDecisionGroup**](RecResultDecisionGroup.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
string decision = "example decision";
RecResultDecisionGroup? decisionGroup = new RecResultDecisionGroup();


RecResultReview recResultReviewInstance = new RecResultReview(
    status: status,
    decision: decision,
    decisionGroup: decisionGroup);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
