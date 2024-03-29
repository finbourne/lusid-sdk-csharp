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
    /// The input &#39;transition&#39; within a corporate action, representing the singular input position
    /// </summary>
    [DataContract(Name = "InputTransition")]
    public partial class InputTransition : IEquatable<InputTransition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputTransition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InputTransition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputTransition" /> class.
        /// </summary>
        /// <param name="unitsFactor">The factor to scale units by (required).</param>
        /// <param name="costFactor">The factor to scale cost by (required).</param>
        public InputTransition(decimal unitsFactor = default(decimal), decimal costFactor = default(decimal))
        {
            this.UnitsFactor = unitsFactor;
            this.CostFactor = costFactor;
        }

        /// <summary>
        /// The factor to scale units by
        /// </summary>
        /// <value>The factor to scale units by</value>
        [DataMember(Name = "unitsFactor", IsRequired = true, EmitDefaultValue = true)]
        public decimal UnitsFactor { get; set; }

        /// <summary>
        /// The factor to scale cost by
        /// </summary>
        /// <value>The factor to scale cost by</value>
        [DataMember(Name = "costFactor", IsRequired = true, EmitDefaultValue = true)]
        public decimal CostFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InputTransition {\n");
            sb.Append("  UnitsFactor: ").Append(UnitsFactor).Append("\n");
            sb.Append("  CostFactor: ").Append(CostFactor).Append("\n");
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
            return this.Equals(input as InputTransition);
        }

        /// <summary>
        /// Returns true if InputTransition instances are equal
        /// </summary>
        /// <param name="input">Instance of InputTransition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputTransition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnitsFactor == input.UnitsFactor ||
                    this.UnitsFactor.Equals(input.UnitsFactor)
                ) && 
                (
                    this.CostFactor == input.CostFactor ||
                    this.CostFactor.Equals(input.CostFactor)
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
                hashCode = (hashCode * 59) + this.UnitsFactor.GetHashCode();
                hashCode = (hashCode * 59) + this.CostFactor.GetHashCode();
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
