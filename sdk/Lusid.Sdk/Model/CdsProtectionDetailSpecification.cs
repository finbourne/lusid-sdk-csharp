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
    /// CDSs generally conform to fairly standard definitions, but can be tweaked in a number of different ways.  This class gathers a number of common features which may deviate. These will default to the market standard when  no overrides are provided.
    /// </summary>
    [DataContract(Name = "CdsProtectionDetailSpecification")]
    public partial class CdsProtectionDetailSpecification : IEquatable<CdsProtectionDetailSpecification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CdsProtectionDetailSpecification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CdsProtectionDetailSpecification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CdsProtectionDetailSpecification" /> class.
        /// </summary>
        /// <param name="seniority">The seniority level of the CDS.    Supported string (enumeration) values are: [SNR, SUB, JRSUBUT2, PREFT1, SECDOM, SNRFOR, SUBLT2]. (required).</param>
        /// <param name="restructuringType">The restructuring clause.  Supported string (enumeration) values are: [CR, MR, MM, XR]. (required).</param>
        /// <param name="protectStartDay">Does the protection leg pay out in the case of default on the start date. (required).</param>
        /// <param name="payAccruedInterestOnDefault">Should accrued interest on the premium leg be paid if a credit event occurs. (required).</param>
        public CdsProtectionDetailSpecification(string seniority = default(string), string restructuringType = default(string), bool protectStartDay = default(bool), bool payAccruedInterestOnDefault = default(bool))
        {
            // to ensure "seniority" is required (not null)
            if (seniority == null)
            {
                throw new ArgumentNullException("seniority is a required property for CdsProtectionDetailSpecification and cannot be null");
            }
            this.Seniority = seniority;
            // to ensure "restructuringType" is required (not null)
            if (restructuringType == null)
            {
                throw new ArgumentNullException("restructuringType is a required property for CdsProtectionDetailSpecification and cannot be null");
            }
            this.RestructuringType = restructuringType;
            this.ProtectStartDay = protectStartDay;
            this.PayAccruedInterestOnDefault = payAccruedInterestOnDefault;
        }

        /// <summary>
        /// The seniority level of the CDS.    Supported string (enumeration) values are: [SNR, SUB, JRSUBUT2, PREFT1, SECDOM, SNRFOR, SUBLT2].
        /// </summary>
        /// <value>The seniority level of the CDS.    Supported string (enumeration) values are: [SNR, SUB, JRSUBUT2, PREFT1, SECDOM, SNRFOR, SUBLT2].</value>
        [DataMember(Name = "seniority", IsRequired = true, EmitDefaultValue = true)]
        public string Seniority { get; set; }

        /// <summary>
        /// The restructuring clause.  Supported string (enumeration) values are: [CR, MR, MM, XR].
        /// </summary>
        /// <value>The restructuring clause.  Supported string (enumeration) values are: [CR, MR, MM, XR].</value>
        [DataMember(Name = "restructuringType", IsRequired = true, EmitDefaultValue = true)]
        public string RestructuringType { get; set; }

        /// <summary>
        /// Does the protection leg pay out in the case of default on the start date.
        /// </summary>
        /// <value>Does the protection leg pay out in the case of default on the start date.</value>
        [DataMember(Name = "protectStartDay", IsRequired = true, EmitDefaultValue = true)]
        public bool ProtectStartDay { get; set; }

        /// <summary>
        /// Should accrued interest on the premium leg be paid if a credit event occurs.
        /// </summary>
        /// <value>Should accrued interest on the premium leg be paid if a credit event occurs.</value>
        [DataMember(Name = "payAccruedInterestOnDefault", IsRequired = true, EmitDefaultValue = true)]
        public bool PayAccruedInterestOnDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CdsProtectionDetailSpecification {\n");
            sb.Append("  Seniority: ").Append(Seniority).Append("\n");
            sb.Append("  RestructuringType: ").Append(RestructuringType).Append("\n");
            sb.Append("  ProtectStartDay: ").Append(ProtectStartDay).Append("\n");
            sb.Append("  PayAccruedInterestOnDefault: ").Append(PayAccruedInterestOnDefault).Append("\n");
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
            return this.Equals(input as CdsProtectionDetailSpecification);
        }

        /// <summary>
        /// Returns true if CdsProtectionDetailSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of CdsProtectionDetailSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdsProtectionDetailSpecification input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Seniority == input.Seniority ||
                    (this.Seniority != null &&
                    this.Seniority.Equals(input.Seniority))
                ) && 
                (
                    this.RestructuringType == input.RestructuringType ||
                    (this.RestructuringType != null &&
                    this.RestructuringType.Equals(input.RestructuringType))
                ) && 
                (
                    this.ProtectStartDay == input.ProtectStartDay ||
                    this.ProtectStartDay.Equals(input.ProtectStartDay)
                ) && 
                (
                    this.PayAccruedInterestOnDefault == input.PayAccruedInterestOnDefault ||
                    this.PayAccruedInterestOnDefault.Equals(input.PayAccruedInterestOnDefault)
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
                if (this.Seniority != null)
                {
                    hashCode = (hashCode * 59) + this.Seniority.GetHashCode();
                }
                if (this.RestructuringType != null)
                {
                    hashCode = (hashCode * 59) + this.RestructuringType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProtectStartDay.GetHashCode();
                hashCode = (hashCode * 59) + this.PayAccruedInterestOnDefault.GetHashCode();
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
            // Seniority (string) minLength
            if (this.Seniority != null && this.Seniority.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Seniority, length must be greater than 1.", new [] { "Seniority" });
            }

            // RestructuringType (string) minLength
            if (this.RestructuringType != null && this.RestructuringType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RestructuringType, length must be greater than 1.", new [] { "RestructuringType" });
            }

            yield break;
        }
    }
}
