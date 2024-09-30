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
    /// The breakdown of PnL for a Fund on a specified date.
    /// </summary>
    [DataContract(Name = "FundPnlBreakdown")]
    public partial class FundPnlBreakdown : IEquatable<FundPnlBreakdown>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundPnlBreakdown" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FundPnlBreakdown() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FundPnlBreakdown" /> class.
        /// </summary>
        /// <param name="nonClassSpecificPnl">Bucket of detail for PnL within the queried period that is not specific to any share class. (required).</param>
        /// <param name="aggregatedClassPnl">Bucket of detail for the sum of class PnL across all share classes in a fund and within the queried period. (required).</param>
        /// <param name="totalPnl">Bucket of detail for the sum of class PnL and PnL not specific to a class within the queried period. (required).</param>
        public FundPnlBreakdown(Dictionary<string, FundAmount> nonClassSpecificPnl = default(Dictionary<string, FundAmount>), Dictionary<string, FundAmount> aggregatedClassPnl = default(Dictionary<string, FundAmount>), Dictionary<string, FundAmount> totalPnl = default(Dictionary<string, FundAmount>))
        {
            // to ensure "nonClassSpecificPnl" is required (not null)
            if (nonClassSpecificPnl == null)
            {
                throw new ArgumentNullException("nonClassSpecificPnl is a required property for FundPnlBreakdown and cannot be null");
            }
            this.NonClassSpecificPnl = nonClassSpecificPnl;
            // to ensure "aggregatedClassPnl" is required (not null)
            if (aggregatedClassPnl == null)
            {
                throw new ArgumentNullException("aggregatedClassPnl is a required property for FundPnlBreakdown and cannot be null");
            }
            this.AggregatedClassPnl = aggregatedClassPnl;
            // to ensure "totalPnl" is required (not null)
            if (totalPnl == null)
            {
                throw new ArgumentNullException("totalPnl is a required property for FundPnlBreakdown and cannot be null");
            }
            this.TotalPnl = totalPnl;
        }

        /// <summary>
        /// Bucket of detail for PnL within the queried period that is not specific to any share class.
        /// </summary>
        /// <value>Bucket of detail for PnL within the queried period that is not specific to any share class.</value>
        [DataMember(Name = "nonClassSpecificPnl", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, FundAmount> NonClassSpecificPnl { get; set; }

        /// <summary>
        /// Bucket of detail for the sum of class PnL across all share classes in a fund and within the queried period.
        /// </summary>
        /// <value>Bucket of detail for the sum of class PnL across all share classes in a fund and within the queried period.</value>
        [DataMember(Name = "aggregatedClassPnl", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, FundAmount> AggregatedClassPnl { get; set; }

        /// <summary>
        /// Bucket of detail for the sum of class PnL and PnL not specific to a class within the queried period.
        /// </summary>
        /// <value>Bucket of detail for the sum of class PnL and PnL not specific to a class within the queried period.</value>
        [DataMember(Name = "totalPnl", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, FundAmount> TotalPnl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FundPnlBreakdown {\n");
            sb.Append("  NonClassSpecificPnl: ").Append(NonClassSpecificPnl).Append("\n");
            sb.Append("  AggregatedClassPnl: ").Append(AggregatedClassPnl).Append("\n");
            sb.Append("  TotalPnl: ").Append(TotalPnl).Append("\n");
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
            return this.Equals(input as FundPnlBreakdown);
        }

        /// <summary>
        /// Returns true if FundPnlBreakdown instances are equal
        /// </summary>
        /// <param name="input">Instance of FundPnlBreakdown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundPnlBreakdown input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NonClassSpecificPnl == input.NonClassSpecificPnl ||
                    this.NonClassSpecificPnl != null &&
                    input.NonClassSpecificPnl != null &&
                    this.NonClassSpecificPnl.SequenceEqual(input.NonClassSpecificPnl)
                ) && 
                (
                    this.AggregatedClassPnl == input.AggregatedClassPnl ||
                    this.AggregatedClassPnl != null &&
                    input.AggregatedClassPnl != null &&
                    this.AggregatedClassPnl.SequenceEqual(input.AggregatedClassPnl)
                ) && 
                (
                    this.TotalPnl == input.TotalPnl ||
                    this.TotalPnl != null &&
                    input.TotalPnl != null &&
                    this.TotalPnl.SequenceEqual(input.TotalPnl)
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
                if (this.NonClassSpecificPnl != null)
                {
                    hashCode = (hashCode * 59) + this.NonClassSpecificPnl.GetHashCode();
                }
                if (this.AggregatedClassPnl != null)
                {
                    hashCode = (hashCode * 59) + this.AggregatedClassPnl.GetHashCode();
                }
                if (this.TotalPnl != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPnl.GetHashCode();
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