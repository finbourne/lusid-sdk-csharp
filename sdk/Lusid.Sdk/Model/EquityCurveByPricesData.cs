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
    /// Contains data (i.e. dates and prices + metadata) for building Equity curves
    /// </summary>
    [DataContract(Name = "EquityCurveByPricesData")]
    [JsonConverter(typeof(JsonSubtypes), "MarketDataType")]
    public partial class EquityCurveByPricesData : ComplexMarketData, IEquatable<EquityCurveByPricesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquityCurveByPricesData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EquityCurveByPricesData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EquityCurveByPricesData" /> class.
        /// </summary>
        /// <param name="baseDate">EffectiveAt date of the provided prices (required).</param>
        /// <param name="dates">Dates provided for the forward price of the Equity at the corresponding price in Prices.  These dates should be in the future with respect to the BaseDate. (required).</param>
        /// <param name="lineage">Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;..</param>
        /// <param name="prices">Prices provided for the forward price of the Equity at the corresponding date in Dates. (required).</param>
        /// <param name="marketDataOptions">marketDataOptions.</param>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface (required) (default to &quot;EquityCurveByPricesData&quot;).</param>
        public EquityCurveByPricesData(DateTimeOffset baseDate = default(DateTimeOffset), List<DateTimeOffset> dates = default(List<DateTimeOffset>), string lineage = default(string), List<decimal> prices = default(List<decimal>), MarketDataOptions marketDataOptions = default(MarketDataOptions), MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum)) : base(marketDataType)
        {
            this.BaseDate = baseDate;
            // to ensure "dates" is required (not null)
            if (dates == null)
            {
                throw new ArgumentNullException("dates is a required property for EquityCurveByPricesData and cannot be null");
            }
            this.Dates = dates;
            // to ensure "prices" is required (not null)
            if (prices == null)
            {
                throw new ArgumentNullException("prices is a required property for EquityCurveByPricesData and cannot be null");
            }
            this.Prices = prices;
            this.Lineage = lineage;
            this.MarketDataOptions = marketDataOptions;
        }

        /// <summary>
        /// EffectiveAt date of the provided prices
        /// </summary>
        /// <value>EffectiveAt date of the provided prices</value>
        [DataMember(Name = "baseDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset BaseDate { get; set; }

        /// <summary>
        /// Dates provided for the forward price of the Equity at the corresponding price in Prices.  These dates should be in the future with respect to the BaseDate.
        /// </summary>
        /// <value>Dates provided for the forward price of the Equity at the corresponding price in Prices.  These dates should be in the future with respect to the BaseDate.</value>
        [DataMember(Name = "dates", IsRequired = true, EmitDefaultValue = true)]
        public List<DateTimeOffset> Dates { get; set; }

        /// <summary>
        /// Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.
        /// </summary>
        /// <value>Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.</value>
        [DataMember(Name = "lineage", EmitDefaultValue = true)]
        public string Lineage { get; set; }

        /// <summary>
        /// Prices provided for the forward price of the Equity at the corresponding date in Dates.
        /// </summary>
        /// <value>Prices provided for the forward price of the Equity at the corresponding date in Dates.</value>
        [DataMember(Name = "prices", IsRequired = true, EmitDefaultValue = true)]
        public List<decimal> Prices { get; set; }

        /// <summary>
        /// Gets or Sets MarketDataOptions
        /// </summary>
        [DataMember(Name = "marketDataOptions", EmitDefaultValue = false)]
        public MarketDataOptions MarketDataOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EquityCurveByPricesData {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BaseDate: ").Append(BaseDate).Append("\n");
            sb.Append("  Dates: ").Append(Dates).Append("\n");
            sb.Append("  Lineage: ").Append(Lineage).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
            sb.Append("  MarketDataOptions: ").Append(MarketDataOptions).Append("\n");
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
            return this.Equals(input as EquityCurveByPricesData);
        }

        /// <summary>
        /// Returns true if EquityCurveByPricesData instances are equal
        /// </summary>
        /// <param name="input">Instance of EquityCurveByPricesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EquityCurveByPricesData input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.BaseDate == input.BaseDate ||
                    (this.BaseDate != null &&
                    this.BaseDate.Equals(input.BaseDate))
                ) && base.Equals(input) && 
                (
                    this.Dates == input.Dates ||
                    this.Dates != null &&
                    input.Dates != null &&
                    this.Dates.SequenceEqual(input.Dates)
                ) && base.Equals(input) && 
                (
                    this.Lineage == input.Lineage ||
                    (this.Lineage != null &&
                    this.Lineage.Equals(input.Lineage))
                ) && base.Equals(input) && 
                (
                    this.Prices == input.Prices ||
                    this.Prices != null &&
                    input.Prices != null &&
                    this.Prices.SequenceEqual(input.Prices)
                ) && base.Equals(input) && 
                (
                    this.MarketDataOptions == input.MarketDataOptions ||
                    (this.MarketDataOptions != null &&
                    this.MarketDataOptions.Equals(input.MarketDataOptions))
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
                if (this.BaseDate != null)
                {
                    hashCode = (hashCode * 59) + this.BaseDate.GetHashCode();
                }
                if (this.Dates != null)
                {
                    hashCode = (hashCode * 59) + this.Dates.GetHashCode();
                }
                if (this.Lineage != null)
                {
                    hashCode = (hashCode * 59) + this.Lineage.GetHashCode();
                }
                if (this.Prices != null)
                {
                    hashCode = (hashCode * 59) + this.Prices.GetHashCode();
                }
                if (this.MarketDataOptions != null)
                {
                    hashCode = (hashCode * 59) + this.MarketDataOptions.GetHashCode();
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
            // Lineage (string) maxLength
            if (this.Lineage != null && this.Lineage.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Lineage, length must be less than 1024.", new [] { "Lineage" });
            }

            // Lineage (string) minLength
            if (this.Lineage != null && this.Lineage.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Lineage, length must be greater than 0.", new [] { "Lineage" });
            }

            yield break;
        }
    }
}
