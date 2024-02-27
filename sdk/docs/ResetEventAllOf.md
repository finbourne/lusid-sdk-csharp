# Lusid.Sdk.Model.ResetEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **decimal?** | The quantity associated with the reset. This will only be populated if the information is known. | [optional] 
**ResetType** | **string** | The type of the reset; e.g. RIC, Currency-pair | 
**FixingSource** | **string** | Fixing identification source, if available. | [optional] 
**FixingDate** | **DateTimeOffset** | The date the reset fixes, or is observed upon. | 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

