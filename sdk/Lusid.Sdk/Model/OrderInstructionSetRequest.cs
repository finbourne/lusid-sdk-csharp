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
    /// A request to create or update multiple OrderInstructions.
    /// </summary>
    [DataContract(Name = "OrderInstructionSetRequest")]
    public partial class OrderInstructionSetRequest : IEquatable<OrderInstructionSetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInstructionSetRequest" /> class.
        /// </summary>
        /// <param name="requests">A collection of OrderInstructionRequests..</param>
        public OrderInstructionSetRequest(List<OrderInstructionRequest> requests = default(List<OrderInstructionRequest>))
        {
            this.Requests = requests;
        }

        /// <summary>
        /// A collection of OrderInstructionRequests.
        /// </summary>
        /// <value>A collection of OrderInstructionRequests.</value>
        [DataMember(Name = "requests", EmitDefaultValue = true)]
        public List<OrderInstructionRequest> Requests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderInstructionSetRequest {\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
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
            return this.Equals(input as OrderInstructionSetRequest);
        }

        /// <summary>
        /// Returns true if OrderInstructionSetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderInstructionSetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderInstructionSetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Requests == input.Requests ||
                    this.Requests != null &&
                    input.Requests != null &&
                    this.Requests.SequenceEqual(input.Requests)
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
                if (this.Requests != null)
                {
                    hashCode = (hashCode * 59) + this.Requests.GetHashCode();
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
