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
    /// A simple result for a boolean value
    /// </summary>
    [DataContract(Name = "ResultValueBool")]
    [JsonConverter(typeof(JsonSubtypes), "ResultValueType")]
    public partial class ResultValueBool : ResultValue, IEquatable<ResultValueBool>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultValueBool" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResultValueBool() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultValueBool" /> class.
        /// </summary>
        /// <param name="value">The value itself.</param>
        /// <param name="resultValueType">The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset (required) (default to &quot;ResultValueBool&quot;).</param>
        public ResultValueBool(bool value = default(bool), ResultValueTypeEnum resultValueType = default(ResultValueTypeEnum)) : base(resultValueType)
        {
            this.Value = value;
        }

        /// <summary>
        /// The value itself
        /// </summary>
        /// <value>The value itself</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public bool Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResultValueBool {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ResultValueBool);
        }

        /// <summary>
        /// Returns true if ResultValueBool instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultValueBool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultValueBool input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }
}
