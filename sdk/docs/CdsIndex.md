# Lusid.Sdk.Model.CdsIndex
LUSID representation of a Credit Default Swap Index (CDX).                This instrument has multiple legs, to see how legs are used in LUSID see [knowledge base article KA-02252](https://support.lusid.com/knowledgebase/article/KA-02252).                | Leg Index | Leg Identifier | Description |  | - -- -- -- -- | - -- -- -- -- -- -- - | - -- -- -- -- -- |  | 1 | ProtectionLeg | Payments made by the protection seller in the case of default across all CDS instruments in the index. |  | 2 | PremiumLeg | The premium payments made by the protection buyer across all CDS instruments in the index. |  | 3 | AdditionalPayments | Cash flows relating to any additional payments (optional). |

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward, PreferredShare, CapitalInterest. | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**MaturityDate** | **DateTimeOffset** | The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. | 
**FlowConventions** | [**CdsFlowConventions**](CdsFlowConventions.md) |  | [optional] 
**CouponRate** | **decimal** | The coupon rate paid on each payment date of the premium leg as a fraction of 100 percent, e.g. \&quot;0.05\&quot; meaning 500 basis points or 5%.  For a standard corporate CDS (North American) this must be either 100bps or 500bps. | 
**Identifiers** | **Dictionary&lt;string, string&gt;** | External market codes and identifiers for the cds index, e.g. a RED code, BBG ID or ICE code. | 
**Basket** | [**Basket**](Basket.md) |  | [optional] 
**ConventionName** | [**FlowConventionName**](FlowConventionName.md) |  | [optional] 
**Notional** | **decimal** | The notional quantity that applies to both the premium and protection legs. | 
**IsNonStandard** | **bool** | By default IsNonStandard is false, and the contract follows the IMM convention: the roll and payment  frequencies must be 3M or 6M, and the start and maturity dates are rolled onto IMM dates  (the 20th of March, June, September or December).  If IsNonStandard&#x3D;true, the premium schedule uses the stated start and maturity dates and any payment  frequency is accepted. The payment dates roll back from the maturity, so a term that is not a whole  number of payment periods has a short first period. | [optional] 
**AdditionalPayments** | [**List&lt;AdditionalPayment&gt;**](AdditionalPayment.md) | Optional additional payments at a given date e.g. to level off an uneven swap.  The dates must be distinct and either all payments are Pay or all payments are Receive. | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

CdsFlowConventions? flowConventions = new CdsFlowConventions();
decimal couponRate = "couponRate";

Dictionary<string, string> identifiers = new Dictionary<string, string>();
Basket? basket = new Basket();

FlowConventionName? conventionName = new FlowConventionName();
decimal notional = "notional";

bool isNonStandard = //"True";
List<AdditionalPayment> additionalPayments = new List<AdditionalPayment>();
TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();


CdsIndex cdsIndexInstance = new CdsIndex(
    startDate: startDate,
    maturityDate: maturityDate,
    flowConventions: flowConventions,
    couponRate: couponRate,
    identifiers: identifiers,
    basket: basket,
    conventionName: conventionName,
    notional: notional,
    isNonStandard: isNonStandard,
    additionalPayments: additionalPayments,
    timeZoneConventions: timeZoneConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
