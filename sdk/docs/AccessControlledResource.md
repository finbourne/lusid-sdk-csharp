# Lusid.Sdk.Model.AccessControlledResource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Application** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | 
**Actions** | [**List&lt;AccessControlledAction&gt;**](AccessControlledAction.md) |  | 
**IdentifierParts** | [**List&lt;IdentifierPartSchema&gt;**](IdentifierPartSchema.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string application = "example application";
string name = "example name";
string description = "description";
List<AccessControlledAction> actions = new List<AccessControlledAction>();
List<IdentifierPartSchema> identifierParts = new List<IdentifierPartSchema>();
List<Link> links = new List<Link>();

AccessControlledResource accessControlledResourceInstance = new AccessControlledResource(
    application: application,
    name: name,
    description: description,
    actions: actions,
    identifierParts: identifierParts,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
