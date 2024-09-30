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
    /// UnitisationData
    /// </summary>
    [DataContract(Name = "UnitisationData")]
    public partial class UnitisationData : IEquatable<UnitisationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitisationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnitisationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitisationData" /> class.
        /// </summary>
        /// <param name="sharesInIssue">The number of shares in issue at a valuation point. (required).</param>
        /// <param name="unitPrice">The price of one unit of the share class at a valuation point. (required).</param>
        /// <param name="netDealingUnits">The net dealing in units for the share class at a valuation point. This could be the sum of negative redemptions (in units) and positive subscriptions (in units). (required).</param>
        public UnitisationData(decimal sharesInIssue = default(decimal), decimal unitPrice = default(decimal), decimal netDealingUnits = default(decimal))
        {
            this.SharesInIssue = sharesInIssue;
            this.UnitPrice = unitPrice;
            this.NetDealingUnits = netDealingUnits;
        }

        /// <summary>
        /// The number of shares in issue at a valuation point.
        /// </summary>
        /// <value>The number of shares in issue at a valuation point.</value>
        [DataMember(Name = "sharesInIssue", IsRequired = true, EmitDefaultValue = true)]
        public decimal SharesInIssue { get; set; }

        /// <summary>
        /// The price of one unit of the share class at a valuation point.
        /// </summary>
        /// <value>The price of one unit of the share class at a valuation point.</value>
        [DataMember(Name = "unitPrice", IsRequired = true, EmitDefaultValue = true)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The net dealing in units for the share class at a valuation point. This could be the sum of negative redemptions (in units) and positive subscriptions (in units).
        /// </summary>
        /// <value>The net dealing in units for the share class at a valuation point. This could be the sum of negative redemptions (in units) and positive subscriptions (in units).</value>
        [DataMember(Name = "netDealingUnits", IsRequired = true, EmitDefaultValue = true)]
        public decimal NetDealingUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnitisationData {\n");
            sb.Append("  SharesInIssue: ").Append(SharesInIssue).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  NetDealingUnits: ").Append(NetDealingUnits).Append("\n");
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
            return this.Equals(input as UnitisationData);
        }

        /// <summary>
        /// Returns true if UnitisationData instances are equal
        /// </summary>
        /// <param name="input">Instance of UnitisationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnitisationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SharesInIssue == input.SharesInIssue ||
                    this.SharesInIssue.Equals(input.SharesInIssue)
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
                ) && 
                (
                    this.NetDealingUnits == input.NetDealingUnits ||
                    this.NetDealingUnits.Equals(input.NetDealingUnits)
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
                hashCode = (hashCode * 59) + this.SharesInIssue.GetHashCode();
                hashCode = (hashCode * 59) + this.UnitPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.NetDealingUnits.GetHashCode();
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