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
    /// CancelledOrderResult
    /// </summary>
    [DataContract(Name = "CancelledOrderResult")]
    public partial class CancelledOrderResult : IEquatable<CancelledOrderResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelledOrderResult" /> class.
        /// </summary>
        /// <param name="orderState">orderState.</param>
        public CancelledOrderResult(Order orderState = default(Order))
        {
            this.OrderState = orderState;
        }

        /// <summary>
        /// Gets or Sets OrderState
        /// </summary>
        [DataMember(Name = "orderState", EmitDefaultValue = false)]
        public Order OrderState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CancelledOrderResult {\n");
            sb.Append("  OrderState: ").Append(OrderState).Append("\n");
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
            return this.Equals(input as CancelledOrderResult);
        }

        /// <summary>
        /// Returns true if CancelledOrderResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelledOrderResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelledOrderResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderState == input.OrderState ||
                    (this.OrderState != null &&
                    this.OrderState.Equals(input.OrderState))
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
                if (this.OrderState != null)
                {
                    hashCode = (hashCode * 59) + this.OrderState.GetHashCode();
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
