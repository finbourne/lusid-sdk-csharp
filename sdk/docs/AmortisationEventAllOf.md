# Lusid.Sdk.Model.AmortisationEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountReduced** | **decimal** | The amount reduced in this amortisation event.  That is, the difference between the previous notional amount and the current notional amount as set in this event. | 
**DomCcy** | **string** | Domestic currency of the originating instrument | 
**PayReceive** | **string** | Is this event in relation to the Pay or Receive leg | 
**EventStatus** | **string** | What is the event status, is it a known (ie historic) or unknown (ie projected) event? | 
**PaymentDate** | **DateTimeOffset** | The date the principal payment is to be made. | 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

