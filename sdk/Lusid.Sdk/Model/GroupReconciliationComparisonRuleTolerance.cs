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
    /// GroupReconciliationComparisonRuleTolerance
    /// </summary>
    [DataContract(Name = "GroupReconciliationComparisonRuleTolerance")]
    public partial class GroupReconciliationComparisonRuleTolerance : IEquatable<GroupReconciliationComparisonRuleTolerance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReconciliationComparisonRuleTolerance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupReconciliationComparisonRuleTolerance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReconciliationComparisonRuleTolerance" /> class.
        /// </summary>
        /// <param name="type">The type of tolerance to allow. \&quot;Relative\&quot; | \&quot;Absolute\&quot; (required).</param>
        /// <param name="value">The decimal value of how much tolerance to allow when comparing in relative (i.e percentage) or absolute terms depending on the ToleranceType specified (required).</param>
        public GroupReconciliationComparisonRuleTolerance(string type = default(string), decimal value = default(decimal))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for GroupReconciliationComparisonRuleTolerance and cannot be null");
            }
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// The type of tolerance to allow. \&quot;Relative\&quot; | \&quot;Absolute\&quot;
        /// </summary>
        /// <value>The type of tolerance to allow. \&quot;Relative\&quot; | \&quot;Absolute\&quot;</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The decimal value of how much tolerance to allow when comparing in relative (i.e percentage) or absolute terms depending on the ToleranceType specified
        /// </summary>
        /// <value>The decimal value of how much tolerance to allow when comparing in relative (i.e percentage) or absolute terms depending on the ToleranceType specified</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public decimal Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupReconciliationComparisonRuleTolerance {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as GroupReconciliationComparisonRuleTolerance);
        }

        /// <summary>
        /// Returns true if GroupReconciliationComparisonRuleTolerance instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupReconciliationComparisonRuleTolerance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupReconciliationComparisonRuleTolerance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            yield break;
        }
    }
}