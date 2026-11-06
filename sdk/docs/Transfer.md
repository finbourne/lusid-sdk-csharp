# Lusid.Sdk.Model.Transfer
A transfer and both of the transactions it booked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransferId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TransferType** | **string** | The derived type of the transfer: &#39;Transfer&#39; when the position moves between portfolios, &#39;Switch&#39; when one instrument is exchanged for another within a portfolio, and &#39;Twitch&#39; when the position moves between portfolios and changes instrument at the same time. | [optional] 
**PortfolioIdOut** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PortfolioIdIn** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PricingMethod** | **string** | How the legs were priced: &#39;AtCost&#39; or &#39;AtPrice&#39;. | [optional] 
**TaxLotStructure** | **string** | What happened to the tax lots of the outgoing position: &#39;Consolidate&#39; or &#39;Preserve&#39;. | [optional] 
**WeightOut** | **decimal?** | The weighting factor recorded against the outgoing leg. | [optional] 
**AccountingMethod** | **string** | The accounting method recorded against the transfer. | [optional] 
**TransactionOut** | [**Transaction**](Transaction.md) |  | [optional] 
**TransactionIn** | [**Transaction**](Transaction.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties of the transfer, for the requested PropertyKeys. | [optional] 
**Href** | **string** | The specifc Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? transferId = new ResourceId();

string transferType = "example transferType";
ResourceId? portfolioIdOut = new ResourceId();

ResourceId? portfolioIdIn = new ResourceId();

string pricingMethod = "example pricingMethod";
string taxLotStructure = "example taxLotStructure";
string accountingMethod = "example accountingMethod";
Transaction? transactionOut = new Transaction();

Transaction? transactionIn = new Transaction();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

Transfer transferInstance = new Transfer(
    transferId: transferId,
    transferType: transferType,
    portfolioIdOut: portfolioIdOut,
    portfolioIdIn: portfolioIdIn,
    pricingMethod: pricingMethod,
    taxLotStructure: taxLotStructure,
    weightOut: weightOut,
    accountingMethod: accountingMethod,
    transactionOut: transactionOut,
    transactionIn: transactionIn,
    properties: properties,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
