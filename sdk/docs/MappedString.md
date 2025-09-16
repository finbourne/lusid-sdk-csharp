# Lusid.Sdk.Model.MappedString

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeftValue** | **string** |  | [optional] 
**RightValue** | **string** |  | [optional] 
**MappingDirection** | **string** |  | [optional] 
**IsCaseSensitive** | **bool** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string leftValue = "example leftValue";
string rightValue = "example rightValue";
string mappingDirection = "example mappingDirection";
bool isCaseSensitive = //"True";

MappedString mappedStringInstance = new MappedString(
    leftValue: leftValue,
    rightValue: rightValue,
    mappingDirection: mappingDirection,
    isCaseSensitive: isCaseSensitive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
