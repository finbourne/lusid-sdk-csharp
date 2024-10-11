# Lusid.Sdk.Model.CdxCreditEvent
Definition of a credit event for credit default swap index (CDX) instruments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent | 
**EffectiveDate** | **DateTimeOffset** | The date of the credit default - i.e. date on which the debt issuer defaulted on its repayment obligation. | 
**AuctionDate** | **DateTimeOffset?** | The date of the credit event auction - i.e. date on which the defaulted debt is sold via auction, and a recovery rate determined. | [optional] 
**RecoveryRate** | **decimal?** | The fraction of the defaulted debt that can be recovered. | [optional] 
**ConstituentWeight** | **decimal** | The relative weight of the CDX constituent. | 
**ConstituentReference** | **string** | Reference value used to identify the CDX constituent. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

