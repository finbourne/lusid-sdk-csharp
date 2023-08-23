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
    /// PropertyKeyComplianceParameterAllOf
    /// </summary>
    [DataContract(Name = "PropertyKeyComplianceParameter_allOf")]
    public partial class PropertyKeyComplianceParameterAllOf : IEquatable<PropertyKeyComplianceParameterAllOf>, IValidatableObject
    {
        /// <summary>
        /// The parameter type. The available values are: BoolComplianceParameter, StringComplianceParameter, DecimalComplianceParameter, DateTimeComplianceParameter, PropertyKeyComplianceParameter, AddressKeyComplianceParameter, PortfolioIdComplianceParameter, PortfolioGroupIdComplianceParameter, StringListComplianceParameter, BoolListComplianceParameter, DateTimeListComplianceParameter, DecimalListComplianceParameter, PropertyKeyListComplianceParameter, AddressKeyListComplianceParameter, PortfolioIdListComplianceParameter, PortfolioGroupIdListComplianceParameter
        /// </summary>
        /// <value>The parameter type. The available values are: BoolComplianceParameter, StringComplianceParameter, DecimalComplianceParameter, DateTimeComplianceParameter, PropertyKeyComplianceParameter, AddressKeyComplianceParameter, PortfolioIdComplianceParameter, PortfolioGroupIdComplianceParameter, StringListComplianceParameter, BoolListComplianceParameter, DateTimeListComplianceParameter, DecimalListComplianceParameter, PropertyKeyListComplianceParameter, AddressKeyListComplianceParameter, PortfolioIdListComplianceParameter, PortfolioGroupIdListComplianceParameter</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComplianceParameterTypeEnum
        {
            /// <summary>
            /// Enum BoolComplianceParameter for value: BoolComplianceParameter
            /// </summary>
            [EnumMember(Value = "BoolComplianceParameter")]
            BoolComplianceParameter = 1,

            /// <summary>
            /// Enum StringComplianceParameter for value: StringComplianceParameter
            /// </summary>
            [EnumMember(Value = "StringComplianceParameter")]
            StringComplianceParameter = 2,

            /// <summary>
            /// Enum DecimalComplianceParameter for value: DecimalComplianceParameter
            /// </summary>
            [EnumMember(Value = "DecimalComplianceParameter")]
            DecimalComplianceParameter = 3,

            /// <summary>
            /// Enum DateTimeComplianceParameter for value: DateTimeComplianceParameter
            /// </summary>
            [EnumMember(Value = "DateTimeComplianceParameter")]
            DateTimeComplianceParameter = 4,

            /// <summary>
            /// Enum PropertyKeyComplianceParameter for value: PropertyKeyComplianceParameter
            /// </summary>
            [EnumMember(Value = "PropertyKeyComplianceParameter")]
            PropertyKeyComplianceParameter = 5,

            /// <summary>
            /// Enum AddressKeyComplianceParameter for value: AddressKeyComplianceParameter
            /// </summary>
            [EnumMember(Value = "AddressKeyComplianceParameter")]
            AddressKeyComplianceParameter = 6,

            /// <summary>
            /// Enum PortfolioIdComplianceParameter for value: PortfolioIdComplianceParameter
            /// </summary>
            [EnumMember(Value = "PortfolioIdComplianceParameter")]
            PortfolioIdComplianceParameter = 7,

            /// <summary>
            /// Enum PortfolioGroupIdComplianceParameter for value: PortfolioGroupIdComplianceParameter
            /// </summary>
            [EnumMember(Value = "PortfolioGroupIdComplianceParameter")]
            PortfolioGroupIdComplianceParameter = 8,

            /// <summary>
            /// Enum StringListComplianceParameter for value: StringListComplianceParameter
            /// </summary>
            [EnumMember(Value = "StringListComplianceParameter")]
            StringListComplianceParameter = 9,

            /// <summary>
            /// Enum BoolListComplianceParameter for value: BoolListComplianceParameter
            /// </summary>
            [EnumMember(Value = "BoolListComplianceParameter")]
            BoolListComplianceParameter = 10,

            /// <summary>
            /// Enum DateTimeListComplianceParameter for value: DateTimeListComplianceParameter
            /// </summary>
            [EnumMember(Value = "DateTimeListComplianceParameter")]
            DateTimeListComplianceParameter = 11,

            /// <summary>
            /// Enum DecimalListComplianceParameter for value: DecimalListComplianceParameter
            /// </summary>
            [EnumMember(Value = "DecimalListComplianceParameter")]
            DecimalListComplianceParameter = 12,

            /// <summary>
            /// Enum PropertyKeyListComplianceParameter for value: PropertyKeyListComplianceParameter
            /// </summary>
            [EnumMember(Value = "PropertyKeyListComplianceParameter")]
            PropertyKeyListComplianceParameter = 13,

            /// <summary>
            /// Enum AddressKeyListComplianceParameter for value: AddressKeyListComplianceParameter
            /// </summary>
            [EnumMember(Value = "AddressKeyListComplianceParameter")]
            AddressKeyListComplianceParameter = 14,

            /// <summary>
            /// Enum PortfolioIdListComplianceParameter for value: PortfolioIdListComplianceParameter
            /// </summary>
            [EnumMember(Value = "PortfolioIdListComplianceParameter")]
            PortfolioIdListComplianceParameter = 15,

            /// <summary>
            /// Enum PortfolioGroupIdListComplianceParameter for value: PortfolioGroupIdListComplianceParameter
            /// </summary>
            [EnumMember(Value = "PortfolioGroupIdListComplianceParameter")]
            PortfolioGroupIdListComplianceParameter = 16

        }


        /// <summary>
        /// The parameter type. The available values are: BoolComplianceParameter, StringComplianceParameter, DecimalComplianceParameter, DateTimeComplianceParameter, PropertyKeyComplianceParameter, AddressKeyComplianceParameter, PortfolioIdComplianceParameter, PortfolioGroupIdComplianceParameter, StringListComplianceParameter, BoolListComplianceParameter, DateTimeListComplianceParameter, DecimalListComplianceParameter, PropertyKeyListComplianceParameter, AddressKeyListComplianceParameter, PortfolioIdListComplianceParameter, PortfolioGroupIdListComplianceParameter
        /// </summary>
        /// <value>The parameter type. The available values are: BoolComplianceParameter, StringComplianceParameter, DecimalComplianceParameter, DateTimeComplianceParameter, PropertyKeyComplianceParameter, AddressKeyComplianceParameter, PortfolioIdComplianceParameter, PortfolioGroupIdComplianceParameter, StringListComplianceParameter, BoolListComplianceParameter, DateTimeListComplianceParameter, DecimalListComplianceParameter, PropertyKeyListComplianceParameter, AddressKeyListComplianceParameter, PortfolioIdListComplianceParameter, PortfolioGroupIdListComplianceParameter</value>
        [DataMember(Name = "complianceParameterType", IsRequired = true, EmitDefaultValue = true)]
        public ComplianceParameterTypeEnum ComplianceParameterType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyKeyComplianceParameterAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyKeyComplianceParameterAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyKeyComplianceParameterAllOf" /> class.
        /// </summary>
        /// <param name="value">The key that uniquely identifies the property. It has the format {domain}/{scope}/{code}. (required).</param>
        /// <param name="complianceParameterType">The parameter type. The available values are: BoolComplianceParameter, StringComplianceParameter, DecimalComplianceParameter, DateTimeComplianceParameter, PropertyKeyComplianceParameter, AddressKeyComplianceParameter, PortfolioIdComplianceParameter, PortfolioGroupIdComplianceParameter, StringListComplianceParameter, BoolListComplianceParameter, DateTimeListComplianceParameter, DecimalListComplianceParameter, PropertyKeyListComplianceParameter, AddressKeyListComplianceParameter, PortfolioIdListComplianceParameter, PortfolioGroupIdListComplianceParameter (required).</param>
        public PropertyKeyComplianceParameterAllOf(string value = default(string), ComplianceParameterTypeEnum complianceParameterType = default(ComplianceParameterTypeEnum))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for PropertyKeyComplianceParameterAllOf and cannot be null");
            }
            this.Value = value;
            this.ComplianceParameterType = complianceParameterType;
        }

        /// <summary>
        /// The key that uniquely identifies the property. It has the format {domain}/{scope}/{code}.
        /// </summary>
        /// <value>The key that uniquely identifies the property. It has the format {domain}/{scope}/{code}.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PropertyKeyComplianceParameterAllOf {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ComplianceParameterType: ").Append(ComplianceParameterType).Append("\n");
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
            return this.Equals(input as PropertyKeyComplianceParameterAllOf);
        }

        /// <summary>
        /// Returns true if PropertyKeyComplianceParameterAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyKeyComplianceParameterAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyKeyComplianceParameterAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ComplianceParameterType == input.ComplianceParameterType ||
                    this.ComplianceParameterType.Equals(input.ComplianceParameterType)
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ComplianceParameterType.GetHashCode();
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
