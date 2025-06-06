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
    /// FieldValue
    /// </summary>
    [DataContract(Name = "FieldValue")]
    public partial class FieldValue : IEquatable<FieldValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldValue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValue" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="fields">fields.</param>
        /// <param name="numericFields">numericFields.</param>
        public FieldValue(string value = default(string), Dictionary<string, string> fields = default(Dictionary<string, string>), Dictionary<string, decimal> numericFields = default(Dictionary<string, decimal>))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for FieldValue and cannot be null");
            }
            this.Value = value;
            this.Fields = fields;
            this.NumericFields = numericFields;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public Dictionary<string, string> Fields { get; set; }

        /// <summary>
        /// Gets or Sets NumericFields
        /// </summary>
        [DataMember(Name = "numericFields", EmitDefaultValue = true)]
        public Dictionary<string, decimal> NumericFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  NumericFields: ").Append(NumericFields).Append("\n");
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
            return this.Equals(input as FieldValue);
        }

        /// <summary>
        /// Returns true if FieldValue instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValue input)
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
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.NumericFields == input.NumericFields ||
                    this.NumericFields != null &&
                    input.NumericFields != null &&
                    this.NumericFields.SequenceEqual(input.NumericFields)
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
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.NumericFields != null)
                {
                    hashCode = (hashCode * 59) + this.NumericFields.GetHashCode();
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
            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than 512.", new [] { "Value" });
            }

            // Value (string) minLength
            if (this.Value != null && this.Value.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be greater than 1.", new [] { "Value" });
            }

            // Value (string) pattern
            Regex regexValue = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexValue.Match(this.Value).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must match a pattern of " + regexValue, new [] { "Value" });
            }

            yield break;
        }
    }
}
