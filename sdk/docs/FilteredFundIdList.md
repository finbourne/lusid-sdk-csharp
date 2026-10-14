# Lusid.Sdk.Model.FilteredFundIdList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceListType** | **string** | The reference list values. Available values: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList, PropertyList, FundIdList, FilteredFundIdList. | 
**Filter** | **string** |  | 
**Values** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | [optional] [readonly] 
**NavTypeCodesHint** | **List&lt;string&gt;** |  | [optional] 
**NavTypeSelection** | **string** | Available values: First, All. | [optional] 
**ResolvedFundNavTypeCodes** | [**List&lt;FundNavTypeCodes&gt;**](FundNavTypeCodes.md) |  | [optional] [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

string filter = "filter";
List<ResourceId> values = new List<ResourceId>();
List<string> navTypeCodesHint = new List<string>();
string navTypeSelection = "example navTypeSelection";
List<FundNavTypeCodes> resolvedFundNavTypeCodes = new List<FundNavTypeCodes>();

FilteredFundIdList filteredFundIdListInstance = new FilteredFundIdList(
    filter: filter,
    values: values,
    navTypeCodesHint: navTypeCodesHint,
    navTypeSelection: navTypeSelection,
    resolvedFundNavTypeCodes: resolvedFundNavTypeCodes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
