# Lusid.Sdk.Model.FundIdList

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceListType** | **string** | The reference list values. Available values: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList, PropertyList, FundIdList, FilteredFundIdList. | 
**Values** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**NavTypeCodesHint** | **List&lt;string&gt;** | The NAV type codes this list nominates, in priority order; entries may contain &#39;*&#39; wildcards.  For each fund the first matching code the fund defines is picked, falling back to the fund&#39;s  primary (official) NAV type when the list is empty or nothing matches. Optional. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> values = new List<ResourceId>();
List<string> navTypeCodesHint = new List<string>();

FundIdList fundIdListInstance = new FundIdList(
    values: values,
    navTypeCodesHint: navTypeCodesHint);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
