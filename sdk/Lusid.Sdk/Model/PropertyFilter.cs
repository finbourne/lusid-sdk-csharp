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
    /// PropertyFilter
    /// </summary>
    [DataContract(Name = "PropertyFilter")]
    public partial class PropertyFilter : IEquatable<PropertyFilter>, IValidatableObject
    {
        /// <summary>
        /// The available values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqualTo, LessThan, LessThanOrEqualTo, In
        /// </summary>
        /// <value>The available values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqualTo, LessThan, LessThanOrEqualTo, In</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Enum Equals for value: Equals
            /// </summary>
            [EnumMember(Value = "Equals")]
            Equals = 1,

            /// <summary>
            /// Enum NotEquals for value: NotEquals
            /// </summary>
            [EnumMember(Value = "NotEquals")]
            NotEquals = 2,

            /// <summary>
            /// Enum GreaterThan for value: GreaterThan
            /// </summary>
            [EnumMember(Value = "GreaterThan")]
            GreaterThan = 3,

            /// <summary>
            /// Enum GreaterThanOrEqualTo for value: GreaterThanOrEqualTo
            /// </summary>
            [EnumMember(Value = "GreaterThanOrEqualTo")]
            GreaterThanOrEqualTo = 4,

            /// <summary>
            /// Enum LessThan for value: LessThan
            /// </summary>
            [EnumMember(Value = "LessThan")]
            LessThan = 5,

            /// <summary>
            /// Enum LessThanOrEqualTo for value: LessThanOrEqualTo
            /// </summary>
            [EnumMember(Value = "LessThanOrEqualTo")]
            LessThanOrEqualTo = 6,

            /// <summary>
            /// Enum In for value: In
            /// </summary>
            [EnumMember(Value = "In")]
            In = 7
        }


        /// <summary>
        /// The available values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqualTo, LessThan, LessThanOrEqualTo, In
        /// </summary>
        /// <value>The available values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqualTo, LessThan, LessThanOrEqualTo, In</value>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// The available values are: Absolute, Property
        /// </summary>
        /// <value>The available values are: Absolute, Property</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RightOperandTypeEnum
        {
            /// <summary>
            /// Enum Absolute for value: Absolute
            /// </summary>
            [EnumMember(Value = "Absolute")]
            Absolute = 1,

            /// <summary>
            /// Enum Property for value: Property
            /// </summary>
            [EnumMember(Value = "Property")]
            Property = 2
        }


        /// <summary>
        /// The available values are: Absolute, Property
        /// </summary>
        /// <value>The available values are: Absolute, Property</value>
        [DataMember(Name = "rightOperandType", EmitDefaultValue = false)]
        public RightOperandTypeEnum? RightOperandType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyFilter" /> class.
        /// </summary>
        /// <param name="left">The key that uniquely identifies a queryable address in Lusid..</param>
        /// <param name="varOperator">The available values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqualTo, LessThan, LessThanOrEqualTo, In.</param>
        /// <param name="right">right.</param>
        /// <param name="rightOperandType">The available values are: Absolute, Property.</param>
        public PropertyFilter(string left = default(string), OperatorEnum ?varOperator = default(OperatorEnum?), Object right = default(Object), RightOperandTypeEnum ?rightOperandType = default(RightOperandTypeEnum?))
        {
            this.Left = left;
            this.Operator = varOperator;
            this.Right = right;
            this.RightOperandType = rightOperandType;
        }

        /// <summary>
        /// The key that uniquely identifies a queryable address in Lusid.
        /// </summary>
        /// <value>The key that uniquely identifies a queryable address in Lusid.</value>
        [DataMember(Name = "left", EmitDefaultValue = true)]
        public string Left { get; set; }

        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name = "right", EmitDefaultValue = true)]
        public Object Right { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyFilter {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  RightOperandType: ").Append(RightOperandType).Append("\n");
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
            return this.Equals(input as PropertyFilter);
        }

        /// <summary>
        /// Returns true if PropertyFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyFilter input)
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
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.Right == input.Right ||
                    (this.Right != null &&
                    this.Right.Equals(input.Right))
                ) && 
                (
                    this.RightOperandType == input.RightOperandType ||
                    this.RightOperandType.Equals(input.RightOperandType)
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
                hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                if (this.Right != null)
                {
                    hashCode = (hashCode * 59) + this.Right.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RightOperandType.GetHashCode();
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
