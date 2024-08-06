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
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

