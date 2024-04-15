# Lusid.Sdk.Model.TriggerEvent
Definition of a trigger event.  This is an event that occurs on transformation of an option instrument being  triggered by a barrier/touch price level being hit by the underlying asset.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent | 
**Level** | **decimal** | The underlying price level that triggers the event | 
**TriggerType** | **string** | The type of the trigger; valid options are Knock-In, Knock-Out, Touch or No-Touch | 
**TriggerDirection** | **string** | The direction of the trigger; valid options are Up and Down | 
**TriggerDate** | **DateTimeOffset** | The date the trigger happens at. | 
**MaturityDate** | **DateTimeOffset** | The date the trigger takes effect. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

