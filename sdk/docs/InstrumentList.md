# Lusid.Sdk.Model.InstrumentList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceListType** | **string** | The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList, PropertyList, FundIdList | 
**Values** | **List&lt;string&gt;** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> values = new List<string>();

InstrumentList instrumentListInstance = new InstrumentList(
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
