# Lusid.Sdk.Model.CashFlowLineage
Lineage for cash flow value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The instrument type of the instrument to which the cash flow belongs to. When upserting CashFlowValues, this  should be null. | [optional] 
**CashFlowType** | **string** | The cashflow type.When upserting CashFlowValues, this should be null, or one of [Unknown, Coupon, Notional,  Premium, Principal, Protection, Cash] | [optional] 
**InstrumentId** | **string** | The LUID of the instrument to which the cash flow belongs to. When upserting this should be null. | [optional] 
**LegId** | **string** | The leg id to which the cash flow belongs to. | [optional] 
**SourceTransactionId** | **string** | The source transaction of the instrument to which the cash flow belongs to. When upserting this should be null | [optional] 
**PayReceive** | **string** | Does the cash flow belong to the Pay or Receive leg. When upserting this should either be null or one of [Pay, Receive, NotApplicable] | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

