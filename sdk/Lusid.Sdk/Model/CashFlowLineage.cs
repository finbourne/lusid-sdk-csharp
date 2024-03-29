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
    /// Lineage for cash flow value
    /// </summary>
    [DataContract(Name = "CashFlowLineage")]
    public partial class CashFlowLineage : IEquatable<CashFlowLineage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashFlowLineage" /> class.
        /// </summary>
        /// <param name="instrumentType">The instrument type of the instrument to which the cash flow belongs to. When upserting CashFlowValues, this  should be null..</param>
        /// <param name="cashFlowType">The cashflow type.When upserting CashFlowValues, this should be null, or one of [Unknown, Coupon, Notional,  Premium, Principal, Protection, Cash].</param>
        /// <param name="instrumentId">The LUID of the instrument to which the cash flow belongs to. When upserting this should be null..</param>
        /// <param name="legId">The leg id to which the cash flow belongs to..</param>
        /// <param name="sourceTransactionId">The source transaction of the instrument to which the cash flow belongs to. When upserting this should be null.</param>
        /// <param name="payReceive">Does the cash flow belong to the Pay or Receive leg. When upserting this should either be null or one of [Pay, Receive, NotApplicable].</param>
        public CashFlowLineage(string instrumentType = default(string), string cashFlowType = default(string), string instrumentId = default(string), string legId = default(string), string sourceTransactionId = default(string), string payReceive = default(string))
        {
            this.InstrumentType = instrumentType;
            this.CashFlowType = cashFlowType;
            this.InstrumentId = instrumentId;
            this.LegId = legId;
            this.SourceTransactionId = sourceTransactionId;
            this.PayReceive = payReceive;
        }

        /// <summary>
        /// The instrument type of the instrument to which the cash flow belongs to. When upserting CashFlowValues, this  should be null.
        /// </summary>
        /// <value>The instrument type of the instrument to which the cash flow belongs to. When upserting CashFlowValues, this  should be null.</value>
        [DataMember(Name = "instrumentType", EmitDefaultValue = true)]
        public string InstrumentType { get; set; }

        /// <summary>
        /// The cashflow type.When upserting CashFlowValues, this should be null, or one of [Unknown, Coupon, Notional,  Premium, Principal, Protection, Cash]
        /// </summary>
        /// <value>The cashflow type.When upserting CashFlowValues, this should be null, or one of [Unknown, Coupon, Notional,  Premium, Principal, Protection, Cash]</value>
        [DataMember(Name = "cashFlowType", EmitDefaultValue = true)]
        public string CashFlowType { get; set; }

        /// <summary>
        /// The LUID of the instrument to which the cash flow belongs to. When upserting this should be null.
        /// </summary>
        /// <value>The LUID of the instrument to which the cash flow belongs to. When upserting this should be null.</value>
        [DataMember(Name = "instrumentId", EmitDefaultValue = true)]
        public string InstrumentId { get; set; }

        /// <summary>
        /// The leg id to which the cash flow belongs to.
        /// </summary>
        /// <value>The leg id to which the cash flow belongs to.</value>
        [DataMember(Name = "legId", EmitDefaultValue = true)]
        public string LegId { get; set; }

        /// <summary>
        /// The source transaction of the instrument to which the cash flow belongs to. When upserting this should be null
        /// </summary>
        /// <value>The source transaction of the instrument to which the cash flow belongs to. When upserting this should be null</value>
        [DataMember(Name = "sourceTransactionId", EmitDefaultValue = true)]
        public string SourceTransactionId { get; set; }

        /// <summary>
        /// Does the cash flow belong to the Pay or Receive leg. When upserting this should either be null or one of [Pay, Receive, NotApplicable]
        /// </summary>
        /// <value>Does the cash flow belong to the Pay or Receive leg. When upserting this should either be null or one of [Pay, Receive, NotApplicable]</value>
        [DataMember(Name = "payReceive", EmitDefaultValue = true)]
        public string PayReceive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CashFlowLineage {\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
            sb.Append("  CashFlowType: ").Append(CashFlowType).Append("\n");
            sb.Append("  InstrumentId: ").Append(InstrumentId).Append("\n");
            sb.Append("  LegId: ").Append(LegId).Append("\n");
            sb.Append("  SourceTransactionId: ").Append(SourceTransactionId).Append("\n");
            sb.Append("  PayReceive: ").Append(PayReceive).Append("\n");
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
            return this.Equals(input as CashFlowLineage);
        }

        /// <summary>
        /// Returns true if CashFlowLineage instances are equal
        /// </summary>
        /// <param name="input">Instance of CashFlowLineage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashFlowLineage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstrumentType == input.InstrumentType ||
                    (this.InstrumentType != null &&
                    this.InstrumentType.Equals(input.InstrumentType))
                ) && 
                (
                    this.CashFlowType == input.CashFlowType ||
                    (this.CashFlowType != null &&
                    this.CashFlowType.Equals(input.CashFlowType))
                ) && 
                (
                    this.InstrumentId == input.InstrumentId ||
                    (this.InstrumentId != null &&
                    this.InstrumentId.Equals(input.InstrumentId))
                ) && 
                (
                    this.LegId == input.LegId ||
                    (this.LegId != null &&
                    this.LegId.Equals(input.LegId))
                ) && 
                (
                    this.SourceTransactionId == input.SourceTransactionId ||
                    (this.SourceTransactionId != null &&
                    this.SourceTransactionId.Equals(input.SourceTransactionId))
                ) && 
                (
                    this.PayReceive == input.PayReceive ||
                    (this.PayReceive != null &&
                    this.PayReceive.Equals(input.PayReceive))
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
                if (this.InstrumentType != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentType.GetHashCode();
                }
                if (this.CashFlowType != null)
                {
                    hashCode = (hashCode * 59) + this.CashFlowType.GetHashCode();
                }
                if (this.InstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentId.GetHashCode();
                }
                if (this.LegId != null)
                {
                    hashCode = (hashCode * 59) + this.LegId.GetHashCode();
                }
                if (this.SourceTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceTransactionId.GetHashCode();
                }
                if (this.PayReceive != null)
                {
                    hashCode = (hashCode * 59) + this.PayReceive.GetHashCode();
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
