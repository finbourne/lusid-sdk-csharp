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
    /// Class which holds market data overrides to be used in valuation
    /// </summary>
    [DataContract(Name = "MarketDataOverrides")]
    public partial class MarketDataOverrides : IEquatable<MarketDataOverrides>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketDataOverrides" /> class.
        /// </summary>
        /// <param name="complexMarketData">A list of EconomicDependency paired with quote data satisfying that economic dependency.</param>
        /// <param name="quotes">A list of EconomicDependency paired with a ComplexMarketData satisfying that economic dependency.</param>
        public MarketDataOverrides(List<EconomicDependencyWithComplexMarketData> complexMarketData = default(List<EconomicDependencyWithComplexMarketData>), List<EconomicDependencyWithQuote> quotes = default(List<EconomicDependencyWithQuote>))
        {
            this.ComplexMarketData = complexMarketData;
            this.Quotes = quotes;
        }

        /// <summary>
        /// A list of EconomicDependency paired with quote data satisfying that economic dependency
        /// </summary>
        /// <value>A list of EconomicDependency paired with quote data satisfying that economic dependency</value>
        [DataMember(Name = "complexMarketData", EmitDefaultValue = true)]
        public List<EconomicDependencyWithComplexMarketData> ComplexMarketData { get; set; }

        /// <summary>
        /// A list of EconomicDependency paired with a ComplexMarketData satisfying that economic dependency
        /// </summary>
        /// <value>A list of EconomicDependency paired with a ComplexMarketData satisfying that economic dependency</value>
        [DataMember(Name = "quotes", EmitDefaultValue = true)]
        public List<EconomicDependencyWithQuote> Quotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarketDataOverrides {\n");
            sb.Append("  ComplexMarketData: ").Append(ComplexMarketData).Append("\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
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
            return this.Equals(input as MarketDataOverrides);
        }

        /// <summary>
        /// Returns true if MarketDataOverrides instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketDataOverrides to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketDataOverrides input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ComplexMarketData == input.ComplexMarketData ||
                    this.ComplexMarketData != null &&
                    input.ComplexMarketData != null &&
                    this.ComplexMarketData.SequenceEqual(input.ComplexMarketData)
                ) && 
                (
                    this.Quotes == input.Quotes ||
                    this.Quotes != null &&
                    input.Quotes != null &&
                    this.Quotes.SequenceEqual(input.Quotes)
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
                if (this.ComplexMarketData != null)
                {
                    hashCode = (hashCode * 59) + this.ComplexMarketData.GetHashCode();
                }
                if (this.Quotes != null)
                {
                    hashCode = (hashCode * 59) + this.Quotes.GetHashCode();
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
            yield break;
        }
    }
}
