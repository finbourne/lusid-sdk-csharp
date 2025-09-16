# Lusid.Sdk.Model.VirtualDocumentRow
Rows identified by the composite id, based on the data maps

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RowId** | **Dictionary&lt;string, string&gt;** | The identifier for the row. This is keyed by address keys, and values obtained through applying the data map to the documents. | [optional] 
**RowData** | [**GroupedResultOfAddressKey**](GroupedResultOfAddressKey.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> rowId = new Dictionary<string, string>();
GroupedResultOfAddressKey? rowData = new GroupedResultOfAddressKey();


VirtualDocumentRow virtualDocumentRowInstance = new VirtualDocumentRow(
    rowId: rowId,
    rowData: rowData);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
