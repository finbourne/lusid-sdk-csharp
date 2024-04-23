# Lusid.Sdk.Model.BondPrincipalEvent
Definition of a Bond Principal Event  This is an event that describes the occurence of a cashflow due to the principal payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent | 
**Currency** | **string** | Currency of the principal payment | 
**ExDate** | **DateTimeOffset** | Ex-Dividend date of the principal payment | 
**PaymentDate** | **DateTimeOffset** | Payment date of the principal payment | 
**PrincipalPerUnit** | **decimal** | Principal per unit | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

