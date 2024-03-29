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
    /// PropertyInterval
    /// </summary>
    [DataContract(Name = "PropertyInterval")]
    public partial class PropertyInterval : IEquatable<PropertyInterval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInterval" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyInterval() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInterval" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="effectiveRange">effectiveRange (required).</param>
        /// <param name="asAtRange">asAtRange (required).</param>
        /// <param name="status">Indicates whether the value is part of the prevailing effective date timeline for the requested asAt date, or whether it has been superseded by correctional activity (required).</param>
        public PropertyInterval(PropertyValue value = default(PropertyValue), DateRange effectiveRange = default(DateRange), DateRange asAtRange = default(DateRange), string status = default(string))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for PropertyInterval and cannot be null");
            }
            this.Value = value;
            // to ensure "effectiveRange" is required (not null)
            if (effectiveRange == null)
            {
                throw new ArgumentNullException("effectiveRange is a required property for PropertyInterval and cannot be null");
            }
            this.EffectiveRange = effectiveRange;
            // to ensure "asAtRange" is required (not null)
            if (asAtRange == null)
            {
                throw new ArgumentNullException("asAtRange is a required property for PropertyInterval and cannot be null");
            }
            this.AsAtRange = asAtRange;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for PropertyInterval and cannot be null");
            }
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public PropertyValue Value { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveRange
        /// </summary>
        [DataMember(Name = "effectiveRange", IsRequired = true, EmitDefaultValue = true)]
        public DateRange EffectiveRange { get; set; }

        /// <summary>
        /// Gets or Sets AsAtRange
        /// </summary>
        [DataMember(Name = "asAtRange", IsRequired = true, EmitDefaultValue = true)]
        public DateRange AsAtRange { get; set; }

        /// <summary>
        /// Indicates whether the value is part of the prevailing effective date timeline for the requested asAt date, or whether it has been superseded by correctional activity
        /// </summary>
        /// <value>Indicates whether the value is part of the prevailing effective date timeline for the requested asAt date, or whether it has been superseded by correctional activity</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyInterval {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  EffectiveRange: ").Append(EffectiveRange).Append("\n");
            sb.Append("  AsAtRange: ").Append(AsAtRange).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PropertyInterval);
        }

        /// <summary>
        /// Returns true if PropertyInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyInterval input)
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
                    this.EffectiveRange == input.EffectiveRange ||
                    (this.EffectiveRange != null &&
                    this.EffectiveRange.Equals(input.EffectiveRange))
                ) && 
                (
                    this.AsAtRange == input.AsAtRange ||
                    (this.AsAtRange != null &&
                    this.AsAtRange.Equals(input.AsAtRange))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.EffectiveRange != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveRange.GetHashCode();
                }
                if (this.AsAtRange != null)
                {
                    hashCode = (hashCode * 59) + this.AsAtRange.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            yield break;
        }
    }
}
