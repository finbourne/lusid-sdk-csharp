# Lusid.Sdk.Model.DateAttributes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Irregular** | **bool** |  | 
**IrregularSession** | **bool** |  | 
**NewHours** | **bool** |  | 
**Activity** | **string** |  | [optional] 
**FirstOpen** | **string** |  | [optional] 
**LastOpen** | **string** |  | [optional] 
**FirstClose** | **string** |  | [optional] 
**LastClose** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool irregular = //"True";
bool irregularSession = //"True";
bool newHours = //"True";
string activity = "example activity";
string firstOpen = "example firstOpen";
string lastOpen = "example lastOpen";
string firstClose = "example firstClose";
string lastClose = "example lastClose";

DateAttributes dateAttributesInstance = new DateAttributes(
    irregular: irregular,
    irregularSession: irregularSession,
    newHours: newHours,
    activity: activity,
    firstOpen: firstOpen,
    lastOpen: lastOpen,
    firstClose: firstClose,
    lastClose: lastClose);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
