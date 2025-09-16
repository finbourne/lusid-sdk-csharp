# Lusid.Sdk.Model.CleardownModuleResponse
A Cleardown Module definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**CleardownModuleCode** | **string** | The code of the Cleardown Module. | 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Cleardown Module. | 
**Description** | **string** | A description for the Cleardown Module. | [optional] 
**Rules** | [**List&lt;CleardownModuleRule&gt;**](CleardownModuleRule.md) | The Cleardown Rules that apply for the Cleardown Module. Rules are evaluated in the order they occur in this collection. | [optional] 
**Status** | **string** | The Cleardown Module status. Can be Active, Inactive or Deleted. Defaults to Active. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string cleardownModuleCode = "cleardownModuleCode";
ResourceId chartOfAccountsId = new ResourceId();
string displayName = "displayName";
string description = "example description";
List<CleardownModuleRule> rules = new List<CleardownModuleRule>();
string status = "status";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

CleardownModuleResponse cleardownModuleResponseInstance = new CleardownModuleResponse(
    href: href,
    cleardownModuleCode: cleardownModuleCode,
    chartOfAccountsId: chartOfAccountsId,
    displayName: displayName,
    description: description,
    rules: rules,
    status: status,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
