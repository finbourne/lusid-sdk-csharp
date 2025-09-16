# Lusid.Sdk.Model.Reconciliation
Representation of Reconciliation in LUSID Api

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ReconciliationId**](ReconciliationId.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Name** | **string** | The name of the scheduled reconciliation | [optional] 
**Description** | **string** | A description of the scheduled reconciliation | [optional] 
**IsPortfolioGroup** | **bool** | Specifies whether reconciliation is between portfolios or portfolio groups | [optional] 
**Left** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Right** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Transactions** | [**ReconciliationTransactions**](ReconciliationTransactions.md) |  | [optional] 
**Positions** | [**ReconciliationConfiguration**](ReconciliationConfiguration.md) |  | [optional] 
**Valuations** | [**ReconciliationConfiguration**](ReconciliationConfiguration.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Reconciliation properties | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ReconciliationId? id = new ReconciliationId();

string href = "example href";
string name = "example name";
string description = "example description";
bool isPortfolioGroup = //"True";
ResourceId? left = new ResourceId();

ResourceId? right = new ResourceId();

ReconciliationTransactions? transactions = new ReconciliationTransactions();

ReconciliationConfiguration? positions = new ReconciliationConfiguration();

ReconciliationConfiguration? valuations = new ReconciliationConfiguration();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

Reconciliation reconciliationInstance = new Reconciliation(
    id: id,
    href: href,
    name: name,
    description: description,
    isPortfolioGroup: isPortfolioGroup,
    left: left,
    right: right,
    transactions: transactions,
    positions: positions,
    valuations: valuations,
    properties: properties,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
