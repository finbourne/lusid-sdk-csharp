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
    /// The target holdings.
    /// </summary>
    [DataContract(Name = "HoldingAdjustment")]
    public partial class HoldingAdjustment : IEquatable<HoldingAdjustment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingAdjustment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HoldingAdjustment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingAdjustment" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">A set of instrument identifiers that can resolve the holding adjustment to a unique instrument..</param>
        /// <param name="instrumentScope">The scope of the instrument that the holding adjustment is in..</param>
        /// <param name="instrumentUid">The unqiue Lusid Instrument Id (LUID) of the instrument that the holding adjustment is in. (required).</param>
        /// <param name="subHoldingKeys">The set of unique transaction properties and associated values stored with the holding adjustment transactions automatically created by LUSID. Each property will be from the &#39;Transaction&#39; domain..</param>
        /// <param name="properties">The set of unique holding properties and associated values stored with the target holding. Each property will be from the &#39;Holding&#39; domain..</param>
        /// <param name="taxLots">The tax-lots that together make up the target holding. (required).</param>
        /// <param name="currency">The Holding currency..</param>
        public HoldingAdjustment(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), string instrumentScope = default(string), string instrumentUid = default(string), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), List<TargetTaxLot> taxLots = default(List<TargetTaxLot>), string currency = default(string))
        {
            // to ensure "instrumentUid" is required (not null)
            if (instrumentUid == null)
            {
                throw new ArgumentNullException("instrumentUid is a required property for HoldingAdjustment and cannot be null");
            }
            this.InstrumentUid = instrumentUid;
            // to ensure "taxLots" is required (not null)
            if (taxLots == null)
            {
                throw new ArgumentNullException("taxLots is a required property for HoldingAdjustment and cannot be null");
            }
            this.TaxLots = taxLots;
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.InstrumentScope = instrumentScope;
            this.SubHoldingKeys = subHoldingKeys;
            this.Properties = properties;
            this.Currency = currency;
        }

        /// <summary>
        /// A set of instrument identifiers that can resolve the holding adjustment to a unique instrument.
        /// </summary>
        /// <value>A set of instrument identifiers that can resolve the holding adjustment to a unique instrument.</value>
        [DataMember(Name = "instrumentIdentifiers", EmitDefaultValue = true)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The scope of the instrument that the holding adjustment is in.
        /// </summary>
        /// <value>The scope of the instrument that the holding adjustment is in.</value>
        [DataMember(Name = "instrumentScope", EmitDefaultValue = true)]
        public string InstrumentScope { get; set; }

        /// <summary>
        /// The unqiue Lusid Instrument Id (LUID) of the instrument that the holding adjustment is in.
        /// </summary>
        /// <value>The unqiue Lusid Instrument Id (LUID) of the instrument that the holding adjustment is in.</value>
        [DataMember(Name = "instrumentUid", IsRequired = true, EmitDefaultValue = true)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// The set of unique transaction properties and associated values stored with the holding adjustment transactions automatically created by LUSID. Each property will be from the &#39;Transaction&#39; domain.
        /// </summary>
        /// <value>The set of unique transaction properties and associated values stored with the holding adjustment transactions automatically created by LUSID. Each property will be from the &#39;Transaction&#39; domain.</value>
        [DataMember(Name = "subHoldingKeys", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// The set of unique holding properties and associated values stored with the target holding. Each property will be from the &#39;Holding&#39; domain.
        /// </summary>
        /// <value>The set of unique holding properties and associated values stored with the target holding. Each property will be from the &#39;Holding&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The tax-lots that together make up the target holding.
        /// </summary>
        /// <value>The tax-lots that together make up the target holding.</value>
        [DataMember(Name = "taxLots", IsRequired = true, EmitDefaultValue = true)]
        public List<TargetTaxLot> TaxLots { get; set; }

        /// <summary>
        /// The Holding currency.
        /// </summary>
        /// <value>The Holding currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HoldingAdjustment {\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  InstrumentScope: ").Append(InstrumentScope).Append("\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  TaxLots: ").Append(TaxLots).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as HoldingAdjustment);
        }

        /// <summary>
        /// Returns true if HoldingAdjustment instances are equal
        /// </summary>
        /// <param name="input">Instance of HoldingAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HoldingAdjustment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.InstrumentScope == input.InstrumentScope ||
                    (this.InstrumentScope != null &&
                    this.InstrumentScope.Equals(input.InstrumentScope))
                ) && 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.TaxLots == input.TaxLots ||
                    this.TaxLots != null &&
                    input.TaxLots != null &&
                    this.TaxLots.SequenceEqual(input.TaxLots)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.InstrumentIdentifiers != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentIdentifiers.GetHashCode();
                }
                if (this.InstrumentScope != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentScope.GetHashCode();
                }
                if (this.InstrumentUid != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentUid.GetHashCode();
                }
                if (this.SubHoldingKeys != null)
                {
                    hashCode = (hashCode * 59) + this.SubHoldingKeys.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.TaxLots != null)
                {
                    hashCode = (hashCode * 59) + this.TaxLots.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
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
            // InstrumentUid (string) minLength
            if (this.InstrumentUid != null && this.InstrumentUid.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentUid, length must be greater than 1.", new [] { "InstrumentUid" });
            }

            yield break;
        }
    }
}
