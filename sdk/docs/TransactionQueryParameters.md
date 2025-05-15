# Lusid.Sdk.Model.TransactionQueryParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The lower bound effective datetime or cut label (inclusive) from which to build the transactions. | 
**EndDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions. | 
**QueryMode** | **string** | The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate | [optional] 
**ShowCancelledTransactions** | **bool** | Option to specify whether or not to include cancelled transactions in the output. Defaults to False if not specified. | [optional] 
**TimelineScope** | **string** | Scope of the Timeline for the Portfolio. The Timeline to be used while building transactions | [optional] 
**TimelineCode** | **string** | Code of the Timeline for the Portfolio. The Timeline to be used while building transactions | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

