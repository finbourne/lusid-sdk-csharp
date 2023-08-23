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
    /// A2B Record - shows values on, and changes between two dates: A and B
    /// </summary>
    [DataContract(Name = "A2BDataRecord")]
    public partial class A2BDataRecord : IEquatable<A2BDataRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="A2BDataRecord" /> class.
        /// </summary>
        /// <param name="portfolioId">portfolioId.</param>
        /// <param name="holdingType">The code for the type of the holding e.g. P, B, C, R, F etc..</param>
        /// <param name="instrumentScope">The unique Lusid Instrument Id (LUID) of the instrument that the holding is in..</param>
        /// <param name="instrumentUid">The unique Lusid Instrument Id (LUID) of the instrument that the holding is in..</param>
        /// <param name="subHoldingKeys">The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio..</param>
        /// <param name="currency">The holding currency..</param>
        /// <param name="transactionId">The unique identifier for the transaction..</param>
        /// <param name="start">start.</param>
        /// <param name="flows">flows.</param>
        /// <param name="gains">gains.</param>
        /// <param name="carry">carry.</param>
        /// <param name="end">end.</param>
        /// <param name="properties">The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; domain..</param>
        /// <param name="groupId">Arbitrary string that can be used to cross reference an entry in the A2B report with activity in the A2B-Movements. This should be used purely as a token. The content should not be relied upon..</param>
        /// <param name="errors">Any errors with the record are reported here..</param>
        public A2BDataRecord(ResourceId portfolioId = default(ResourceId), string holdingType = default(string), string instrumentScope = default(string), string instrumentUid = default(string), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), string currency = default(string), string transactionId = default(string), A2BCategory start = default(A2BCategory), A2BCategory flows = default(A2BCategory), A2BCategory gains = default(A2BCategory), A2BCategory carry = default(A2BCategory), A2BCategory end = default(A2BCategory), Dictionary<string, Property> properties = default(Dictionary<string, Property>), string groupId = default(string), List<ResponseMetaData> errors = default(List<ResponseMetaData>))
        {
            this.PortfolioId = portfolioId;
            this.HoldingType = holdingType;
            this.InstrumentScope = instrumentScope;
            this.InstrumentUid = instrumentUid;
            this.SubHoldingKeys = subHoldingKeys;
            this.Currency = currency;
            this.TransactionId = transactionId;
            this.Start = start;
            this.Flows = flows;
            this.Gains = gains;
            this.Carry = carry;
            this.End = end;
            this.Properties = properties;
            this.GroupId = groupId;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name = "portfolioId", EmitDefaultValue = false)]
        public ResourceId PortfolioId { get; set; }

        /// <summary>
        /// The code for the type of the holding e.g. P, B, C, R, F etc.
        /// </summary>
        /// <value>The code for the type of the holding e.g. P, B, C, R, F etc.</value>
        [DataMember(Name = "holdingType", EmitDefaultValue = true)]
        public string HoldingType { get; set; }

        /// <summary>
        /// The unique Lusid Instrument Id (LUID) of the instrument that the holding is in.
        /// </summary>
        /// <value>The unique Lusid Instrument Id (LUID) of the instrument that the holding is in.</value>
        [DataMember(Name = "instrumentScope", EmitDefaultValue = true)]
        public string InstrumentScope { get; set; }

        /// <summary>
        /// The unique Lusid Instrument Id (LUID) of the instrument that the holding is in.
        /// </summary>
        /// <value>The unique Lusid Instrument Id (LUID) of the instrument that the holding is in.</value>
        [DataMember(Name = "instrumentUid", EmitDefaultValue = true)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio.
        /// </summary>
        /// <value>The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio.</value>
        [DataMember(Name = "subHoldingKeys", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// The holding currency.
        /// </summary>
        /// <value>The holding currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The unique identifier for the transaction.
        /// </summary>
        /// <value>The unique identifier for the transaction.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = true)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public A2BCategory Start { get; set; }

        /// <summary>
        /// Gets or Sets Flows
        /// </summary>
        [DataMember(Name = "flows", EmitDefaultValue = false)]
        public A2BCategory Flows { get; set; }

        /// <summary>
        /// Gets or Sets Gains
        /// </summary>
        [DataMember(Name = "gains", EmitDefaultValue = false)]
        public A2BCategory Gains { get; set; }

        /// <summary>
        /// Gets or Sets Carry
        /// </summary>
        [DataMember(Name = "carry", EmitDefaultValue = false)]
        public A2BCategory Carry { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public A2BCategory End { get; set; }

        /// <summary>
        /// The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; domain.
        /// </summary>
        /// <value>The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// Arbitrary string that can be used to cross reference an entry in the A2B report with activity in the A2B-Movements. This should be used purely as a token. The content should not be relied upon.
        /// </summary>
        /// <value>Arbitrary string that can be used to cross reference an entry in the A2B report with activity in the A2B-Movements. This should be used purely as a token. The content should not be relied upon.</value>
        [DataMember(Name = "groupId", EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Any errors with the record are reported here.
        /// </summary>
        /// <value>Any errors with the record are reported here.</value>
        [DataMember(Name = "errors", EmitDefaultValue = true)]
        public List<ResponseMetaData> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class A2BDataRecord {\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  HoldingType: ").Append(HoldingType).Append("\n");
            sb.Append("  InstrumentScope: ").Append(InstrumentScope).Append("\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  Flows: ").Append(Flows).Append("\n");
            sb.Append("  Gains: ").Append(Gains).Append("\n");
            sb.Append("  Carry: ").Append(Carry).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as A2BDataRecord);
        }

        /// <summary>
        /// Returns true if A2BDataRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of A2BDataRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(A2BDataRecord input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PortfolioId == input.PortfolioId ||
                    (this.PortfolioId != null &&
                    this.PortfolioId.Equals(input.PortfolioId))
                ) && 
                (
                    this.HoldingType == input.HoldingType ||
                    (this.HoldingType != null &&
                    this.HoldingType.Equals(input.HoldingType))
                ) && 
                (
                    this.InstrumentScope == input.InstrumentScope ||
                    (this.InstrumentScope != null &&
                    this.InstrumentScope.Equals(input.InstrumentScope))
                ) && 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Flows == input.Flows ||
                    (this.Flows != null &&
                    this.Flows.Equals(input.Flows))
                ) && 
                (
                    this.Gains == input.Gains ||
                    (this.Gains != null &&
                    this.Gains.Equals(input.Gains))
                ) && 
                (
                    this.Carry == input.Carry ||
                    (this.Carry != null &&
                    this.Carry.Equals(input.Carry))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.PortfolioId != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioId.GetHashCode();
                }
                if (this.HoldingType != null)
                {
                    hashCode = (hashCode * 59) + this.HoldingType.GetHashCode();
                }
                if (this.InstrumentScope != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentScope.GetHashCode();
                }
                if (this.InstrumentUid != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentUid.GetHashCode();
                }
                if (this.SubHoldingKeys != null)
                {
                    hashCode = (hashCode * 59) + this.SubHoldingKeys.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.Start != null)
                {
                    hashCode = (hashCode * 59) + this.Start.GetHashCode();
                }
                if (this.Flows != null)
                {
                    hashCode = (hashCode * 59) + this.Flows.GetHashCode();
                }
                if (this.Gains != null)
                {
                    hashCode = (hashCode * 59) + this.Gains.GetHashCode();
                }
                if (this.Carry != null)
                {
                    hashCode = (hashCode * 59) + this.Carry.GetHashCode();
                }
                if (this.End != null)
                {
                    hashCode = (hashCode * 59) + this.End.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
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
