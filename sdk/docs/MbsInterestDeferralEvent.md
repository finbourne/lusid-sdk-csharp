# Lusid.Sdk.Model.MbsInterestDeferralEvent
Definition of an MBS Interest Deferral Event  This is an event that describes the occurence of a cashflow due to unpaid interest that was deferred and  capitalised into the outstanding principal balance of a mortgage-backed security.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent | 
**ExDate** | **DateTimeOffset** | The ex date (entitlement date) of the interest payment, usually several weeks prior to the payment date | 
**PaymentDate** | **DateTimeOffset** | The payment date of the interest that is deferred and capitalised | 
**Currency** | **string** | The currency in which the interest amount is notated | 
**InterestPerUnit** | **decimal** | The interest amount to be deferred and capitalised for each unit of the instrument held on the ex date | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

