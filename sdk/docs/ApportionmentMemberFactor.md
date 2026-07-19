# Lusid.Sdk.Model.ApportionmentMemberFactor
One member share class's outcome within an apportionment result: the base value the method produced for it  and the resulting apportionment factor.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemberIdentifier** | **string** | The member share class&#39;s short code. | 
**FundScope** | **string** | The scope of the fund the member share class belongs to. | [optional] 
**FundCode** | **string** | The code of the fund the member share class belongs to. | [optional] 
**BaseValue** | **decimal?** | The base value the method produced for the member, or null for the SetFactor method. | [optional] 
**ApportionmentFactor** | **decimal** | The member&#39;s apportionment factor: its base value over the total across the group or fund. | 

```csharp
using Lusid.Sdk.Model;
using System;

string memberIdentifier = "memberIdentifier";
string fundScope = "example fundScope";
string fundCode = "example fundCode";decimal apportionmentFactor = "apportionmentFactor";


ApportionmentMemberFactor apportionmentMemberFactorInstance = new ApportionmentMemberFactor(
    memberIdentifier: memberIdentifier,
    fundScope: fundScope,
    fundCode: fundCode,
    baseValue: baseValue,
    apportionmentFactor: apportionmentFactor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
