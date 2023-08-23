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
    /// RawVendorEventAllOf
    /// </summary>
    [DataContract(Name = "RawVendorEvent_allOf")]
    public partial class RawVendorEventAllOf : IEquatable<RawVendorEventAllOf>, IValidatableObject
    {
        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentEventTypeEnum
        {
            /// <summary>
            /// Enum TransitionEvent for value: TransitionEvent
            /// </summary>
            [EnumMember(Value = "TransitionEvent")]
            TransitionEvent = 1,

            /// <summary>
            /// Enum InformationalEvent for value: InformationalEvent
            /// </summary>
            [EnumMember(Value = "InformationalEvent")]
            InformationalEvent = 2,

            /// <summary>
            /// Enum OpenEvent for value: OpenEvent
            /// </summary>
            [EnumMember(Value = "OpenEvent")]
            OpenEvent = 3,

            /// <summary>
            /// Enum CloseEvent for value: CloseEvent
            /// </summary>
            [EnumMember(Value = "CloseEvent")]
            CloseEvent = 4,

            /// <summary>
            /// Enum StockSplitEvent for value: StockSplitEvent
            /// </summary>
            [EnumMember(Value = "StockSplitEvent")]
            StockSplitEvent = 5,

            /// <summary>
            /// Enum BondDefaultEvent for value: BondDefaultEvent
            /// </summary>
            [EnumMember(Value = "BondDefaultEvent")]
            BondDefaultEvent = 6,

            /// <summary>
            /// Enum CashDividendEvent for value: CashDividendEvent
            /// </summary>
            [EnumMember(Value = "CashDividendEvent")]
            CashDividendEvent = 7,

            /// <summary>
            /// Enum AmortisationEvent for value: AmortisationEvent
            /// </summary>
            [EnumMember(Value = "AmortisationEvent")]
            AmortisationEvent = 8,

            /// <summary>
            /// Enum CashFlowEvent for value: CashFlowEvent
            /// </summary>
            [EnumMember(Value = "CashFlowEvent")]
            CashFlowEvent = 9,

            /// <summary>
            /// Enum ExerciseEvent for value: ExerciseEvent
            /// </summary>
            [EnumMember(Value = "ExerciseEvent")]
            ExerciseEvent = 10,

            /// <summary>
            /// Enum ResetEvent for value: ResetEvent
            /// </summary>
            [EnumMember(Value = "ResetEvent")]
            ResetEvent = 11,

            /// <summary>
            /// Enum TriggerEvent for value: TriggerEvent
            /// </summary>
            [EnumMember(Value = "TriggerEvent")]
            TriggerEvent = 12,

            /// <summary>
            /// Enum RawVendorEvent for value: RawVendorEvent
            /// </summary>
            [EnumMember(Value = "RawVendorEvent")]
            RawVendorEvent = 13,

            /// <summary>
            /// Enum InformationalErrorEvent for value: InformationalErrorEvent
            /// </summary>
            [EnumMember(Value = "InformationalErrorEvent")]
            InformationalErrorEvent = 14

        }


        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent</value>
        [DataMember(Name = "instrumentEventType", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentEventTypeEnum InstrumentEventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RawVendorEventAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RawVendorEventAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RawVendorEventAllOf" /> class.
        /// </summary>
        /// <param name="effectiveAt">The effective date of the event (required).</param>
        /// <param name="eventValue">eventValue (required).</param>
        /// <param name="eventType">What type of internal event does this represent; reset, exercise, amortisation etc. (required).</param>
        /// <param name="eventStatus">What is the event status, is it a known (ie historic) or unknown (ie projected) event? (required).</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent (required).</param>
        public RawVendorEventAllOf(DateTimeOffset effectiveAt = default(DateTimeOffset), LifeCycleEventValue eventValue = default(LifeCycleEventValue), string eventType = default(string), string eventStatus = default(string), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum))
        {
            this.EffectiveAt = effectiveAt;
            // to ensure "eventValue" is required (not null)
            if (eventValue == null)
            {
                throw new ArgumentNullException("eventValue is a required property for RawVendorEventAllOf and cannot be null");
            }
            this.EventValue = eventValue;
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new ArgumentNullException("eventType is a required property for RawVendorEventAllOf and cannot be null");
            }
            this.EventType = eventType;
            // to ensure "eventStatus" is required (not null)
            if (eventStatus == null)
            {
                throw new ArgumentNullException("eventStatus is a required property for RawVendorEventAllOf and cannot be null");
            }
            this.EventStatus = eventStatus;
            this.InstrumentEventType = instrumentEventType;
        }

        /// <summary>
        /// The effective date of the event
        /// </summary>
        /// <value>The effective date of the event</value>
        [DataMember(Name = "effectiveAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset EffectiveAt { get; set; }

        /// <summary>
        /// Gets or Sets EventValue
        /// </summary>
        [DataMember(Name = "eventValue", IsRequired = true, EmitDefaultValue = true)]
        public LifeCycleEventValue EventValue { get; set; }

        /// <summary>
        /// What type of internal event does this represent; reset, exercise, amortisation etc.
        /// </summary>
        /// <value>What type of internal event does this represent; reset, exercise, amortisation etc.</value>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// What is the event status, is it a known (ie historic) or unknown (ie projected) event?
        /// </summary>
        /// <value>What is the event status, is it a known (ie historic) or unknown (ie projected) event?</value>
        [DataMember(Name = "eventStatus", IsRequired = true, EmitDefaultValue = true)]
        public string EventStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RawVendorEventAllOf {\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  EventValue: ").Append(EventValue).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventStatus: ").Append(EventStatus).Append("\n");
            sb.Append("  InstrumentEventType: ").Append(InstrumentEventType).Append("\n");
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
            return this.Equals(input as RawVendorEventAllOf);
        }

        /// <summary>
        /// Returns true if RawVendorEventAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of RawVendorEventAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RawVendorEventAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
                ) && 
                (
                    this.EventValue == input.EventValue ||
                    (this.EventValue != null &&
                    this.EventValue.Equals(input.EventValue))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.EventStatus == input.EventStatus ||
                    (this.EventStatus != null &&
                    this.EventStatus.Equals(input.EventStatus))
                ) && 
                (
                    this.InstrumentEventType == input.InstrumentEventType ||
                    this.InstrumentEventType.Equals(input.InstrumentEventType)
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
                if (this.EffectiveAt != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveAt.GetHashCode();
                }
                if (this.EventValue != null)
                {
                    hashCode = (hashCode * 59) + this.EventValue.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.EventStatus != null)
                {
                    hashCode = (hashCode * 59) + this.EventStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InstrumentEventType.GetHashCode();
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
            // EventType (string) minLength
            if (this.EventType != null && this.EventType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventType, length must be greater than 1.", new [] { "EventType" });
            }

            // EventStatus (string) minLength
            if (this.EventStatus != null && this.EventStatus.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventStatus, length must be greater than 1.", new [] { "EventStatus" });
            }

            yield break;
        }
    }
}
