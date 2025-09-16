# Lusid.Sdk.Model.CreateAmortisationRuleSetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";

CreateAmortisationRuleSetRequest createAmortisationRuleSetRequestInstance = new CreateAmortisationRuleSetRequest(
    code: code,
    displayName: displayName,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
