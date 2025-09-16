# Lusid.Sdk.Model.DecimalList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceListType** | **string** | The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList, PropertyList, FundIdList | 
**Values** | **List&lt;decimal&gt;** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<decimal> values = new List<decimal>();

DecimalList decimalListInstance = new DecimalList(
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
