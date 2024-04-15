# Lusid.Sdk.Model.ResetEvent
Definition of a reset event.  This is an event that describes a reset or fixing for an instrument such as the floating payment on  a swap cash flow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent | 
**Value** | **decimal?** | The quantity associated with the reset. This will only be populated if the information is known. | [optional] 
**ResetType** | **string** | The type of the reset; e.g. RIC, Currency-pair | 
**FixingSource** | **string** | Fixing identification source, if available. | [optional] 
**FixingDate** | **DateTimeOffset** | The date the reset fixes, or is observed upon. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

