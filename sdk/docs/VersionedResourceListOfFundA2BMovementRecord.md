# Lusid.Sdk.Model.VersionedResourceListOfFundA2BMovementRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Values** | [**List&lt;FundA2BMovementRecord&gt;**](FundA2BMovementRecord.md) |  | 
**Href** | **string** |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion varVersion = new ModelVersion();
List<FundA2BMovementRecord> values = new List<FundA2BMovementRecord>();
string href = "example href";
string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<Link> links = new List<Link>();

VersionedResourceListOfFundA2BMovementRecord versionedResourceListOfFundA2BMovementRecordInstance = new VersionedResourceListOfFundA2BMovementRecord(
    varVersion: varVersion,
    values: values,
    href: href,
    nextPage: nextPage,
    previousPage: previousPage,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
