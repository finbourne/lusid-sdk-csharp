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
    /// TransactionTypePropertyMapping
    /// </summary>
    [DataContract(Name = "TransactionTypePropertyMapping")]
    public partial class TransactionTypePropertyMapping : IEquatable<TransactionTypePropertyMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTypePropertyMapping" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionTypePropertyMapping() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTypePropertyMapping" /> class.
        /// </summary>
        /// <param name="propertyKey">The key that uniquely identifies the property. It has the format {domain}/{scope}/{code} (required).</param>
        /// <param name="mapFrom">The Property Key of the Property to map from.</param>
        /// <param name="setTo">A pointer to the Property being mapped from.</param>
        /// <param name="templateFrom">The template that defines how the property value is constructed from transaction, instrument and portfolio details..</param>
        /// <param name="nullify">Flag to unset the Property Key for the mapping.</param>
        public TransactionTypePropertyMapping(string propertyKey = default(string), string mapFrom = default(string), string setTo = default(string), string templateFrom = default(string), bool? nullify = default(bool?))
        {
            // to ensure "propertyKey" is required (not null)
            if (propertyKey == null)
            {
                throw new ArgumentNullException("propertyKey is a required property for TransactionTypePropertyMapping and cannot be null");
            }
            this.PropertyKey = propertyKey;
            this.MapFrom = mapFrom;
            this.SetTo = setTo;
            this.TemplateFrom = templateFrom;
            this.Nullify = nullify;
        }

        /// <summary>
        /// The key that uniquely identifies the property. It has the format {domain}/{scope}/{code}
        /// </summary>
        /// <value>The key that uniquely identifies the property. It has the format {domain}/{scope}/{code}</value>
        [DataMember(Name = "propertyKey", IsRequired = true, EmitDefaultValue = true)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// The Property Key of the Property to map from
        /// </summary>
        /// <value>The Property Key of the Property to map from</value>
        [DataMember(Name = "mapFrom", EmitDefaultValue = true)]
        public string MapFrom { get; set; }

        /// <summary>
        /// A pointer to the Property being mapped from
        /// </summary>
        /// <value>A pointer to the Property being mapped from</value>
        [DataMember(Name = "setTo", EmitDefaultValue = true)]
        public string SetTo { get; set; }

        /// <summary>
        /// The template that defines how the property value is constructed from transaction, instrument and portfolio details.
        /// </summary>
        /// <value>The template that defines how the property value is constructed from transaction, instrument and portfolio details.</value>
        [DataMember(Name = "templateFrom", EmitDefaultValue = true)]
        public string TemplateFrom { get; set; }

        /// <summary>
        /// Flag to unset the Property Key for the mapping
        /// </summary>
        /// <value>Flag to unset the Property Key for the mapping</value>
        [DataMember(Name = "nullify", EmitDefaultValue = true)]
        public bool? Nullify { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionTypePropertyMapping {\n");
            sb.Append("  PropertyKey: ").Append(PropertyKey).Append("\n");
            sb.Append("  MapFrom: ").Append(MapFrom).Append("\n");
            sb.Append("  SetTo: ").Append(SetTo).Append("\n");
            sb.Append("  TemplateFrom: ").Append(TemplateFrom).Append("\n");
            sb.Append("  Nullify: ").Append(Nullify).Append("\n");
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
            return this.Equals(input as TransactionTypePropertyMapping);
        }

        /// <summary>
        /// Returns true if TransactionTypePropertyMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionTypePropertyMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionTypePropertyMapping input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PropertyKey == input.PropertyKey ||
                    (this.PropertyKey != null &&
                    this.PropertyKey.Equals(input.PropertyKey))
                ) && 
                (
                    this.MapFrom == input.MapFrom ||
                    (this.MapFrom != null &&
                    this.MapFrom.Equals(input.MapFrom))
                ) && 
                (
                    this.SetTo == input.SetTo ||
                    (this.SetTo != null &&
                    this.SetTo.Equals(input.SetTo))
                ) && 
                (
                    this.TemplateFrom == input.TemplateFrom ||
                    (this.TemplateFrom != null &&
                    this.TemplateFrom.Equals(input.TemplateFrom))
                ) && 
                (
                    this.Nullify == input.Nullify ||
                    (this.Nullify != null &&
                    this.Nullify.Equals(input.Nullify))
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
                if (this.PropertyKey != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyKey.GetHashCode();
                }
                if (this.MapFrom != null)
                {
                    hashCode = (hashCode * 59) + this.MapFrom.GetHashCode();
                }
                if (this.SetTo != null)
                {
                    hashCode = (hashCode * 59) + this.SetTo.GetHashCode();
                }
                if (this.TemplateFrom != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateFrom.GetHashCode();
                }
                if (this.Nullify != null)
                {
                    hashCode = (hashCode * 59) + this.Nullify.GetHashCode();
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
            // SetTo (string) maxLength
            if (this.SetTo != null && this.SetTo.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SetTo, length must be less than 512.", new [] { "SetTo" });
            }

            // SetTo (string) minLength
            if (this.SetTo != null && this.SetTo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SetTo, length must be greater than 0.", new [] { "SetTo" });
            }

            // SetTo (string) pattern
            Regex regexSetTo = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexSetTo.Match(this.SetTo).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SetTo, must match a pattern of " + regexSetTo, new [] { "SetTo" });
            }

            // TemplateFrom (string) maxLength
            if (this.TemplateFrom != null && this.TemplateFrom.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TemplateFrom, length must be less than 512.", new [] { "TemplateFrom" });
            }

            // TemplateFrom (string) minLength
            if (this.TemplateFrom != null && this.TemplateFrom.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TemplateFrom, length must be greater than 1.", new [] { "TemplateFrom" });
            }

            // TemplateFrom (string) pattern
            Regex regexTemplateFrom = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexTemplateFrom.Match(this.TemplateFrom).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TemplateFrom, must match a pattern of " + regexTemplateFrom, new [] { "TemplateFrom" });
            }

            yield break;
        }
    }
}
