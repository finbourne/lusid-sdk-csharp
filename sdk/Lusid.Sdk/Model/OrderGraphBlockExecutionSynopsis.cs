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
    /// OrderGraphBlockExecutionSynopsis
    /// </summary>
    [DataContract(Name = "OrderGraphBlockExecutionSynopsis")]
    public partial class OrderGraphBlockExecutionSynopsis : IEquatable<OrderGraphBlockExecutionSynopsis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderGraphBlockExecutionSynopsis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderGraphBlockExecutionSynopsis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderGraphBlockExecutionSynopsis" /> class.
        /// </summary>
        /// <param name="quantity">Total number of units executed. (required).</param>
        /// <param name="details">Identifiers for each execution in this block. (required).</param>
        public OrderGraphBlockExecutionSynopsis(decimal quantity = default(decimal), List<OrderGraphBlockExecutionDetail> details = default(List<OrderGraphBlockExecutionDetail>))
        {
            this.Quantity = quantity;
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new ArgumentNullException("details is a required property for OrderGraphBlockExecutionSynopsis and cannot be null");
            }
            this.Details = details;
        }

        /// <summary>
        /// Total number of units executed.
        /// </summary>
        /// <value>Total number of units executed.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Identifiers for each execution in this block.
        /// </summary>
        /// <value>Identifiers for each execution in this block.</value>
        [DataMember(Name = "details", IsRequired = true, EmitDefaultValue = true)]
        public List<OrderGraphBlockExecutionDetail> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderGraphBlockExecutionSynopsis {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as OrderGraphBlockExecutionSynopsis);
        }

        /// <summary>
        /// Returns true if OrderGraphBlockExecutionSynopsis instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderGraphBlockExecutionSynopsis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderGraphBlockExecutionSynopsis input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
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
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
