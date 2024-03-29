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
    /// ListAggregationReconciliation
    /// </summary>
    [DataContract(Name = "ListAggregationReconciliation")]
    public partial class ListAggregationReconciliation : IEquatable<ListAggregationReconciliation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAggregationReconciliation" /> class.
        /// </summary>
        /// <param name="left">left.</param>
        /// <param name="right">right.</param>
        /// <param name="diff">diff.</param>
        /// <param name="dataSchema">dataSchema.</param>
        public ListAggregationReconciliation(ListAggregationResponse left = default(ListAggregationResponse), ListAggregationResponse right = default(ListAggregationResponse), List<Dictionary<string, Object>> diff = default(List<Dictionary<string, Object>>), ResultDataSchema dataSchema = default(ResultDataSchema))
        {
            this.Left = left;
            this.Right = right;
            this.Diff = diff;
            this.DataSchema = dataSchema;
        }

        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name = "left", EmitDefaultValue = false)]
        public ListAggregationResponse Left { get; set; }

        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name = "right", EmitDefaultValue = false)]
        public ListAggregationResponse Right { get; set; }

        /// <summary>
        /// Gets or Sets Diff
        /// </summary>
        [DataMember(Name = "diff", EmitDefaultValue = true)]
        public List<Dictionary<string, Object>> Diff { get; set; }

        /// <summary>
        /// Gets or Sets DataSchema
        /// </summary>
        [DataMember(Name = "dataSchema", EmitDefaultValue = false)]
        public ResultDataSchema DataSchema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListAggregationReconciliation {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Diff: ").Append(Diff).Append("\n");
            sb.Append("  DataSchema: ").Append(DataSchema).Append("\n");
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
            return this.Equals(input as ListAggregationReconciliation);
        }

        /// <summary>
        /// Returns true if ListAggregationReconciliation instances are equal
        /// </summary>
        /// <param name="input">Instance of ListAggregationReconciliation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListAggregationReconciliation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Left == input.Left ||
                    (this.Left != null &&
                    this.Left.Equals(input.Left))
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
                ) && 
                (
                    this.Diff == input.Diff ||
                    this.Diff != null &&
                    input.Diff != null &&
                    this.Diff.SequenceEqual(input.Diff)
                ) && 
                (
                    this.DataSchema == input.DataSchema ||
                    (this.DataSchema != null &&
                    this.DataSchema.Equals(input.DataSchema))
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
                if (this.Left != null)
                {
                    hashCode = (hashCode * 59) + this.Left.GetHashCode();
                }
                if (this.Right != null)
                {
                    hashCode = (hashCode * 59) + this.Right.GetHashCode();
                }
                if (this.Diff != null)
                {
                    hashCode = (hashCode * 59) + this.Diff.GetHashCode();
                }
                if (this.DataSchema != null)
                {
                    hashCode = (hashCode * 59) + this.DataSchema.GetHashCode();
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
