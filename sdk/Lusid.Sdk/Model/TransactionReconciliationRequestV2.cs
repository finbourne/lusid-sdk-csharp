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
    /// Specification for the reconciliation request. Left and Right hand sides are constructed. Each consists of transactions from a portfolio  The results of this can then be compared to each other.
    /// </summary>
    [DataContract(Name = "TransactionReconciliationRequestV2")]
    public partial class TransactionReconciliationRequestV2 : IEquatable<TransactionReconciliationRequestV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionReconciliationRequestV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionReconciliationRequestV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionReconciliationRequestV2" /> class.
        /// </summary>
        /// <param name="left">left (required).</param>
        /// <param name="right">right (required).</param>
        /// <param name="leftToRightMapping">The mapping from property keys requested by left aggregation to property keys on right hand side.</param>
        /// <param name="comparisonRules">The set of rules to be used in comparing values. These are the rules that determine what constitutes a match.  The simplest is obviously an exact one-for-one comparison, but tolerances on numerical or date time values and  case-insensitive string comparison are supported amongst other types..</param>
        /// <param name="preserveKeys">List of keys to preserve (from rhs) in the diff. Used in conjunction with filtering/grouping.  If two values are equal, for a given key then the value is elided from the results. Setting it here  will preserve it (takes the values from the RHS and puts it into the line by line results)..</param>
        public TransactionReconciliationRequestV2(AggregatedTransactionsRequest left = default(AggregatedTransactionsRequest), AggregatedTransactionsRequest right = default(AggregatedTransactionsRequest), List<ReconciliationLeftRightAddressKeyPair> leftToRightMapping = default(List<ReconciliationLeftRightAddressKeyPair>), List<ReconciliationRule> comparisonRules = default(List<ReconciliationRule>), List<string> preserveKeys = default(List<string>))
        {
            // to ensure "left" is required (not null)
            if (left == null)
            {
                throw new ArgumentNullException("left is a required property for TransactionReconciliationRequestV2 and cannot be null");
            }
            this.Left = left;
            // to ensure "right" is required (not null)
            if (right == null)
            {
                throw new ArgumentNullException("right is a required property for TransactionReconciliationRequestV2 and cannot be null");
            }
            this.Right = right;
            this.LeftToRightMapping = leftToRightMapping;
            this.ComparisonRules = comparisonRules;
            this.PreserveKeys = preserveKeys;
        }

        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name = "left", IsRequired = true, EmitDefaultValue = true)]
        public AggregatedTransactionsRequest Left { get; set; }

        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name = "right", IsRequired = true, EmitDefaultValue = true)]
        public AggregatedTransactionsRequest Right { get; set; }

        /// <summary>
        /// The mapping from property keys requested by left aggregation to property keys on right hand side
        /// </summary>
        /// <value>The mapping from property keys requested by left aggregation to property keys on right hand side</value>
        [DataMember(Name = "leftToRightMapping", EmitDefaultValue = true)]
        public List<ReconciliationLeftRightAddressKeyPair> LeftToRightMapping { get; set; }

        /// <summary>
        /// The set of rules to be used in comparing values. These are the rules that determine what constitutes a match.  The simplest is obviously an exact one-for-one comparison, but tolerances on numerical or date time values and  case-insensitive string comparison are supported amongst other types.
        /// </summary>
        /// <value>The set of rules to be used in comparing values. These are the rules that determine what constitutes a match.  The simplest is obviously an exact one-for-one comparison, but tolerances on numerical or date time values and  case-insensitive string comparison are supported amongst other types.</value>
        [DataMember(Name = "comparisonRules", EmitDefaultValue = true)]
        public List<ReconciliationRule> ComparisonRules { get; set; }

        /// <summary>
        /// List of keys to preserve (from rhs) in the diff. Used in conjunction with filtering/grouping.  If two values are equal, for a given key then the value is elided from the results. Setting it here  will preserve it (takes the values from the RHS and puts it into the line by line results).
        /// </summary>
        /// <value>List of keys to preserve (from rhs) in the diff. Used in conjunction with filtering/grouping.  If two values are equal, for a given key then the value is elided from the results. Setting it here  will preserve it (takes the values from the RHS and puts it into the line by line results).</value>
        [DataMember(Name = "preserveKeys", EmitDefaultValue = true)]
        public List<string> PreserveKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionReconciliationRequestV2 {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  LeftToRightMapping: ").Append(LeftToRightMapping).Append("\n");
            sb.Append("  ComparisonRules: ").Append(ComparisonRules).Append("\n");
            sb.Append("  PreserveKeys: ").Append(PreserveKeys).Append("\n");
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
            return this.Equals(input as TransactionReconciliationRequestV2);
        }

        /// <summary>
        /// Returns true if TransactionReconciliationRequestV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionReconciliationRequestV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionReconciliationRequestV2 input)
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
                    this.LeftToRightMapping == input.LeftToRightMapping ||
                    this.LeftToRightMapping != null &&
                    input.LeftToRightMapping != null &&
                    this.LeftToRightMapping.SequenceEqual(input.LeftToRightMapping)
                ) && 
                (
                    this.ComparisonRules == input.ComparisonRules ||
                    this.ComparisonRules != null &&
                    input.ComparisonRules != null &&
                    this.ComparisonRules.SequenceEqual(input.ComparisonRules)
                ) && 
                (
                    this.PreserveKeys == input.PreserveKeys ||
                    this.PreserveKeys != null &&
                    input.PreserveKeys != null &&
                    this.PreserveKeys.SequenceEqual(input.PreserveKeys)
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
                if (this.LeftToRightMapping != null)
                {
                    hashCode = (hashCode * 59) + this.LeftToRightMapping.GetHashCode();
                }
                if (this.ComparisonRules != null)
                {
                    hashCode = (hashCode * 59) + this.ComparisonRules.GetHashCode();
                }
                if (this.PreserveKeys != null)
                {
                    hashCode = (hashCode * 59) + this.PreserveKeys.GetHashCode();
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