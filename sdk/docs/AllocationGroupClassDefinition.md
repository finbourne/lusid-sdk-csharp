# Lusid.Sdk.Model.AllocationGroupClassDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassShortCode** | **string** | A short code that uniquely identifies the share class within the Fund and is attached to the transaction. | 
**ApportionmentFactor** | **decimal?** | Only used for fixed percentage method or be zero, must equal 1 or 0 across all classes in the fund. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string shareClassShortCode = "shareClassShortCode";

AllocationGroupClassDefinition allocationGroupClassDefinitionInstance = new AllocationGroupClassDefinition(
    shareClassShortCode: shareClassShortCode,
    apportionmentFactor: apportionmentFactor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
