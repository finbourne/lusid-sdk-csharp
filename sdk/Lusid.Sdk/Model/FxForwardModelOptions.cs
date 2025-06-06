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
    /// FxForwardModelOptions
    /// </summary>
    [DataContract(Name = "FxForwardModelOptions")]
    [JsonConverter(typeof(JsonSubtypes), "ModelOptionsType")]
    public partial class FxForwardModelOptions : ModelOptions, IEquatable<FxForwardModelOptions>, IValidatableObject
    {
        /// <summary>
        /// The available values are: ForwardPoints, ForwardRate, RatesCurve, FxForwardCurve, Invalid
        /// </summary>
        /// <value>The available values are: ForwardPoints, ForwardRate, RatesCurve, FxForwardCurve, Invalid</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ForwardRateObservableTypeEnum
        {
            /// <summary>
            /// Enum ForwardPoints for value: ForwardPoints
            /// </summary>
            [EnumMember(Value = "ForwardPoints")]
            ForwardPoints = 1,

            /// <summary>
            /// Enum ForwardRate for value: ForwardRate
            /// </summary>
            [EnumMember(Value = "ForwardRate")]
            ForwardRate = 2,

            /// <summary>
            /// Enum RatesCurve for value: RatesCurve
            /// </summary>
            [EnumMember(Value = "RatesCurve")]
            RatesCurve = 3,

            /// <summary>
            /// Enum FxForwardCurve for value: FxForwardCurve
            /// </summary>
            [EnumMember(Value = "FxForwardCurve")]
            FxForwardCurve = 4,

            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 5
        }


        /// <summary>
        /// The available values are: ForwardPoints, ForwardRate, RatesCurve, FxForwardCurve, Invalid
        /// </summary>
        /// <value>The available values are: ForwardPoints, ForwardRate, RatesCurve, FxForwardCurve, Invalid</value>
        [DataMember(Name = "forwardRateObservableType", IsRequired = true, EmitDefaultValue = true)]
        public ForwardRateObservableTypeEnum ForwardRateObservableType { get; set; }
        /// <summary>
        /// The available values are: Standard, ConstantTimeValueOfMoney, Invalid
        /// </summary>
        /// <value>The available values are: Standard, ConstantTimeValueOfMoney, Invalid</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiscountingMethodEnum
        {
            /// <summary>
            /// Enum Standard for value: Standard
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard = 1,

            /// <summary>
            /// Enum ConstantTimeValueOfMoney for value: ConstantTimeValueOfMoney
            /// </summary>
            [EnumMember(Value = "ConstantTimeValueOfMoney")]
            ConstantTimeValueOfMoney = 2,

            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 3
        }


        /// <summary>
        /// The available values are: Standard, ConstantTimeValueOfMoney, Invalid
        /// </summary>
        /// <value>The available values are: Standard, ConstantTimeValueOfMoney, Invalid</value>
        [DataMember(Name = "discountingMethod", IsRequired = true, EmitDefaultValue = true)]
        public DiscountingMethodEnum DiscountingMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardModelOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxForwardModelOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardModelOptions" /> class.
        /// </summary>
        /// <param name="forwardRateObservableType">The available values are: ForwardPoints, ForwardRate, RatesCurve, FxForwardCurve, Invalid (required).</param>
        /// <param name="discountingMethod">The available values are: Standard, ConstantTimeValueOfMoney, Invalid (required).</param>
        /// <param name="convertToReportCcy">Convert all FX flows to the report currency  By setting this all FX forwards will be priced using Forward Curves that have Report Currency as the base. (required).</param>
        /// <param name="modelOptionsType">The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions (required) (default to &quot;FxForwardModelOptions&quot;).</param>
        public FxForwardModelOptions(ForwardRateObservableTypeEnum forwardRateObservableType = default(ForwardRateObservableTypeEnum), DiscountingMethodEnum discountingMethod = default(DiscountingMethodEnum), bool convertToReportCcy = default(bool), ModelOptionsTypeEnum modelOptionsType = default(ModelOptionsTypeEnum)) : base(modelOptionsType)
        {
            this.ForwardRateObservableType = forwardRateObservableType;
            this.DiscountingMethod = discountingMethod;
            this.ConvertToReportCcy = convertToReportCcy;
        }

        /// <summary>
        /// Convert all FX flows to the report currency  By setting this all FX forwards will be priced using Forward Curves that have Report Currency as the base.
        /// </summary>
        /// <value>Convert all FX flows to the report currency  By setting this all FX forwards will be priced using Forward Curves that have Report Currency as the base.</value>
        [DataMember(Name = "convertToReportCcy", IsRequired = true, EmitDefaultValue = true)]
        public bool ConvertToReportCcy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FxForwardModelOptions {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ForwardRateObservableType: ").Append(ForwardRateObservableType).Append("\n");
            sb.Append("  DiscountingMethod: ").Append(DiscountingMethod).Append("\n");
            sb.Append("  ConvertToReportCcy: ").Append(ConvertToReportCcy).Append("\n");
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
            return this.Equals(input as FxForwardModelOptions);
        }

        /// <summary>
        /// Returns true if FxForwardModelOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of FxForwardModelOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxForwardModelOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ForwardRateObservableType == input.ForwardRateObservableType ||
                    this.ForwardRateObservableType.Equals(input.ForwardRateObservableType)
                ) && base.Equals(input) && 
                (
                    this.DiscountingMethod == input.DiscountingMethod ||
                    this.DiscountingMethod.Equals(input.DiscountingMethod)
                ) && base.Equals(input) && 
                (
                    this.ConvertToReportCcy == input.ConvertToReportCcy ||
                    this.ConvertToReportCcy.Equals(input.ConvertToReportCcy)
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
                hashCode = (hashCode * 59) + this.ForwardRateObservableType.GetHashCode();
                hashCode = (hashCode * 59) + this.DiscountingMethod.GetHashCode();
                hashCode = (hashCode * 59) + this.ConvertToReportCcy.GetHashCode();
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
            yield break;
        }
    }
}
