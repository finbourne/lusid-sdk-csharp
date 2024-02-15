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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// LUSID representation of a Forward Rate Agreement.
    /// </summary>
    [DataContract(Name = "ForwardRateAgreement")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentType")]
    public partial class ForwardRateAgreement : LusidInstrument, IEquatable<ForwardRateAgreement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardRateAgreement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForwardRateAgreement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardRateAgreement" /> class.
        /// </summary>
        /// <param name="startDate">The settlement date of the FRA (required).</param>
        /// <param name="maturityDate">The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date. (required).</param>
        /// <param name="domCcy">The domestic currency of the instrument. (required).</param>
        /// <param name="fixingDate">The date at which the rate to be paid, the reference rate, is confirmed/observed. (required).</param>
        /// <param name="fraRate">The rate at which the FRA is traded. (required).</param>
        /// <param name="notional">The amount for which the FRA is traded. (required).</param>
        /// <param name="indexConvention">indexConvention.</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass (required) (default to &quot;ForwardRateAgreement&quot;).</param>
        public ForwardRateAgreement(DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset maturityDate = default(DateTimeOffset), string domCcy = default(string), DateTimeOffset fixingDate = default(DateTimeOffset), decimal fraRate = default(decimal), decimal notional = default(decimal), IndexConvention indexConvention = default(IndexConvention), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            this.StartDate = startDate;
            this.MaturityDate = maturityDate;
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new ArgumentNullException("domCcy is a required property for ForwardRateAgreement and cannot be null");
            }
            this.DomCcy = domCcy;
            this.FixingDate = fixingDate;
            this.FraRate = fraRate;
            this.Notional = notional;
            this.IndexConvention = indexConvention;
        }

        /// <summary>
        /// The settlement date of the FRA
        /// </summary>
        /// <value>The settlement date of the FRA</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date.
        /// </summary>
        /// <value>The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date.</value>
        [DataMember(Name = "maturityDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset MaturityDate { get; set; }

        /// <summary>
        /// The domestic currency of the instrument.
        /// </summary>
        /// <value>The domestic currency of the instrument.</value>
        [DataMember(Name = "domCcy", IsRequired = true, EmitDefaultValue = true)]
        public string DomCcy { get; set; }

        /// <summary>
        /// The date at which the rate to be paid, the reference rate, is confirmed/observed.
        /// </summary>
        /// <value>The date at which the rate to be paid, the reference rate, is confirmed/observed.</value>
        [DataMember(Name = "fixingDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset FixingDate { get; set; }

        /// <summary>
        /// The rate at which the FRA is traded.
        /// </summary>
        /// <value>The rate at which the FRA is traded.</value>
        [DataMember(Name = "fraRate", IsRequired = true, EmitDefaultValue = true)]
        public decimal FraRate { get; set; }

        /// <summary>
        /// The amount for which the FRA is traded.
        /// </summary>
        /// <value>The amount for which the FRA is traded.</value>
        [DataMember(Name = "notional", IsRequired = true, EmitDefaultValue = true)]
        public decimal Notional { get; set; }

        /// <summary>
        /// Gets or Sets IndexConvention
        /// </summary>
        [DataMember(Name = "indexConvention", EmitDefaultValue = false)]
        public IndexConvention IndexConvention { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForwardRateAgreement {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  FixingDate: ").Append(FixingDate).Append("\n");
            sb.Append("  FraRate: ").Append(FraRate).Append("\n");
            sb.Append("  Notional: ").Append(Notional).Append("\n");
            sb.Append("  IndexConvention: ").Append(IndexConvention).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ForwardRateAgreement);
        }

        /// <summary>
        /// Returns true if ForwardRateAgreement instances are equal
        /// </summary>
        /// <param name="input">Instance of ForwardRateAgreement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardRateAgreement input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && base.Equals(input) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && base.Equals(input) && 
                (
                    this.FixingDate == input.FixingDate ||
                    (this.FixingDate != null &&
                    this.FixingDate.Equals(input.FixingDate))
                ) && base.Equals(input) && 
                (
                    this.FraRate == input.FraRate ||
                    this.FraRate.Equals(input.FraRate)
                ) && base.Equals(input) && 
                (
                    this.Notional == input.Notional ||
                    this.Notional.Equals(input.Notional)
                ) && base.Equals(input) && 
                (
                    this.IndexConvention == input.IndexConvention ||
                    (this.IndexConvention != null &&
                    this.IndexConvention.Equals(input.IndexConvention))
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
                int hashCode = base.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.MaturityDate != null)
                {
                    hashCode = (hashCode * 59) + this.MaturityDate.GetHashCode();
                }
                if (this.DomCcy != null)
                {
                    hashCode = (hashCode * 59) + this.DomCcy.GetHashCode();
                }
                if (this.FixingDate != null)
                {
                    hashCode = (hashCode * 59) + this.FixingDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FraRate.GetHashCode();
                hashCode = (hashCode * 59) + this.Notional.GetHashCode();
                if (this.IndexConvention != null)
                {
                    hashCode = (hashCode * 59) + this.IndexConvention.GetHashCode();
                }
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }
}
