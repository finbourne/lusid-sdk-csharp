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
    /// DataTypeSummary
    /// </summary>
    [DataContract(Name = "DataTypeSummary")]
    public partial class DataTypeSummary : IEquatable<DataTypeSummary>, IValidatableObject
    {
        /// <summary>
        /// Indicates the range of data acceptable by a data type. The available values are: Open, Closed
        /// </summary>
        /// <value>Indicates the range of data acceptable by a data type. The available values are: Open, Closed</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeValueRangeEnum
        {
            /// <summary>
            /// Enum Open for value: Open
            /// </summary>
            [EnumMember(Value = "Open")]
            Open = 1,

            /// <summary>
            /// Enum Closed for value: Closed
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed = 2

        }


        /// <summary>
        /// Indicates the range of data acceptable by a data type. The available values are: Open, Closed
        /// </summary>
        /// <value>Indicates the range of data acceptable by a data type. The available values are: Open, Closed</value>
        [DataMember(Name = "typeValueRange", IsRequired = true, EmitDefaultValue = true)]
        public TypeValueRangeEnum TypeValueRange { get; set; }
        /// <summary>
        /// The expected type of the values. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText
        /// </summary>
        /// <value>The expected type of the values. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
        {
            /// <summary>
            /// Enum String for value: String
            /// </summary>
            [EnumMember(Value = "String")]
            String = 1,

            /// <summary>
            /// Enum Int for value: Int
            /// </summary>
            [EnumMember(Value = "Int")]
            Int = 2,

            /// <summary>
            /// Enum Decimal for value: Decimal
            /// </summary>
            [EnumMember(Value = "Decimal")]
            Decimal = 3,

            /// <summary>
            /// Enum DateTime for value: DateTime
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime = 4,

            /// <summary>
            /// Enum Boolean for value: Boolean
            /// </summary>
            [EnumMember(Value = "Boolean")]
            Boolean = 5,

            /// <summary>
            /// Enum Map for value: Map
            /// </summary>
            [EnumMember(Value = "Map")]
            Map = 6,

            /// <summary>
            /// Enum List for value: List
            /// </summary>
            [EnumMember(Value = "List")]
            List = 7,

            /// <summary>
            /// Enum PropertyArray for value: PropertyArray
            /// </summary>
            [EnumMember(Value = "PropertyArray")]
            PropertyArray = 8,

            /// <summary>
            /// Enum Percentage for value: Percentage
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage = 9,

            /// <summary>
            /// Enum Code for value: Code
            /// </summary>
            [EnumMember(Value = "Code")]
            Code = 10,

            /// <summary>
            /// Enum Id for value: Id
            /// </summary>
            [EnumMember(Value = "Id")]
            Id = 11,

            /// <summary>
            /// Enum Uri for value: Uri
            /// </summary>
            [EnumMember(Value = "Uri")]
            Uri = 12,

            /// <summary>
            /// Enum CurrencyAndAmount for value: CurrencyAndAmount
            /// </summary>
            [EnumMember(Value = "CurrencyAndAmount")]
            CurrencyAndAmount = 13,

            /// <summary>
            /// Enum TradePrice for value: TradePrice
            /// </summary>
            [EnumMember(Value = "TradePrice")]
            TradePrice = 14,

            /// <summary>
            /// Enum Currency for value: Currency
            /// </summary>
            [EnumMember(Value = "Currency")]
            Currency = 15,

            /// <summary>
            /// Enum MetricValue for value: MetricValue
            /// </summary>
            [EnumMember(Value = "MetricValue")]
            MetricValue = 16,

            /// <summary>
            /// Enum ResourceId for value: ResourceId
            /// </summary>
            [EnumMember(Value = "ResourceId")]
            ResourceId = 17,

            /// <summary>
            /// Enum ResultValue for value: ResultValue
            /// </summary>
            [EnumMember(Value = "ResultValue")]
            ResultValue = 18,

            /// <summary>
            /// Enum CutLocalTime for value: CutLocalTime
            /// </summary>
            [EnumMember(Value = "CutLocalTime")]
            CutLocalTime = 19,

            /// <summary>
            /// Enum DateOrCutLabel for value: DateOrCutLabel
            /// </summary>
            [EnumMember(Value = "DateOrCutLabel")]
            DateOrCutLabel = 20,

            /// <summary>
            /// Enum UnindexedText for value: UnindexedText
            /// </summary>
            [EnumMember(Value = "UnindexedText")]
            UnindexedText = 21

        }


        /// <summary>
        /// The expected type of the values. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText
        /// </summary>
        /// <value>The expected type of the values. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText</value>
        [DataMember(Name = "valueType", IsRequired = true, EmitDefaultValue = true)]
        public ValueTypeEnum ValueType { get; set; }
        /// <summary>
        /// The schema of the data type&#39;s units. The available values are: NoUnits, Basic, Iso4217Currency
        /// </summary>
        /// <value>The schema of the data type&#39;s units. The available values are: NoUnits, Basic, Iso4217Currency</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitSchemaEnum
        {
            /// <summary>
            /// Enum NoUnits for value: NoUnits
            /// </summary>
            [EnumMember(Value = "NoUnits")]
            NoUnits = 1,

            /// <summary>
            /// Enum Basic for value: Basic
            /// </summary>
            [EnumMember(Value = "Basic")]
            Basic = 2,

            /// <summary>
            /// Enum Iso4217Currency for value: Iso4217Currency
            /// </summary>
            [EnumMember(Value = "Iso4217Currency")]
            Iso4217Currency = 3

        }


        /// <summary>
        /// The schema of the data type&#39;s units. The available values are: NoUnits, Basic, Iso4217Currency
        /// </summary>
        /// <value>The schema of the data type&#39;s units. The available values are: NoUnits, Basic, Iso4217Currency</value>
        [DataMember(Name = "unitSchema", EmitDefaultValue = false)]
        public UnitSchemaEnum? UnitSchema { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataTypeSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeSummary" /> class.
        /// </summary>
        /// <param name="typeValueRange">Indicates the range of data acceptable by a data type. The available values are: Open, Closed (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">The display name of the data type. (required).</param>
        /// <param name="description">The description of the data type. (required).</param>
        /// <param name="valueType">The expected type of the values. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText (required).</param>
        /// <param name="acceptableValues">The acceptable set of values for this data type. Only applies to &#39;open&#39; value type range..</param>
        /// <param name="unitSchema">The schema of the data type&#39;s units. The available values are: NoUnits, Basic, Iso4217Currency.</param>
        /// <param name="acceptableUnits">The definitions of the acceptable units..</param>
        public DataTypeSummary(TypeValueRangeEnum typeValueRange = default(TypeValueRangeEnum), ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), ValueTypeEnum valueType = default(ValueTypeEnum), List<string> acceptableValues = default(List<string>), UnitSchemaEnum? unitSchema = default(UnitSchemaEnum?), List<IUnitDefinitionDto> acceptableUnits = default(List<IUnitDefinitionDto>))
        {
            this.TypeValueRange = typeValueRange;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DataTypeSummary and cannot be null");
            }
            this.Id = id;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for DataTypeSummary and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for DataTypeSummary and cannot be null");
            }
            this.Description = description;
            this.ValueType = valueType;
            this.AcceptableValues = acceptableValues;
            this.UnitSchema = unitSchema;
            this.AcceptableUnits = acceptableUnits;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The display name of the data type.
        /// </summary>
        /// <value>The display name of the data type.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description of the data type.
        /// </summary>
        /// <value>The description of the data type.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The acceptable set of values for this data type. Only applies to &#39;open&#39; value type range.
        /// </summary>
        /// <value>The acceptable set of values for this data type. Only applies to &#39;open&#39; value type range.</value>
        [DataMember(Name = "acceptableValues", EmitDefaultValue = true)]
        public List<string> AcceptableValues { get; set; }

        /// <summary>
        /// The definitions of the acceptable units.
        /// </summary>
        /// <value>The definitions of the acceptable units.</value>
        [DataMember(Name = "acceptableUnits", EmitDefaultValue = true)]
        public List<IUnitDefinitionDto> AcceptableUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataTypeSummary {\n");
            sb.Append("  TypeValueRange: ").Append(TypeValueRange).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  AcceptableValues: ").Append(AcceptableValues).Append("\n");
            sb.Append("  UnitSchema: ").Append(UnitSchema).Append("\n");
            sb.Append("  AcceptableUnits: ").Append(AcceptableUnits).Append("\n");
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
            return this.Equals(input as DataTypeSummary);
        }

        /// <summary>
        /// Returns true if DataTypeSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTypeSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTypeSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TypeValueRange == input.TypeValueRange ||
                    this.TypeValueRange.Equals(input.TypeValueRange)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    this.ValueType.Equals(input.ValueType)
                ) && 
                (
                    this.AcceptableValues == input.AcceptableValues ||
                    this.AcceptableValues != null &&
                    input.AcceptableValues != null &&
                    this.AcceptableValues.SequenceEqual(input.AcceptableValues)
                ) && 
                (
                    this.UnitSchema == input.UnitSchema ||
                    this.UnitSchema.Equals(input.UnitSchema)
                ) && 
                (
                    this.AcceptableUnits == input.AcceptableUnits ||
                    this.AcceptableUnits != null &&
                    input.AcceptableUnits != null &&
                    this.AcceptableUnits.SequenceEqual(input.AcceptableUnits)
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
                hashCode = (hashCode * 59) + this.TypeValueRange.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValueType.GetHashCode();
                if (this.AcceptableValues != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptableValues.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnitSchema.GetHashCode();
                if (this.AcceptableUnits != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptableUnits.GetHashCode();
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
            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            yield break;
        }
    }
}
