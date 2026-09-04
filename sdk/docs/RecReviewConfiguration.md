# Lusid.Sdk.Model.RecReviewConfiguration
How the results of a rec definition's runs are reviewed and approved: what needs reviewing, when the  reviewer may submit, and who has to approve the submission.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OpenExceptions** | [**RecReviewRequirementRule**](RecReviewRequirementRule.md) |  | [optional] 
**ClosedExceptions** | [**RecReviewRequirementRule**](RecReviewRequirementRule.md) |  | [optional] 
**Matches** | [**RecReviewRequirementRule**](RecReviewRequirementRule.md) |  | [optional] 
**ReviewSubmission** | [**RecReviewSubmission**](RecReviewSubmission.md) |  | [optional] 
**RequiredApprovals** | [**List&lt;RecReviewRequiredApproval&gt;**](RecReviewRequiredApproval.md) | The approvals a submitted review has to collect. All are required and may be given in any order, and no user may give more than one of them. Empty means no approvals are required and the reviewer self-approves on submission. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

RecReviewRequirementRule? openExceptions = new RecReviewRequirementRule();

RecReviewRequirementRule? closedExceptions = new RecReviewRequirementRule();

RecReviewRequirementRule? matches = new RecReviewRequirementRule();

RecReviewSubmission? reviewSubmission = new RecReviewSubmission();

List<RecReviewRequiredApproval> requiredApprovals = new List<RecReviewRequiredApproval>();

RecReviewConfiguration recReviewConfigurationInstance = new RecReviewConfiguration(
    openExceptions: openExceptions,
    closedExceptions: closedExceptions,
    matches: matches,
    reviewSubmission: reviewSubmission,
    requiredApprovals: requiredApprovals);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
