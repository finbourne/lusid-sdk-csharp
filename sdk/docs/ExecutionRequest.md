
# Lusid.Sdk.Model.ExecutionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionId** | **string** | The unique identifier of the Execution Report (8) message as assigned by sell-side. FIX field 17. | 
**Side** | **string** | The side of the order. FIX field 54. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | A set of instrument identifiers that can resolve the execution to a unique instrument. | 
**TransactionTime** | **DateTimeOffset?** | Time of execution/order creation. FIX field 60. | 
**LastShares** | **decimal?** | Quantity (e.g. shares) bought/sold on this (last) fill. FIX field 32. | 
**LastPx** | **decimal?** | Price of this (last) fill. FIX field 31. | 
**Currency** | **string** | The currency used for the price. FIX field 15. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

