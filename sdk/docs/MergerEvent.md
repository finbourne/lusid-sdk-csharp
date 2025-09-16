# Lusid.Sdk.Model.MergerEvent
Merger Event (MRGR).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent | 
**AnnouncementDate** | **DateTimeOffset?** | The date the merger is announced. | [optional] 
**CashAndSecurityOfferElections** | [**List&lt;CashAndSecurityOfferElection&gt;**](CashAndSecurityOfferElection.md) | List of possible CashAndSecurityOfferElections for this merger event | [optional] 
**CashOfferElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) | List of possible CashOfferElections for this merger event | [optional] 
**ExDate** | **DateTimeOffset** | The first date on which the holder of record of the original shares has entitled ownership of the new shares. | [optional] 
**FractionalUnitsCashCurrency** | **string** | Optional. Used in calculating cash-in-lieu of fractional shares. | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | Optional. Used in calculating cash-in-lieu of fractional shares. | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**PaymentDate** | **DateTimeOffset** | Date on which the merger takes place. | [optional] 
**RecordDate** | **DateTimeOffset?** | Optional. Date you have to be the holder of record of the original shares in order to receive the new shares. | [optional] 
**SecurityOfferElections** | [**List&lt;SecurityOfferElection&gt;**](SecurityOfferElection.md) | List of possible SecurityOfferElections for this merger event | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<CashAndSecurityOfferElection> cashAndSecurityOfferElections = new List<CashAndSecurityOfferElection>();
List<CashOfferElection> cashOfferElections = new List<CashOfferElection>();
string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";
NewInstrument newInstrument = new NewInstrument();
List<SecurityOfferElection> securityOfferElections = new List<SecurityOfferElection>();

MergerEvent mergerEventInstance = new MergerEvent(
    announcementDate: announcementDate,
    cashAndSecurityOfferElections: cashAndSecurityOfferElections,
    cashOfferElections: cashOfferElections,
    exDate: exDate,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    newInstrument: newInstrument,
    paymentDate: paymentDate,
    recordDate: recordDate,
    securityOfferElections: securityOfferElections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
