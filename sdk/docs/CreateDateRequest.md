# Lusid.Sdk.Model.CreateDateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateId** | **string** |  | 
**FromUtc** | **DateTimeOffset** |  | 
**ToUtc** | **DateTimeOffset** |  | 
**VarTimeZone** | **string** |  | 
**Description** | **string** |  | 
**Type** | **string** |  | [optional] 
**Attributes** | [**DateAttributes**](DateAttributes.md) |  | [optional] 
**SourceData** | **Dictionary&lt;string, string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string dateId = "dateId";
string varTimeZone = "varTimeZone";
string description = "description";
string type = "example type";
DateAttributes? attributes = new DateAttributes();

Dictionary<string, string> sourceData = new Dictionary<string, string>();

CreateDateRequest createDateRequestInstance = new CreateDateRequest(
    dateId: dateId,
    fromUtc: fromUtc,
    toUtc: toUtc,
    varTimeZone: varTimeZone,
    description: description,
    type: type,
    attributes: attributes,
    sourceData: sourceData);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
