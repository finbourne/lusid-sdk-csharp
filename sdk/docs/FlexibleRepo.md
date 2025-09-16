# Lusid.Sdk.Model.FlexibleRepo
Lusid representation of a repurchase agreement, where one party sells some collateral and agrees to re-buy it at a later date for some given price.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**MaturityDate** | **DateTimeOffset?** | The maturity date of the instrument. This is the date at which the repurchase will occur for a TermRepo.  Optional for OpenRepo, but if not provided, defaults to the StartDate plus a long period (e.g. 2099-12-31). | [optional] 
**BuyerOrSeller** | **string** | Is the user the Buyer or the Seller of this repo?  Every repo agreement has two sides, a buyer and a seller.  The Buyer pays the PurchasePrice to the Seller in exchange for legal ownership of the collateral.  At Maturity, the Buyer then receives the RepurchasePrice in exchange for returning legal ownership of the collateral.  Controls the direction of purchase and repurchase cashflows, as well as the recipient of cashflows from the collateral.    Supported string (enumeration) values are: [Buyer, Seller]. | 
**RepoCcy** | **string** | Currency of the purchase and repurchase prices. May differ from the currencies on any collateral. | 
**RepoType** | **string** | The type of the repurchase agreement, Open or Term.  If Term, the repurchase automatically takes place at Maturity.  If Open, the agreement is rolled by the given tenor, and an interest cashflow is paid out with each roll,  unless manually triggered by a FlexibleRepoFullClosureEvent.    Supported string (enumeration) values are: [OpenRepo, TermRepo]. | 
**AccrualBasis** | **string** | For calculation of interest, the accrual day count to be used.  Required if no RepoRateSchedules are provided.  If both RepoRateSchedules and AccrualBasis are provided,  then AccrualBasis will take precedence.    Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM]. | [optional] 
**Collateral** | [**Collateral**](Collateral.md) |  | [optional] 
**Haircut** | **decimal?** | Haircut on the value of the collateral, used to calculate PurchasePrice if not provided directly.  Haircut or Margin should be specified if PurchasePrice is not specified. | [optional] 
**Margin** | **decimal?** | Initial margin on the value of the collateral, used to calculate PurchasePrice if not provided directly.  Haircut or Margin should be specified if PurchasePrice is not specified. | [optional] 
**OpenRepoRollingPeriod** | **string** | Required if the RepoType is Open.  The tenor representing the mandatory roll period if the FlexibleRepo is not manually matured.  If a user matures the FlexibleRepo via an instrument event, then the repurchase will delay until the end of this rolling period.  Generally this is set to 1D (one day), i.e. the repurchase will occur on the same day as the instrument event,  though any valid tenor is accepted with TenorUnit set to Day, Week, Month, or Year.  Note that TenorUnit T is not accepted here. | [optional] 
**PurchasePrice** | **decimal?** | The initial purchase price of the collateral.  If provided directly in this field, then Collateral.CollateralValue,  Haircut, and Margin should not be provided. | [optional] 
**RepoRateSchedules** | [**List&lt;Schedule&gt;**](Schedule.md) | Schedules used to calculate the repurchase price and any interest payments on the FlexibleRepo.  Only one schedule may be provided, and must be of type FixedSchedule or FloatSchedule.  If RepoType is OpenRepo, a FixedSchedule or FloatSchedule must be provided to calculate the expected Repo Rate,  and RepurchasePrice must be omitted.  If RepoType is TermRepo, only one of RepurchasePrice and RepoRateSchedules should be provided.  If a RepoRateSchedule is provided on a TermRepo, the PaymentFrequency in the FlowConventions should be 1T.  StubType must be set to None, and no ExDividend configuration should be provided. | [optional] 
**RepurchasePrice** | **decimal?** | The repurchase price of the repo, if known.  Only one of RepurchasePrice and RepoRateSchedules should be provided.  In the case of an OpenRepo, RepurchasePrice should not be provided,  and RepoRateSchedules should be provided instead in order to calculate the RepoRate. | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 
**TradingConventions** | [**TradingConventions**](TradingConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string buyerOrSeller = "buyerOrSeller";
string repoCcy = "repoCcy";
string repoType = "repoType";
string accrualBasis = "example accrualBasis";
Collateral? collateral = new Collateral();

string openRepoRollingPeriod = "example openRepoRollingPeriod";
List<Schedule> repoRateSchedules = new List<Schedule>();
TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();

TradingConventions? tradingConventions = new TradingConventions();


FlexibleRepo flexibleRepoInstance = new FlexibleRepo(
    startDate: startDate,
    maturityDate: maturityDate,
    buyerOrSeller: buyerOrSeller,
    repoCcy: repoCcy,
    repoType: repoType,
    accrualBasis: accrualBasis,
    collateral: collateral,
    haircut: haircut,
    margin: margin,
    openRepoRollingPeriod: openRepoRollingPeriod,
    purchasePrice: purchasePrice,
    repoRateSchedules: repoRateSchedules,
    repurchasePrice: repurchasePrice,
    timeZoneConventions: timeZoneConventions,
    tradingConventions: tradingConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
