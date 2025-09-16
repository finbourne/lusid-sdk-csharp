# Lusid.Sdk.Model.StockSplitEvent
A split in the company's shares. Shareholders are given additional company shares based on the terms of the stock split.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent | 
**PaymentDate** | **DateTimeOffset** | Date on which the stock split takes effect. | [optional] 
**ExDate** | **DateTimeOffset** | The first date on which the shares will trade at the post-split price. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**RecordDate** | **DateTimeOffset?** | Date you have to be the holder of record in order to receive the additional shares. | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | Date the stock split was announced. | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | The cash price per unit paid in lieu when fractional units can not be distributed. | [optional] 
**FractionalUnitsCashCurrency** | **string** | The currency of the cash paid in lieu of fractional units. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

UnitsRatio unitsRatio = new UnitsRatio();
string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";

StockSplitEvent stockSplitEventInstance = new StockSplitEvent(
    paymentDate: paymentDate,
    exDate: exDate,
    unitsRatio: unitsRatio,
    recordDate: recordDate,
    announcementDate: announcementDate,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
