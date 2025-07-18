# Lusid.Sdk.Model.FxForward
LUSID representation of an FX Forward.  Including FX Spot and Non-Deliverable Forwards.                This instrument has multiple legs, to see how legs are used in LUSID see [knowledge base article KA-02252](https://support.lusid.com/knowledgebase/article/KA-02252).                | Leg Index | Leg Identifier | Description |  | - -- -- -- -- | - -- -- -- -- -- -- - | - -- -- -- -- -- |  | 1 | DomesticLeg | Cash flows in the domestic currency of the forward. |  | 2 | ForeignLeg | Cash flows in the foreign currency of the forward (not present for non-deliverable forwards). |

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**MaturityDate** | **DateTimeOffset** | The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. | 
**DomAmount** | **decimal** | The amount that is to be paid in the domestic currency on the maturity date. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**FgnAmount** | **decimal** | The amount that is to be paid in the foreign currency on the maturity date. | 
**FgnCcy** | **string** | The foreign (other) currency of the instrument. In the NDF case, only payments are made in the domestic currency.  For the outright forward, currencies are exchanged. | 
**RefSpotRate** | **decimal** | The reference Fx Spot rate for currency pair Foreign-Domestic that was seen on the trade start date (time). | [optional] 
**IsNdf** | **bool** | Is the contract an Fx-Forward of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the domestic currency based on the change in fx-rate vs  a reference rate is used. | [optional] 
**FixingDate** | **DateTimeOffset** | The fixing date. | [optional] 
**SettlementCcy** | **string** | The settlement currency.  If provided, present value will be calculated in settlement currency, otherwise the domestic currency. Applies only to non-deliverable FX Forwards. | [optional] 
**BookedAsSpot** | **bool** | Boolean flag for FX Forward transactions booked with Spot settlement. This will default to False if not provided.  For information purposes only, this does not impact LUSID valuation, analytics, cashflows or events, but may be used by third party vendors. | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

