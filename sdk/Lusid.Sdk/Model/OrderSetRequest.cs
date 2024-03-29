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
    /// A request to create or update multiple Orders.
    /// </summary>
    [DataContract(Name = "OrderSetRequest")]
    public partial class OrderSetRequest : IEquatable<OrderSetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSetRequest" /> class.
        /// </summary>
        /// <param name="orderRequests">A collection of OrderRequests..</param>
        public OrderSetRequest(List<OrderRequest> orderRequests = default(List<OrderRequest>))
        {
            this.OrderRequests = orderRequests;
        }

        /// <summary>
        /// A collection of OrderRequests.
        /// </summary>
        /// <value>A collection of OrderRequests.</value>
        [DataMember(Name = "orderRequests", EmitDefaultValue = true)]
        public List<OrderRequest> OrderRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderSetRequest {\n");
            sb.Append("  OrderRequests: ").Append(OrderRequests).Append("\n");
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
            return this.Equals(input as OrderSetRequest);
        }

        /// <summary>
        /// Returns true if OrderSetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderSetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderSetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderRequests == input.OrderRequests ||
                    this.OrderRequests != null &&
                    input.OrderRequests != null &&
                    this.OrderRequests.SequenceEqual(input.OrderRequests)
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
                if (this.OrderRequests != null)
                {
                    hashCode = (hashCode * 59) + this.OrderRequests.GetHashCode();
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
