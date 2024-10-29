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
    /// GroupReconciliationAggregateAttributeValues
    /// </summary>
    [DataContract(Name = "GroupReconciliationAggregateAttributeValues")]
    public partial class GroupReconciliationAggregateAttributeValues : IEquatable<GroupReconciliationAggregateAttributeValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReconciliationAggregateAttributeValues" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupReconciliationAggregateAttributeValues() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReconciliationAggregateAttributeValues" /> class.
        /// </summary>
        /// <param name="leftAggregateAttributes">Aggregate attribute names and values for the left hand entity being reconciled. (required).</param>
        /// <param name="rightAggregateAttributes">Aggregate attribute names and values for the right hand entity being reconciled. (required).</param>
        public GroupReconciliationAggregateAttributeValues(List<ComparisonAttributeValuePair> leftAggregateAttributes = default(List<ComparisonAttributeValuePair>), List<ComparisonAttributeValuePair> rightAggregateAttributes = default(List<ComparisonAttributeValuePair>))
        {
            // to ensure "leftAggregateAttributes" is required (not null)
            if (leftAggregateAttributes == null)
            {
                throw new ArgumentNullException("leftAggregateAttributes is a required property for GroupReconciliationAggregateAttributeValues and cannot be null");
            }
            this.LeftAggregateAttributes = leftAggregateAttributes;
            // to ensure "rightAggregateAttributes" is required (not null)
            if (rightAggregateAttributes == null)
            {
                throw new ArgumentNullException("rightAggregateAttributes is a required property for GroupReconciliationAggregateAttributeValues and cannot be null");
            }
            this.RightAggregateAttributes = rightAggregateAttributes;
        }

        /// <summary>
        /// Aggregate attribute names and values for the left hand entity being reconciled.
        /// </summary>
        /// <value>Aggregate attribute names and values for the left hand entity being reconciled.</value>
        [DataMember(Name = "leftAggregateAttributes", IsRequired = true, EmitDefaultValue = true)]
        public List<ComparisonAttributeValuePair> LeftAggregateAttributes { get; set; }

        /// <summary>
        /// Aggregate attribute names and values for the right hand entity being reconciled.
        /// </summary>
        /// <value>Aggregate attribute names and values for the right hand entity being reconciled.</value>
        [DataMember(Name = "rightAggregateAttributes", IsRequired = true, EmitDefaultValue = true)]
        public List<ComparisonAttributeValuePair> RightAggregateAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupReconciliationAggregateAttributeValues {\n");
            sb.Append("  LeftAggregateAttributes: ").Append(LeftAggregateAttributes).Append("\n");
            sb.Append("  RightAggregateAttributes: ").Append(RightAggregateAttributes).Append("\n");
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
            return this.Equals(input as GroupReconciliationAggregateAttributeValues);
        }

        /// <summary>
        /// Returns true if GroupReconciliationAggregateAttributeValues instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupReconciliationAggregateAttributeValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupReconciliationAggregateAttributeValues input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LeftAggregateAttributes == input.LeftAggregateAttributes ||
                    this.LeftAggregateAttributes != null &&
                    input.LeftAggregateAttributes != null &&
                    this.LeftAggregateAttributes.SequenceEqual(input.LeftAggregateAttributes)
                ) && 
                (
                    this.RightAggregateAttributes == input.RightAggregateAttributes ||
                    this.RightAggregateAttributes != null &&
                    input.RightAggregateAttributes != null &&
                    this.RightAggregateAttributes.SequenceEqual(input.RightAggregateAttributes)
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
                if (this.LeftAggregateAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.LeftAggregateAttributes.GetHashCode();
                }
                if (this.RightAggregateAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.RightAggregateAttributes.GetHashCode();
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