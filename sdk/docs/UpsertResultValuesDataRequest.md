# Lusid.Sdk.Model.UpsertResultValuesDataRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DocumentId** | [**StructuredResultDataId**](StructuredResultDataId.md) |  | 
**Key** | **Dictionary&lt;string, string&gt;** | The structured unit result data key. | [optional] 
**DataAddress** | **string** | The address of the piece of unit result data | [optional] 
**ResultValue** | [**ResultValue**](ResultValue.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

StructuredResultDataId documentId = new StructuredResultDataId();
Dictionary<string, string> key = new Dictionary<string, string>();
string dataAddress = "example dataAddress";
ResultValue? resultValue = new ResultValue();


UpsertResultValuesDataRequest upsertResultValuesDataRequestInstance = new UpsertResultValuesDataRequest(
    documentId: documentId,
    key: key,
    dataAddress: dataAddress,
    resultValue: resultValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
