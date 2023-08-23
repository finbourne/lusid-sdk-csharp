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
    /// Base class for representing complex market data in LUSID.  Generally speaking, market data is complex when it cannot be represented as a single quote.  Examples include discounting curves, projection curves, and volatility surfaces, which are used to compute instrument analytics.  This base class should not be directly instantiated; each supported MarketDataType has a corresponding inherited class.
    /// </summary>
    [DataContract(Name = "ComplexMarketData")]
    [JsonConverter(typeof(JsonSubtypes), "MarketDataType")]
    [JsonSubtypes.KnownSubType(typeof(CreditSpreadCurveData), "CreditSpreadCurveData")]
    [JsonSubtypes.KnownSubType(typeof(DiscountFactorCurveData), "DiscountFactorCurveData")]
    [JsonSubtypes.KnownSubType(typeof(EquityCurveByPricesData), "EquityCurveByPricesData")]
    [JsonSubtypes.KnownSubType(typeof(EquityVolSurfaceData), "EquityVolSurfaceData")]
    [JsonSubtypes.KnownSubType(typeof(FxForwardCurveByQuoteReference), "FxForwardCurveByQuoteReference")]
    [JsonSubtypes.KnownSubType(typeof(FxForwardCurveData), "FxForwardCurveData")]
    [JsonSubtypes.KnownSubType(typeof(FxForwardPipsCurveData), "FxForwardPipsCurveData")]
    [JsonSubtypes.KnownSubType(typeof(FxForwardTenorCurveData), "FxForwardTenorCurveData")]
    [JsonSubtypes.KnownSubType(typeof(FxForwardTenorPipsCurveData), "FxForwardTenorPipsCurveData")]
    [JsonSubtypes.KnownSubType(typeof(FxVolSurfaceData), "FxVolSurfaceData")]
    [JsonSubtypes.KnownSubType(typeof(IrVolCubeData), "IrVolCubeData")]
    [JsonSubtypes.KnownSubType(typeof(OpaqueMarketData), "OpaqueMarketData")]
    [JsonSubtypes.KnownSubType(typeof(YieldCurveData), "YieldCurveData")]
    public partial class ComplexMarketData : IEquatable<ComplexMarketData>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ComplexMarketData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComplexMarketData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexMarketData" /> class.
        /// </summary>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData (required).</param>
        public ComplexMarketData(MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum))
        {
            this.MarketDataType = marketDataType;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComplexMarketData {\n");
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
            return this.Equals(input as ComplexMarketData);
        }

        /// <summary>
        /// Returns true if ComplexMarketData instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplexMarketData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplexMarketData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
