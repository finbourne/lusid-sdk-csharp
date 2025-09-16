# Lusid.Sdk.Model.CreateCorporateActionSourceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope of the corporate action source | 
**Code** | **string** | The code of the corporate action source | 
**DisplayName** | **string** | The name of the corporate action source | 
**Description** | **string** | The description of the corporate action source | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The list of instrument scopes used as the scope resolution strategy when resolving instruments of upserted corporate actions. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string displayName = "displayName";
string description = "example description";
List<string> instrumentScopes = new List<string>();

CreateCorporateActionSourceRequest createCorporateActionSourceRequestInstance = new CreateCorporateActionSourceRequest(
    scope: scope,
    code: code,
    displayName: displayName,
    description: description,
    instrumentScopes: instrumentScopes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
