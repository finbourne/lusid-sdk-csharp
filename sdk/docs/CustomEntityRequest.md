# Lusid.Sdk.Model.CustomEntityRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | A display label for the custom entity. | 
**Description** | **string** | A description of the custom entity. | 
**Identifiers** | [**List&lt;CustomEntityId&gt;**](CustomEntityId.md) | The identifiers the custom entity will be upserted with. | 
**Fields** | [**List&lt;CustomEntityField&gt;**](CustomEntityField.md) | The fields that decorate the custom entity. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties that decorate the custom entity. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "description";
List<CustomEntityId> identifiers = new List<CustomEntityId>();
List<CustomEntityField> fields = new List<CustomEntityField>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();

CustomEntityRequest customEntityRequestInstance = new CustomEntityRequest(
    displayName: displayName,
    description: description,
    identifiers: identifiers,
    fields: fields,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
