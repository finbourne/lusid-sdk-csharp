# Lusid.Sdk.Model.PortfolioIdList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceListType** | **string** | The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList, PropertyList, FundIdList | 
**Values** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> values = new List<ResourceId>();

PortfolioIdList portfolioIdListInstance = new PortfolioIdList(
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
