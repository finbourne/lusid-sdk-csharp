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
        /// <param name="seniority">The seniority level of the CDS.  Supported string (enumeration) values are: [SNR, SUB, JRSUBUT2, PREFT1, SECDOM, SNRFOR, SUBLT2].  Defaults to \&quot;SUB\&quot; if not set. (default to &quot;SUB&quot;).</param>
        /// <param name="restructuringType">The restructuring clause.  Supported string (enumeration) values are: [CR, MR, MM, XR]. Defaults to \&quot;MM\&quot; if not set. (default to &quot;MM&quot;).</param>
        /// <param name="protectStartDay">Does the protection leg pay out in the case of default on the start date. Defaults to true if not set. (default to true).</param>
        /// <param name="payAccruedInterestOnDefault">Should accrued interest on the premium leg be paid if a credit event occurs. Defaults to true if not set. (default to true).</param>
        public CdsProtectionDetailSpecification(string seniority = @"SUB", string restructuringType = @"MM", bool protectStartDay = true, bool payAccruedInterestOnDefault = true)
        {
            // use default value if no "seniority" provided
            this.Seniority = seniority ?? @"SUB";
            // use default value if no "restructuringType" provided
            this.RestructuringType = restructuringType ?? @"MM";
            this.ProtectStartDay = protectStartDay;
            this.PayAccruedInterestOnDefault = payAccruedInterestOnDefault;
        }

        /// <summary>
        /// The seniority level of the CDS.  Supported string (enumeration) values are: [SNR, SUB, JRSUBUT2, PREFT1, SECDOM, SNRFOR, SUBLT2].  Defaults to \&quot;SUB\&quot; if not set.
        /// </summary>
        /// <value>The seniority level of the CDS.  Supported string (enumeration) values are: [SNR, SUB, JRSUBUT2, PREFT1, SECDOM, SNRFOR, SUBLT2].  Defaults to \&quot;SUB\&quot; if not set.</value>
        [DataMember(Name = "seniority", EmitDefaultValue = true)]
        public string Seniority { get; set; }

        /// <summary>
        /// The restructuring clause.  Supported string (enumeration) values are: [CR, MR, MM, XR]. Defaults to \&quot;MM\&quot; if not set.
        /// </summary>
        /// <value>The restructuring clause.  Supported string (enumeration) values are: [CR, MR, MM, XR]. Defaults to \&quot;MM\&quot; if not set.</value>
        [DataMember(Name = "restructuringType", EmitDefaultValue = true)]
        public string RestructuringType { get; set; }

        /// <summary>
        /// Does the protection leg pay out in the case of default on the start date. Defaults to true if not set.
        /// </summary>
        /// <value>Does the protection leg pay out in the case of default on the start date. Defaults to true if not set.</value>
        [DataMember(Name = "protectStartDay", EmitDefaultValue = true)]
        public bool ProtectStartDay { get; set; }

        /// <summary>
        /// Should accrued interest on the premium leg be paid if a credit event occurs. Defaults to true if not set.
        /// </summary>
        /// <value>Should accrued interest on the premium leg be paid if a credit event occurs. Defaults to true if not set.</value>
        [DataMember(Name = "payAccruedInterestOnDefault", EmitDefaultValue = true)]
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
            yield break;
        }
    }
}
