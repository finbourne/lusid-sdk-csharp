# Lusid.Sdk.Model.AddressKeyFilter
Class specifying a filtering operation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | **string** | Address for the value in the row | [optional] 
**Operator** | **string** | What sort of comparison is the filter performing. Can be either \&quot;eq\&quot; for equals or \&quot;neq\&quot; for not equals. | [optional] 
**Right** | [**ResultValue**](ResultValue.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string left = "example left";
string operator = "example operator";
ResultValue? right = new ResultValue();


AddressKeyFilter addressKeyFilterInstance = new AddressKeyFilter(
    left: left,
    operator: operator,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
