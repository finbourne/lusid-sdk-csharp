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
    /// The lineage of the event value
    /// </summary>
    [DataContract(Name = "LifeCycleEventLineage")]
    public partial class LifeCycleEventLineage : IEquatable<LifeCycleEventLineage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LifeCycleEventLineage" /> class.
        /// </summary>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="instrumentType">The instrument type of the instrument for the event..</param>
        /// <param name="instrumentId">The LUID of the instrument for the event..</param>
        /// <param name="legId">Leg id for the event..</param>
        /// <param name="sourceTransactionId">The source transaction of the instrument for the event..</param>
        public LifeCycleEventLineage(string eventType = default(string), string instrumentType = default(string), string instrumentId = default(string), string legId = default(string), string sourceTransactionId = default(string))
        {
            this.EventType = eventType;
            this.InstrumentType = instrumentType;
            this.InstrumentId = instrumentId;
            this.LegId = legId;
            this.SourceTransactionId = sourceTransactionId;
        }

        /// <summary>
        /// The type of the event
        /// </summary>
        /// <value>The type of the event</value>
        [DataMember(Name = "eventType", EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// The instrument type of the instrument for the event.
        /// </summary>
        /// <value>The instrument type of the instrument for the event.</value>
        [DataMember(Name = "instrumentType", EmitDefaultValue = true)]
        public string InstrumentType { get; set; }

        /// <summary>
        /// The LUID of the instrument for the event.
        /// </summary>
        /// <value>The LUID of the instrument for the event.</value>
        [DataMember(Name = "instrumentId", EmitDefaultValue = true)]
        public string InstrumentId { get; set; }

        /// <summary>
        /// Leg id for the event.
        /// </summary>
        /// <value>Leg id for the event.</value>
        [DataMember(Name = "legId", EmitDefaultValue = true)]
        public string LegId { get; set; }

        /// <summary>
        /// The source transaction of the instrument for the event.
        /// </summary>
        /// <value>The source transaction of the instrument for the event.</value>
        [DataMember(Name = "sourceTransactionId", EmitDefaultValue = true)]
        public string SourceTransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LifeCycleEventLineage {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
            sb.Append("  InstrumentId: ").Append(InstrumentId).Append("\n");
            sb.Append("  LegId: ").Append(LegId).Append("\n");
            sb.Append("  SourceTransactionId: ").Append(SourceTransactionId).Append("\n");
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
            return this.Equals(input as LifeCycleEventLineage);
        }

        /// <summary>
        /// Returns true if LifeCycleEventLineage instances are equal
        /// </summary>
        /// <param name="input">Instance of LifeCycleEventLineage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LifeCycleEventLineage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.InstrumentType == input.InstrumentType ||
                    (this.InstrumentType != null &&
                    this.InstrumentType.Equals(input.InstrumentType))
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
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.InstrumentType != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentType.GetHashCode();
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
