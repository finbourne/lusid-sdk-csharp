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
    /// LUSID representation of an Interest Rate Swap, including:      * Vanilla (single currency fixed-float non-amortising)    * CrossCurrency (&gt;1 currency is used by the swap legs)    * Basis (single currency, floating-floating legs of different tenors)    * Amortising (the swap has 1+ leg with amortised notional)                This instrument has multiple legs, to see how legs are used in LUSID see [knowledge base article KA-02252](https://support.lusid.com/knowledgebase/article/KA-02252).                | Leg Index | Leg Identifier | Description |  | - -- -- -- -- | - -- -- -- -- -- -- - | - -- -- -- -- -- |  | 1 | Pay/Receive | Cash flows representing the pay/receive leg. |  | 2 | Receive/Pay | Cash flows representing the receive/pay leg. |  | 3 | AdditionalPayments | Cash flows relating to any additional payments (optional). |
    /// </summary>
    [DataContract(Name = "InterestRateSwap")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentType")]
    public partial class InterestRateSwap : LusidInstrument, IEquatable<InterestRateSwap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterestRateSwap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InterestRateSwap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InterestRateSwap" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="maturityDate">The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. (required).</param>
        /// <param name="isNonDeliverable">Is the contract an IRS of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the settlement currency based on the difference between  the fixed and floating rates..</param>
        /// <param name="legs">The set of instrument legs that define the swap instrument, these should be FloatingLeg or FixedLeg. (required).</param>
        /// <param name="settlementCcy">Settlement currency if IRS is non-deliverable..</param>
        /// <param name="additionalPayments">Optional additional payments at a given date e.g. to level off an uneven fixed-floating swap.  The dates must be distinct and either all payments are Pay or all payments are Receive..</param>
        /// <param name="timeZoneConventions">timeZoneConventions.</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo (required) (default to &quot;InterestRateSwap&quot;).</param>
        public InterestRateSwap(DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset maturityDate = default(DateTimeOffset), bool isNonDeliverable = default(bool), List<InstrumentLeg> legs = default(List<InstrumentLeg>), string settlementCcy = default(string), List<AdditionalPayment> additionalPayments = default(List<AdditionalPayment>), TimeZoneConventions timeZoneConventions = default(TimeZoneConventions), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            this.StartDate = startDate;
            this.MaturityDate = maturityDate;
            // to ensure "legs" is required (not null)
            if (legs == null)
            {
                throw new ArgumentNullException("legs is a required property for InterestRateSwap and cannot be null");
            }
            this.Legs = legs;
            this.IsNonDeliverable = isNonDeliverable;
            this.SettlementCcy = settlementCcy;
            this.AdditionalPayments = additionalPayments;
            this.TimeZoneConventions = timeZoneConventions;
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
        /// Is the contract an IRS of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the settlement currency based on the difference between  the fixed and floating rates.
        /// </summary>
        /// <value>Is the contract an IRS of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the settlement currency based on the difference between  the fixed and floating rates.</value>
        [DataMember(Name = "isNonDeliverable", EmitDefaultValue = true)]
        public bool IsNonDeliverable { get; set; }

        /// <summary>
        /// The set of instrument legs that define the swap instrument, these should be FloatingLeg or FixedLeg.
        /// </summary>
        /// <value>The set of instrument legs that define the swap instrument, these should be FloatingLeg or FixedLeg.</value>
        [DataMember(Name = "legs", IsRequired = true, EmitDefaultValue = true)]
        public List<InstrumentLeg> Legs { get; set; }

        /// <summary>
        /// Settlement currency if IRS is non-deliverable.
        /// </summary>
        /// <value>Settlement currency if IRS is non-deliverable.</value>
        [DataMember(Name = "settlementCcy", EmitDefaultValue = true)]
        public string SettlementCcy { get; set; }

        /// <summary>
        /// Optional additional payments at a given date e.g. to level off an uneven fixed-floating swap.  The dates must be distinct and either all payments are Pay or all payments are Receive.
        /// </summary>
        /// <value>Optional additional payments at a given date e.g. to level off an uneven fixed-floating swap.  The dates must be distinct and either all payments are Pay or all payments are Receive.</value>
        [DataMember(Name = "additionalPayments", EmitDefaultValue = true)]
        public List<AdditionalPayment> AdditionalPayments { get; set; }

        /// <summary>
        /// Gets or Sets TimeZoneConventions
        /// </summary>
        [DataMember(Name = "timeZoneConventions", EmitDefaultValue = false)]
        public TimeZoneConventions TimeZoneConventions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterestRateSwap {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  IsNonDeliverable: ").Append(IsNonDeliverable).Append("\n");
            sb.Append("  Legs: ").Append(Legs).Append("\n");
            sb.Append("  SettlementCcy: ").Append(SettlementCcy).Append("\n");
            sb.Append("  AdditionalPayments: ").Append(AdditionalPayments).Append("\n");
            sb.Append("  TimeZoneConventions: ").Append(TimeZoneConventions).Append("\n");
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
            return this.Equals(input as InterestRateSwap);
        }

        /// <summary>
        /// Returns true if InterestRateSwap instances are equal
        /// </summary>
        /// <param name="input">Instance of InterestRateSwap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterestRateSwap input)
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
                    this.IsNonDeliverable == input.IsNonDeliverable ||
                    this.IsNonDeliverable.Equals(input.IsNonDeliverable)
                ) && base.Equals(input) && 
                (
                    this.Legs == input.Legs ||
                    this.Legs != null &&
                    input.Legs != null &&
                    this.Legs.SequenceEqual(input.Legs)
                ) && base.Equals(input) && 
                (
                    this.SettlementCcy == input.SettlementCcy ||
                    (this.SettlementCcy != null &&
                    this.SettlementCcy.Equals(input.SettlementCcy))
                ) && base.Equals(input) && 
                (
                    this.AdditionalPayments == input.AdditionalPayments ||
                    this.AdditionalPayments != null &&
                    input.AdditionalPayments != null &&
                    this.AdditionalPayments.SequenceEqual(input.AdditionalPayments)
                ) && base.Equals(input) && 
                (
                    this.TimeZoneConventions == input.TimeZoneConventions ||
                    (this.TimeZoneConventions != null &&
                    this.TimeZoneConventions.Equals(input.TimeZoneConventions))
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
                hashCode = (hashCode * 59) + this.IsNonDeliverable.GetHashCode();
                if (this.Legs != null)
                {
                    hashCode = (hashCode * 59) + this.Legs.GetHashCode();
                }
                if (this.SettlementCcy != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementCcy.GetHashCode();
                }
                if (this.AdditionalPayments != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalPayments.GetHashCode();
                }
                if (this.TimeZoneConventions != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZoneConventions.GetHashCode();
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
