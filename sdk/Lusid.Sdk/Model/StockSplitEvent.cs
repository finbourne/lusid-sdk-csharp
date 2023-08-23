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
    /// A split in the company&#39;s shares. Shareholders are given additional company shares based on the terms of the stock split.
    /// </summary>
    [DataContract(Name = "StockSplitEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class StockSplitEvent : InstrumentEvent, IEquatable<StockSplitEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StockSplitEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StockSplitEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StockSplitEvent" /> class.
        /// </summary>
        /// <param name="equitySplitRatio">This number describes the rate at which the company will be dividing their current shares outstanding. It is displayed as new shares per old. (required).</param>
        /// <param name="paymentDate">Date on which the stock-split takes effect. (required).</param>
        /// <param name="recordDate">Date you have to be the holder of record in order to participate in the tender. (required).</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent (required) (default to &quot;StockSplitEvent&quot;).</param>
        public StockSplitEvent(decimal equitySplitRatio = default(decimal), DateTimeOffset paymentDate = default(DateTimeOffset), DateTimeOffset recordDate = default(DateTimeOffset), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            this.EquitySplitRatio = equitySplitRatio;
            this.PaymentDate = paymentDate;
            this.RecordDate = recordDate;
        }

        /// <summary>
        /// This number describes the rate at which the company will be dividing their current shares outstanding. It is displayed as new shares per old.
        /// </summary>
        /// <value>This number describes the rate at which the company will be dividing their current shares outstanding. It is displayed as new shares per old.</value>
        [DataMember(Name = "equitySplitRatio", IsRequired = true, EmitDefaultValue = true)]
        public decimal EquitySplitRatio { get; set; }

        /// <summary>
        /// Date on which the stock-split takes effect.
        /// </summary>
        /// <value>Date on which the stock-split takes effect.</value>
        [DataMember(Name = "paymentDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// Date you have to be the holder of record in order to participate in the tender.
        /// </summary>
        /// <value>Date you have to be the holder of record in order to participate in the tender.</value>
        [DataMember(Name = "recordDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset RecordDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StockSplitEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EquitySplitRatio: ").Append(EquitySplitRatio).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
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
            return this.Equals(input as StockSplitEvent);
        }

        /// <summary>
        /// Returns true if StockSplitEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of StockSplitEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockSplitEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.EquitySplitRatio == input.EquitySplitRatio ||
                    this.EquitySplitRatio.Equals(input.EquitySplitRatio)
                ) && base.Equals(input) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && base.Equals(input) && 
                (
                    this.RecordDate == input.RecordDate ||
                    (this.RecordDate != null &&
                    this.RecordDate.Equals(input.RecordDate))
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
                hashCode = (hashCode * 59) + this.EquitySplitRatio.GetHashCode();
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                if (this.RecordDate != null)
                {
                    hashCode = (hashCode * 59) + this.RecordDate.GetHashCode();
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
            yield break;
        }
    }
}
