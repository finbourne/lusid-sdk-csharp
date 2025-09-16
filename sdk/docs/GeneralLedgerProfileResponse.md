# Lusid.Sdk.Model.GeneralLedgerProfileResponse
A General Ledger Profile Definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**GeneralLedgerProfileCode** | **string** | The unique code for the General Ledger Profile | 
**DisplayName** | **string** | The name of the General Ledger Profile | 
**Description** | **string** | A description for the General Ledger Profile | [optional] 
**GeneralLedgerProfileMappings** | [**List&lt;GeneralLedgerProfileMapping&gt;**](GeneralLedgerProfileMapping.md) | Rules for mapping Account or property values to aggregation pattern definitions | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId chartOfAccountsId = new ResourceId();
string generalLedgerProfileCode = "generalLedgerProfileCode";
string displayName = "displayName";
string description = "example description";
List<GeneralLedgerProfileMapping> generalLedgerProfileMappings = new List<GeneralLedgerProfileMapping>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

GeneralLedgerProfileResponse generalLedgerProfileResponseInstance = new GeneralLedgerProfileResponse(
    href: href,
    chartOfAccountsId: chartOfAccountsId,
    generalLedgerProfileCode: generalLedgerProfileCode,
    displayName: displayName,
    description: description,
    generalLedgerProfileMappings: generalLedgerProfileMappings,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
