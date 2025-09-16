# Lusid.Sdk.Model.CreateCutLabelDefinitionRequest
This request specifies a new Cut Label Definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | [optional] 
**CutLocalTime** | [**CutLocalTime**](CutLocalTime.md) |  | 
**VarTimeZone** | **string** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";
CutLocalTime cutLocalTime = new CutLocalTime();
string varTimeZone = "varTimeZone";

CreateCutLabelDefinitionRequest createCutLabelDefinitionRequestInstance = new CreateCutLabelDefinitionRequest(
    code: code,
    displayName: displayName,
    description: description,
    cutLocalTime: cutLocalTime,
    varTimeZone: varTimeZone);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
