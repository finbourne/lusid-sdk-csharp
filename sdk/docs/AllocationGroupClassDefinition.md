# Lusid.Sdk.Model.AllocationGroupClassDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassShortCode** | **string** | A short code that uniquely identifies the share class within the Fund and is attached to the transaction. | 
**ShareClassFundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ApportionmentFactor** | **decimal?** | The weighting factor used for apportionment across this share class. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string shareClassShortCode = "shareClassShortCode";
ResourceId? shareClassFundId = new ResourceId();


AllocationGroupClassDefinition allocationGroupClassDefinitionInstance = new AllocationGroupClassDefinition(
    shareClassShortCode: shareClassShortCode,
    shareClassFundId: shareClassFundId,
    apportionmentFactor: apportionmentFactor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
