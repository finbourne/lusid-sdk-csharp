# Lusid.Sdk.Model.SettlementActivityQuery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The asAt time at which to query settlement activity. Defaults to latest. | [optional] 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The portfolios and / or portfolio groups to query. At least one entry is required. | [optional] 
**StartActivityDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | Lower bound (inclusive) of the activity date range. If not set, no lower bound is applied. | [optional] 
**EndActivityDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | Upper bound (inclusive) of the activity date range. Defaults to the current date and time. Treated as effectiveAt. | [optional] 
**Filter** | **string** | A LUSID standard filter expression. Supports traversal into transaction and settlementInstruction. | [optional] 
**SettlementInstructionPropertyKeys** | **List&lt;string&gt;** | Settlement instruction property keys to populate on the response. Behaviour matches BuildSettlementInstructions. | [optional] 
**TransactionPropertyKeys** | **List&lt;string&gt;** | Transaction property keys to populate on the response. Behaviour matches BuildSettlementInstructions. | [optional] 
**Limit** | **int?** | Page size limit; standard pagination control. Defaults to 5000. | [optional] 
**Page** | **string** | Pagination cursor returned by a previous response. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<PortfolioEntityId> portfolioEntityIds = new List<PortfolioEntityId>();
DateTimeOrCutLabel startActivityDate = "example startActivityDate";
DateTimeOrCutLabel endActivityDate = "example endActivityDate";
string filter = "example filter";
List<string> settlementInstructionPropertyKeys = new List<string>();
List<string> transactionPropertyKeys = new List<string>();
string page = "example page";

SettlementActivityQuery settlementActivityQueryInstance = new SettlementActivityQuery(
    asAt: asAt,
    portfolioEntityIds: portfolioEntityIds,
    startActivityDate: startActivityDate,
    endActivityDate: endActivityDate,
    filter: filter,
    settlementInstructionPropertyKeys: settlementInstructionPropertyKeys,
    transactionPropertyKeys: transactionPropertyKeys,
    limit: limit,
    page: page);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
