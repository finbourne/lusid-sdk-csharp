# Lusid.Sdk.Model.CallOnIntermediateSecuritiesEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpiryDate** | **DateTimeOffset** | The date on which the issue ends. | 
**PaymentDate** | **DateTimeOffset** | The payment date of the event. | 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**Price** | **decimal** | The price at which new units are purchased. | 
**ExerciseCurrency** | **string** | The currency of the exercise. | 
**OptionExerciseElections** | [**List&lt;OptionExerciseElection&gt;**](OptionExerciseElection.md) | Option exercise election for this event. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | Lapse election for this event. | [optional] 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, ProtectionPayoutCashFlowEvent | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

