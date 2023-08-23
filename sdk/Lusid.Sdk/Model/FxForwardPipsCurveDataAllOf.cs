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
    /// FxForwardPipsCurveDataAllOf
    /// </summary>
    [DataContract(Name = "FxForwardPipsCurveData_allOf")]
    public partial class FxForwardPipsCurveDataAllOf : IEquatable<FxForwardPipsCurveDataAllOf>, IValidatableObject
    {
        /// <summary>
        /// The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData
        /// </summary>
        /// <value>The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MarketDataTypeEnum
        {
            /// <summary>
            /// Enum DiscountFactorCurveData for value: DiscountFactorCurveData
            /// </summary>
            [EnumMember(Value = "DiscountFactorCurveData")]
            DiscountFactorCurveData = 1,

            /// <summary>
            /// Enum EquityVolSurfaceData for value: EquityVolSurfaceData
            /// </summary>
            [EnumMember(Value = "EquityVolSurfaceData")]
            EquityVolSurfaceData = 2,

            /// <summary>
            /// Enum FxVolSurfaceData for value: FxVolSurfaceData
            /// </summary>
            [EnumMember(Value = "FxVolSurfaceData")]
            FxVolSurfaceData = 3,

            /// <summary>
            /// Enum IrVolCubeData for value: IrVolCubeData
            /// </summary>
            [EnumMember(Value = "IrVolCubeData")]
            IrVolCubeData = 4,

            /// <summary>
            /// Enum OpaqueMarketData for value: OpaqueMarketData
            /// </summary>
            [EnumMember(Value = "OpaqueMarketData")]
            OpaqueMarketData = 5,

            /// <summary>
            /// Enum YieldCurveData for value: YieldCurveData
            /// </summary>
            [EnumMember(Value = "YieldCurveData")]
            YieldCurveData = 6,

            /// <summary>
            /// Enum FxForwardCurveData for value: FxForwardCurveData
            /// </summary>
            [EnumMember(Value = "FxForwardCurveData")]
            FxForwardCurveData = 7,

            /// <summary>
            /// Enum FxForwardPipsCurveData for value: FxForwardPipsCurveData
            /// </summary>
            [EnumMember(Value = "FxForwardPipsCurveData")]
            FxForwardPipsCurveData = 8,

            /// <summary>
            /// Enum FxForwardTenorCurveData for value: FxForwardTenorCurveData
            /// </summary>
            [EnumMember(Value = "FxForwardTenorCurveData")]
            FxForwardTenorCurveData = 9,

            /// <summary>
            /// Enum FxForwardTenorPipsCurveData for value: FxForwardTenorPipsCurveData
            /// </summary>
            [EnumMember(Value = "FxForwardTenorPipsCurveData")]
            FxForwardTenorPipsCurveData = 10,

            /// <summary>
            /// Enum FxForwardCurveByQuoteReference for value: FxForwardCurveByQuoteReference
            /// </summary>
            [EnumMember(Value = "FxForwardCurveByQuoteReference")]
            FxForwardCurveByQuoteReference = 11,

            /// <summary>
            /// Enum CreditSpreadCurveData for value: CreditSpreadCurveData
            /// </summary>
            [EnumMember(Value = "CreditSpreadCurveData")]
            CreditSpreadCurveData = 12,

            /// <summary>
            /// Enum EquityCurveByPricesData for value: EquityCurveByPricesData
            /// </summary>
            [EnumMember(Value = "EquityCurveByPricesData")]
            EquityCurveByPricesData = 13

        }


        /// <summary>
        /// The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData
        /// </summary>
        /// <value>The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData</value>
        [DataMember(Name = "marketDataType", IsRequired = true, EmitDefaultValue = true)]
        public MarketDataTypeEnum MarketDataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardPipsCurveDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxForwardPipsCurveDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardPipsCurveDataAllOf" /> class.
        /// </summary>
        /// <param name="baseDate">EffectiveAt date of the quoted pip rates (required).</param>
        /// <param name="domCcy">Domestic currency of the fx forward (required).</param>
        /// <param name="fgnCcy">Foreign currency of the fx forward (required).</param>
        /// <param name="dates">Dates for which the forward rates apply (required).</param>
        /// <param name="pipRates">Rates provided for the fx forward (price in FgnCcy per unit of DomCcy), expressed in pips (required).</param>
        /// <param name="lineage">Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;..</param>
        /// <param name="marketDataOptions">marketDataOptions.</param>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData (required).</param>
        public FxForwardPipsCurveDataAllOf(DateTimeOffset baseDate = default(DateTimeOffset), string domCcy = default(string), string fgnCcy = default(string), List<DateTimeOffset> dates = default(List<DateTimeOffset>), List<decimal> pipRates = default(List<decimal>), string lineage = default(string), MarketDataOptions marketDataOptions = default(MarketDataOptions), MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum))
        {
            this.BaseDate = baseDate;
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new ArgumentNullException("domCcy is a required property for FxForwardPipsCurveDataAllOf and cannot be null");
            }
            this.DomCcy = domCcy;
            // to ensure "fgnCcy" is required (not null)
            if (fgnCcy == null)
            {
                throw new ArgumentNullException("fgnCcy is a required property for FxForwardPipsCurveDataAllOf and cannot be null");
            }
            this.FgnCcy = fgnCcy;
            // to ensure "dates" is required (not null)
            if (dates == null)
            {
                throw new ArgumentNullException("dates is a required property for FxForwardPipsCurveDataAllOf and cannot be null");
            }
            this.Dates = dates;
            // to ensure "pipRates" is required (not null)
            if (pipRates == null)
            {
                throw new ArgumentNullException("pipRates is a required property for FxForwardPipsCurveDataAllOf and cannot be null");
            }
            this.PipRates = pipRates;
            this.MarketDataType = marketDataType;
            this.Lineage = lineage;
            this.MarketDataOptions = marketDataOptions;
        }

        /// <summary>
        /// EffectiveAt date of the quoted pip rates
        /// </summary>
        /// <value>EffectiveAt date of the quoted pip rates</value>
        [DataMember(Name = "baseDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset BaseDate { get; set; }

        /// <summary>
        /// Domestic currency of the fx forward
        /// </summary>
        /// <value>Domestic currency of the fx forward</value>
        [DataMember(Name = "domCcy", IsRequired = true, EmitDefaultValue = true)]
        public string DomCcy { get; set; }

        /// <summary>
        /// Foreign currency of the fx forward
        /// </summary>
        /// <value>Foreign currency of the fx forward</value>
        [DataMember(Name = "fgnCcy", IsRequired = true, EmitDefaultValue = true)]
        public string FgnCcy { get; set; }

        /// <summary>
        /// Dates for which the forward rates apply
        /// </summary>
        /// <value>Dates for which the forward rates apply</value>
        [DataMember(Name = "dates", IsRequired = true, EmitDefaultValue = true)]
        public List<DateTimeOffset> Dates { get; set; }

        /// <summary>
        /// Rates provided for the fx forward (price in FgnCcy per unit of DomCcy), expressed in pips
        /// </summary>
        /// <value>Rates provided for the fx forward (price in FgnCcy per unit of DomCcy), expressed in pips</value>
        [DataMember(Name = "pipRates", IsRequired = true, EmitDefaultValue = true)]
        public List<decimal> PipRates { get; set; }

        /// <summary>
        /// Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.
        /// </summary>
        /// <value>Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.</value>
        [DataMember(Name = "lineage", EmitDefaultValue = true)]
        public string Lineage { get; set; }

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
            sb.Append("class FxForwardPipsCurveDataAllOf {\n");
            sb.Append("  BaseDate: ").Append(BaseDate).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  FgnCcy: ").Append(FgnCcy).Append("\n");
            sb.Append("  Dates: ").Append(Dates).Append("\n");
            sb.Append("  PipRates: ").Append(PipRates).Append("\n");
            sb.Append("  Lineage: ").Append(Lineage).Append("\n");
            sb.Append("  MarketDataOptions: ").Append(MarketDataOptions).Append("\n");
            sb.Append("  MarketDataType: ").Append(MarketDataType).Append("\n");
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
            return this.Equals(input as FxForwardPipsCurveDataAllOf);
        }

        /// <summary>
        /// Returns true if FxForwardPipsCurveDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of FxForwardPipsCurveDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxForwardPipsCurveDataAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BaseDate == input.BaseDate ||
                    (this.BaseDate != null &&
                    this.BaseDate.Equals(input.BaseDate))
                ) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && 
                (
                    this.FgnCcy == input.FgnCcy ||
                    (this.FgnCcy != null &&
                    this.FgnCcy.Equals(input.FgnCcy))
                ) && 
                (
                    this.Dates == input.Dates ||
                    this.Dates != null &&
                    input.Dates != null &&
                    this.Dates.SequenceEqual(input.Dates)
                ) && 
                (
                    this.PipRates == input.PipRates ||
                    this.PipRates != null &&
                    input.PipRates != null &&
                    this.PipRates.SequenceEqual(input.PipRates)
                ) && 
                (
                    this.Lineage == input.Lineage ||
                    (this.Lineage != null &&
                    this.Lineage.Equals(input.Lineage))
                ) && 
                (
                    this.MarketDataOptions == input.MarketDataOptions ||
                    (this.MarketDataOptions != null &&
                    this.MarketDataOptions.Equals(input.MarketDataOptions))
                ) && 
                (
                    this.MarketDataType == input.MarketDataType ||
                    this.MarketDataType.Equals(input.MarketDataType)
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
                if (this.BaseDate != null)
                {
                    hashCode = (hashCode * 59) + this.BaseDate.GetHashCode();
                }
                if (this.DomCcy != null)
                {
                    hashCode = (hashCode * 59) + this.DomCcy.GetHashCode();
                }
                if (this.FgnCcy != null)
                {
                    hashCode = (hashCode * 59) + this.FgnCcy.GetHashCode();
                }
                if (this.Dates != null)
                {
                    hashCode = (hashCode * 59) + this.Dates.GetHashCode();
                }
                if (this.PipRates != null)
                {
                    hashCode = (hashCode * 59) + this.PipRates.GetHashCode();
                }
                if (this.Lineage != null)
                {
                    hashCode = (hashCode * 59) + this.Lineage.GetHashCode();
                }
                if (this.MarketDataOptions != null)
                {
                    hashCode = (hashCode * 59) + this.MarketDataOptions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MarketDataType.GetHashCode();
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
