# Lusid.Sdk.Model.NavTypeCatchUp
The number of valuation points the leader finalised while a follower NAV type was dormant (deactivated).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavTypeCode** | **string** | The code of the follower NAV type that was reactivated. | 
**CatchUpCount** | **int** | The number of valuation points the leader finalised while this follower NAV type was dormant (deactivated). | 

```csharp
using Lusid.Sdk.Model;
using System;

string navTypeCode = "navTypeCode";

NavTypeCatchUp navTypeCatchUpInstance = new NavTypeCatchUp(
    navTypeCode: navTypeCode,
    catchUpCount: catchUpCount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
