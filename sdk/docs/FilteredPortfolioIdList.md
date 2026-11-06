# Lusid.Sdk.Model.FilteredPortfolioIdList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceListType** | **string** | The reference list values. Available values: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList, PropertyList, FundIdList, FilteredFundIdList, FilteredPortfolioIdList. | 
**Filter** | **string** | The filter that selects the portfolios in the list. It is stored as given and resolved against the portfolios the caller is entitled to see each time the list is read. Supports portfolio fields (e.g. id.scope, displayName, type) and portfolio properties (e.g. properties[Portfolio/MyScope/Strategy] eq &#39;Equity&#39;). Relationship filters are not supported. Time-variant properties are evaluated at the asAt of the request; there is no effectiveAt. On upsert the filter must resolve successfully. | 
**Values** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The ids of the portfolios the filter resolved to when the list was read. Read only; must not be supplied on upsert. | [optional] [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

string filter = "filter";
List<ResourceId> values = new List<ResourceId>();

FilteredPortfolioIdList filteredPortfolioIdListInstance = new FilteredPortfolioIdList(
    filter: filter,
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
