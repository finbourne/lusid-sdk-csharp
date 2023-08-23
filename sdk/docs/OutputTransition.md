# Lusid.Sdk.Model.OutputTransition
A 'transition' within a corporate action, representing an output transition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | 
**UnitsFactor** | **decimal** | The factor to scale units by | 
**CostFactor** | **decimal** | The factor to scale cost by | 
**LusidInstrumentId** | **string** | LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers | [optional] [readonly] 
**InstrumentScope** | **string** | The scope in which the instrument lies. | [optional] [readonly] 
**Rounding** | [**RoundingConfiguration**](RoundingConfiguration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

