# Lusid.Sdk.Model.BondCouponEvent
Definition of a Bond Coupon Event  This is an event that describes the occurence of a cashflow due to a fixed rate bond coupon payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent | 
**ExDate** | **DateTimeOffset** | Ex-Dividend date of the coupon payment | 
**PaymentDate** | **DateTimeOffset** | Payment date of the coupon payment | 
**Currency** | **string** | Currency of the coupon payment | 
**CouponPerUnit** | **decimal** | CouponRate*Principal | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

