# Lusid.Sdk.Model.PlacementUpdateRequest
A request to create or update a Placement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Quantity** | **decimal** | The quantity of given instrument ordered. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this placement. | [optional] 
**Counterparty** | **string** | Optionally specifies the market entity this placement is placed with. | [optional] 
**ExecutionSystem** | **string** | Optionally specifies the execution system in use. | [optional] 
**EntryType** | **string** | Optionally specifies the entry type of this placement. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

