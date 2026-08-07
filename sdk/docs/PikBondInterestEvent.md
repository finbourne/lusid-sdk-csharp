# Lusid.Sdk.Model.PikBondInterestEvent
Definition of a PIK Bond Interest Event  This is an event that describes the paid-in-kind portion of a coupon period on a  Payment-in-Kind ComplexBond that is settled by delivering units of another instrument, rather  than in cash or by capitalising the amount into the bond's current face. The interest amount is  converted to units of the deliverable at the delivery price and added to the deliverable's  holding as a new tax lot; the paying bond's own units and current face are unchanged.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent. | 
**ExDate** | **DateTimeOffset** | The ex date (entitlement date) of the interest | [optional] 
**PaymentDate** | **DateTimeOffset** | The date on which the securities are delivered | [optional] 
**Currency** | **string** | The currency in which the interest amount is expressed | 
**CouponPerUnit** | **decimal?** | The interest amount, in cash terms, per unit of the held bond&#39;s current face | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**DeliveryPrice** | **decimal?** | The clean price the deliverable is delivered at, as a percentage of its nominal per unit  following bond market convention: 100 is par and 98.5 is a one-and-a-half point discount.  This is not a cash amount per unit. Null is par. It governs how many units the interest  amount buys, not how much face each of those units carries. | [optional] 
**DeliveredContractSize** | **decimal?** | The deliverable&#39;s nominal per unit - its contract size. Null is 1. | [optional] 
**DeliveredCurrentFacePerUnit** | **decimal?** | The current face each delivered unit carries. Null falls back to DeliveredContractSize;  supply it for a seasoned note whose face has already amortised away from its contract size.  When both are absent the delivered lot carries no current face, which is how a deliverable  that is not current-face-based, such as an equity, is expressed. | [optional] 
**DeliveredAccruedPerUnit** | **decimal?** | Interest accrued on the deliverable per delivered unit, settled alongside the clean price  when a seasoned note is delivered mid-period. Null is a fresh issue with nothing accrued. | [optional] 
**FractionalUnitsRoundingConvention** | **string** | The convention used to round the units entitlement. Defaults to Floor.                Supported string (enumeration) values are: [Floor, Ceiling, RoundHalfUp, RoundHalfDown, RoundToDecimalPlaces, BankerRounding]. Available values: Floor, Ceiling, RoundHalfUp, RoundHalfDown, RoundToDecimalPlaces, BuyUp, BankerRounding. | [optional] 
**FractionalUnitsDecimalPlaces** | **int?** | The number of decimal places to round to when FractionalUnitsRoundingConvention is RoundToDecimalPlaces. | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | The cash price paid in lieu of the units that could not be delivered. Supplying it, together  with FractionalUnitsCashCurrency, is what settles the undelivered fraction in cash; leave  both absent and the fraction is simply not paid. | [optional] 
**FractionalUnitsCashCurrency** | **string** | The currency of the cash paid in lieu of the undelivered fraction. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "currency";
NewInstrument newInstrument = new NewInstrument();
string fractionalUnitsRoundingConvention = "example fractionalUnitsRoundingConvention";
string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";

PikBondInterestEvent pikBondInterestEventInstance = new PikBondInterestEvent(
    exDate: exDate,
    paymentDate: paymentDate,
    currency: currency,
    couponPerUnit: couponPerUnit,
    newInstrument: newInstrument,
    deliveryPrice: deliveryPrice,
    deliveredContractSize: deliveredContractSize,
    deliveredCurrentFacePerUnit: deliveredCurrentFacePerUnit,
    deliveredAccruedPerUnit: deliveredAccruedPerUnit,
    fractionalUnitsRoundingConvention: fractionalUnitsRoundingConvention,
    fractionalUnitsDecimalPlaces: fractionalUnitsDecimalPlaces,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
