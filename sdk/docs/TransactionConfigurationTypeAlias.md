# Lusid.Sdk.Model.TransactionConfigurationTypeAlias

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The transaction type | 
**Description** | **string** | Brief description of the transaction | 
**TransactionClass** | **string** | Relates types of a similar class. E.g. Buy/Sell, StockIn/StockOut | 
**TransactionGroup** | **string** | Group is a set of codes related to a source, or sync. DEPRECATED: This field will be removed, use &#x60;Source&#x60; instead | [optional] 
**Source** | **string** | Used to group a set of transaction types | [optional] 
**TransactionRoles** | **string** | . The available values are: None, LongLonger, LongShorter, ShortShorter, Shorter, ShortLonger, Longer, AllRoles | 
**IsDefault** | **bool** | IsDefault is a flag that denotes the default alias for a source. There can only be, at most, one per source. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

