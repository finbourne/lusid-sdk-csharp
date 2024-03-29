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
    /// TransactionTypeCalculation
    /// </summary>
    [DataContract(Name = "TransactionTypeCalculation")]
    public partial class TransactionTypeCalculation : IEquatable<TransactionTypeCalculation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTypeCalculation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionTypeCalculation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTypeCalculation" /> class.
        /// </summary>
        /// <param name="type">The type of calculation to perform (required).</param>
        /// <param name="side">The side to which the calculation is applied (required).</param>
        public TransactionTypeCalculation(string type = default(string), string side = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for TransactionTypeCalculation and cannot be null");
            }
            this.Type = type;
            // to ensure "side" is required (not null)
            if (side == null)
            {
                throw new ArgumentNullException("side is a required property for TransactionTypeCalculation and cannot be null");
            }
            this.Side = side;
        }

        /// <summary>
        /// The type of calculation to perform
        /// </summary>
        /// <value>The type of calculation to perform</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The side to which the calculation is applied
        /// </summary>
        /// <value>The side to which the calculation is applied</value>
        [DataMember(Name = "side", IsRequired = true, EmitDefaultValue = true)]
        public string Side { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionTypeCalculation {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
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
            return this.Equals(input as TransactionTypeCalculation);
        }

        /// <summary>
        /// Returns true if TransactionTypeCalculation instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionTypeCalculation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionTypeCalculation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Side != null)
                {
                    hashCode = (hashCode * 59) + this.Side.GetHashCode();
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
            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            // Side (string) maxLength
            if (this.Side != null && this.Side.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Side, length must be less than 64.", new [] { "Side" });
            }

            // Side (string) minLength
            if (this.Side != null && this.Side.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Side, length must be greater than 1.", new [] { "Side" });
            }

            // Side (string) pattern
            Regex regexSide = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexSide.Match(this.Side).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Side, must match a pattern of " + regexSide, new [] { "Side" });
            }

            yield break;
        }
    }
}
