# Lusid.Sdk.Model.BonusIssueEvent
Representation of a Bonus Issue corporate action.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent | 
**AnnouncementDate** | **DateTimeOffset?** | The date the Bonus Issue is announced. | [optional] 
**ExDate** | **DateTimeOffset** | The ex-date of the Bonus Issue. | [optional] 
**RecordDate** | **DateTimeOffset?** | The record date of the Bonus Issue. | [optional] 
**PaymentDate** | **DateTimeOffset** | The date the Bonus Issue is executed. | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | Optional. Used in calculating cash-in-lieu of fractional shares. | [optional] 
**FractionalUnitsCashCurrency** | **string** | Optional. Used in calculating cash-in-lieu of fractional shares. | [optional] 
**SecurityOfferElections** | [**List&lt;SecurityOfferElection&gt;**](SecurityOfferElection.md) | Possible SecurityElections for this Bonus Issue event, if any. | [optional] 
**CashOfferElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) | Possible CashOfferElections for this Bonus Issue event, if any. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | Possible LapseElections for this Bonus Issue event, if any. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

