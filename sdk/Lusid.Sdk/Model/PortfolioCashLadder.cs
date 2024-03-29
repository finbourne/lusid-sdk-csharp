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
    /// PortfolioCashLadder
    /// </summary>
    [DataContract(Name = "PortfolioCashLadder")]
    public partial class PortfolioCashLadder : IEquatable<PortfolioCashLadder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioCashLadder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfolioCashLadder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioCashLadder" /> class.
        /// </summary>
        /// <param name="currency">The currency of the cash-flows. (required).</param>
        /// <param name="subHoldingKeys">The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio..</param>
        /// <param name="records">A record of cash flows on a specific date. (required).</param>
        /// <param name="failed">The records that could not be returned along with a reason for their failure..</param>
        /// <param name="links">links.</param>
        public PortfolioCashLadder(string currency = default(string), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), List<CashLadderRecord> records = default(List<CashLadderRecord>), Dictionary<string, ErrorDetail> failed = default(Dictionary<string, ErrorDetail>), List<Link> links = default(List<Link>))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for PortfolioCashLadder and cannot be null");
            }
            this.Currency = currency;
            // to ensure "records" is required (not null)
            if (records == null)
            {
                throw new ArgumentNullException("records is a required property for PortfolioCashLadder and cannot be null");
            }
            this.Records = records;
            this.SubHoldingKeys = subHoldingKeys;
            this.Failed = failed;
            this.Links = links;
        }

        /// <summary>
        /// The currency of the cash-flows.
        /// </summary>
        /// <value>The currency of the cash-flows.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio.
        /// </summary>
        /// <value>The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio.</value>
        [DataMember(Name = "subHoldingKeys", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// A record of cash flows on a specific date.
        /// </summary>
        /// <value>A record of cash flows on a specific date.</value>
        [DataMember(Name = "records", IsRequired = true, EmitDefaultValue = true)]
        public List<CashLadderRecord> Records { get; set; }

        /// <summary>
        /// The records that could not be returned along with a reason for their failure.
        /// </summary>
        /// <value>The records that could not be returned along with a reason for their failure.</value>
        [DataMember(Name = "failed", EmitDefaultValue = true)]
        public Dictionary<string, ErrorDetail> Failed { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PortfolioCashLadder {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as PortfolioCashLadder);
        }

        /// <summary>
        /// Returns true if PortfolioCashLadder instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioCashLadder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioCashLadder input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
                ) && 
                (
                    this.Failed == input.Failed ||
                    this.Failed != null &&
                    input.Failed != null &&
                    this.Failed.SequenceEqual(input.Failed)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.SubHoldingKeys != null)
                {
                    hashCode = (hashCode * 59) + this.SubHoldingKeys.GetHashCode();
                }
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
                }
                if (this.Failed != null)
                {
                    hashCode = (hashCode * 59) + this.Failed.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
