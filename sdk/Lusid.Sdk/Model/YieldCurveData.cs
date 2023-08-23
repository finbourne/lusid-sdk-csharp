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
    /// Market data for a yield curve,  represented by a list of instruments and corresponding market quotes
    /// </summary>
    [DataContract(Name = "YieldCurveData")]
    [JsonConverter(typeof(JsonSubtypes), "MarketDataType")]
    public partial class YieldCurveData : ComplexMarketData, IEquatable<YieldCurveData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YieldCurveData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected YieldCurveData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="YieldCurveData" /> class.
        /// </summary>
        /// <param name="baseDate">Base date (required).</param>
        /// <param name="instruments">The set of instruments that define the curve. (required).</param>
        /// <param name="quotes">The market quotes corresponding to the the instruments used to define the curve (required).</param>
        /// <param name="lineage">Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;..</param>
        /// <param name="marketDataOptions">marketDataOptions.</param>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData (required) (default to &quot;YieldCurveData&quot;).</param>
        public YieldCurveData(DateTimeOffset baseDate = default(DateTimeOffset), List<LusidInstrument> instruments = default(List<LusidInstrument>), List<MarketQuote> quotes = default(List<MarketQuote>), string lineage = default(string), MarketDataOptions marketDataOptions = default(MarketDataOptions), MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum)) : base(marketDataType)
        {
            this.BaseDate = baseDate;
            // to ensure "instruments" is required (not null)
            if (instruments == null)
            {
                throw new ArgumentNullException("instruments is a required property for YieldCurveData and cannot be null");
            }
            this.Instruments = instruments;
            // to ensure "quotes" is required (not null)
            if (quotes == null)
            {
                throw new ArgumentNullException("quotes is a required property for YieldCurveData and cannot be null");
            }
            this.Quotes = quotes;
            this.Lineage = lineage;
            this.MarketDataOptions = marketDataOptions;
        }

        /// <summary>
        /// Base date
        /// </summary>
        /// <value>Base date</value>
        [DataMember(Name = "baseDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset BaseDate { get; set; }

        /// <summary>
        /// The set of instruments that define the curve.
        /// </summary>
        /// <value>The set of instruments that define the curve.</value>
        [DataMember(Name = "instruments", IsRequired = true, EmitDefaultValue = true)]
        public List<LusidInstrument> Instruments { get; set; }

        /// <summary>
        /// The market quotes corresponding to the the instruments used to define the curve
        /// </summary>
        /// <value>The market quotes corresponding to the the instruments used to define the curve</value>
        [DataMember(Name = "quotes", IsRequired = true, EmitDefaultValue = true)]
        public List<MarketQuote> Quotes { get; set; }

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
            sb.Append("class YieldCurveData {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BaseDate: ").Append(BaseDate).Append("\n");
            sb.Append("  Instruments: ").Append(Instruments).Append("\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
            sb.Append("  Lineage: ").Append(Lineage).Append("\n");
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
            return this.Equals(input as YieldCurveData);
        }

        /// <summary>
        /// Returns true if YieldCurveData instances are equal
        /// </summary>
        /// <param name="input">Instance of YieldCurveData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YieldCurveData input)
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
                    this.Instruments == input.Instruments ||
                    this.Instruments != null &&
                    input.Instruments != null &&
                    this.Instruments.SequenceEqual(input.Instruments)
                ) && base.Equals(input) && 
                (
                    this.Quotes == input.Quotes ||
                    this.Quotes != null &&
                    input.Quotes != null &&
                    this.Quotes.SequenceEqual(input.Quotes)
                ) && base.Equals(input) && 
                (
                    this.Lineage == input.Lineage ||
                    (this.Lineage != null &&
                    this.Lineage.Equals(input.Lineage))
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
                if (this.Instruments != null)
                {
                    hashCode = (hashCode * 59) + this.Instruments.GetHashCode();
                }
                if (this.Quotes != null)
                {
                    hashCode = (hashCode * 59) + this.Quotes.GetHashCode();
                }
                if (this.Lineage != null)
                {
                    hashCode = (hashCode * 59) + this.Lineage.GetHashCode();
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
