# Lusid.Sdk.Model.GroupedResultOfAddressKey
Holder class for a group of results. It consists of a list of columns and values for that column.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Columns** | **List&lt;string&gt;** | The columns, or keys, for a particular group of results | [optional] 
**Values** | [**List&lt;ResultValue&gt;**](ResultValue.md) | The values for the list of results | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> columns = new List<string>();
List<ResultValue> values = new List<ResultValue>();

GroupedResultOfAddressKey groupedResultOfAddressKeyInstance = new GroupedResultOfAddressKey(
    columns: columns,
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
