# Lusid.Sdk.Model.UpsertCorporateActionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorporateActionCode** | **string** | The unique identifier of this corporate action | 
**Description** | **string** | The description of the corporate action. | [optional] 
**AnnouncementDate** | **DateTimeOffset** | The announcement date of the corporate action | 
**ExDate** | **DateTimeOffset** | The ex date of the corporate action | 
**RecordDate** | **DateTimeOffset** | The record date of the corporate action | 
**PaymentDate** | **DateTimeOffset** | The payment date of the corporate action | 
**Transitions** | [**List&lt;CorporateActionTransitionRequest&gt;**](CorporateActionTransitionRequest.md) | The transitions that result from this corporate action | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

