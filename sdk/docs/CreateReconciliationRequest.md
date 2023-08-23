# Lusid.Sdk.Model.CreateReconciliationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The unique identifier associated with the reconciliation | 
**Name** | **string** | The name of the scheduled reconciliation | [optional] 
**Description** | **string** | A description of the scheduled reconciliation | [optional] 
**IsPortfolioGroup** | **bool** | Specifies whether reconciliation is between portfolios or portfolio groups | [optional] 
**Left** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Right** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Transactions** | [**ReconciliationTransactions**](ReconciliationTransactions.md) |  | [optional] 
**Positions** | [**ReconciliationConfiguration**](ReconciliationConfiguration.md) |  | [optional] 
**Valuations** | [**ReconciliationConfiguration**](ReconciliationConfiguration.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Reconciliation properties | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

