# Lusid.Sdk.Model.StagingRuleApprovalCriteria

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequiredApprovals** | **int?** |  | [optional] 
**DecidingUser** | **string** |  | [optional] 
**StagingUserCanDecide** | **bool?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string decidingUser = "example decidingUser";
bool? stagingUserCanDecide = //"True";

StagingRuleApprovalCriteria stagingRuleApprovalCriteriaInstance = new StagingRuleApprovalCriteria(
    requiredApprovals: requiredApprovals,
    decidingUser: decidingUser,
    stagingUserCanDecide: stagingUserCanDecide);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
