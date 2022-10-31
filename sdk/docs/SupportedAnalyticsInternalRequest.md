# Lusid.Sdk.Model.SupportedAnalyticsInternalRequest
The request body for the SupportedAnalyticsInternal endpoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeAllAddresses** | **bool** | If true, then we show every possible address key, otherwise we show the address keys specified in addresses array. | 
**Addresses** | **List&lt;string&gt;** | Address keys specified here will be included in the response to the call, which will include details on whether those keys are supported. | [optional] 
**GroupBy** | **List&lt;string&gt;** | The address keys to group by. | 
**ShowTestCounts** | **bool** | If true, returns an integer matrix showing test counts for each address.  If false, masks to a boolean matrix representing whether an address is supported or unsupported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

