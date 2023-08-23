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
    /// A2B Breakdown - Shows the total, and each sub-element within an A2B Category
    /// </summary>
    [DataContract(Name = "A2BBreakdown")]
    public partial class A2BBreakdown : IEquatable<A2BBreakdown>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="A2BBreakdown" /> class.
        /// </summary>
        /// <param name="total">The total value of all the components within this category..</param>
        /// <param name="currency">The currency. Applies to the Total, as well as all the componenents..</param>
        /// <param name="components">The individual components that make up the category. For example, the Start category may have Cost, Unrealised gains and accrued interest components..</param>
        public A2BBreakdown(decimal total = default(decimal), string currency = default(string), Dictionary<string, decimal> components = default(Dictionary<string, decimal>))
        {
            this.Total = total;
            this.Currency = currency;
            this.Components = components;
        }

        /// <summary>
        /// The total value of all the components within this category.
        /// </summary>
        /// <value>The total value of all the components within this category.</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public decimal Total { get; set; }

        /// <summary>
        /// The currency. Applies to the Total, as well as all the componenents.
        /// </summary>
        /// <value>The currency. Applies to the Total, as well as all the componenents.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The individual components that make up the category. For example, the Start category may have Cost, Unrealised gains and accrued interest components.
        /// </summary>
        /// <value>The individual components that make up the category. For example, the Start category may have Cost, Unrealised gains and accrued interest components.</value>
        [DataMember(Name = "components", EmitDefaultValue = true)]
        public Dictionary<string, decimal> Components { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class A2BBreakdown {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
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
            return this.Equals(input as A2BBreakdown);
        }

        /// <summary>
        /// Returns true if A2BBreakdown instances are equal
        /// </summary>
        /// <param name="input">Instance of A2BBreakdown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(A2BBreakdown input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Components == input.Components ||
                    this.Components != null &&
                    input.Components != null &&
                    this.Components.SequenceEqual(input.Components)
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
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Components != null)
                {
                    hashCode = (hashCode * 59) + this.Components.GetHashCode();
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
