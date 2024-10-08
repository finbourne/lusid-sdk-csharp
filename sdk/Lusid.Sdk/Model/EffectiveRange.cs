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
    /// EffectiveRange
    /// </summary>
    [DataContract(Name = "EffectiveRange")]
    public partial class EffectiveRange : IEquatable<EffectiveRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveRange" /> class.
        /// </summary>
        /// <param name="fromDate">The effective from datetime that this range applies to..</param>
        /// <param name="untilDate">The effective from datetime that this range applies to..</param>
        public EffectiveRange(DateTimeOffset fromDate = default(DateTimeOffset), DateTimeOffset untilDate = default(DateTimeOffset))
        {
            this.FromDate = fromDate;
            this.UntilDate = untilDate;
        }

        /// <summary>
        /// The effective from datetime that this range applies to.
        /// </summary>
        /// <value>The effective from datetime that this range applies to.</value>
        [DataMember(Name = "fromDate", EmitDefaultValue = false)]
        public DateTimeOffset FromDate { get; set; }

        /// <summary>
        /// The effective from datetime that this range applies to.
        /// </summary>
        /// <value>The effective from datetime that this range applies to.</value>
        [DataMember(Name = "untilDate", EmitDefaultValue = false)]
        public DateTimeOffset UntilDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EffectiveRange {\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  UntilDate: ").Append(UntilDate).Append("\n");
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
            return this.Equals(input as EffectiveRange);
        }

        /// <summary>
        /// Returns true if EffectiveRange instances are equal
        /// </summary>
        /// <param name="input">Instance of EffectiveRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EffectiveRange input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FromDate == input.FromDate ||
                    (this.FromDate != null &&
                    this.FromDate.Equals(input.FromDate))
                ) && 
                (
                    this.UntilDate == input.UntilDate ||
                    (this.UntilDate != null &&
                    this.UntilDate.Equals(input.UntilDate))
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
                if (this.FromDate != null)
                {
                    hashCode = (hashCode * 59) + this.FromDate.GetHashCode();
                }
                if (this.UntilDate != null)
                {
                    hashCode = (hashCode * 59) + this.UntilDate.GetHashCode();
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
            yield break;
        }
    }
}
