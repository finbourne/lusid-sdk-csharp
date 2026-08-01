# Lusid.Sdk.Model.BucketDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketId** | **string** |  | 
**DisplayName** | **string** |  | 
**FilterExpression** | **string** |  | 
**BucketType** | **string** | Available values: Dealing, PnL, Fees, BalanceSheet, Misc. | 
**Unitised** | **bool?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketId = "bucketId";
string displayName = "displayName";
string filterExpression = "filterExpression";
string bucketType = "bucketType";
bool? unitised = //"True";

BucketDefinition bucketDefinitionInstance = new BucketDefinition(
    bucketId: bucketId,
    displayName: displayName,
    filterExpression: filterExpression,
    bucketType: bucketType,
    unitised: unitised);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
