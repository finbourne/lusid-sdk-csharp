# Lusid.Sdk.Model.PartnerStatementLineDifference
One figure that differs between two partner statements.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the figure. | 
**Before** | **decimal?** | The figure on the statement compared against. | [optional] 
**After** | **decimal?** | The figure on this statement. | [optional] 
**Change** | **decimal** | After less before. | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";decimal change = "change";


PartnerStatementLineDifference partnerStatementLineDifferenceInstance = new PartnerStatementLineDifference(
    key: key,
    before: before,
    after: after,
    change: change);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
