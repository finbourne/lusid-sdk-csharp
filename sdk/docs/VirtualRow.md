# Lusid.Sdk.Model.VirtualRow
Rows identified by the composite id, based on the data maps

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RowId** | **Dictionary&lt;string, string&gt;** | The identifier for the row. This is keyed by address keys, and values obtained through applying the data map to the documents. | [optional] 
**RowData** | [**Dictionary&lt;string, ResultValue&gt;**](ResultValue.md) | The data for the particular row | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> rowId = new Dictionary<string, string>();
Dictionary<string, ResultValue> rowData = new Dictionary<string, ResultValue>();

VirtualRow virtualRowInstance = new VirtualRow(
    rowId: rowId,
    rowData: rowData);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
