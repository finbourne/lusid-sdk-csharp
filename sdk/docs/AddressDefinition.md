# Lusid.Sdk.Model.AddressDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the address key. | [optional] 
**Type** | **string** | The available values are: String, Int, Decimal, DateTime, Boolean, ResultValue, Result0D, Json | [optional] 
**Description** | **string** | The description for this result. | [optional] 
**LifeCycleStatus** | **string** | What is the status of the address path. If it is not Production then it might be removed at some point in the future.  See the removal date for the likely timing of that if any. | [optional] 
**RemovalDate** | **DateTimeOffset?** | If the life-cycle status of the address is Deprecated then this is the date at which support of the address will be suspended.  After that date it will be removed at the earliest possible point subject to any specific contractual support and development constraints. | [optional] 
**DocumentationLink** | **string** | Contains a link to the documentation for this AddressDefinition in KnowledgeBase. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "example displayName";
string type = "example type";
string description = "example description";
string lifeCycleStatus = "example lifeCycleStatus";
string documentationLink = "example documentationLink";

AddressDefinition addressDefinitionInstance = new AddressDefinition(
    displayName: displayName,
    type: type,
    description: description,
    lifeCycleStatus: lifeCycleStatus,
    removalDate: removalDate,
    documentationLink: documentationLink);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
