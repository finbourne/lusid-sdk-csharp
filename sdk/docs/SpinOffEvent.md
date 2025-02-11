# Lusid.Sdk.Model.SpinOffEvent
Spin-off event (SOFF), representing the distribution of securities issued by another company.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent | 
**AnnouncementDate** | **DateTimeOffset?** | Optional.  The date the spin-off is announced. | [optional] 
**ExDate** | **DateTimeOffset** | The first date on which the holder of record has entitled ownership of the new shares. | 
**RecordDate** | **DateTimeOffset?** | Optional.  Date you have to be the holder of record in order to receive the additional shares. | [optional] 
**PaymentDate** | **DateTimeOffset** | Date on which the distribution of shares takes place. | 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**CostFactor** | **decimal?** | Optional. The fraction of cost that is transferred from the existing shares to the new shares. | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | Optional. Used in calculating cash-in-lieu of fractional shares. | [optional] 
**FractionalUnitsCashCurrency** | **string** | Optional. Used in calculating cash-in-lieu of fractional shares. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

