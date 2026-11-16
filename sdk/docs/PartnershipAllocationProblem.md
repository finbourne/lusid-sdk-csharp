# Lusid.Sdk.Model.PartnershipAllocationProblem
Why the period cannot be allocated to the partners as it stands. The read reports it; the allocation run and the  acceptance refuse with the same failure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The problem. Available values: AllocationRulesNotConfigured, UnbucketedPnl, UnknownDistributionCharacter. | 
**Message** | **string** | What is wrong and what to change, naming the accounts, amounts and values concerned. | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string message = "message";

PartnershipAllocationProblem partnershipAllocationProblemInstance = new PartnershipAllocationProblem(
    code: code,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
