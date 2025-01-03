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
    /// Strategy
    /// </summary>
    [DataContract(Name = "Strategy")]
    public partial class Strategy : IEquatable<Strategy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Strategy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Strategy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Strategy" /> class.
        /// </summary>
        /// <param name="keys">keys (required).</param>
        /// <param name="valueType">valueType (required).</param>
        /// <param name="value">value (required).</param>
        public Strategy(List<PerpetualProperty> keys = default(List<PerpetualProperty>), string valueType = default(string), decimal value = default(decimal))
        {
            // to ensure "keys" is required (not null)
            if (keys == null)
            {
                throw new ArgumentNullException("keys is a required property for Strategy and cannot be null");
            }
            this.Keys = keys;
            // to ensure "valueType" is required (not null)
            if (valueType == null)
            {
                throw new ArgumentNullException("valueType is a required property for Strategy and cannot be null");
            }
            this.ValueType = valueType;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Keys
        /// </summary>
        [DataMember(Name = "keys", IsRequired = true, EmitDefaultValue = true)]
        public List<PerpetualProperty> Keys { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "valueType", IsRequired = true, EmitDefaultValue = true)]
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public decimal Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Strategy {\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Strategy);
        }

        /// <summary>
        /// Returns true if Strategy instances are equal
        /// </summary>
        /// <param name="input">Instance of Strategy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Strategy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Keys == input.Keys ||
                    this.Keys != null &&
                    input.Keys != null &&
                    this.Keys.SequenceEqual(input.Keys)
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.Keys != null)
                {
                    hashCode = (hashCode * 59) + this.Keys.GetHashCode();
                }
                if (this.ValueType != null)
                {
                    hashCode = (hashCode * 59) + this.ValueType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
            // ValueType (string) minLength
            if (this.ValueType != null && this.ValueType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ValueType, length must be greater than 1.", new [] { "ValueType" });
            }

            yield break;
        }
    }
}
