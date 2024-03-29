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
    /// IndexProjectionDependencyAllOf
    /// </summary>
    [DataContract(Name = "IndexProjectionDependency_allOf")]
    public partial class IndexProjectionDependencyAllOf : IEquatable<IndexProjectionDependencyAllOf>, IValidatableObject
    {
        /// <summary>
        /// The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency
        /// </summary>
        /// <value>The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DependencyTypeEnum
        {
            /// <summary>
            /// Enum OpaqueDependency for value: OpaqueDependency
            /// </summary>
            [EnumMember(Value = "OpaqueDependency")]
            OpaqueDependency = 1,

            /// <summary>
            /// Enum CashDependency for value: CashDependency
            /// </summary>
            [EnumMember(Value = "CashDependency")]
            CashDependency = 2,

            /// <summary>
            /// Enum DiscountingDependency for value: DiscountingDependency
            /// </summary>
            [EnumMember(Value = "DiscountingDependency")]
            DiscountingDependency = 3,

            /// <summary>
            /// Enum EquityCurveDependency for value: EquityCurveDependency
            /// </summary>
            [EnumMember(Value = "EquityCurveDependency")]
            EquityCurveDependency = 4,

            /// <summary>
            /// Enum EquityVolDependency for value: EquityVolDependency
            /// </summary>
            [EnumMember(Value = "EquityVolDependency")]
            EquityVolDependency = 5,

            /// <summary>
            /// Enum FxDependency for value: FxDependency
            /// </summary>
            [EnumMember(Value = "FxDependency")]
            FxDependency = 6,

            /// <summary>
            /// Enum FxForwardsDependency for value: FxForwardsDependency
            /// </summary>
            [EnumMember(Value = "FxForwardsDependency")]
            FxForwardsDependency = 7,

            /// <summary>
            /// Enum FxVolDependency for value: FxVolDependency
            /// </summary>
            [EnumMember(Value = "FxVolDependency")]
            FxVolDependency = 8,

            /// <summary>
            /// Enum IndexProjectionDependency for value: IndexProjectionDependency
            /// </summary>
            [EnumMember(Value = "IndexProjectionDependency")]
            IndexProjectionDependency = 9,

            /// <summary>
            /// Enum IrVolDependency for value: IrVolDependency
            /// </summary>
            [EnumMember(Value = "IrVolDependency")]
            IrVolDependency = 10,

            /// <summary>
            /// Enum QuoteDependency for value: QuoteDependency
            /// </summary>
            [EnumMember(Value = "QuoteDependency")]
            QuoteDependency = 11,

            /// <summary>
            /// Enum Vendor for value: Vendor
            /// </summary>
            [EnumMember(Value = "Vendor")]
            Vendor = 12,

            /// <summary>
            /// Enum CalendarDependency for value: CalendarDependency
            /// </summary>
            [EnumMember(Value = "CalendarDependency")]
            CalendarDependency = 13,

            /// <summary>
            /// Enum InflationFixingDependency for value: InflationFixingDependency
            /// </summary>
            [EnumMember(Value = "InflationFixingDependency")]
            InflationFixingDependency = 14

        }


        /// <summary>
        /// The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency
        /// </summary>
        /// <value>The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency</value>
        [DataMember(Name = "dependencyType", IsRequired = true, EmitDefaultValue = true)]
        public DependencyTypeEnum DependencyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexProjectionDependencyAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IndexProjectionDependencyAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexProjectionDependencyAllOf" /> class.
        /// </summary>
        /// <param name="currency">The currency of the corresponding IndexConvention. E.g. this would be USD for a convention named USD.6M.LIBOR (required).</param>
        /// <param name="tenor">The tenor of the corresponding IndexConvention. E.g. this would be \&quot;6M\&quot; for a convention named USD.6M.LIBOR (required).</param>
        /// <param name="indexName">The IndexName of the corresponding IndexConvention. E.g. this would be \&quot;LIBOR\&quot; for a convention named USD.6M.LIBOR (required).</param>
        /// <param name="date">The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date. (required).</param>
        /// <param name="dependencyType">The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency (required).</param>
        public IndexProjectionDependencyAllOf(string currency = default(string), string tenor = default(string), string indexName = default(string), DateTimeOffset date = default(DateTimeOffset), DependencyTypeEnum dependencyType = default(DependencyTypeEnum))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for IndexProjectionDependencyAllOf and cannot be null");
            }
            this.Currency = currency;
            // to ensure "tenor" is required (not null)
            if (tenor == null)
            {
                throw new ArgumentNullException("tenor is a required property for IndexProjectionDependencyAllOf and cannot be null");
            }
            this.Tenor = tenor;
            // to ensure "indexName" is required (not null)
            if (indexName == null)
            {
                throw new ArgumentNullException("indexName is a required property for IndexProjectionDependencyAllOf and cannot be null");
            }
            this.IndexName = indexName;
            this.Date = date;
            this.DependencyType = dependencyType;
        }

        /// <summary>
        /// The currency of the corresponding IndexConvention. E.g. this would be USD for a convention named USD.6M.LIBOR
        /// </summary>
        /// <value>The currency of the corresponding IndexConvention. E.g. this would be USD for a convention named USD.6M.LIBOR</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The tenor of the corresponding IndexConvention. E.g. this would be \&quot;6M\&quot; for a convention named USD.6M.LIBOR
        /// </summary>
        /// <value>The tenor of the corresponding IndexConvention. E.g. this would be \&quot;6M\&quot; for a convention named USD.6M.LIBOR</value>
        [DataMember(Name = "tenor", IsRequired = true, EmitDefaultValue = true)]
        public string Tenor { get; set; }

        /// <summary>
        /// The IndexName of the corresponding IndexConvention. E.g. this would be \&quot;LIBOR\&quot; for a convention named USD.6M.LIBOR
        /// </summary>
        /// <value>The IndexName of the corresponding IndexConvention. E.g. this would be \&quot;LIBOR\&quot; for a convention named USD.6M.LIBOR</value>
        [DataMember(Name = "indexName", IsRequired = true, EmitDefaultValue = true)]
        public string IndexName { get; set; }

        /// <summary>
        /// The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date.
        /// </summary>
        /// <value>The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date.</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndexProjectionDependencyAllOf {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
            sb.Append("  IndexName: ").Append(IndexName).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DependencyType: ").Append(DependencyType).Append("\n");
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
            return this.Equals(input as IndexProjectionDependencyAllOf);
        }

        /// <summary>
        /// Returns true if IndexProjectionDependencyAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexProjectionDependencyAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexProjectionDependencyAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Tenor == input.Tenor ||
                    (this.Tenor != null &&
                    this.Tenor.Equals(input.Tenor))
                ) && 
                (
                    this.IndexName == input.IndexName ||
                    (this.IndexName != null &&
                    this.IndexName.Equals(input.IndexName))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DependencyType == input.DependencyType ||
                    this.DependencyType.Equals(input.DependencyType)
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
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Tenor != null)
                {
                    hashCode = (hashCode * 59) + this.Tenor.GetHashCode();
                }
                if (this.IndexName != null)
                {
                    hashCode = (hashCode * 59) + this.IndexName.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DependencyType.GetHashCode();
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
            // Tenor (string) maxLength
            if (this.Tenor != null && this.Tenor.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tenor, length must be less than 50.", new [] { "Tenor" });
            }

            // Tenor (string) minLength
            if (this.Tenor != null && this.Tenor.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tenor, length must be greater than 0.", new [] { "Tenor" });
            }

            // IndexName (string) maxLength
            if (this.IndexName != null && this.IndexName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndexName, length must be less than 50.", new [] { "IndexName" });
            }

            // IndexName (string) minLength
            if (this.IndexName != null && this.IndexName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndexName, length must be greater than 0.", new [] { "IndexName" });
            }

            yield break;
        }
    }
}
