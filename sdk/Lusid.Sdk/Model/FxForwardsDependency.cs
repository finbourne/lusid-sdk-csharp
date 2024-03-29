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
    /// Indicates a dependency on an FxForwardCurve.  Identical to Fx dependencies in the meaning of domestic and foreign currencies, but describes a *set* of fx rates.  These rates are quoted rates for fx forwards, which can be used to interpolate the forward rate at a specific time in the future.  In the case of pips, the absolute rates can be expressed as rate &#x3D; spotFx + pips / pipsPerUnit
    /// </summary>
    [DataContract(Name = "FxForwardsDependency")]
    [JsonConverter(typeof(JsonSubtypes), "DependencyType")]
    public partial class FxForwardsDependency : EconomicDependency, IEquatable<FxForwardsDependency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardsDependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxForwardsDependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardsDependency" /> class.
        /// </summary>
        /// <param name="domesticCurrency">DomesticCurrency is the first currency in a currency pair quote e.g. eur-gbp, eur is the domestic currency. (required).</param>
        /// <param name="foreignCurrency">ForeignCurrency is the second currency in a currency pair quote e.g. eur-gbp, gbp is the foreign currency. (required).</param>
        /// <param name="curveType">Used to describe the format in which the curve is expressed  e.g. FxFwdCurve (general term to describe any representation), TenorFxFwdCurve, PipsFxFwdCurve. (required).</param>
        /// <param name="date">The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date. (required).</param>
        /// <param name="dependencyType">The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency (required) (default to &quot;FxForwardsDependency&quot;).</param>
        public FxForwardsDependency(string domesticCurrency = default(string), string foreignCurrency = default(string), string curveType = default(string), DateTimeOffset date = default(DateTimeOffset), DependencyTypeEnum dependencyType = default(DependencyTypeEnum)) : base(dependencyType)
        {
            // to ensure "domesticCurrency" is required (not null)
            if (domesticCurrency == null)
            {
                throw new ArgumentNullException("domesticCurrency is a required property for FxForwardsDependency and cannot be null");
            }
            this.DomesticCurrency = domesticCurrency;
            // to ensure "foreignCurrency" is required (not null)
            if (foreignCurrency == null)
            {
                throw new ArgumentNullException("foreignCurrency is a required property for FxForwardsDependency and cannot be null");
            }
            this.ForeignCurrency = foreignCurrency;
            // to ensure "curveType" is required (not null)
            if (curveType == null)
            {
                throw new ArgumentNullException("curveType is a required property for FxForwardsDependency and cannot be null");
            }
            this.CurveType = curveType;
            this.Date = date;
        }

        /// <summary>
        /// DomesticCurrency is the first currency in a currency pair quote e.g. eur-gbp, eur is the domestic currency.
        /// </summary>
        /// <value>DomesticCurrency is the first currency in a currency pair quote e.g. eur-gbp, eur is the domestic currency.</value>
        [DataMember(Name = "domesticCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string DomesticCurrency { get; set; }

        /// <summary>
        /// ForeignCurrency is the second currency in a currency pair quote e.g. eur-gbp, gbp is the foreign currency.
        /// </summary>
        /// <value>ForeignCurrency is the second currency in a currency pair quote e.g. eur-gbp, gbp is the foreign currency.</value>
        [DataMember(Name = "foreignCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string ForeignCurrency { get; set; }

        /// <summary>
        /// Used to describe the format in which the curve is expressed  e.g. FxFwdCurve (general term to describe any representation), TenorFxFwdCurve, PipsFxFwdCurve.
        /// </summary>
        /// <value>Used to describe the format in which the curve is expressed  e.g. FxFwdCurve (general term to describe any representation), TenorFxFwdCurve, PipsFxFwdCurve.</value>
        [DataMember(Name = "curveType", IsRequired = true, EmitDefaultValue = true)]
        public string CurveType { get; set; }

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
            sb.Append("class FxForwardsDependency {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DomesticCurrency: ").Append(DomesticCurrency).Append("\n");
            sb.Append("  ForeignCurrency: ").Append(ForeignCurrency).Append("\n");
            sb.Append("  CurveType: ").Append(CurveType).Append("\n");
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
            return this.Equals(input as FxForwardsDependency);
        }

        /// <summary>
        /// Returns true if FxForwardsDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of FxForwardsDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxForwardsDependency input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.DomesticCurrency == input.DomesticCurrency ||
                    (this.DomesticCurrency != null &&
                    this.DomesticCurrency.Equals(input.DomesticCurrency))
                ) && base.Equals(input) && 
                (
                    this.ForeignCurrency == input.ForeignCurrency ||
                    (this.ForeignCurrency != null &&
                    this.ForeignCurrency.Equals(input.ForeignCurrency))
                ) && base.Equals(input) && 
                (
                    this.CurveType == input.CurveType ||
                    (this.CurveType != null &&
                    this.CurveType.Equals(input.CurveType))
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
                if (this.DomesticCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.DomesticCurrency.GetHashCode();
                }
                if (this.ForeignCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignCurrency.GetHashCode();
                }
                if (this.CurveType != null)
                {
                    hashCode = (hashCode * 59) + this.CurveType.GetHashCode();
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
            // CurveType (string) maxLength
            if (this.CurveType != null && this.CurveType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurveType, length must be less than 50.", new [] { "CurveType" });
            }

            // CurveType (string) minLength
            if (this.CurveType != null && this.CurveType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurveType, length must be greater than 0.", new [] { "CurveType" });
            }

            yield break;
        }
    }
}
