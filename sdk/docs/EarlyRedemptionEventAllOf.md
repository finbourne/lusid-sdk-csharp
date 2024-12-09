# Lusid.Sdk.Model.EarlyRedemptionEventAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveDate** | **DateTimeOffset?** | Date of redemption.  For internally generated European callables, this is set to the exercise date.  For internally generated American callables, this is set to the start of the exercise period. | [optional] 
**Currency** | **string** | Currency of the redemption. | 
**EarlyRedemptionElections** | [**List&lt;EarlyRedemptionElection&gt;**](EarlyRedemptionElection.md) | EarlyRedemptionElection for the redemption.  Used to trigger the redemption. | 
**RedemptionPercentage** | **decimal** | Percentage of the original issue that is redeemed, where 0.5 implies 50%.  Defaults to 1 if not set.  Must be between 0 and 1. | [optional] 
**PricePerUnit** | **decimal?** | The price, or strike, that each unit is redeemed at. | [optional] 
**AccruedInterestPerUnit** | **decimal?** | Unpaid accrued interest also repaid as part of the redemption, per unit.  Optional field.  If left empty, will be resolved internally by calculating the accrued owed on the EffectiveDate.  This process may require additional market data. | [optional] 
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

