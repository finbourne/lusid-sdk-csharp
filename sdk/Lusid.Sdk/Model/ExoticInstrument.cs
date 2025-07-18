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
    /// LUSID representation of a generic OTC Exotic Instrument that is not fully defined within other LUSID models.
    /// </summary>
    [DataContract(Name = "ExoticInstrument")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentType")]
    public partial class ExoticInstrument : LusidInstrument, IEquatable<ExoticInstrument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExoticInstrument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExoticInstrument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExoticInstrument" /> class.
        /// </summary>
        /// <param name="instrumentFormat">instrumentFormat (required).</param>
        /// <param name="content">The original document received into the system. This format could potentially be anything though is most likely to be either Json or Xml. In the case where no other  interface is supported it is possible to fall back onto this.  For example, a trade from an external client system. This may be recognized internally by Lusid or simply passed through to another vendor system. (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo (required) (default to &quot;ExoticInstrument&quot;).</param>
        public ExoticInstrument(InstrumentDefinitionFormat instrumentFormat = default(InstrumentDefinitionFormat), string content = default(string), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            // to ensure "instrumentFormat" is required (not null)
            if (instrumentFormat == null)
            {
                throw new ArgumentNullException("instrumentFormat is a required property for ExoticInstrument and cannot be null");
            }
            this.InstrumentFormat = instrumentFormat;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for ExoticInstrument and cannot be null");
            }
            this.Content = content;
        }

        /// <summary>
        /// Gets or Sets InstrumentFormat
        /// </summary>
        [DataMember(Name = "instrumentFormat", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentDefinitionFormat InstrumentFormat { get; set; }

        /// <summary>
        /// The original document received into the system. This format could potentially be anything though is most likely to be either Json or Xml. In the case where no other  interface is supported it is possible to fall back onto this.  For example, a trade from an external client system. This may be recognized internally by Lusid or simply passed through to another vendor system.
        /// </summary>
        /// <value>The original document received into the system. This format could potentially be anything though is most likely to be either Json or Xml. In the case where no other  interface is supported it is possible to fall back onto this.  For example, a trade from an external client system. This may be recognized internally by Lusid or simply passed through to another vendor system.</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExoticInstrument {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  InstrumentFormat: ").Append(InstrumentFormat).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as ExoticInstrument);
        }

        /// <summary>
        /// Returns true if ExoticInstrument instances are equal
        /// </summary>
        /// <param name="input">Instance of ExoticInstrument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExoticInstrument input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.InstrumentFormat == input.InstrumentFormat ||
                    (this.InstrumentFormat != null &&
                    this.InstrumentFormat.Equals(input.InstrumentFormat))
                ) && base.Equals(input) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.InstrumentFormat != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentFormat.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
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
            // Content (string) minLength
            if (this.Content != null && this.Content.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Content, length must be greater than 1.", new [] { "Content" });
            }

            yield break;
        }
    }
}
