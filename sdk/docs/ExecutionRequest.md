
# Lusid.Sdk.Model.ExecutionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionId** | **string** | FIX Field 17.  Unique execution identifier. | 
**Side** | **string** | FIX Field 54. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | 
**TransactionTime** | **DateTimeOffset?** | FIX field 60.  Time the transaction represented by this ExecutionReport occurred. | 
**LastShares** | **double?** | FIX field 32. | 
**LastPx** | **double?** | FIX field 31. | 
**Currency** | **string** | FIX field 15. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

