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
    /// ResultValue0DAllOf
    /// </summary>
    [DataContract(Name = "ResultValue0D_allOf")]
    public partial class ResultValue0DAllOf : IEquatable<ResultValue0DAllOf>, IValidatableObject
    {
        /// <summary>
        /// The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset
        /// </summary>
        /// <value>The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultValueTypeEnum
        {
            /// <summary>
            /// Enum ResultValue for value: ResultValue
            /// </summary>
            [EnumMember(Value = "ResultValue")]
            ResultValue = 1,

            /// <summary>
            /// Enum ResultValueDictionary for value: ResultValueDictionary
            /// </summary>
            [EnumMember(Value = "ResultValueDictionary")]
            ResultValueDictionary = 2,

            /// <summary>
            /// Enum ResultValue0D for value: ResultValue0D
            /// </summary>
            [EnumMember(Value = "ResultValue0D")]
            ResultValue0D = 3,

            /// <summary>
            /// Enum ResultValueDecimal for value: ResultValueDecimal
            /// </summary>
            [EnumMember(Value = "ResultValueDecimal")]
            ResultValueDecimal = 4,

            /// <summary>
            /// Enum ResultValueInt for value: ResultValueInt
            /// </summary>
            [EnumMember(Value = "ResultValueInt")]
            ResultValueInt = 5,

            /// <summary>
            /// Enum ResultValueString for value: ResultValueString
            /// </summary>
            [EnumMember(Value = "ResultValueString")]
            ResultValueString = 6,

            /// <summary>
            /// Enum ResultValueBool for value: ResultValueBool
            /// </summary>
            [EnumMember(Value = "ResultValueBool")]
            ResultValueBool = 7,

            /// <summary>
            /// Enum ResultValueCurrency for value: ResultValueCurrency
            /// </summary>
            [EnumMember(Value = "ResultValueCurrency")]
            ResultValueCurrency = 8,

            /// <summary>
            /// Enum CashFlowValue for value: CashFlowValue
            /// </summary>
            [EnumMember(Value = "CashFlowValue")]
            CashFlowValue = 9,

            /// <summary>
            /// Enum CashFlowValueSet for value: CashFlowValueSet
            /// </summary>
            [EnumMember(Value = "CashFlowValueSet")]
            CashFlowValueSet = 10,

            /// <summary>
            /// Enum ResultValueLifeCycleEventValue for value: ResultValueLifeCycleEventValue
            /// </summary>
            [EnumMember(Value = "ResultValueLifeCycleEventValue")]
            ResultValueLifeCycleEventValue = 11,

            /// <summary>
            /// Enum ResultValueDateTimeOffset for value: ResultValueDateTimeOffset
            /// </summary>
            [EnumMember(Value = "ResultValueDateTimeOffset")]
            ResultValueDateTimeOffset = 12

        }


        /// <summary>
        /// The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset
        /// </summary>
        /// <value>The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset</value>
        [DataMember(Name = "resultValueType", IsRequired = true, EmitDefaultValue = true)]
        public ResultValueTypeEnum ResultValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultValue0DAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResultValue0DAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultValue0DAllOf" /> class.
        /// </summary>
        /// <param name="units">Unit of the result.</param>
        /// <param name="value">The value of the result.</param>
        /// <param name="dimension">The dimension of the result. Can be null if there is no sensible way of defining the dimension. This field should not be  populate by the user on upsertion..</param>
        /// <param name="resultValueType">The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset (required).</param>
        public ResultValue0DAllOf(string units = default(string), decimal value = default(decimal), int? dimension = default(int?), ResultValueTypeEnum resultValueType = default(ResultValueTypeEnum))
        {
            this.ResultValueType = resultValueType;
            this.Units = units;
            this.Value = value;
            this.Dimension = dimension;
        }

        /// <summary>
        /// Unit of the result
        /// </summary>
        /// <value>Unit of the result</value>
        [DataMember(Name = "units", EmitDefaultValue = true)]
        public string Units { get; set; }

        /// <summary>
        /// The value of the result
        /// </summary>
        /// <value>The value of the result</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// The dimension of the result. Can be null if there is no sensible way of defining the dimension. This field should not be  populate by the user on upsertion.
        /// </summary>
        /// <value>The dimension of the result. Can be null if there is no sensible way of defining the dimension. This field should not be  populate by the user on upsertion.</value>
        [DataMember(Name = "dimension", EmitDefaultValue = true)]
        public int? Dimension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResultValue0DAllOf {\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  ResultValueType: ").Append(ResultValueType).Append("\n");
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
            return this.Equals(input as ResultValue0DAllOf);
        }

        /// <summary>
        /// Returns true if ResultValue0DAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultValue0DAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultValue0DAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Dimension == input.Dimension ||
                    (this.Dimension != null &&
                    this.Dimension.Equals(input.Dimension))
                ) && 
                (
                    this.ResultValueType == input.ResultValueType ||
                    this.ResultValueType.Equals(input.ResultValueType)
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
                if (this.Units != null)
                {
                    hashCode = (hashCode * 59) + this.Units.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                if (this.Dimension != null)
                {
                    hashCode = (hashCode * 59) + this.Dimension.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ResultValueType.GetHashCode();
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
