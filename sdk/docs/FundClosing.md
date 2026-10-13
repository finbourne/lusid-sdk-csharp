# Lusid.Sdk.Model.FundClosing

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClosingId** | **string** |  | 
**ClosingDate** | **DateTimeOffset** |  | 
**IsFinal** | **bool?** |  | [optional] 
**Description** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string closingId = "closingId";
bool? isFinal = //"True";
string description = "example description";

FundClosing fundClosingInstance = new FundClosing(
    closingId: closingId,
    closingDate: closingDate,
    isFinal: isFinal,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
