# Lusid.Sdk.Model.ApportionmentInput
One named amount that contributed to a member share class's apportionment base value - the workings behind  the figure rather than the figure alone. A member's inputs always sum to its base value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The input&#39;s identifier within its apportionment method, for example &#39;openingNav&#39;. | 
**DisplayName** | **string** | The input&#39;s human-readable name, for example &#39;Opening NAV&#39;. | 
**Value** | **decimal** | The input&#39;s contribution to the base value, signed as it contributes. | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";decimal value = "value";


ApportionmentInput apportionmentInputInstance = new ApportionmentInput(
    code: code,
    displayName: displayName,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
