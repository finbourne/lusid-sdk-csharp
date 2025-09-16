# Lusid.Sdk.Model.StructuredResultData
An item of structured result data that is to be inserted into Lusid. This will typically be a Json or Xml document that  contains a set of result data appropriate to a specific entity such as an instrument or potentially an index.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentFormat** | **string** | The format of the accompanying document. | 
**VarVersion** | **string** | The semantic version of the document format; MAJOR.MINOR.PATCH | [optional] 
**Name** | **string** | The name or description for the document | [optional] 
**Document** | **string** | The document that will be stored (or retrieved) and which describes a unit result data entity such as a set of prices or yields | 
**DataMapKey** | [**DataMapKey**](DataMapKey.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string documentFormat = "documentFormat";
string varVersion = "example varVersion";
string name = "example name";
string document = "document";
DataMapKey? dataMapKey = new DataMapKey();


StructuredResultData structuredResultDataInstance = new StructuredResultData(
    documentFormat: documentFormat,
    varVersion: varVersion,
    name: name,
    document: document,
    dataMapKey: dataMapKey);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
