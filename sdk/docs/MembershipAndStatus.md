# Lusid.Sdk.Model.MembershipAndStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Describes whether the entity is still a valid member of the data model. | 
**Scope** | **string** | The scope of the unique identifier associated with the Custom Data Model. | 
**Code** | **string** | The code of the unique identifier associated with the Custom Data Model. | 
**DisplayName** | **string** | The name of the Custom Data Model. | 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
string scope = "scope";
string code = "code";
string displayName = "displayName";

MembershipAndStatus membershipAndStatusInstance = new MembershipAndStatus(
    status: status,
    scope: scope,
    code: code,
    displayName: displayName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
