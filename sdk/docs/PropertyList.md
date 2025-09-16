# Lusid.Sdk.Model.PropertyList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceListType** | **string** | The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList, PropertyList, FundIdList | 
**Values** | [**List&lt;Property&gt;**](Property.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<Property> values = new List<Property>();

PropertyList propertyListInstance = new PropertyList(
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
