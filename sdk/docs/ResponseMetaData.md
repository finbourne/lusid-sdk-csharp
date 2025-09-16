# Lusid.Sdk.Model.ResponseMetaData
Metadata related to an api response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of meta data information being provided | [optional] 
**Description** | **string** | The description of what occured for this specific piece of meta data | [optional] 
**IdentifierType** | **string** | The type of the listed identifiers | [optional] 
**Identifiers** | **List&lt;string&gt;** | The related identifiers that were impacted by this event | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "example type";
string description = "example description";
string identifierType = "example identifierType";
List<string> identifiers = new List<string>();

ResponseMetaData responseMetaDataInstance = new ResponseMetaData(
    type: type,
    description: description,
    identifierType: identifierType,
    identifiers: identifiers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
