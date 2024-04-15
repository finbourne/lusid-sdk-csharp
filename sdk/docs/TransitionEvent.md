# Lusid.Sdk.Model.TransitionEvent
A 'transition' within a corporate action, representing a set of output movements paired to a single input position

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent | 
**AnnouncementDate** | **DateTimeOffset** | The announcement date of the corporate action | [optional] 
**ExDate** | **DateTimeOffset** | The ex date of the corporate action | [optional] 
**RecordDate** | **DateTimeOffset** | The record date of the corporate action | [optional] 
**PaymentDate** | **DateTimeOffset** | The payment date of the corporate action | [optional] 
**InputTransition** | [**InputTransition**](InputTransition.md) |  | [optional] 
**OutputTransitions** | [**List&lt;OutputTransition&gt;**](OutputTransition.md) | The resulting transitions from this event | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

