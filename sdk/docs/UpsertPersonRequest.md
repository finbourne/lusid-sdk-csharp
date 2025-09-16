# Lusid.Sdk.Model.UpsertPersonRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifiers** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The identifiers the person will be upserted with.The provided keys should be idTypeScope, idTypeCode, code | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties associated to the Person. There can be multiple properties associated with a property key. | [optional] 
**DisplayName** | **string** | The display name of the Person | 
**Description** | **string** | The description of the Person | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Property> identifiers = new Dictionary<string, Property>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string displayName = "displayName";
string description = "example description";

UpsertPersonRequest upsertPersonRequestInstance = new UpsertPersonRequest(
    identifiers: identifiers,
    properties: properties,
    displayName: displayName,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
