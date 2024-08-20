# Lusid.Sdk.Model.SwapCashFlowEvent
Definition of a swap cash flow event.  This event describes the cashflow generated from either an interest rate swap or inflation swap instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent | 
**ExDate** | **DateTimeOffset** | The ex-dividend date of the cashflow. | 
**PaymentDate** | **DateTimeOffset** | The payment date of the cashflow. | 
**Currency** | **string** | The currency in which the cashflow is paid. | 
**CashFlowPerUnit** | **decimal** | The cashflow amount received for each unit of the instrument held on the ex date. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

