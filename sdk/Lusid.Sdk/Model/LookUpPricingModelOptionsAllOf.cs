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
    /// LookUpPricingModelOptionsAllOf
    /// </summary>
    [DataContract(Name = "LookUpPricingModelOptions_allOf")]
    public partial class LookUpPricingModelOptionsAllOf : IEquatable<LookUpPricingModelOptionsAllOf>, IValidatableObject
    {
        /// <summary>
        /// The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions
        /// </summary>
        /// <value>The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModelOptionsTypeEnum
        {
            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 1,

            /// <summary>
            /// Enum OpaqueModelOptions for value: OpaqueModelOptions
            /// </summary>
            [EnumMember(Value = "OpaqueModelOptions")]
            OpaqueModelOptions = 2,

            /// <summary>
            /// Enum EmptyModelOptions for value: EmptyModelOptions
            /// </summary>
            [EnumMember(Value = "EmptyModelOptions")]
            EmptyModelOptions = 3,

            /// <summary>
            /// Enum IndexModelOptions for value: IndexModelOptions
            /// </summary>
            [EnumMember(Value = "IndexModelOptions")]
            IndexModelOptions = 4,

            /// <summary>
            /// Enum FxForwardModelOptions for value: FxForwardModelOptions
            /// </summary>
            [EnumMember(Value = "FxForwardModelOptions")]
            FxForwardModelOptions = 5,

            /// <summary>
            /// Enum FundingLegModelOptions for value: FundingLegModelOptions
            /// </summary>
            [EnumMember(Value = "FundingLegModelOptions")]
            FundingLegModelOptions = 6,

            /// <summary>
            /// Enum EquityModelOptions for value: EquityModelOptions
            /// </summary>
            [EnumMember(Value = "EquityModelOptions")]
            EquityModelOptions = 7,

            /// <summary>
            /// Enum LookUpPricingModelOptions for value: LookUpPricingModelOptions
            /// </summary>
            [EnumMember(Value = "LookUpPricingModelOptions")]
            LookUpPricingModelOptions = 8

        }


        /// <summary>
        /// The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions
        /// </summary>
        /// <value>The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions</value>
        [DataMember(Name = "modelOptionsType", IsRequired = true, EmitDefaultValue = true)]
        public ModelOptionsTypeEnum ModelOptionsType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpPricingModelOptionsAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LookUpPricingModelOptionsAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpPricingModelOptionsAllOf" /> class.
        /// </summary>
        /// <param name="addAccrual">Add Instrument Accrual to Valuation (required).</param>
        /// <param name="applyIndexRatio">Apply Index Ratio to price before valuation.  Used for InflationLinkedBond (required).</param>
        /// <param name="modelOptionsType">The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions (required).</param>
        public LookUpPricingModelOptionsAllOf(bool addAccrual = default(bool), bool applyIndexRatio = default(bool), ModelOptionsTypeEnum modelOptionsType = default(ModelOptionsTypeEnum))
        {
            this.AddAccrual = addAccrual;
            this.ApplyIndexRatio = applyIndexRatio;
            this.ModelOptionsType = modelOptionsType;
        }

        /// <summary>
        /// Add Instrument Accrual to Valuation
        /// </summary>
        /// <value>Add Instrument Accrual to Valuation</value>
        [DataMember(Name = "addAccrual", IsRequired = true, EmitDefaultValue = true)]
        public bool AddAccrual { get; set; }

        /// <summary>
        /// Apply Index Ratio to price before valuation.  Used for InflationLinkedBond
        /// </summary>
        /// <value>Apply Index Ratio to price before valuation.  Used for InflationLinkedBond</value>
        [DataMember(Name = "applyIndexRatio", IsRequired = true, EmitDefaultValue = true)]
        public bool ApplyIndexRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LookUpPricingModelOptionsAllOf {\n");
            sb.Append("  AddAccrual: ").Append(AddAccrual).Append("\n");
            sb.Append("  ApplyIndexRatio: ").Append(ApplyIndexRatio).Append("\n");
            sb.Append("  ModelOptionsType: ").Append(ModelOptionsType).Append("\n");
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
            return this.Equals(input as LookUpPricingModelOptionsAllOf);
        }

        /// <summary>
        /// Returns true if LookUpPricingModelOptionsAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of LookUpPricingModelOptionsAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookUpPricingModelOptionsAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddAccrual == input.AddAccrual ||
                    this.AddAccrual.Equals(input.AddAccrual)
                ) && 
                (
                    this.ApplyIndexRatio == input.ApplyIndexRatio ||
                    this.ApplyIndexRatio.Equals(input.ApplyIndexRatio)
                ) && 
                (
                    this.ModelOptionsType == input.ModelOptionsType ||
                    this.ModelOptionsType.Equals(input.ModelOptionsType)
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
                hashCode = (hashCode * 59) + this.AddAccrual.GetHashCode();
                hashCode = (hashCode * 59) + this.ApplyIndexRatio.GetHashCode();
                hashCode = (hashCode * 59) + this.ModelOptionsType.GetHashCode();
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
