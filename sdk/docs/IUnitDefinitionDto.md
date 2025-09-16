# Lusid.Sdk.Model.IUnitDefinitionDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schema** | **string** | The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**Code** | **string** |  | [optional] [readonly] 
**DisplayName** | **string** |  | [optional] [readonly] 
**Description** | **string** |  | [optional] [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

string schema = "example schema";
string code = "example code";
string displayName = "example displayName";
string description = "example description";

IUnitDefinitionDto iUnitDefinitionDtoInstance = new IUnitDefinitionDto(
    schema: schema,
    code: code,
    displayName: displayName,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
