# Lusid.Sdk.Model.FundPnlBreakdown
The breakdown of PnL for a Fund on a specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NonClassSpecificPnl** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for PnL within the queried period that is not specific to any share class. | 
**AggregatedClassPnl** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for the sum of class PnL across all share classes in a fund and within the queried period. | 
**TotalPnl** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for the sum of class PnL and PnL not specific to a class within the queried period. | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

