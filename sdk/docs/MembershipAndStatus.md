# Lusid.Sdk.Model.MembershipAndStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Describes whether the entity is still a valid member of the data model. | 
**Scope** | **string** | The scope of the unique identifier associated with the Custom Data Model. | 
**Code** | **string** | The code of the unique identifier associated with the Custom Data Model. | 
**DisplayName** | **string** | The name of the Custom Data Model. | 
**ValidationFailures** | **List&lt;string&gt;** | A list of validation failures returned when the entity&#39;s status with respect to the current model is &#39;Invalid&#39; or &#39;Inadmissible&#39; | 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
string scope = "scope";
string code = "code";
string displayName = "displayName";
List<string> validationFailures = new List<string>();

MembershipAndStatus membershipAndStatusInstance = new MembershipAndStatus(
    status: status,
    scope: scope,
    code: code,
    displayName: displayName,
    validationFailures: validationFailures);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
