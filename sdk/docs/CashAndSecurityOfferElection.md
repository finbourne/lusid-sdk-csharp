# Lusid.Sdk.Model.CashAndSecurityOfferElection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CashOfferCurrency** | **string** | Currency of the cash offer | 
**CashOfferPrice** | **decimal** | Price per share of the cash offer | 
**CostFactor** | **decimal?** | Optional. The fraction of cost that is transferred from the existing shares to the new shares. | [optional] 
**ElectionKey** | **string** | Unique key associated to this election. | 
**IsChosen** | **bool** | Is this the election that has been explicitly chosen from multiple options. | [optional] 
**IsDefault** | **bool** | Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

