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
    /// OrderGraphBlockPlacementSynopsis
    /// </summary>
    [DataContract(Name = "OrderGraphBlockPlacementSynopsis")]
    public partial class OrderGraphBlockPlacementSynopsis : IEquatable<OrderGraphBlockPlacementSynopsis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderGraphBlockPlacementSynopsis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderGraphBlockPlacementSynopsis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderGraphBlockPlacementSynopsis" /> class.
        /// </summary>
        /// <param name="quantity">Total number of units placed. (required).</param>
        /// <param name="quantityByState">Total number of units placed..</param>
        /// <param name="details">Identifiers for each placement in this block. (required).</param>
        public OrderGraphBlockPlacementSynopsis(decimal quantity = default(decimal), Dictionary<string, decimal> quantityByState = default(Dictionary<string, decimal>), List<OrderGraphBlockPlacementDetail> details = default(List<OrderGraphBlockPlacementDetail>))
        {
            this.Quantity = quantity;
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new ArgumentNullException("details is a required property for OrderGraphBlockPlacementSynopsis and cannot be null");
            }
            this.Details = details;
            this.QuantityByState = quantityByState;
        }

        /// <summary>
        /// Total number of units placed.
        /// </summary>
        /// <value>Total number of units placed.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Total number of units placed.
        /// </summary>
        /// <value>Total number of units placed.</value>
        [DataMember(Name = "quantityByState", EmitDefaultValue = true)]
        public Dictionary<string, decimal> QuantityByState { get; set; }

        /// <summary>
        /// Identifiers for each placement in this block.
        /// </summary>
        /// <value>Identifiers for each placement in this block.</value>
        [DataMember(Name = "details", IsRequired = true, EmitDefaultValue = true)]
        public List<OrderGraphBlockPlacementDetail> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderGraphBlockPlacementSynopsis {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  QuantityByState: ").Append(QuantityByState).Append("\n");
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
            return this.Equals(input as OrderGraphBlockPlacementSynopsis);
        }

        /// <summary>
        /// Returns true if OrderGraphBlockPlacementSynopsis instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderGraphBlockPlacementSynopsis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderGraphBlockPlacementSynopsis input)
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
                    this.QuantityByState == input.QuantityByState ||
                    this.QuantityByState != null &&
                    input.QuantityByState != null &&
                    this.QuantityByState.SequenceEqual(input.QuantityByState)
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
                if (this.QuantityByState != null)
                {
                    hashCode = (hashCode * 59) + this.QuantityByState.GetHashCode();
                }
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
