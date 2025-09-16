# Lusid.Sdk.Model.Membership

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope of the unique identifier associated with the Custom Data Model. | 
**Code** | **string** | The code of the unique identifier associated with the Custom Data Model. | 
**DisplayName** | **string** | The name of the Custom Data Model. | 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string displayName = "displayName";

Membership membershipInstance = new Membership(
    scope: scope,
    code: code,
    displayName: displayName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
