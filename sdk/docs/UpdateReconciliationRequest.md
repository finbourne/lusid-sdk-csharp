# Lusid.Sdk.Model.UpdateReconciliationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the scheduled reconciliation | [optional] 
**Description** | **string** | A description of the scheduled reconciliation | [optional] 
**IsPortfolioGroup** | **bool** | Specifies whether reconciliation is between portfolios or portfolio groups | [optional] 
**Left** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Right** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Transactions** | [**ReconciliationTransactions**](ReconciliationTransactions.md) |  | [optional] 
**Positions** | [**ReconciliationConfiguration**](ReconciliationConfiguration.md) |  | [optional] 
**Valuations** | [**ReconciliationConfiguration**](ReconciliationConfiguration.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Reconciliation properties | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "example name";
string description = "example description";
bool isPortfolioGroup = //"True";
ResourceId? left = new ResourceId();

ResourceId? right = new ResourceId();

ReconciliationTransactions? transactions = new ReconciliationTransactions();

ReconciliationConfiguration? positions = new ReconciliationConfiguration();

ReconciliationConfiguration? valuations = new ReconciliationConfiguration();

Dictionary<string, Property> properties = new Dictionary<string, Property>();

UpdateReconciliationRequest updateReconciliationRequestInstance = new UpdateReconciliationRequest(
    name: name,
    description: description,
    isPortfolioGroup: isPortfolioGroup,
    left: left,
    right: right,
    transactions: transactions,
    positions: positions,
    valuations: valuations,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
