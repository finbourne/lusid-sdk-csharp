# Lusid.Sdk.Model.TriggerEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Level** | **decimal** | The underlying price level that triggers the event | 
**TriggerType** | **string** | The type of the trigger; valid options are Knock-In, Knock-Out, Touch or No-Touch | 
**TriggerDirection** | **string** | The direction of the trigger; valid options are Up and Down | 
**TriggerDate** | **DateTimeOffset** | The date the trigger happens at. | 
**MaturityDate** | **DateTimeOffset** | The date the trigger takes effect. | 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

