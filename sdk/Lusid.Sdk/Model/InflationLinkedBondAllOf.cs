/*
 * LUSID API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// InflationLinkedBondAllOf
    /// </summary>
    [DataContract(Name = "InflationLinkedBond_allOf")]
    public partial class InflationLinkedBondAllOf : IEquatable<InflationLinkedBondAllOf>, IValidatableObject
    {
        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentTypeEnum
        {
            /// <summary>
            /// Enum QuotedSecurity for value: QuotedSecurity
            /// </summary>
            [EnumMember(Value = "QuotedSecurity")]
            QuotedSecurity = 1,

            /// <summary>
            /// Enum InterestRateSwap for value: InterestRateSwap
            /// </summary>
            [EnumMember(Value = "InterestRateSwap")]
            InterestRateSwap = 2,

            /// <summary>
            /// Enum FxForward for value: FxForward
            /// </summary>
            [EnumMember(Value = "FxForward")]
            FxForward = 3,

            /// <summary>
            /// Enum Future for value: Future
            /// </summary>
            [EnumMember(Value = "Future")]
            Future = 4,

            /// <summary>
            /// Enum ExoticInstrument for value: ExoticInstrument
            /// </summary>
            [EnumMember(Value = "ExoticInstrument")]
            ExoticInstrument = 5,

            /// <summary>
            /// Enum FxOption for value: FxOption
            /// </summary>
            [EnumMember(Value = "FxOption")]
            FxOption = 6,

            /// <summary>
            /// Enum CreditDefaultSwap for value: CreditDefaultSwap
            /// </summary>
            [EnumMember(Value = "CreditDefaultSwap")]
            CreditDefaultSwap = 7,

            /// <summary>
            /// Enum InterestRateSwaption for value: InterestRateSwaption
            /// </summary>
            [EnumMember(Value = "InterestRateSwaption")]
            InterestRateSwaption = 8,

            /// <summary>
            /// Enum Bond for value: Bond
            /// </summary>
            [EnumMember(Value = "Bond")]
            Bond = 9,

            /// <summary>
            /// Enum EquityOption for value: EquityOption
            /// </summary>
            [EnumMember(Value = "EquityOption")]
            EquityOption = 10,

            /// <summary>
            /// Enum FixedLeg for value: FixedLeg
            /// </summary>
            [EnumMember(Value = "FixedLeg")]
            FixedLeg = 11,

            /// <summary>
            /// Enum FloatingLeg for value: FloatingLeg
            /// </summary>
            [EnumMember(Value = "FloatingLeg")]
            FloatingLeg = 12,

            /// <summary>
            /// Enum BespokeCashFlowsLeg for value: BespokeCashFlowsLeg
            /// </summary>
            [EnumMember(Value = "BespokeCashFlowsLeg")]
            BespokeCashFlowsLeg = 13,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 14,

            /// <summary>
            /// Enum TermDeposit for value: TermDeposit
            /// </summary>
            [EnumMember(Value = "TermDeposit")]
            TermDeposit = 15,

            /// <summary>
            /// Enum ContractForDifference for value: ContractForDifference
            /// </summary>
            [EnumMember(Value = "ContractForDifference")]
            ContractForDifference = 16,

            /// <summary>
            /// Enum EquitySwap for value: EquitySwap
            /// </summary>
            [EnumMember(Value = "EquitySwap")]
            EquitySwap = 17,

            /// <summary>
            /// Enum CashPerpetual for value: CashPerpetual
            /// </summary>
            [EnumMember(Value = "CashPerpetual")]
            CashPerpetual = 18,

            /// <summary>
            /// Enum CapFloor for value: CapFloor
            /// </summary>
            [EnumMember(Value = "CapFloor")]
            CapFloor = 19,

            /// <summary>
            /// Enum CashSettled for value: CashSettled
            /// </summary>
            [EnumMember(Value = "CashSettled")]
            CashSettled = 20,

            /// <summary>
            /// Enum CdsIndex for value: CdsIndex
            /// </summary>
            [EnumMember(Value = "CdsIndex")]
            CdsIndex = 21,

            /// <summary>
            /// Enum Basket for value: Basket
            /// </summary>
            [EnumMember(Value = "Basket")]
            Basket = 22,

            /// <summary>
            /// Enum FundingLeg for value: FundingLeg
            /// </summary>
            [EnumMember(Value = "FundingLeg")]
            FundingLeg = 23,

            /// <summary>
            /// Enum FxSwap for value: FxSwap
            /// </summary>
            [EnumMember(Value = "FxSwap")]
            FxSwap = 24,

            /// <summary>
            /// Enum ForwardRateAgreement for value: ForwardRateAgreement
            /// </summary>
            [EnumMember(Value = "ForwardRateAgreement")]
            ForwardRateAgreement = 25,

            /// <summary>
            /// Enum SimpleInstrument for value: SimpleInstrument
            /// </summary>
            [EnumMember(Value = "SimpleInstrument")]
            SimpleInstrument = 26,

            /// <summary>
            /// Enum Repo for value: Repo
            /// </summary>
            [EnumMember(Value = "Repo")]
            Repo = 27,

            /// <summary>
            /// Enum Equity for value: Equity
            /// </summary>
            [EnumMember(Value = "Equity")]
            Equity = 28,

            /// <summary>
            /// Enum ExchangeTradedOption for value: ExchangeTradedOption
            /// </summary>
            [EnumMember(Value = "ExchangeTradedOption")]
            ExchangeTradedOption = 29,

            /// <summary>
            /// Enum ReferenceInstrument for value: ReferenceInstrument
            /// </summary>
            [EnumMember(Value = "ReferenceInstrument")]
            ReferenceInstrument = 30,

            /// <summary>
            /// Enum ComplexBond for value: ComplexBond
            /// </summary>
            [EnumMember(Value = "ComplexBond")]
            ComplexBond = 31,

            /// <summary>
            /// Enum InflationLinkedBond for value: InflationLinkedBond
            /// </summary>
            [EnumMember(Value = "InflationLinkedBond")]
            InflationLinkedBond = 32,

            /// <summary>
            /// Enum InflationSwap for value: InflationSwap
            /// </summary>
            [EnumMember(Value = "InflationSwap")]
            InflationSwap = 33,

            /// <summary>
            /// Enum SimpleCashFlowLoan for value: SimpleCashFlowLoan
            /// </summary>
            [EnumMember(Value = "SimpleCashFlowLoan")]
            SimpleCashFlowLoan = 34

        }


        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan</value>
        [DataMember(Name = "instrumentType", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentTypeEnum InstrumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InflationLinkedBondAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InflationLinkedBondAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InflationLinkedBondAllOf" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the bond. (required).</param>
        /// <param name="maturityDate">The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. (required).</param>
        /// <param name="flowConventions">flowConventions (required).</param>
        /// <param name="inflationIndexConventions">inflationIndexConventions (required).</param>
        /// <param name="couponRate">Simple coupon rate. (required).</param>
        /// <param name="identifiers">External market codes and identifiers for the bond, e.g. ISIN..</param>
        /// <param name="baseCPI">BaseCPI value. This is optional, if not provided the BaseCPI value will be calculated from the BaseCPIDate,  if that too is not present the StartDate will be used.                If provided then this value will always set the BaseCPI on this bond.                The BaseCPI of an inflation linked bond is calculated using the following logic:  - If a BaseCPI value is provided, this is used.  - Otherwise, if BaseCPIDate is provided, the CPI for this date is calculated and used.  - Otherwise, the CPI for the StartDate is calculated and used.                Note that if both BaseCPI and BaseCPIDate are set, the BaseCPI value will be used and the BaseCPIDate  will be ignored but can still be added for informative purposes.                Some bonds are issued with a BaseCPI date that does not correspond to the StartDate CPI value, in this  case the value should be provided here or with the BaseCPIDate..</param>
        /// <param name="baseCPIDate">BaseCPIDate. This is optional. Gives the date that the BaseCPI is calculated for.                Note this is an un-lagged date (similar to StartDate) so the Bond ObservationLag will  be applied to this date when calculating the CPI.                The BaseCPI of an inflation linked bond is calculated using the following logic:  - If a BaseCPI value is provided, this is used.  - Otherwise, if BaseCPIDate is provided, the CPI for this date is calculated and used.  - Otherwise, the CPI for the StartDate is calculated and used.                Note that if both BaseCPI and BaseCPIDate are set, the BaseCPI value will be used and the BaseCPIDate  will be ignored but can still be added for informative purposes.                Some bonds are issued with a BaseCPI date that does not correspond to the StartDate CPI value, in this  case the value should be provided here or with the actual BaseCPI..</param>
        /// <param name="calculationType">The calculation type applied to the bond coupon and principal amount.  The default CalculationType is &#x60;Standard&#x60;.    Supported string (enumeration) values are: [Standard, Quarterly, Ratio]..</param>
        /// <param name="exDividendDays">Number of Good Business Days before the next coupon payment, in which the bond goes ex-dividend.  This is not common in inflation linked bonds but has been seen with (for example) bonds issued by  the Bank of Thailand..</param>
        /// <param name="indexPrecision">Number of decimal places used to round IndexRatio. This defaults to 5 if not set..</param>
        /// <param name="principal">The face-value or principal for the bond at outset. (required).</param>
        /// <param name="principalProtection">If true then the principal is protected in that the redemption amount will be at least the face value (Principal).  This is typically set to true for inflation linked bonds issued by the United States and France (for example).  This is typically set to false for inflation linked bonds issued by the United Kingdom (post 2005).  For other sovereigns this can vary from issue to issue.  If not set this property defaults to true.  This is sometimes referred to as Deflation protection or an inflation floor of 0%..</param>
        /// <param name="stubType">StubType. Most Inflation linked bonds have a ShortFront stub type so this is the default, however in some cases  with a long front stub LongFront should be selected.  StubType Both is not supported for InflationLinkedBonds.    Supported string (enumeration) values are: [ShortFront, ShortBack, LongBack, LongFront, Both]..</param>
        /// <param name="roundingConventions">Rounding conventions for analytics, if any..</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan (required).</param>
        public InflationLinkedBondAllOf(DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset maturityDate = default(DateTimeOffset), FlowConventions flowConventions = default(FlowConventions), InflationIndexConventions inflationIndexConventions = default(InflationIndexConventions), decimal couponRate = default(decimal), Dictionary<string, string> identifiers = default(Dictionary<string, string>), decimal? baseCPI = default(decimal?), DateTimeOffset? baseCPIDate = default(DateTimeOffset?), string calculationType = default(string), int? exDividendDays = default(int?), int indexPrecision = default(int), decimal principal = default(decimal), bool principalProtection = default(bool), string stubType = default(string), List<RoundingConvention> roundingConventions = default(List<RoundingConvention>), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum))
        {
            this.StartDate = startDate;
            this.MaturityDate = maturityDate;
            // to ensure "flowConventions" is required (not null)
            if (flowConventions == null)
            {
                throw new ArgumentNullException("flowConventions is a required property for InflationLinkedBondAllOf and cannot be null");
            }
            this.FlowConventions = flowConventions;
            // to ensure "inflationIndexConventions" is required (not null)
            if (inflationIndexConventions == null)
            {
                throw new ArgumentNullException("inflationIndexConventions is a required property for InflationLinkedBondAllOf and cannot be null");
            }
            this.InflationIndexConventions = inflationIndexConventions;
            this.CouponRate = couponRate;
            this.Principal = principal;
            this.InstrumentType = instrumentType;
            this.Identifiers = identifiers;
            this.BaseCPI = baseCPI;
            this.BaseCPIDate = baseCPIDate;
            this.CalculationType = calculationType;
            this.ExDividendDays = exDividendDays;
            this.IndexPrecision = indexPrecision;
            this.PrincipalProtection = principalProtection;
            this.StubType = stubType;
            this.RoundingConventions = roundingConventions;
        }

        /// <summary>
        /// The start date of the bond.
        /// </summary>
        /// <value>The start date of the bond.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it.
        /// </summary>
        /// <value>The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it.</value>
        [DataMember(Name = "maturityDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset MaturityDate { get; set; }

        /// <summary>
        /// Gets or Sets FlowConventions
        /// </summary>
        [DataMember(Name = "flowConventions", IsRequired = true, EmitDefaultValue = true)]
        public FlowConventions FlowConventions { get; set; }

        /// <summary>
        /// Gets or Sets InflationIndexConventions
        /// </summary>
        [DataMember(Name = "inflationIndexConventions", IsRequired = true, EmitDefaultValue = true)]
        public InflationIndexConventions InflationIndexConventions { get; set; }

        /// <summary>
        /// Simple coupon rate.
        /// </summary>
        /// <value>Simple coupon rate.</value>
        [DataMember(Name = "couponRate", IsRequired = true, EmitDefaultValue = true)]
        public decimal CouponRate { get; set; }

        /// <summary>
        /// External market codes and identifiers for the bond, e.g. ISIN.
        /// </summary>
        /// <value>External market codes and identifiers for the bond, e.g. ISIN.</value>
        [DataMember(Name = "identifiers", EmitDefaultValue = true)]
        public Dictionary<string, string> Identifiers { get; set; }

        /// <summary>
        /// BaseCPI value. This is optional, if not provided the BaseCPI value will be calculated from the BaseCPIDate,  if that too is not present the StartDate will be used.                If provided then this value will always set the BaseCPI on this bond.                The BaseCPI of an inflation linked bond is calculated using the following logic:  - If a BaseCPI value is provided, this is used.  - Otherwise, if BaseCPIDate is provided, the CPI for this date is calculated and used.  - Otherwise, the CPI for the StartDate is calculated and used.                Note that if both BaseCPI and BaseCPIDate are set, the BaseCPI value will be used and the BaseCPIDate  will be ignored but can still be added for informative purposes.                Some bonds are issued with a BaseCPI date that does not correspond to the StartDate CPI value, in this  case the value should be provided here or with the BaseCPIDate.
        /// </summary>
        /// <value>BaseCPI value. This is optional, if not provided the BaseCPI value will be calculated from the BaseCPIDate,  if that too is not present the StartDate will be used.                If provided then this value will always set the BaseCPI on this bond.                The BaseCPI of an inflation linked bond is calculated using the following logic:  - If a BaseCPI value is provided, this is used.  - Otherwise, if BaseCPIDate is provided, the CPI for this date is calculated and used.  - Otherwise, the CPI for the StartDate is calculated and used.                Note that if both BaseCPI and BaseCPIDate are set, the BaseCPI value will be used and the BaseCPIDate  will be ignored but can still be added for informative purposes.                Some bonds are issued with a BaseCPI date that does not correspond to the StartDate CPI value, in this  case the value should be provided here or with the BaseCPIDate.</value>
        [DataMember(Name = "baseCPI", EmitDefaultValue = true)]
        public decimal? BaseCPI { get; set; }

        /// <summary>
        /// BaseCPIDate. This is optional. Gives the date that the BaseCPI is calculated for.                Note this is an un-lagged date (similar to StartDate) so the Bond ObservationLag will  be applied to this date when calculating the CPI.                The BaseCPI of an inflation linked bond is calculated using the following logic:  - If a BaseCPI value is provided, this is used.  - Otherwise, if BaseCPIDate is provided, the CPI for this date is calculated and used.  - Otherwise, the CPI for the StartDate is calculated and used.                Note that if both BaseCPI and BaseCPIDate are set, the BaseCPI value will be used and the BaseCPIDate  will be ignored but can still be added for informative purposes.                Some bonds are issued with a BaseCPI date that does not correspond to the StartDate CPI value, in this  case the value should be provided here or with the actual BaseCPI.
        /// </summary>
        /// <value>BaseCPIDate. This is optional. Gives the date that the BaseCPI is calculated for.                Note this is an un-lagged date (similar to StartDate) so the Bond ObservationLag will  be applied to this date when calculating the CPI.                The BaseCPI of an inflation linked bond is calculated using the following logic:  - If a BaseCPI value is provided, this is used.  - Otherwise, if BaseCPIDate is provided, the CPI for this date is calculated and used.  - Otherwise, the CPI for the StartDate is calculated and used.                Note that if both BaseCPI and BaseCPIDate are set, the BaseCPI value will be used and the BaseCPIDate  will be ignored but can still be added for informative purposes.                Some bonds are issued with a BaseCPI date that does not correspond to the StartDate CPI value, in this  case the value should be provided here or with the actual BaseCPI.</value>
        [DataMember(Name = "baseCPIDate", EmitDefaultValue = true)]
        public DateTimeOffset? BaseCPIDate { get; set; }

        /// <summary>
        /// The calculation type applied to the bond coupon and principal amount.  The default CalculationType is &#x60;Standard&#x60;.    Supported string (enumeration) values are: [Standard, Quarterly, Ratio].
        /// </summary>
        /// <value>The calculation type applied to the bond coupon and principal amount.  The default CalculationType is &#x60;Standard&#x60;.    Supported string (enumeration) values are: [Standard, Quarterly, Ratio].</value>
        [DataMember(Name = "calculationType", EmitDefaultValue = true)]
        public string CalculationType { get; set; }

        /// <summary>
        /// Number of Good Business Days before the next coupon payment, in which the bond goes ex-dividend.  This is not common in inflation linked bonds but has been seen with (for example) bonds issued by  the Bank of Thailand.
        /// </summary>
        /// <value>Number of Good Business Days before the next coupon payment, in which the bond goes ex-dividend.  This is not common in inflation linked bonds but has been seen with (for example) bonds issued by  the Bank of Thailand.</value>
        [DataMember(Name = "exDividendDays", EmitDefaultValue = true)]
        public int? ExDividendDays { get; set; }

        /// <summary>
        /// Number of decimal places used to round IndexRatio. This defaults to 5 if not set.
        /// </summary>
        /// <value>Number of decimal places used to round IndexRatio. This defaults to 5 if not set.</value>
        [DataMember(Name = "indexPrecision", EmitDefaultValue = false)]
        public int IndexPrecision { get; set; }

        /// <summary>
        /// The face-value or principal for the bond at outset.
        /// </summary>
        /// <value>The face-value or principal for the bond at outset.</value>
        [DataMember(Name = "principal", IsRequired = true, EmitDefaultValue = true)]
        public decimal Principal { get; set; }

        /// <summary>
        /// If true then the principal is protected in that the redemption amount will be at least the face value (Principal).  This is typically set to true for inflation linked bonds issued by the United States and France (for example).  This is typically set to false for inflation linked bonds issued by the United Kingdom (post 2005).  For other sovereigns this can vary from issue to issue.  If not set this property defaults to true.  This is sometimes referred to as Deflation protection or an inflation floor of 0%.
        /// </summary>
        /// <value>If true then the principal is protected in that the redemption amount will be at least the face value (Principal).  This is typically set to true for inflation linked bonds issued by the United States and France (for example).  This is typically set to false for inflation linked bonds issued by the United Kingdom (post 2005).  For other sovereigns this can vary from issue to issue.  If not set this property defaults to true.  This is sometimes referred to as Deflation protection or an inflation floor of 0%.</value>
        [DataMember(Name = "principalProtection", EmitDefaultValue = true)]
        public bool PrincipalProtection { get; set; }

        /// <summary>
        /// StubType. Most Inflation linked bonds have a ShortFront stub type so this is the default, however in some cases  with a long front stub LongFront should be selected.  StubType Both is not supported for InflationLinkedBonds.    Supported string (enumeration) values are: [ShortFront, ShortBack, LongBack, LongFront, Both].
        /// </summary>
        /// <value>StubType. Most Inflation linked bonds have a ShortFront stub type so this is the default, however in some cases  with a long front stub LongFront should be selected.  StubType Both is not supported for InflationLinkedBonds.    Supported string (enumeration) values are: [ShortFront, ShortBack, LongBack, LongFront, Both].</value>
        [DataMember(Name = "stubType", EmitDefaultValue = true)]
        public string StubType { get; set; }

        /// <summary>
        /// Rounding conventions for analytics, if any.
        /// </summary>
        /// <value>Rounding conventions for analytics, if any.</value>
        [DataMember(Name = "roundingConventions", EmitDefaultValue = true)]
        public List<RoundingConvention> RoundingConventions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InflationLinkedBondAllOf {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  FlowConventions: ").Append(FlowConventions).Append("\n");
            sb.Append("  InflationIndexConventions: ").Append(InflationIndexConventions).Append("\n");
            sb.Append("  CouponRate: ").Append(CouponRate).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  BaseCPI: ").Append(BaseCPI).Append("\n");
            sb.Append("  BaseCPIDate: ").Append(BaseCPIDate).Append("\n");
            sb.Append("  CalculationType: ").Append(CalculationType).Append("\n");
            sb.Append("  ExDividendDays: ").Append(ExDividendDays).Append("\n");
            sb.Append("  IndexPrecision: ").Append(IndexPrecision).Append("\n");
            sb.Append("  Principal: ").Append(Principal).Append("\n");
            sb.Append("  PrincipalProtection: ").Append(PrincipalProtection).Append("\n");
            sb.Append("  StubType: ").Append(StubType).Append("\n");
            sb.Append("  RoundingConventions: ").Append(RoundingConventions).Append("\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InflationLinkedBondAllOf);
        }

        /// <summary>
        /// Returns true if InflationLinkedBondAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of InflationLinkedBondAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InflationLinkedBondAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && 
                (
                    this.FlowConventions == input.FlowConventions ||
                    (this.FlowConventions != null &&
                    this.FlowConventions.Equals(input.FlowConventions))
                ) && 
                (
                    this.InflationIndexConventions == input.InflationIndexConventions ||
                    (this.InflationIndexConventions != null &&
                    this.InflationIndexConventions.Equals(input.InflationIndexConventions))
                ) && 
                (
                    this.CouponRate == input.CouponRate ||
                    this.CouponRate.Equals(input.CouponRate)
                ) && 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && 
                (
                    this.BaseCPI == input.BaseCPI ||
                    (this.BaseCPI != null &&
                    this.BaseCPI.Equals(input.BaseCPI))
                ) && 
                (
                    this.BaseCPIDate == input.BaseCPIDate ||
                    (this.BaseCPIDate != null &&
                    this.BaseCPIDate.Equals(input.BaseCPIDate))
                ) && 
                (
                    this.CalculationType == input.CalculationType ||
                    (this.CalculationType != null &&
                    this.CalculationType.Equals(input.CalculationType))
                ) && 
                (
                    this.ExDividendDays == input.ExDividendDays ||
                    (this.ExDividendDays != null &&
                    this.ExDividendDays.Equals(input.ExDividendDays))
                ) && 
                (
                    this.IndexPrecision == input.IndexPrecision ||
                    this.IndexPrecision.Equals(input.IndexPrecision)
                ) && 
                (
                    this.Principal == input.Principal ||
                    this.Principal.Equals(input.Principal)
                ) && 
                (
                    this.PrincipalProtection == input.PrincipalProtection ||
                    this.PrincipalProtection.Equals(input.PrincipalProtection)
                ) && 
                (
                    this.StubType == input.StubType ||
                    (this.StubType != null &&
                    this.StubType.Equals(input.StubType))
                ) && 
                (
                    this.RoundingConventions == input.RoundingConventions ||
                    this.RoundingConventions != null &&
                    input.RoundingConventions != null &&
                    this.RoundingConventions.SequenceEqual(input.RoundingConventions)
                ) && 
                (
                    this.InstrumentType == input.InstrumentType ||
                    this.InstrumentType.Equals(input.InstrumentType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.MaturityDate != null)
                {
                    hashCode = (hashCode * 59) + this.MaturityDate.GetHashCode();
                }
                if (this.FlowConventions != null)
                {
                    hashCode = (hashCode * 59) + this.FlowConventions.GetHashCode();
                }
                if (this.InflationIndexConventions != null)
                {
                    hashCode = (hashCode * 59) + this.InflationIndexConventions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CouponRate.GetHashCode();
                if (this.Identifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Identifiers.GetHashCode();
                }
                if (this.BaseCPI != null)
                {
                    hashCode = (hashCode * 59) + this.BaseCPI.GetHashCode();
                }
                if (this.BaseCPIDate != null)
                {
                    hashCode = (hashCode * 59) + this.BaseCPIDate.GetHashCode();
                }
                if (this.CalculationType != null)
                {
                    hashCode = (hashCode * 59) + this.CalculationType.GetHashCode();
                }
                if (this.ExDividendDays != null)
                {
                    hashCode = (hashCode * 59) + this.ExDividendDays.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IndexPrecision.GetHashCode();
                hashCode = (hashCode * 59) + this.Principal.GetHashCode();
                hashCode = (hashCode * 59) + this.PrincipalProtection.GetHashCode();
                if (this.StubType != null)
                {
                    hashCode = (hashCode * 59) + this.StubType.GetHashCode();
                }
                if (this.RoundingConventions != null)
                {
                    hashCode = (hashCode * 59) + this.RoundingConventions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InstrumentType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
