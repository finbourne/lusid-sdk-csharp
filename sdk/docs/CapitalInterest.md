# Lusid.Sdk.Model.CapitalInterest
LUSID representation of a CapitalInterest.  A CapitalInterest represents an investor's interest in a single commitment line to a  private-markets fund: one instrument per (fund, investor, commitment line). Units act as  a liveness flag (1 while the line is open, 0 once closed) and the economics are carried  by cost, fair value and the running capital balances rather than by quantity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward, PreferredShare, CapitalInterest. | 
**QuantityBasis** | **string** | How the quantity of the holding is interpreted. Under the &#39;Anchored&#39; basis, units act as a  liveness flag: 1 while the commitment line is open and 0 once it is closed. Only &#39;Anchored&#39;  is currently supported.                Supported string (enumeration) values are: [Anchored, Unitless]. Available values: Anchored, Unitless. | 
**CommitmentCurrency** | **string** | The currency the commitment is denominated in. May differ from both the fund currency  and the portfolio base currency. | 
**FundEntityId** | **string** | The identifier of the fund entity the commitment is made to. | 
**InvestorEntityId** | **string** | The identifier of the investor entity holding the commitment. | 
**CommitmentLineId** | **string** | The identifier of the commitment line, unique for a given fund and investor. | 
**OriginalCommitment** | **decimal** | The committed amount at inception, in the commitment currency. May be zero for evergreen  funds. This is the original value only; subsequent amendments are carried by the running  capital balances, not by the instrument. | 
**CommitmentDate** | **DateTimeOffset** | The date the commitment closed. | 
**Vintage** | **int?** | The vintage year of the commitment. Defaults to the year of the commitment date. | [optional] 
**CapitalInterestAssetClass** | **string** | The private-markets asset class of the fund the commitment is made to,  for example private equity, venture capital or infrastructure.                Supported string (enumeration) values are: [PrivateEquity, VentureCapital, PrivateCredit, RealAssets, Infrastructure, FundOfFunds, Secondary, CoInvestment, DirectEquity, ShareholderLoan, Other]. Available values: PrivateEquity, VentureCapital, PrivateCredit, RealAssets, Infrastructure, FundOfFunds, Secondary, CoInvestment, DirectEquity, ShareholderLoan, Other. | [optional] 
**ReliefPolicy** | **string** | How distributions from the commitment line are relieved against the cost of the holding.  Defaults to &#39;InstructedCharacter&#39;.                Supported string (enumeration) values are: [InstructedCharacter, CostRecovery, ProportionalToFairValue, ProportionalToPercentageInterest, NoRelief]. Available values: InstructedCharacter, CostRecovery, ProportionalToFairValue, ProportionalToPercentageInterest, NoRelief. | [optional] 
**ReliefRevisionMode** | **string** | How revisions to previously applied distribution relief are handled.  Defaults to &#39;ProspectiveTrueUp&#39;.                Supported string (enumeration) values are: [ProspectiveTrueUp, Restate, Final]. Available values: ProspectiveTrueUp, Restate, Final. | [optional] 
**FairValueSourcePrecedence** | **List&lt;string&gt;** | The order of precedence of the sources a fair value for the interest can be taken from.  Defaults to the reported NAV rolled forward for subsequent capital activity, then cost.                Supported string (enumeration) values for each entry are: [ReportedNav, RollForward, Independent, Cost]. | [optional] 
**TerminationDate** | **DateTimeOffset?** | The expected end of the fund&#39;s life, if known. This is expected rather than contractual  and does not act as a maturity date for the instrument. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string quantityBasis = "quantityBasis";
string commitmentCurrency = "commitmentCurrency";
string fundEntityId = "fundEntityId";
string investorEntityId = "investorEntityId";
string commitmentLineId = "commitmentLineId";decimal originalCommitment = "originalCommitment";

string capitalInterestAssetClass = "example capitalInterestAssetClass";
string reliefPolicy = "example reliefPolicy";
string reliefRevisionMode = "example reliefRevisionMode";
List<string> fairValueSourcePrecedence = new List<string>();

CapitalInterest capitalInterestInstance = new CapitalInterest(
    quantityBasis: quantityBasis,
    commitmentCurrency: commitmentCurrency,
    fundEntityId: fundEntityId,
    investorEntityId: investorEntityId,
    commitmentLineId: commitmentLineId,
    originalCommitment: originalCommitment,
    commitmentDate: commitmentDate,
    vintage: vintage,
    capitalInterestAssetClass: capitalInterestAssetClass,
    reliefPolicy: reliefPolicy,
    reliefRevisionMode: reliefRevisionMode,
    fairValueSourcePrecedence: fairValueSourcePrecedence,
    terminationDate: terminationDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
