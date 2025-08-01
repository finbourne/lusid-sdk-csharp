# Lusid.Sdk.Model.FxForwardSettlementEvent
Settlement for FX Forward, including NDF and deliverable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent | 
**MaturityDate** | **DateTimeOffset** | Maturity date of the forward | [optional] 
**DomAmountPerUnit** | **decimal** | Amount per unit in the DomCcy (domestic currency) | 
**DomCcy** | **string** | The domestic currency of the forward | 
**FgnAmountPerUnit** | **decimal** | Amount per unit in the FgnCcy (foreign currency) | 
**FgnCcy** | **string** | The foreign currency of the forward. | 
**IsNdf** | **bool** | Is this settlement corresponding to a deliverable forward, or an NDF | 
**FixingDate** | **DateTimeOffset?** | Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  Date of the FxRate fixings. | [optional] 
**SettlementCcy** | **string** | Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  May be set to either DomCcy or FgnCcy, or a third currency. | [optional] 
**CashFlowPerUnit** | **decimal?** | Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  CashFlow per unit.  Paid in the SettlementCcy. | [optional] 
**DomesticToForeignRate** | **decimal?** | Domestic currency to foreign currency FX rate.  Not required, only used to override quotes. | [optional] 
**DomesticToSettlementRate** | **decimal?** | Domestic currency to settlement currency FX rate  Not required, only used to override quotes. | [optional] 
**ForeignToSettlementRate** | **decimal?** | Foreign currency to settlement currency FX rate  Not required, only used to override quotes. | [optional] [readonly] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

