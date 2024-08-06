# Lusid.Sdk.Model.BatchAdjustHoldingsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, HoldingAdjustmentWithDate&gt;**](HoldingAdjustmentWithDate.md) | The holdings which have been successfully adjusted. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The holdings that could not be adjusted along with a reason for their failure. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Contains warnings related to adjusted holdings | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

