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
    /// This request specifies single target holding. i.e. holding data that the  system should match. And deletes previous adjustment made to that holding
    /// </summary>
    [DataContract(Name = "CancelSingleHoldingAdjustmentRequest")]
    public partial class CancelSingleHoldingAdjustmentRequest : IEquatable<CancelSingleHoldingAdjustmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelSingleHoldingAdjustmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CancelSingleHoldingAdjustmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelSingleHoldingAdjustmentRequest" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">A set of instrument identifiers that can resolve the holding adjustment to a unique instrument. (required).</param>
        /// <param name="subHoldingKeys">The sub-holding properties which identify the holding. Each property must be from the &#39;Transaction&#39; domain..</param>
        /// <param name="currency">The Holding currency..</param>
        public CancelSingleHoldingAdjustmentRequest(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), string currency = default(string))
        {
            // to ensure "instrumentIdentifiers" is required (not null)
            if (instrumentIdentifiers == null)
            {
                throw new ArgumentNullException("instrumentIdentifiers is a required property for CancelSingleHoldingAdjustmentRequest and cannot be null");
            }
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.SubHoldingKeys = subHoldingKeys;
            this.Currency = currency;
        }

        /// <summary>
        /// A set of instrument identifiers that can resolve the holding adjustment to a unique instrument.
        /// </summary>
        /// <value>A set of instrument identifiers that can resolve the holding adjustment to a unique instrument.</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The sub-holding properties which identify the holding. Each property must be from the &#39;Transaction&#39; domain.
        /// </summary>
        /// <value>The sub-holding properties which identify the holding. Each property must be from the &#39;Transaction&#39; domain.</value>
        [DataMember(Name = "subHoldingKeys", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

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
            sb.Append("class CancelSingleHoldingAdjustmentRequest {\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
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
            return this.Equals(input as CancelSingleHoldingAdjustmentRequest);
        }

        /// <summary>
        /// Returns true if CancelSingleHoldingAdjustmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelSingleHoldingAdjustmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelSingleHoldingAdjustmentRequest input)
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