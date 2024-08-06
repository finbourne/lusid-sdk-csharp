# Lusid.Sdk.Model.ShareClassPnlBreakdown
The breakdown of PnL for a Share Class on a specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApportionedNonClassSpecificPnl** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for PnL within the queried period not explicitly allocated to any share class but has been apportioned to the share class. | 
**ClassPnl** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for PnL specific to the share class within the queried period. | 
**TotalPnl** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for the sum of class PnL and PnL not specific to a class within the queried period. | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

