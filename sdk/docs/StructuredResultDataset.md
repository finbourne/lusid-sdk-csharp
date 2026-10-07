# Lusid.Sdk.Model.StructuredResultDataset
Contains the run-time parameters that are appropriate for check definitions  with datasetSchema.type = \"StructuredResultData\". Names one structured result data document.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | **DateTimeOffset?** | The effectiveAt date of the document&#39;s rows to check. Required. | [optional] 
**AsAt** | **DateTimeOffset?** | The asAt date to fetch the data. Nullable. Defaults to latest. | [optional] 
**Scope** | **string** | The scope of the document. Required. | [optional] 
**Code** | **string** | The code of the document. Required. | [optional] 
**Source** | **string** | The platform or vendor that provided the document, e.g. \&quot;Client\&quot;. Required. | [optional] 
**ResultType** | **string** | The document&#39;s result type, e.g. \&quot;UnitResult/Custom\&quot;. Required. | [optional] 
**RowSelectorAttribute** | **string** | A row field to narrow down the rows checked, e.g. rowId[&#39;Instrument/default/LusidInstrumentId&#39;] or  rowData[&#39;Valuation/PV&#39;].Units. Cannot be provided without rowSelectorValue, and vice versa. | [optional] 
**RowSelectorValue** | **string** | The value of the above row field used to narrow down the rows. Cannot be provided without  rowSelectorAttribute, and vice versa. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "example scope";
string code = "example code";
string source = "example source";
string resultType = "example resultType";
string rowSelectorAttribute = "example rowSelectorAttribute";
string rowSelectorValue = "example rowSelectorValue";

StructuredResultDataset structuredResultDatasetInstance = new StructuredResultDataset(
    effectiveAt: effectiveAt,
    asAt: asAt,
    scope: scope,
    code: code,
    source: source,
    resultType: resultType,
    rowSelectorAttribute: rowSelectorAttribute,
    rowSelectorValue: rowSelectorValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
