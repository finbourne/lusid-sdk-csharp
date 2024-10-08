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
    /// GroupReconciliationCoreComparisonRuleOperand
    /// </summary>
    [DataContract(Name = "GroupReconciliationCoreComparisonRuleOperand")]
    public partial class GroupReconciliationCoreComparisonRuleOperand : IEquatable<GroupReconciliationCoreComparisonRuleOperand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReconciliationCoreComparisonRuleOperand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupReconciliationCoreComparisonRuleOperand() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReconciliationCoreComparisonRuleOperand" /> class.
        /// </summary>
        /// <param name="key">The key of the value to compare (required).</param>
        /// <param name="operation">What to do with the value pointed to by the key, e.g. Sum. Only \&quot;Value is allowed for core rules\&quot; (required).</param>
        public GroupReconciliationCoreComparisonRuleOperand(string key = default(string), string operation = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for GroupReconciliationCoreComparisonRuleOperand and cannot be null");
            }
            this.Key = key;
            // to ensure "operation" is required (not null)
            if (operation == null)
            {
                throw new ArgumentNullException("operation is a required property for GroupReconciliationCoreComparisonRuleOperand and cannot be null");
            }
            this.Operation = operation;
        }

        /// <summary>
        /// The key of the value to compare
        /// </summary>
        /// <value>The key of the value to compare</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// What to do with the value pointed to by the key, e.g. Sum. Only \&quot;Value is allowed for core rules\&quot;
        /// </summary>
        /// <value>What to do with the value pointed to by the key, e.g. Sum. Only \&quot;Value is allowed for core rules\&quot;</value>
        [DataMember(Name = "operation", IsRequired = true, EmitDefaultValue = true)]
        public string Operation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupReconciliationCoreComparisonRuleOperand {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
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
            return this.Equals(input as GroupReconciliationCoreComparisonRuleOperand);
        }

        /// <summary>
        /// Returns true if GroupReconciliationCoreComparisonRuleOperand instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupReconciliationCoreComparisonRuleOperand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupReconciliationCoreComparisonRuleOperand input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
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
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
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
            // Key (string) maxLength
            if (this.Key != null && this.Key.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be less than 1024.", new [] { "Key" });
            }

            // Key (string) minLength
            if (this.Key != null && this.Key.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be greater than 0.", new [] { "Key" });
            }

            // Operation (string) minLength
            if (this.Operation != null && this.Operation.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Operation, length must be greater than 1.", new [] { "Operation" });
            }

            yield break;
        }
    }
}
