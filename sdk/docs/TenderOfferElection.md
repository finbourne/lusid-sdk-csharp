# Lusid.Sdk.Model.TenderOfferElection
Election for events that result in cash via a merger or acquisition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenderOfferCurrency** | **string** | Currency of the cash offer | 
**TenderOfferPrice** | **decimal** | Price per share of the cash offer | 
**ElectionKey** | **string** | Unique key associated to this election. | 
**IsChosen** | **bool** | Is this the election that has been explicitly chosen from multiple options. | [optional] 
**IsDefault** | **bool** | Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

