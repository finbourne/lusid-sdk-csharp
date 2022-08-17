# Lusid.Sdk.Model.A2BMovementRecord
A2B Movement Record - shows A2B category based changes relating to a specific movement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**HoldingType** | **string** | The code for the type of the holding e.g. P, B, C, R, F etc. | [optional] 
**InstrumentScope** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that the holding is in. | [optional] 
**InstrumentUid** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that the holding is in. | [optional] 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio. | [optional] 
**Currency** | **string** | The holding currency. | [optional] 
**TransactionId** | **string** | The unique identifier for the transaction. | [optional] 
**MovementName** | **string** | The name of the movement. | [optional] 
**EffectiveDate** | **DateTimeOffset** | The date of the movement. | [optional] 
**Units** | **decimal** | The number of units of the instrument that are affected by the movement. | [optional] 
**Start** | [**A2BCategory**](A2BCategory.md) |  | [optional] 
**Flows** | [**A2BCategory**](A2BCategory.md) |  | [optional] 
**Gains** | [**A2BCategory**](A2BCategory.md) |  | [optional] 
**Carry** | [**A2BCategory**](A2BCategory.md) |  | [optional] 
**End** | [**A2BCategory**](A2BCategory.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; domain. | [optional] 
**GroupId** | **string** | Arbitrary string that can be used to cross reference an entry in the A2B report with activity in the A2B-Movements. This should be used purely as a token. The content should not be relied upon. | [optional] 
**Errors** | [**List&lt;ResponseMetaData&gt;**](ResponseMetaData.md) | Any errors with the record are reported here. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

