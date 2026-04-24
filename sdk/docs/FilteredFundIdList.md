# Lusid.Sdk.Model.FilteredFundIdList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceListType** | **string** | The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList, PropertyList, FundIdList, FilteredFundIdList | 
**Filter** | **string** |  | 
**Values** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | [optional] [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

string filter = "filter";
List<ResourceId> values = new List<ResourceId>();

FilteredFundIdList filteredFundIdListInstance = new FilteredFundIdList(
    filter: filter,
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
