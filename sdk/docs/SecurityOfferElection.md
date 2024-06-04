# Lusid.Sdk.Model.SecurityOfferElection
Security election for Events that result in equity via a merger

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** | Unique key associated to this election. | 
**IsChosen** | **bool** | Is this the election that has been explicitly chosen from multiple options. | [optional] 
**IsDefault** | **bool** | Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

