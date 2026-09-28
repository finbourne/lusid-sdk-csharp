# Lusid.Sdk.Model.AllocationMapParticipants
Who takes part in the allocations of an Allocation Map: the default rule that finds the participant set, and the  exceptions that exclude particular investor records or fix their share.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rule** | **string** | How the default participant set is found. AllCommittedToMembers takes every investor record committed to any of the funds in memberIds; ExplicitList takes exactly the investor records in explicitInvestorRecordIds. Available values: AllCommittedToMembers, ExplicitList. | [optional] 
**MemberIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Under the AllCommittedToMembers rule, the member funds whose committed investor records participate, as scope and code. At least one is required under that rule. | [optional] 
**ExplicitInvestorRecordIds** | **List&lt;string&gt;** | Under the ExplicitList rule, the investor records that participate. At least one is required under that rule. | [optional] 
**Exceptions** | [**List&lt;AllocationMapException&gt;**](AllocationMapException.md) | Departures from the default participation for particular investor records. Each names the investor record, what happens to it, and why. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string rule = "example rule";
List<ResourceId> memberIds = new List<ResourceId>();
List<string> explicitInvestorRecordIds = new List<string>();
List<AllocationMapException> exceptions = new List<AllocationMapException>();

AllocationMapParticipants allocationMapParticipantsInstance = new AllocationMapParticipants(
    rule: rule,
    memberIds: memberIds,
    explicitInvestorRecordIds: explicitInvestorRecordIds,
    exceptions: exceptions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
