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
    /// AggregateSpec
    /// </summary>
    [DataContract(Name = "AggregateSpec")]
    public partial class AggregateSpec : IEquatable<AggregateSpec>, IValidatableObject
    {
        /// <summary>
        /// The available values are: Sum, DefaultSum, Proportion, Average, Count, Min, Max, Value, SumOfPositiveValues, SumOfNegativeValues, SumOfAbsoluteValues, ProportionOfAbsoluteValues, SumCumulativeInAdvance, SumCumulativeInArrears
        /// </summary>
        /// <value>The available values are: Sum, DefaultSum, Proportion, Average, Count, Min, Max, Value, SumOfPositiveValues, SumOfNegativeValues, SumOfAbsoluteValues, ProportionOfAbsoluteValues, SumCumulativeInAdvance, SumCumulativeInArrears</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OpEnum
        {
            /// <summary>
            /// Enum Sum for value: Sum
            /// </summary>
            [EnumMember(Value = "Sum")]
            Sum = 1,

            /// <summary>
            /// Enum DefaultSum for value: DefaultSum
            /// </summary>
            [EnumMember(Value = "DefaultSum")]
            DefaultSum = 2,

            /// <summary>
            /// Enum Proportion for value: Proportion
            /// </summary>
            [EnumMember(Value = "Proportion")]
            Proportion = 3,

            /// <summary>
            /// Enum Average for value: Average
            /// </summary>
            [EnumMember(Value = "Average")]
            Average = 4,

            /// <summary>
            /// Enum Count for value: Count
            /// </summary>
            [EnumMember(Value = "Count")]
            Count = 5,

            /// <summary>
            /// Enum Min for value: Min
            /// </summary>
            [EnumMember(Value = "Min")]
            Min = 6,

            /// <summary>
            /// Enum Max for value: Max
            /// </summary>
            [EnumMember(Value = "Max")]
            Max = 7,

            /// <summary>
            /// Enum Value for value: Value
            /// </summary>
            [EnumMember(Value = "Value")]
            Value = 8,

            /// <summary>
            /// Enum SumOfPositiveValues for value: SumOfPositiveValues
            /// </summary>
            [EnumMember(Value = "SumOfPositiveValues")]
            SumOfPositiveValues = 9,

            /// <summary>
            /// Enum SumOfNegativeValues for value: SumOfNegativeValues
            /// </summary>
            [EnumMember(Value = "SumOfNegativeValues")]
            SumOfNegativeValues = 10,

            /// <summary>
            /// Enum SumOfAbsoluteValues for value: SumOfAbsoluteValues
            /// </summary>
            [EnumMember(Value = "SumOfAbsoluteValues")]
            SumOfAbsoluteValues = 11,

            /// <summary>
            /// Enum ProportionOfAbsoluteValues for value: ProportionOfAbsoluteValues
            /// </summary>
            [EnumMember(Value = "ProportionOfAbsoluteValues")]
            ProportionOfAbsoluteValues = 12,

            /// <summary>
            /// Enum SumCumulativeInAdvance for value: SumCumulativeInAdvance
            /// </summary>
            [EnumMember(Value = "SumCumulativeInAdvance")]
            SumCumulativeInAdvance = 13,

            /// <summary>
            /// Enum SumCumulativeInArrears for value: SumCumulativeInArrears
            /// </summary>
            [EnumMember(Value = "SumCumulativeInArrears")]
            SumCumulativeInArrears = 14

        }


        /// <summary>
        /// The available values are: Sum, DefaultSum, Proportion, Average, Count, Min, Max, Value, SumOfPositiveValues, SumOfNegativeValues, SumOfAbsoluteValues, ProportionOfAbsoluteValues, SumCumulativeInAdvance, SumCumulativeInArrears
        /// </summary>
        /// <value>The available values are: Sum, DefaultSum, Proportion, Average, Count, Min, Max, Value, SumOfPositiveValues, SumOfNegativeValues, SumOfAbsoluteValues, ProportionOfAbsoluteValues, SumCumulativeInAdvance, SumCumulativeInArrears</value>
        [DataMember(Name = "op", IsRequired = true, EmitDefaultValue = true)]
        public OpEnum Op { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AggregateSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateSpec" /> class.
        /// </summary>
        /// <param name="key">The key that uniquely identifies a queryable address in Lusid. (required).</param>
        /// <param name="op">The available values are: Sum, DefaultSum, Proportion, Average, Count, Min, Max, Value, SumOfPositiveValues, SumOfNegativeValues, SumOfAbsoluteValues, ProportionOfAbsoluteValues, SumCumulativeInAdvance, SumCumulativeInArrears (required).</param>
        /// <param name="options">Additional options to apply when performing computations. Options that do not apply to the Key will be  ignored. Option values can be boolean, numeric, string or date-time..</param>
        public AggregateSpec(string key = default(string), OpEnum op = default(OpEnum), Dictionary<string, Object> options = default(Dictionary<string, Object>))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for AggregateSpec and cannot be null");
            }
            this.Key = key;
            this.Op = op;
            this.Options = options;
        }

        /// <summary>
        /// The key that uniquely identifies a queryable address in Lusid.
        /// </summary>
        /// <value>The key that uniquely identifies a queryable address in Lusid.</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Additional options to apply when performing computations. Options that do not apply to the Key will be  ignored. Option values can be boolean, numeric, string or date-time.
        /// </summary>
        /// <value>Additional options to apply when performing computations. Options that do not apply to the Key will be  ignored. Option values can be boolean, numeric, string or date-time.</value>
        [DataMember(Name = "options", EmitDefaultValue = true)]
        public Dictionary<string, Object> Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AggregateSpec {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as AggregateSpec);
        }

        /// <summary>
        /// Returns true if AggregateSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregateSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregateSpec input)
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
                    this.Op == input.Op ||
                    this.Op.Equals(input.Op)
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
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
                hashCode = (hashCode * 59) + this.Op.GetHashCode();
                if (this.Options != null)
                {
                    hashCode = (hashCode * 59) + this.Options.GetHashCode();
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
