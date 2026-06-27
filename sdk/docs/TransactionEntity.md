# Lusid.Sdk.Model.TransactionEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The link to the transaction entity. | 
**EntityUniqueId** | **string** | The unique id of the transaction, combining the portfolio and transaction identifiers. | 
**AsAtVersionNumber** | **int?** | The version number of the transaction entity at the requested asAt. | [optional] 
**Status** | **string** | The status of the transaction entity. &#39;Prevailing&#39; when the transaction exists — including a cancelled transaction, whose cancellation is reflected in its own status rather than here; &#39;Deleted&#39; when the transaction&#39;s portfolio has been deleted; &#39;DoesNotExist&#39; when the transaction does not yet exist (e.g. staged creation preview). Available values: Prevailing, Deleted, DoesNotExist. | 
**AsAtDeleted** | **DateTimeOffset?** | The asAt datetime at which the portfolio (and by extension, the transaction) was deleted. | [optional] 
**UserIdDeleted** | **string** | The unique id of the user who deleted the portfolio. | [optional] 
**RequestIdDeleted** | **string** | The unique request id of the command that deleted the portfolio. | [optional] 
**PrevailingPortfolio** | [**PortfolioWithoutHref**](PortfolioWithoutHref.md) |  | [optional] 
**PrevailingInputTransaction** | [**Transaction**](Transaction.md) |  | [optional] 
**DeletedPortfolio** | [**PortfolioWithoutHref**](PortfolioWithoutHref.md) |  | [optional] 
**DeletedInputTransaction** | [**Transaction**](Transaction.md) |  | [optional] 
**PreviewedStatus** | **string** | The status of the transaction after the staged modification is applied. Always &#39;Prevailing&#39; for transaction previews. Available values: Prevailing, Deleted, DoesNotExist. | [optional] 
**PreviewedPortfolio** | [**PortfolioWithoutHref**](PortfolioWithoutHref.md) |  | [optional] 
**PreviewedInputTransaction** | [**Transaction**](Transaction.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "href";
string entityUniqueId = "entityUniqueId";
string status = "status";
string userIdDeleted = "example userIdDeleted";
string requestIdDeleted = "example requestIdDeleted";
PortfolioWithoutHref? prevailingPortfolio = new PortfolioWithoutHref();

Transaction? prevailingInputTransaction = new Transaction();

PortfolioWithoutHref? deletedPortfolio = new PortfolioWithoutHref();

Transaction? deletedInputTransaction = new Transaction();

string previewedStatus = "example previewedStatus";
PortfolioWithoutHref? previewedPortfolio = new PortfolioWithoutHref();

Transaction? previewedInputTransaction = new Transaction();

List<Link> links = new List<Link>();

TransactionEntity transactionEntityInstance = new TransactionEntity(
    href: href,
    entityUniqueId: entityUniqueId,
    asAtVersionNumber: asAtVersionNumber,
    status: status,
    asAtDeleted: asAtDeleted,
    userIdDeleted: userIdDeleted,
    requestIdDeleted: requestIdDeleted,
    prevailingPortfolio: prevailingPortfolio,
    prevailingInputTransaction: prevailingInputTransaction,
    deletedPortfolio: deletedPortfolio,
    deletedInputTransaction: deletedInputTransaction,
    previewedStatus: previewedStatus,
    previewedPortfolio: previewedPortfolio,
    previewedInputTransaction: previewedInputTransaction,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
