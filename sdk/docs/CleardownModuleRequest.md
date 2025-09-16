# Lusid.Sdk.Model.CleardownModuleRequest
A Cleardown Module request definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Cleardown Module. | 
**DisplayName** | **string** | The name of the Cleardown Module. | 
**Description** | **string** | A description for the Cleardown Module. | [optional] 
**Rules** | [**List&lt;CleardownModuleRule&gt;**](CleardownModuleRule.md) | The Cleardown Rules that apply for the Cleardown Module. Rules are evaluated in the order they occur in this collection. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";
List<CleardownModuleRule> rules = new List<CleardownModuleRule>();

CleardownModuleRequest cleardownModuleRequestInstance = new CleardownModuleRequest(
    code: code,
    displayName: displayName,
    description: description,
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
