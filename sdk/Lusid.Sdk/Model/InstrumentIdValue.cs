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
    /// InstrumentIdValue
    /// </summary>
    [DataContract(Name = "InstrumentIdValue")]
    public partial class InstrumentIdValue : IEquatable<InstrumentIdValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentIdValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstrumentIdValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentIdValue" /> class.
        /// </summary>
        /// <param name="value">The value of the identifier. (required).</param>
        /// <param name="effectiveAt">The effective datetime from which the identifier will be valid. If left unspecified the default value is the beginning of time..</param>
        public InstrumentIdValue(string value = default(string), DateTimeOffset effectiveAt = default(DateTimeOffset))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for InstrumentIdValue and cannot be null");
            }
            this.Value = value;
            this.EffectiveAt = effectiveAt;
        }

        /// <summary>
        /// The value of the identifier.
        /// </summary>
        /// <value>The value of the identifier.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// The effective datetime from which the identifier will be valid. If left unspecified the default value is the beginning of time.
        /// </summary>
        /// <value>The effective datetime from which the identifier will be valid. If left unspecified the default value is the beginning of time.</value>
        [DataMember(Name = "effectiveAt", EmitDefaultValue = false)]
        public DateTimeOffset EffectiveAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstrumentIdValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
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
            return this.Equals(input as InstrumentIdValue);
        }

        /// <summary>
        /// Returns true if InstrumentIdValue instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentIdValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentIdValue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.EffectiveAt != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveAt.GetHashCode();
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
            // Value (string) minLength
            if (this.Value != null && this.Value.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be greater than 1.", new [] { "Value" });
            }

            yield break;
        }
    }
}
