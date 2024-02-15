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
    /// FundShareClassAllOf
    /// </summary>
    [DataContract(Name = "FundShareClass_allOf")]
    public partial class FundShareClassAllOf : IEquatable<FundShareClassAllOf>, IValidatableObject
    {
        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass</value>
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
            SimpleCashFlowLoan = 34,

            /// <summary>
            /// Enum TotalReturnSwap for value: TotalReturnSwap
            /// </summary>
            [EnumMember(Value = "TotalReturnSwap")]
            TotalReturnSwap = 35,

            /// <summary>
            /// Enum InflationLeg for value: InflationLeg
            /// </summary>
            [EnumMember(Value = "InflationLeg")]
            InflationLeg = 36,

            /// <summary>
            /// Enum FundShareClass for value: FundShareClass
            /// </summary>
            [EnumMember(Value = "FundShareClass")]
            FundShareClass = 37

        }


        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass</value>
        [DataMember(Name = "instrumentType", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentTypeEnum InstrumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FundShareClassAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FundShareClassAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FundShareClassAllOf" /> class.
        /// </summary>
        /// <param name="shortCode">A short identifier, unique across a single fund, usually made up of the ShareClass components. Eg \&quot;A Accumulation Euro Hedged Class\&quot; could become \&quot;A Acc H EUR\&quot;. (required).</param>
        /// <param name="fundShareClassType">The type of distribution that the ShareClass will calculate. Can be either &#39;Income&#39; or &#39;Accumulation&#39; - Income classes will pay out and Accumulation classes will retain their ShareClass attributable income.    Supported string (enumeration) values are: [Income, Accumulation]. (required).</param>
        /// <param name="distributionPaymentType">The tax treatment applied to any distributions calculated within the ShareClass. Can be either &#39;Net&#39; (Distribution Calculated net of tax) or &#39;Gross&#39; (Distribution calculated gross of tax).    Supported string (enumeration) values are: [Gross, Net]. (required).</param>
        /// <param name="hedging">A flag to indicate the ShareClass is operating currency hedging as a means to limit currency risk as part of it&#39;s investment strategy.    Supported string (enumeration) values are: [Invalid, None, ApplyHedging]. (required).</param>
        /// <param name="domCcy">The domestic currency of the instrument. (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass (required).</param>
        public FundShareClassAllOf(string shortCode = default(string), string fundShareClassType = default(string), string distributionPaymentType = default(string), string hedging = default(string), string domCcy = default(string), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum))
        {
            // to ensure "shortCode" is required (not null)
            if (shortCode == null)
            {
                throw new ArgumentNullException("shortCode is a required property for FundShareClassAllOf and cannot be null");
            }
            this.ShortCode = shortCode;
            // to ensure "fundShareClassType" is required (not null)
            if (fundShareClassType == null)
            {
                throw new ArgumentNullException("fundShareClassType is a required property for FundShareClassAllOf and cannot be null");
            }
            this.FundShareClassType = fundShareClassType;
            // to ensure "distributionPaymentType" is required (not null)
            if (distributionPaymentType == null)
            {
                throw new ArgumentNullException("distributionPaymentType is a required property for FundShareClassAllOf and cannot be null");
            }
            this.DistributionPaymentType = distributionPaymentType;
            // to ensure "hedging" is required (not null)
            if (hedging == null)
            {
                throw new ArgumentNullException("hedging is a required property for FundShareClassAllOf and cannot be null");
            }
            this.Hedging = hedging;
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new ArgumentNullException("domCcy is a required property for FundShareClassAllOf and cannot be null");
            }
            this.DomCcy = domCcy;
            this.InstrumentType = instrumentType;
        }

        /// <summary>
        /// A short identifier, unique across a single fund, usually made up of the ShareClass components. Eg \&quot;A Accumulation Euro Hedged Class\&quot; could become \&quot;A Acc H EUR\&quot;.
        /// </summary>
        /// <value>A short identifier, unique across a single fund, usually made up of the ShareClass components. Eg \&quot;A Accumulation Euro Hedged Class\&quot; could become \&quot;A Acc H EUR\&quot;.</value>
        [DataMember(Name = "shortCode", IsRequired = true, EmitDefaultValue = true)]
        public string ShortCode { get; set; }

        /// <summary>
        /// The type of distribution that the ShareClass will calculate. Can be either &#39;Income&#39; or &#39;Accumulation&#39; - Income classes will pay out and Accumulation classes will retain their ShareClass attributable income.    Supported string (enumeration) values are: [Income, Accumulation].
        /// </summary>
        /// <value>The type of distribution that the ShareClass will calculate. Can be either &#39;Income&#39; or &#39;Accumulation&#39; - Income classes will pay out and Accumulation classes will retain their ShareClass attributable income.    Supported string (enumeration) values are: [Income, Accumulation].</value>
        [DataMember(Name = "fundShareClassType", IsRequired = true, EmitDefaultValue = true)]
        public string FundShareClassType { get; set; }

        /// <summary>
        /// The tax treatment applied to any distributions calculated within the ShareClass. Can be either &#39;Net&#39; (Distribution Calculated net of tax) or &#39;Gross&#39; (Distribution calculated gross of tax).    Supported string (enumeration) values are: [Gross, Net].
        /// </summary>
        /// <value>The tax treatment applied to any distributions calculated within the ShareClass. Can be either &#39;Net&#39; (Distribution Calculated net of tax) or &#39;Gross&#39; (Distribution calculated gross of tax).    Supported string (enumeration) values are: [Gross, Net].</value>
        [DataMember(Name = "distributionPaymentType", IsRequired = true, EmitDefaultValue = true)]
        public string DistributionPaymentType { get; set; }

        /// <summary>
        /// A flag to indicate the ShareClass is operating currency hedging as a means to limit currency risk as part of it&#39;s investment strategy.    Supported string (enumeration) values are: [Invalid, None, ApplyHedging].
        /// </summary>
        /// <value>A flag to indicate the ShareClass is operating currency hedging as a means to limit currency risk as part of it&#39;s investment strategy.    Supported string (enumeration) values are: [Invalid, None, ApplyHedging].</value>
        [DataMember(Name = "hedging", IsRequired = true, EmitDefaultValue = true)]
        public string Hedging { get; set; }

        /// <summary>
        /// The domestic currency of the instrument.
        /// </summary>
        /// <value>The domestic currency of the instrument.</value>
        [DataMember(Name = "domCcy", IsRequired = true, EmitDefaultValue = true)]
        public string DomCcy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FundShareClassAllOf {\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
            sb.Append("  FundShareClassType: ").Append(FundShareClassType).Append("\n");
            sb.Append("  DistributionPaymentType: ").Append(DistributionPaymentType).Append("\n");
            sb.Append("  Hedging: ").Append(Hedging).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
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
            return this.Equals(input as FundShareClassAllOf);
        }

        /// <summary>
        /// Returns true if FundShareClassAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of FundShareClassAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundShareClassAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
                ) && 
                (
                    this.FundShareClassType == input.FundShareClassType ||
                    (this.FundShareClassType != null &&
                    this.FundShareClassType.Equals(input.FundShareClassType))
                ) && 
                (
                    this.DistributionPaymentType == input.DistributionPaymentType ||
                    (this.DistributionPaymentType != null &&
                    this.DistributionPaymentType.Equals(input.DistributionPaymentType))
                ) && 
                (
                    this.Hedging == input.Hedging ||
                    (this.Hedging != null &&
                    this.Hedging.Equals(input.Hedging))
                ) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
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
                if (this.ShortCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShortCode.GetHashCode();
                }
                if (this.FundShareClassType != null)
                {
                    hashCode = (hashCode * 59) + this.FundShareClassType.GetHashCode();
                }
                if (this.DistributionPaymentType != null)
                {
                    hashCode = (hashCode * 59) + this.DistributionPaymentType.GetHashCode();
                }
                if (this.Hedging != null)
                {
                    hashCode = (hashCode * 59) + this.Hedging.GetHashCode();
                }
                if (this.DomCcy != null)
                {
                    hashCode = (hashCode * 59) + this.DomCcy.GetHashCode();
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
            // ShortCode (string) minLength
            if (this.ShortCode != null && this.ShortCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortCode, length must be greater than 1.", new [] { "ShortCode" });
            }

            // FundShareClassType (string) minLength
            if (this.FundShareClassType != null && this.FundShareClassType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FundShareClassType, length must be greater than 1.", new [] { "FundShareClassType" });
            }

            // DistributionPaymentType (string) minLength
            if (this.DistributionPaymentType != null && this.DistributionPaymentType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DistributionPaymentType, length must be greater than 1.", new [] { "DistributionPaymentType" });
            }

            // Hedging (string) minLength
            if (this.Hedging != null && this.Hedging.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hedging, length must be greater than 1.", new [] { "Hedging" });
            }

            yield break;
        }
    }
}
