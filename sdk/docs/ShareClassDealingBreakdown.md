# Lusid.Sdk.Model.ShareClassDealingBreakdown
The breakdown of Dealing for a Share Class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassDealing** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for any &#39;Dealing&#39; specific to the share class that has occured inside the queried period. | 
**ClassDealingUnits** | [**Dictionary&lt;string, Amount&gt;**](Amount.md) | Bucket of detail for any &#39;Dealing&#39; units specific to the share class that has occured inside the queried period. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, ShareClassAmount> classDealing = new Dictionary<string, ShareClassAmount>();
Dictionary<string, Amount> classDealingUnits = new Dictionary<string, Amount>();

ShareClassDealingBreakdown shareClassDealingBreakdownInstance = new ShareClassDealingBreakdown(
    classDealing: classDealing,
    classDealingUnits: classDealingUnits);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
