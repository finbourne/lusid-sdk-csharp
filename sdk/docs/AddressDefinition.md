# Lusid.Sdk.Model.AddressDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the address key. | [optional] 
**Type** | **string** | Available values: String, Int, Decimal, DateTime, Boolean, ResultValue, Result0D, Result1D, Result2D, Json. | [optional] 
**Description** | **string** | The description for this result. | [optional] 
**LifeCycleStatus** | **string** | What is the status of the address path. If it is not Production then it might be removed at some point in the future.  See the removal date for the likely timing of that if any. | [optional] 
**RemovalDate** | **DateTimeOffset?** | If the life-cycle status of the address is Deprecated then this is the date at which support of the address will be suspended.  After that date it will be removed at the earliest possible point subject to any specific contractual support and development constraints. | [optional] 
**DocumentationLink** | **string** | Contains a link to the documentation for this AddressDefinition in KnowledgeBase. | [optional] 
**Axes** | [**List&lt;ResultAxisDefinition&gt;**](ResultAxisDefinition.md) | For keys whose type is a labelled vector or matrix (Result1D/Result2D), describes what the  labels on each axis mean. Null for scalar results and for shaped results whose axes have  not been described. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "example displayName";
string type = "example type";
string description = "example description";
string lifeCycleStatus = "example lifeCycleStatus";
string documentationLink = "example documentationLink";
List<ResultAxisDefinition> axes = new List<ResultAxisDefinition>();

AddressDefinition addressDefinitionInstance = new AddressDefinition(
    displayName: displayName,
    type: type,
    description: description,
    lifeCycleStatus: lifeCycleStatus,
    removalDate: removalDate,
    documentationLink: documentationLink,
    axes: axes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
