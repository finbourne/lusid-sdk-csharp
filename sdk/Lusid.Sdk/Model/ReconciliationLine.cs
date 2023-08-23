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
    /// In evaluating a left and right hand side holding or valuation set, two data records result. These are then compared based on a set of  rules. This results in either a match or failure to match. If there is a match both left and right will be present, otherwise one will not.  A difference will be present if a match was calculated.  The options used in comparison may result in elision of results where an exact or tolerable match is made.
    /// </summary>
    [DataContract(Name = "ReconciliationLine")]
    public partial class ReconciliationLine : IEquatable<ReconciliationLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReconciliationLine" /> class.
        /// </summary>
        /// <param name="left">Left hand side of the comparison.</param>
        /// <param name="right">Right hand side of the comparison.</param>
        /// <param name="difference">Difference between LHS and RHS of comparison.</param>
        /// <param name="resultComparison">The logical or semantic description of the difference, e.g. \&quot;Matches\&quot; or \&quot;MatchesWithTolerance\&quot; or \&quot;Failed\&quot;..</param>
        public ReconciliationLine(Dictionary<string, Object> left = default(Dictionary<string, Object>), Dictionary<string, Object> right = default(Dictionary<string, Object>), Dictionary<string, Object> difference = default(Dictionary<string, Object>), Dictionary<string, Object> resultComparison = default(Dictionary<string, Object>))
        {
            this.Left = left;
            this.Right = right;
            this.Difference = difference;
            this.ResultComparison = resultComparison;
        }

        /// <summary>
        /// Left hand side of the comparison
        /// </summary>
        /// <value>Left hand side of the comparison</value>
        [DataMember(Name = "left", EmitDefaultValue = true)]
        public Dictionary<string, Object> Left { get; set; }

        /// <summary>
        /// Right hand side of the comparison
        /// </summary>
        /// <value>Right hand side of the comparison</value>
        [DataMember(Name = "right", EmitDefaultValue = true)]
        public Dictionary<string, Object> Right { get; set; }

        /// <summary>
        /// Difference between LHS and RHS of comparison
        /// </summary>
        /// <value>Difference between LHS and RHS of comparison</value>
        [DataMember(Name = "difference", EmitDefaultValue = true)]
        public Dictionary<string, Object> Difference { get; set; }

        /// <summary>
        /// The logical or semantic description of the difference, e.g. \&quot;Matches\&quot; or \&quot;MatchesWithTolerance\&quot; or \&quot;Failed\&quot;.
        /// </summary>
        /// <value>The logical or semantic description of the difference, e.g. \&quot;Matches\&quot; or \&quot;MatchesWithTolerance\&quot; or \&quot;Failed\&quot;.</value>
        [DataMember(Name = "resultComparison", EmitDefaultValue = true)]
        public Dictionary<string, Object> ResultComparison { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReconciliationLine {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Difference: ").Append(Difference).Append("\n");
            sb.Append("  ResultComparison: ").Append(ResultComparison).Append("\n");
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
            return this.Equals(input as ReconciliationLine);
        }

        /// <summary>
        /// Returns true if ReconciliationLine instances are equal
        /// </summary>
        /// <param name="input">Instance of ReconciliationLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReconciliationLine input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Left == input.Left ||
                    this.Left != null &&
                    input.Left != null &&
                    this.Left.SequenceEqual(input.Left)
                ) && 
                (
                    this.Right == input.Right ||
                    this.Right != null &&
                    input.Right != null &&
                    this.Right.SequenceEqual(input.Right)
                ) && 
                (
                    this.Difference == input.Difference ||
                    this.Difference != null &&
                    input.Difference != null &&
                    this.Difference.SequenceEqual(input.Difference)
                ) && 
                (
                    this.ResultComparison == input.ResultComparison ||
                    this.ResultComparison != null &&
                    input.ResultComparison != null &&
                    this.ResultComparison.SequenceEqual(input.ResultComparison)
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
                if (this.Difference != null)
                {
                    hashCode = (hashCode * 59) + this.Difference.GetHashCode();
                }
                if (this.ResultComparison != null)
                {
                    hashCode = (hashCode * 59) + this.ResultComparison.GetHashCode();
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
