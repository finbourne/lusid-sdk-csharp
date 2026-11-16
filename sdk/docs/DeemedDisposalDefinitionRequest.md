# Lusid.Sdk.Model.DeemedDisposalDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**DisplayName** | **string** | The name of the deemed disposal definition. | 
**Description** | **string** | The description of the deemed disposal definition. | [optional] 
**Filter** | **string** | Selects the holdings the definition deems disposed of and re-acquired at market value at a valuation point. Written in the holding filter grammar of the portfolio cash flow endpoints (holdingType, holdingTypeName, instrumentUid, instrumentScope, units, settledUnits, unsettledUnits, overdueUnits, currentFace, cost.amount, cost.currency, costPortfolioCcy.amount, custodianAccountId, custodianAccount, subHoldingKeys[...] and properties[...]), for example \&quot;holdingType eq &#39;B&#39; and cost.currency eq &#39;USD&#39;\&quot;, with the additional system field &#39;InNavTypeBaseCurrency&#39; (true when the holding is in the NAV type&#39;s base currency). The GetHoldings fields &#39;currency&#39; and &#39;transaction&#39; are not accepted. | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";
string filter = "filter";

DeemedDisposalDefinitionRequest deemedDisposalDefinitionRequestInstance = new DeemedDisposalDefinitionRequest(
    code: code,
    displayName: displayName,
    description: description,
    filter: filter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
