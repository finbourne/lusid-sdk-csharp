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
    /// Strike price against par and associated date for a bond call.
    /// </summary>
    [DataContract(Name = "OptionEntry")]
    public partial class OptionEntry : IEquatable<OptionEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OptionEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionEntry" /> class.
        /// </summary>
        /// <param name="strike">The strike on this date (required).</param>
        /// <param name="date">The date at which the option can be actioned at this strike (required).</param>
        /// <param name="endDate">If American exercise, this is the end of the exercise period.  Optional field. Defaults to the Date field if not set..</param>
        public OptionEntry(decimal strike = default(decimal), DateTimeOffset date = default(DateTimeOffset), DateTimeOffset? endDate = default(DateTimeOffset?))
        {
            this.Strike = strike;
            this.Date = date;
            this.EndDate = endDate;
        }

        /// <summary>
        /// The strike on this date
        /// </summary>
        /// <value>The strike on this date</value>
        [DataMember(Name = "strike", IsRequired = true, EmitDefaultValue = true)]
        public decimal Strike { get; set; }

        /// <summary>
        /// The date at which the option can be actioned at this strike
        /// </summary>
        /// <value>The date at which the option can be actioned at this strike</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// If American exercise, this is the end of the exercise period.  Optional field. Defaults to the Date field if not set.
        /// </summary>
        /// <value>If American exercise, this is the end of the exercise period.  Optional field. Defaults to the Date field if not set.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OptionEntry {\n");
            sb.Append("  Strike: ").Append(Strike).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as OptionEntry);
        }

        /// <summary>
        /// Returns true if OptionEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionEntry input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Strike == input.Strike ||
                    this.Strike.Equals(input.Strike)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                hashCode = (hashCode * 59) + this.Strike.GetHashCode();
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
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
