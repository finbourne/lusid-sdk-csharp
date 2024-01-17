# Lusid.Sdk.Model.TransitionEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnnouncementDate** | **DateTimeOffset** | The announcement date of the corporate action | [optional] 
**ExDate** | **DateTimeOffset** | The ex date of the corporate action | [optional] 
**RecordDate** | **DateTimeOffset** | The record date of the corporate action | [optional] 
**PaymentDate** | **DateTimeOffset** | The payment date of the corporate action | [optional] 
**InputTransition** | [**InputTransition**](InputTransition.md) |  | [optional] 
**OutputTransitions** | [**List&lt;OutputTransition&gt;**](OutputTransition.md) | The resulting transitions from this event | [optional] 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

