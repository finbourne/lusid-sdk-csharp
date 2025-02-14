# Lusid.Sdk.Model.OptionExercisePhysicalEvent
Event for physical option exercises.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent | 
**ExerciseDate** | **DateTimeOffset?** | The exercise date of the option. | [optional] 
**DeliveryDate** | **DateTimeOffset?** | The delivery date of the option. | [optional] 
**ExerciseType** | **string** | The optionality type of the underlying option e.g. American, European.    Supported string (enumeration) values are: [European, Bermudan, American]. | 
**MaturityDate** | **DateTimeOffset** | The maturity date of the option. | 
**Moneyness** | **string** | The moneyness of the option e.g. InTheMoney, OutOfTheMoney.    Supported string (enumeration) values are: [InTheMoney, OutOfTheMoney, AtTheMoney]. | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**OptionExerciseElections** | [**List&lt;OptionExerciseElection&gt;**](OptionExerciseElection.md) | Option exercise election for this OptionExercisePhysicalEvent. | [optional] 
**OptionType** | **string** | Type of optionality that is present e.g. call, put.    Supported string (enumeration) values are: [Call, Put]. | 
**StartDate** | **DateTimeOffset** | The trade date of the option. | 
**StrikeCurrency** | **string** | The strike currency of the equity option. | 
**StrikePerUnit** | **decimal** | The strike of the equity option times the number of shares to exchange if exercised. | 
**UnderlyingValuePerUnit** | **decimal?** | The underlying price times the number of shares to exchange if exercised. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

