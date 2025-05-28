# Lusid.Sdk.Model.CalculateOrderDatesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, TransferAgencyDates&gt;**](TransferAgencyDates.md) | A dictionary of successful date calculations, keyed by the request key. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A dictionary of failed date calculations, keyed by the request key, containing the error details of any failures that occurred during the calculation. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

