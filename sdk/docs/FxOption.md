# Lusid.Sdk.Model.FxOption
Lusid-ibor DTO representation of a plain vanilla FX Option instrument.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **DateTimeOffset** | The start date of the option. | 
**OptionMaturityDate** | **DateTimeOffset** | The maturity date of the option. | 
**OptionSettlementDate** | **DateTimeOffset** | The settlement date of the option. | 
**IsDeliveryNotCash** | **bool** | True of the option is settled in cash false if delivery. | 
**IsCallNotPut** | **bool** | True if the option is a call, false if the option is a put. | 
**Strike** | **double** | The strike of the option. | 
**DomCcy** | **string** | The domestic currency of the FX. | 
**FgnCcy** | **string** | The foreign currency of the FX. | 
**InstrumentType** | **string** | Instrument type, must be property for JSON. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

