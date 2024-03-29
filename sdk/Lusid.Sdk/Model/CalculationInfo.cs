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
    /// CalculationInfo
    /// </summary>
    [DataContract(Name = "CalculationInfo")]
    public partial class CalculationInfo : IEquatable<CalculationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculationInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CalculationInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculationInfo" /> class.
        /// </summary>
        /// <param name="calculationMethod">Method of calculating the fees or commission among: BasisPoints, Percentage, Rate, Flat etc. (required).</param>
        /// <param name="multiplier">Field by which to multiply the numerical amount. Eg: Quantity, Value (required).</param>
        /// <param name="calculationAmount">Numerical fee amount (required).</param>
        public CalculationInfo(string calculationMethod = default(string), string multiplier = default(string), decimal calculationAmount = default(decimal))
        {
            // to ensure "calculationMethod" is required (not null)
            if (calculationMethod == null)
            {
                throw new ArgumentNullException("calculationMethod is a required property for CalculationInfo and cannot be null");
            }
            this.CalculationMethod = calculationMethod;
            // to ensure "multiplier" is required (not null)
            if (multiplier == null)
            {
                throw new ArgumentNullException("multiplier is a required property for CalculationInfo and cannot be null");
            }
            this.Multiplier = multiplier;
            this.CalculationAmount = calculationAmount;
        }

        /// <summary>
        /// Method of calculating the fees or commission among: BasisPoints, Percentage, Rate, Flat etc.
        /// </summary>
        /// <value>Method of calculating the fees or commission among: BasisPoints, Percentage, Rate, Flat etc.</value>
        [DataMember(Name = "calculationMethod", IsRequired = true, EmitDefaultValue = true)]
        public string CalculationMethod { get; set; }

        /// <summary>
        /// Field by which to multiply the numerical amount. Eg: Quantity, Value
        /// </summary>
        /// <value>Field by which to multiply the numerical amount. Eg: Quantity, Value</value>
        [DataMember(Name = "multiplier", IsRequired = true, EmitDefaultValue = true)]
        public string Multiplier { get; set; }

        /// <summary>
        /// Numerical fee amount
        /// </summary>
        /// <value>Numerical fee amount</value>
        [DataMember(Name = "calculationAmount", IsRequired = true, EmitDefaultValue = true)]
        public decimal CalculationAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CalculationInfo {\n");
            sb.Append("  CalculationMethod: ").Append(CalculationMethod).Append("\n");
            sb.Append("  Multiplier: ").Append(Multiplier).Append("\n");
            sb.Append("  CalculationAmount: ").Append(CalculationAmount).Append("\n");
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
            return this.Equals(input as CalculationInfo);
        }

        /// <summary>
        /// Returns true if CalculationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculationInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CalculationMethod == input.CalculationMethod ||
                    (this.CalculationMethod != null &&
                    this.CalculationMethod.Equals(input.CalculationMethod))
                ) && 
                (
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
                ) && 
                (
                    this.CalculationAmount == input.CalculationAmount ||
                    this.CalculationAmount.Equals(input.CalculationAmount)
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
                if (this.CalculationMethod != null)
                {
                    hashCode = (hashCode * 59) + this.CalculationMethod.GetHashCode();
                }
                if (this.Multiplier != null)
                {
                    hashCode = (hashCode * 59) + this.Multiplier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CalculationAmount.GetHashCode();
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
            // CalculationMethod (string) minLength
            if (this.CalculationMethod != null && this.CalculationMethod.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CalculationMethod, length must be greater than 1.", new [] { "CalculationMethod" });
            }

            // Multiplier (string) minLength
            if (this.Multiplier != null && this.Multiplier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Multiplier, length must be greater than 1.", new [] { "Multiplier" });
            }

            yield break;
        }
    }
}
