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
    /// LUSID representation of a Credit Default Swap Index (CDX).                This instrument has multiple legs, to see how legs are used in LUSID see [knowledge base article KA-02252](https://support.lusid.com/knowledgebase/article/KA-02252).                | Leg Index | Leg Identifier | Description |  | - -- -- -- -- | - -- -- -- -- -- -- - | - -- -- -- -- -- |  | 1 | ProtectionLeg | Payments made by the protection seller in the case of default across all CDS instruments in the index. |  | 2 | PremiumLeg | The premium payments made by the protection buyer across all CDS instruments in the index. |
    /// </summary>
    [DataContract(Name = "CdsIndex")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentType")]
    public partial class CdsIndex : LusidInstrument, IEquatable<CdsIndex>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CdsIndex" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CdsIndex() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CdsIndex" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="maturityDate">The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. (required).</param>
        /// <param name="flowConventions">flowConventions.</param>
        /// <param name="couponRate">The coupon rate paid on each payment date of the premium leg as a fraction of 100 percent, e.g. \&quot;0.05\&quot; meaning 500 basis points or 5%.  For a standard corporate CDS (North American) this must be either 100bps or 500bps. (required).</param>
        /// <param name="identifiers">External market codes and identifiers for the cds index, e.g. a RED code, BBG ID or ICE code. (required).</param>
        /// <param name="basket">basket.</param>
        /// <param name="conventionName">conventionName.</param>
        /// <param name="notional">The notional quantity that applies to both the premium and protection legs. (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass (required) (default to &quot;CdsIndex&quot;).</param>
        public CdsIndex(DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset maturityDate = default(DateTimeOffset), CdsFlowConventions flowConventions = default(CdsFlowConventions), decimal couponRate = default(decimal), Dictionary<string, string> identifiers = default(Dictionary<string, string>), Basket basket = default(Basket), FlowConventionName conventionName = default(FlowConventionName), decimal notional = default(decimal), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            this.StartDate = startDate;
            this.MaturityDate = maturityDate;
            this.CouponRate = couponRate;
            // to ensure "identifiers" is required (not null)
            if (identifiers == null)
            {
                throw new ArgumentNullException("identifiers is a required property for CdsIndex and cannot be null");
            }
            this.Identifiers = identifiers;
            this.Notional = notional;
            this.FlowConventions = flowConventions;
            this.Basket = basket;
            this.ConventionName = conventionName;
        }

        /// <summary>
        /// The start date of the instrument. This is normally synonymous with the trade-date.
        /// </summary>
        /// <value>The start date of the instrument. This is normally synonymous with the trade-date.</value>
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
        [DataMember(Name = "flowConventions", EmitDefaultValue = false)]
        public CdsFlowConventions FlowConventions { get; set; }

        /// <summary>
        /// The coupon rate paid on each payment date of the premium leg as a fraction of 100 percent, e.g. \&quot;0.05\&quot; meaning 500 basis points or 5%.  For a standard corporate CDS (North American) this must be either 100bps or 500bps.
        /// </summary>
        /// <value>The coupon rate paid on each payment date of the premium leg as a fraction of 100 percent, e.g. \&quot;0.05\&quot; meaning 500 basis points or 5%.  For a standard corporate CDS (North American) this must be either 100bps or 500bps.</value>
        [DataMember(Name = "couponRate", IsRequired = true, EmitDefaultValue = true)]
        public decimal CouponRate { get; set; }

        /// <summary>
        /// External market codes and identifiers for the cds index, e.g. a RED code, BBG ID or ICE code.
        /// </summary>
        /// <value>External market codes and identifiers for the cds index, e.g. a RED code, BBG ID or ICE code.</value>
        [DataMember(Name = "identifiers", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Identifiers { get; set; }

        /// <summary>
        /// Gets or Sets Basket
        /// </summary>
        [DataMember(Name = "basket", EmitDefaultValue = false)]
        public Basket Basket { get; set; }

        /// <summary>
        /// Gets or Sets ConventionName
        /// </summary>
        [DataMember(Name = "conventionName", EmitDefaultValue = false)]
        public FlowConventionName ConventionName { get; set; }

        /// <summary>
        /// The notional quantity that applies to both the premium and protection legs.
        /// </summary>
        /// <value>The notional quantity that applies to both the premium and protection legs.</value>
        [DataMember(Name = "notional", IsRequired = true, EmitDefaultValue = true)]
        public decimal Notional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CdsIndex {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  FlowConventions: ").Append(FlowConventions).Append("\n");
            sb.Append("  CouponRate: ").Append(CouponRate).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Basket: ").Append(Basket).Append("\n");
            sb.Append("  ConventionName: ").Append(ConventionName).Append("\n");
            sb.Append("  Notional: ").Append(Notional).Append("\n");
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
            return this.Equals(input as CdsIndex);
        }

        /// <summary>
        /// Returns true if CdsIndex instances are equal
        /// </summary>
        /// <param name="input">Instance of CdsIndex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdsIndex input)
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
                    this.FlowConventions == input.FlowConventions ||
                    (this.FlowConventions != null &&
                    this.FlowConventions.Equals(input.FlowConventions))
                ) && base.Equals(input) && 
                (
                    this.CouponRate == input.CouponRate ||
                    this.CouponRate.Equals(input.CouponRate)
                ) && base.Equals(input) && 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && base.Equals(input) && 
                (
                    this.Basket == input.Basket ||
                    (this.Basket != null &&
                    this.Basket.Equals(input.Basket))
                ) && base.Equals(input) && 
                (
                    this.ConventionName == input.ConventionName ||
                    (this.ConventionName != null &&
                    this.ConventionName.Equals(input.ConventionName))
                ) && base.Equals(input) && 
                (
                    this.Notional == input.Notional ||
                    this.Notional.Equals(input.Notional)
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
                if (this.FlowConventions != null)
                {
                    hashCode = (hashCode * 59) + this.FlowConventions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CouponRate.GetHashCode();
                if (this.Identifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Identifiers.GetHashCode();
                }
                if (this.Basket != null)
                {
                    hashCode = (hashCode * 59) + this.Basket.GetHashCode();
                }
                if (this.ConventionName != null)
                {
                    hashCode = (hashCode * 59) + this.ConventionName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Notional.GetHashCode();
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
