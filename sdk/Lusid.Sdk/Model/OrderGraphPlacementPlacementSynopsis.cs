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
    /// OrderGraphPlacementPlacementSynopsis
    /// </summary>
    [DataContract(Name = "OrderGraphPlacementPlacementSynopsis")]
    public partial class OrderGraphPlacementPlacementSynopsis : IEquatable<OrderGraphPlacementPlacementSynopsis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderGraphPlacementPlacementSynopsis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderGraphPlacementPlacementSynopsis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderGraphPlacementPlacementSynopsis" /> class.
        /// </summary>
        /// <param name="details">Identifiers for each child placement for this placement. (required).</param>
        /// <param name="quantity">Total number of units placed. (required).</param>
        public OrderGraphPlacementPlacementSynopsis(List<OrderGraphPlacementChildPlacementDetail> details = default(List<OrderGraphPlacementChildPlacementDetail>), decimal quantity = default(decimal))
        {
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new ArgumentNullException("details is a required property for OrderGraphPlacementPlacementSynopsis and cannot be null");
            }
            this.Details = details;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Identifiers for each child placement for this placement.
        /// </summary>
        /// <value>Identifiers for each child placement for this placement.</value>
        [DataMember(Name = "details", IsRequired = true, EmitDefaultValue = true)]
        public List<OrderGraphPlacementChildPlacementDetail> Details { get; set; }

        /// <summary>
        /// Total number of units placed.
        /// </summary>
        /// <value>Total number of units placed.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderGraphPlacementPlacementSynopsis {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as OrderGraphPlacementPlacementSynopsis);
        }

        /// <summary>
        /// Returns true if OrderGraphPlacementPlacementSynopsis instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderGraphPlacementPlacementSynopsis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderGraphPlacementPlacementSynopsis input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
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
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
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
