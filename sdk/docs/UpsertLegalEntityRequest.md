# Lusid.Sdk.Model.UpsertLegalEntityRequest
Request to create or update an legal entity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifiers** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The identifiers the legal entity will be upserted with.The provided keys should be idTypeScope, idTypeCode, code | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties associated to the Legal Entity. | [optional] 
**DisplayName** | **string** | The display name of the Legal Entity | 
**Description** | **string** | The description of the Legal Entity | [optional] 
**CounterpartyRiskInformation** | [**CounterpartyRiskInformation**](CounterpartyRiskInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

