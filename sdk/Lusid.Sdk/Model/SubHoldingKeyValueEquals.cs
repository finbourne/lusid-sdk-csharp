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
    /// A criterion that checks whether a SubHoldingKey Value is equal to the given string value
    /// </summary>
    [DataContract(Name = "SubHoldingKeyValueEquals")]
    [JsonConverter(typeof(JsonSubtypes), "CriterionType")]
    public partial class SubHoldingKeyValueEquals : MatchCriterion, IEquatable<SubHoldingKeyValueEquals>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubHoldingKeyValueEquals" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubHoldingKeyValueEquals() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubHoldingKeyValueEquals" /> class.
        /// </summary>
        /// <param name="subHoldingKey">The sub holding key whose value will form the left-hand side of the operation (required).</param>
        /// <param name="value">The value to be compared against (required).</param>
        /// <param name="criterionType">The available values are: PropertyValueEquals, PropertyValueIn, SubHoldingKeyValueEquals (required) (default to &quot;SubHoldingKeyValueEquals&quot;).</param>
        public SubHoldingKeyValueEquals(string subHoldingKey = default(string), string value = default(string), CriterionTypeEnum criterionType = default(CriterionTypeEnum)) : base(criterionType)
        {
            // to ensure "subHoldingKey" is required (not null)
            if (subHoldingKey == null)
            {
                throw new ArgumentNullException("subHoldingKey is a required property for SubHoldingKeyValueEquals and cannot be null");
            }
            this.SubHoldingKey = subHoldingKey;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for SubHoldingKeyValueEquals and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// The sub holding key whose value will form the left-hand side of the operation
        /// </summary>
        /// <value>The sub holding key whose value will form the left-hand side of the operation</value>
        [DataMember(Name = "subHoldingKey", IsRequired = true, EmitDefaultValue = true)]
        public string SubHoldingKey { get; set; }

        /// <summary>
        /// The value to be compared against
        /// </summary>
        /// <value>The value to be compared against</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubHoldingKeyValueEquals {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SubHoldingKey: ").Append(SubHoldingKey).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SubHoldingKeyValueEquals);
        }

        /// <summary>
        /// Returns true if SubHoldingKeyValueEquals instances are equal
        /// </summary>
        /// <param name="input">Instance of SubHoldingKeyValueEquals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubHoldingKeyValueEquals input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.SubHoldingKey == input.SubHoldingKey ||
                    (this.SubHoldingKey != null &&
                    this.SubHoldingKey.Equals(input.SubHoldingKey))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.SubHoldingKey != null)
                {
                    hashCode = (hashCode * 59) + this.SubHoldingKey.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than 1024.", new [] { "Value" });
            }

            // Value (string) minLength
            if (this.Value != null && this.Value.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be greater than 0.", new [] { "Value" });
            }

            yield break;
        }
    }
}