# Lusid.Sdk.Model.BucketSetDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**DisplayName** | **string** |  | 
**NavTypes** | **List&lt;string&gt;** |  | [optional] 
**Unitised** | **bool** |  | 
**Buckets** | [**List&lt;BucketDefinition&gt;**](BucketDefinition.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
List<string> navTypes = new List<string>();
bool unitised = //"True";
List<BucketDefinition> buckets = new List<BucketDefinition>();

BucketSetDefinition bucketSetDefinitionInstance = new BucketSetDefinition(
    code: code,
    displayName: displayName,
    navTypes: navTypes,
    unitised: unitised,
    buckets: buckets);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
