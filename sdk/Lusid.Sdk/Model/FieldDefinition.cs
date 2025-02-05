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
    /// FieldDefinition
    /// </summary>
    [DataContract(Name = "FieldDefinition")]
    public partial class FieldDefinition : IEquatable<FieldDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldDefinition" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        /// <param name="isRequired">isRequired (required).</param>
        /// <param name="isUnique">isUnique (required).</param>
        /// <param name="valueType">valueType.</param>
        public FieldDefinition(string key = default(string), bool isRequired = default(bool), bool isUnique = default(bool), string valueType = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for FieldDefinition and cannot be null");
            }
            this.Key = key;
            this.IsRequired = isRequired;
            this.IsUnique = isUnique;
            this.ValueType = valueType;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name = "isRequired", IsRequired = true, EmitDefaultValue = true)]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or Sets IsUnique
        /// </summary>
        [DataMember(Name = "isUnique", IsRequired = true, EmitDefaultValue = true)]
        public bool IsUnique { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "valueType", EmitDefaultValue = true)]
        public string ValueType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldDefinition {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  IsUnique: ").Append(IsUnique).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
            return this.Equals(input as FieldDefinition);
        }

        /// <summary>
        /// Returns true if FieldDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldDefinition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    this.IsRequired.Equals(input.IsRequired)
                ) && 
                (
                    this.IsUnique == input.IsUnique ||
                    this.IsUnique.Equals(input.IsUnique)
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsRequired.GetHashCode();
                hashCode = (hashCode * 59) + this.IsUnique.GetHashCode();
                if (this.ValueType != null)
                {
                    hashCode = (hashCode * 59) + this.ValueType.GetHashCode();
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
            // Key (string) maxLength
            if (this.Key != null && this.Key.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be less than 512.", new [] { "Key" });
            }

            // Key (string) minLength
            if (this.Key != null && this.Key.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be greater than 1.", new [] { "Key" });
            }

            // Key (string) pattern
            Regex regexKey = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexKey.Match(this.Key).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, must match a pattern of " + regexKey, new [] { "Key" });
            }

            yield break;
        }
    }
}
