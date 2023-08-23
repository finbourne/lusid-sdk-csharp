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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// Base class for representing result key rules in LUSID, which describe how to resolve (unit) result data.  This base class should not be directly instantiated; each supported ResultKeyRuleType has a corresponding inherited class.
    /// </summary>
    [DataContract(Name = "ResultKeyRule")]
    [JsonConverter(typeof(JsonSubtypes), "ResultKeyRuleType")]
    [JsonSubtypes.KnownSubType(typeof(PortfolioResultDataKeyRule), "PortfolioResultDataKeyRule")]
    [JsonSubtypes.KnownSubType(typeof(ResultDataKeyRule), "ResultDataKeyRule")]
    public partial class ResultKeyRule : IEquatable<ResultKeyRule>, IValidatableObject
    {
        /// <summary>
        /// The available values are: Invalid, ResultDataKeyRule, PortfolioResultDataKeyRule
        /// </summary>
        /// <value>The available values are: Invalid, ResultDataKeyRule, PortfolioResultDataKeyRule</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultKeyRuleTypeEnum
        {
            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 1,

            /// <summary>
            /// Enum ResultDataKeyRule for value: ResultDataKeyRule
            /// </summary>
            [EnumMember(Value = "ResultDataKeyRule")]
            ResultDataKeyRule = 2,

            /// <summary>
            /// Enum PortfolioResultDataKeyRule for value: PortfolioResultDataKeyRule
            /// </summary>
            [EnumMember(Value = "PortfolioResultDataKeyRule")]
            PortfolioResultDataKeyRule = 3

        }


        /// <summary>
        /// The available values are: Invalid, ResultDataKeyRule, PortfolioResultDataKeyRule
        /// </summary>
        /// <value>The available values are: Invalid, ResultDataKeyRule, PortfolioResultDataKeyRule</value>
        [DataMember(Name = "resultKeyRuleType", IsRequired = true, EmitDefaultValue = true)]
        public ResultKeyRuleTypeEnum ResultKeyRuleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultKeyRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResultKeyRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultKeyRule" /> class.
        /// </summary>
        /// <param name="resultKeyRuleType">The available values are: Invalid, ResultDataKeyRule, PortfolioResultDataKeyRule (required).</param>
        public ResultKeyRule(ResultKeyRuleTypeEnum resultKeyRuleType = default(ResultKeyRuleTypeEnum))
        {
            this.ResultKeyRuleType = resultKeyRuleType;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResultKeyRule {\n");
            sb.Append("  ResultKeyRuleType: ").Append(ResultKeyRuleType).Append("\n");
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
            return this.Equals(input as ResultKeyRule);
        }

        /// <summary>
        /// Returns true if ResultKeyRule instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultKeyRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultKeyRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResultKeyRuleType == input.ResultKeyRuleType ||
                    this.ResultKeyRuleType.Equals(input.ResultKeyRuleType)
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
                hashCode = (hashCode * 59) + this.ResultKeyRuleType.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
