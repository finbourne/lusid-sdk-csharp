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
    /// Economic dependency required to price Equity derivative products that contain optionality.  Equity Vol surface is a grid of implied volatilities for an array of strikes and tenors,  derived from vanilla option prices in the market.
    /// </summary>
    [DataContract(Name = "EquityVolDependency")]
    [JsonConverter(typeof(JsonSubtypes), "DependencyType")]
    public partial class EquityVolDependency : EconomicDependency, IEquatable<EquityVolDependency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquityVolDependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EquityVolDependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EquityVolDependency" /> class.
        /// </summary>
        /// <param name="code">The code identifying the corresponding equity, e.g. US0378331005 if the MarketIdentifier was set to ISIN (required).</param>
        /// <param name="domesticCurrency">The domestic currency of the instrument declaring this dependency. (required).</param>
        /// <param name="volType">Volatility type e.g. \&quot;LN\&quot; and \&quot;N\&quot; for log-normal and normal volatility. (required).</param>
        /// <param name="date">The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date. (required).</param>
        /// <param name="dependencyType">The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency (required) (default to &quot;EquityVolDependency&quot;).</param>
        public EquityVolDependency(string code = default(string), string domesticCurrency = default(string), string volType = default(string), DateTimeOffset date = default(DateTimeOffset), DependencyTypeEnum dependencyType = default(DependencyTypeEnum)) : base(dependencyType)
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for EquityVolDependency and cannot be null");
            }
            this.Code = code;
            // to ensure "domesticCurrency" is required (not null)
            if (domesticCurrency == null)
            {
                throw new ArgumentNullException("domesticCurrency is a required property for EquityVolDependency and cannot be null");
            }
            this.DomesticCurrency = domesticCurrency;
            // to ensure "volType" is required (not null)
            if (volType == null)
            {
                throw new ArgumentNullException("volType is a required property for EquityVolDependency and cannot be null");
            }
            this.VolType = volType;
            this.Date = date;
        }

        /// <summary>
        /// The code identifying the corresponding equity, e.g. US0378331005 if the MarketIdentifier was set to ISIN
        /// </summary>
        /// <value>The code identifying the corresponding equity, e.g. US0378331005 if the MarketIdentifier was set to ISIN</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The domestic currency of the instrument declaring this dependency.
        /// </summary>
        /// <value>The domestic currency of the instrument declaring this dependency.</value>
        [DataMember(Name = "domesticCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string DomesticCurrency { get; set; }

        /// <summary>
        /// Volatility type e.g. \&quot;LN\&quot; and \&quot;N\&quot; for log-normal and normal volatility.
        /// </summary>
        /// <value>Volatility type e.g. \&quot;LN\&quot; and \&quot;N\&quot; for log-normal and normal volatility.</value>
        [DataMember(Name = "volType", IsRequired = true, EmitDefaultValue = true)]
        public string VolType { get; set; }

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
            sb.Append("class EquityVolDependency {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DomesticCurrency: ").Append(DomesticCurrency).Append("\n");
            sb.Append("  VolType: ").Append(VolType).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as EquityVolDependency);
        }

        /// <summary>
        /// Returns true if EquityVolDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of EquityVolDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EquityVolDependency input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && base.Equals(input) && 
                (
                    this.DomesticCurrency == input.DomesticCurrency ||
                    (this.DomesticCurrency != null &&
                    this.DomesticCurrency.Equals(input.DomesticCurrency))
                ) && base.Equals(input) && 
                (
                    this.VolType == input.VolType ||
                    (this.VolType != null &&
                    this.VolType.Equals(input.VolType))
                ) && base.Equals(input) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.DomesticCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.DomesticCurrency.GetHashCode();
                }
                if (this.VolType != null)
                {
                    hashCode = (hashCode * 59) + this.VolType.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
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
            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 50.", new [] { "Code" });
            }

            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 0.", new [] { "Code" });
            }

            // VolType (string) maxLength
            if (this.VolType != null && this.VolType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VolType, length must be less than 50.", new [] { "VolType" });
            }

            // VolType (string) minLength
            if (this.VolType != null && this.VolType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VolType, length must be greater than 0.", new [] { "VolType" });
            }

            yield break;
        }
    }
}
