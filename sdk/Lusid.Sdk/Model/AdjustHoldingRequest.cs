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
    /// This request specifies target holdings. i.e. holding data that the  system should match. When processed by the movement  engine, it will create &#39;true-up&#39; adjustments on the fly.
    /// </summary>
    [DataContract(Name = "AdjustHoldingRequest")]
    public partial class AdjustHoldingRequest : IEquatable<AdjustHoldingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustHoldingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdjustHoldingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustHoldingRequest" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">A set of instrument identifiers that can resolve the holding adjustment to a unique instrument. (required).</param>
        /// <param name="subHoldingKeys">Set of unique transaction properties and associated values to store with the holding adjustment transaction automatically created by LUSID. Each property must be from the &#39;Transaction&#39; domain..</param>
        /// <param name="properties">Set of unique holding properties and associated values to store with the target holding. Each property must be from the &#39;Holding&#39; domain..</param>
        /// <param name="taxLots">The tax-lots that together make up the target holding. (required).</param>
        /// <param name="currency">The Holding currency. This needs to be equal with the one on the TaxLot -&gt; cost if one is specified.</param>
        public AdjustHoldingRequest(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), List<TargetTaxLotRequest> taxLots = default(List<TargetTaxLotRequest>), string currency = default(string))
        {
            // to ensure "instrumentIdentifiers" is required (not null)
            if (instrumentIdentifiers == null)
            {
                throw new ArgumentNullException("instrumentIdentifiers is a required property for AdjustHoldingRequest and cannot be null");
            }
            this.InstrumentIdentifiers = instrumentIdentifiers;
            // to ensure "taxLots" is required (not null)
            if (taxLots == null)
            {
                throw new ArgumentNullException("taxLots is a required property for AdjustHoldingRequest and cannot be null");
            }
            this.TaxLots = taxLots;
            this.SubHoldingKeys = subHoldingKeys;
            this.Properties = properties;
            this.Currency = currency;
        }

        /// <summary>
        /// A set of instrument identifiers that can resolve the holding adjustment to a unique instrument.
        /// </summary>
        /// <value>A set of instrument identifiers that can resolve the holding adjustment to a unique instrument.</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// Set of unique transaction properties and associated values to store with the holding adjustment transaction automatically created by LUSID. Each property must be from the &#39;Transaction&#39; domain.
        /// </summary>
        /// <value>Set of unique transaction properties and associated values to store with the holding adjustment transaction automatically created by LUSID. Each property must be from the &#39;Transaction&#39; domain.</value>
        [DataMember(Name = "subHoldingKeys", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// Set of unique holding properties and associated values to store with the target holding. Each property must be from the &#39;Holding&#39; domain.
        /// </summary>
        /// <value>Set of unique holding properties and associated values to store with the target holding. Each property must be from the &#39;Holding&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The tax-lots that together make up the target holding.
        /// </summary>
        /// <value>The tax-lots that together make up the target holding.</value>
        [DataMember(Name = "taxLots", IsRequired = true, EmitDefaultValue = true)]
        public List<TargetTaxLotRequest> TaxLots { get; set; }

        /// <summary>
        /// The Holding currency. This needs to be equal with the one on the TaxLot -&gt; cost if one is specified
        /// </summary>
        /// <value>The Holding currency. This needs to be equal with the one on the TaxLot -&gt; cost if one is specified</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdjustHoldingRequest {\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
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
            return this.Equals(input as AdjustHoldingRequest);
        }

        /// <summary>
        /// Returns true if AdjustHoldingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AdjustHoldingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdjustHoldingRequest input)
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
            yield break;
        }
    }
}
