# Lusid.Sdk.Model.VersionedResourceListOfFundA2BDataRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Values** | [**List&lt;FundA2BDataRecord&gt;**](FundA2BDataRecord.md) |  | 
**Href** | **string** |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion varVersion = new ModelVersion();
List<FundA2BDataRecord> values = new List<FundA2BDataRecord>();
string href = "example href";
string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<Link> links = new List<Link>();

VersionedResourceListOfFundA2BDataRecord versionedResourceListOfFundA2BDataRecordInstance = new VersionedResourceListOfFundA2BDataRecord(
    varVersion: varVersion,
    values: values,
    href: href,
    nextPage: nextPage,
    previousPage: previousPage,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
