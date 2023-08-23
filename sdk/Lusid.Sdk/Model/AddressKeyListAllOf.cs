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
    /// AddressKeyListAllOf
    /// </summary>
    [DataContract(Name = "AddressKeyList_allOf")]
    public partial class AddressKeyListAllOf : IEquatable<AddressKeyListAllOf>, IValidatableObject
    {
        /// <summary>
        /// The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList
        /// </summary>
        /// <value>The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReferenceListTypeEnum
        {
            /// <summary>
            /// Enum PortfolioGroupIdList for value: PortfolioGroupIdList
            /// </summary>
            [EnumMember(Value = "PortfolioGroupIdList")]
            PortfolioGroupIdList = 1,

            /// <summary>
            /// Enum PortfolioIdList for value: PortfolioIdList
            /// </summary>
            [EnumMember(Value = "PortfolioIdList")]
            PortfolioIdList = 2,

            /// <summary>
            /// Enum AddressKeyList for value: AddressKeyList
            /// </summary>
            [EnumMember(Value = "AddressKeyList")]
            AddressKeyList = 3,

            /// <summary>
            /// Enum StringList for value: StringList
            /// </summary>
            [EnumMember(Value = "StringList")]
            StringList = 4,

            /// <summary>
            /// Enum InstrumentList for value: InstrumentList
            /// </summary>
            [EnumMember(Value = "InstrumentList")]
            InstrumentList = 5,

            /// <summary>
            /// Enum DecimalList for value: DecimalList
            /// </summary>
            [EnumMember(Value = "DecimalList")]
            DecimalList = 6

        }


        /// <summary>
        /// The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList
        /// </summary>
        /// <value>The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList</value>
        [DataMember(Name = "referenceListType", IsRequired = true, EmitDefaultValue = true)]
        public ReferenceListTypeEnum ReferenceListType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressKeyListAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressKeyListAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressKeyListAllOf" /> class.
        /// </summary>
        /// <param name="values">values (required).</param>
        /// <param name="referenceListType">The reference list values. The available values are: PortfolioGroupIdList, PortfolioIdList, AddressKeyList, StringList, InstrumentList, DecimalList (required).</param>
        public AddressKeyListAllOf(List<string> values = default(List<string>), ReferenceListTypeEnum referenceListType = default(ReferenceListTypeEnum))
        {
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new ArgumentNullException("values is a required property for AddressKeyListAllOf and cannot be null");
            }
            this.Values = values;
            this.ReferenceListType = referenceListType;
        }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressKeyListAllOf {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  ReferenceListType: ").Append(ReferenceListType).Append("\n");
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
            return this.Equals(input as AddressKeyListAllOf);
        }

        /// <summary>
        /// Returns true if AddressKeyListAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressKeyListAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressKeyListAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.ReferenceListType == input.ReferenceListType ||
                    this.ReferenceListType.Equals(input.ReferenceListType)
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
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReferenceListType.GetHashCode();
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
