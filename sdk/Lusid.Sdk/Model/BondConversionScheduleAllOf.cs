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
    /// BondConversionScheduleAllOf
    /// </summary>
    [DataContract(Name = "BondConversionSchedule_allOf")]
    public partial class BondConversionScheduleAllOf : IEquatable<BondConversionScheduleAllOf>, IValidatableObject
    {
        /// <summary>
        /// The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid
        /// </summary>
        /// <value>The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScheduleTypeEnum
        {
            /// <summary>
            /// Enum FixedSchedule for value: FixedSchedule
            /// </summary>
            [EnumMember(Value = "FixedSchedule")]
            FixedSchedule = 1,

            /// <summary>
            /// Enum FloatSchedule for value: FloatSchedule
            /// </summary>
            [EnumMember(Value = "FloatSchedule")]
            FloatSchedule = 2,

            /// <summary>
            /// Enum OptionalitySchedule for value: OptionalitySchedule
            /// </summary>
            [EnumMember(Value = "OptionalitySchedule")]
            OptionalitySchedule = 3,

            /// <summary>
            /// Enum StepSchedule for value: StepSchedule
            /// </summary>
            [EnumMember(Value = "StepSchedule")]
            StepSchedule = 4,

            /// <summary>
            /// Enum Exercise for value: Exercise
            /// </summary>
            [EnumMember(Value = "Exercise")]
            Exercise = 5,

            /// <summary>
            /// Enum FxRateSchedule for value: FxRateSchedule
            /// </summary>
            [EnumMember(Value = "FxRateSchedule")]
            FxRateSchedule = 6,

            /// <summary>
            /// Enum FxLinkedNotionalSchedule for value: FxLinkedNotionalSchedule
            /// </summary>
            [EnumMember(Value = "FxLinkedNotionalSchedule")]
            FxLinkedNotionalSchedule = 7,

            /// <summary>
            /// Enum BondConversionSchedule for value: BondConversionSchedule
            /// </summary>
            [EnumMember(Value = "BondConversionSchedule")]
            BondConversionSchedule = 8,

            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 9

        }


        /// <summary>
        /// The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid
        /// </summary>
        /// <value>The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid</value>
        [DataMember(Name = "scheduleType", IsRequired = true, EmitDefaultValue = true)]
        public ScheduleTypeEnum ScheduleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BondConversionScheduleAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BondConversionScheduleAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BondConversionScheduleAllOf" /> class.
        /// </summary>
        /// <param name="identifiers">The market identifier(s) of the share that the bond converts to. The instrument  will not fail validation if no identifier is supplied..</param>
        /// <param name="bondConversionEntries">The dates at which the bond may be converted and associated information required about the conversion..</param>
        /// <param name="conversionTrigger">Corporate event that triggers a conversion    Supported string (enumeration) values are: [NextEquityFinancing, IpoConversion, KnownDates, SoftCall]. (required).</param>
        /// <param name="deliveryType">Is a conversion made into cash or into shares?    Supported string (enumeration) values are: [Cash, Physical]..</param>
        /// <param name="exerciseType">The exercise type of the conversion schedule (American or European).  For American type, the bond is convertible from a given exercise date until the next date in the schedule, or until it matures.  For European type, the bond is only convertible on the given exercise date.    Supported string (enumeration) values are: [European, Bermudan, American]. (required).</param>
        /// <param name="includesAccrued">Set this to true if a accrued interest is included in the conversion. Defaults to true..</param>
        /// <param name="mandatoryConversion">Set this to true if a conversion is mandatory if the trigger occurs. Defaults to false..</param>
        /// <param name="notificationPeriodEnd">The last day in the notification period for the conversion of the bond.</param>
        /// <param name="notificationPeriodStart">The first day in the notification period for the conversion of the bond.</param>
        /// <param name="scheduleType">The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid (required).</param>
        public BondConversionScheduleAllOf(Dictionary<string, string> identifiers = default(Dictionary<string, string>), List<BondConversionEntry> bondConversionEntries = default(List<BondConversionEntry>), string conversionTrigger = default(string), string deliveryType = default(string), string exerciseType = default(string), bool includesAccrued = default(bool), bool mandatoryConversion = default(bool), DateTimeOffset notificationPeriodEnd = default(DateTimeOffset), DateTimeOffset notificationPeriodStart = default(DateTimeOffset), ScheduleTypeEnum scheduleType = default(ScheduleTypeEnum))
        {
            // to ensure "conversionTrigger" is required (not null)
            if (conversionTrigger == null)
            {
                throw new ArgumentNullException("conversionTrigger is a required property for BondConversionScheduleAllOf and cannot be null");
            }
            this.ConversionTrigger = conversionTrigger;
            // to ensure "exerciseType" is required (not null)
            if (exerciseType == null)
            {
                throw new ArgumentNullException("exerciseType is a required property for BondConversionScheduleAllOf and cannot be null");
            }
            this.ExerciseType = exerciseType;
            this.ScheduleType = scheduleType;
            this.Identifiers = identifiers;
            this.BondConversionEntries = bondConversionEntries;
            this.DeliveryType = deliveryType;
            this.IncludesAccrued = includesAccrued;
            this.MandatoryConversion = mandatoryConversion;
            this.NotificationPeriodEnd = notificationPeriodEnd;
            this.NotificationPeriodStart = notificationPeriodStart;
        }

        /// <summary>
        /// The market identifier(s) of the share that the bond converts to. The instrument  will not fail validation if no identifier is supplied.
        /// </summary>
        /// <value>The market identifier(s) of the share that the bond converts to. The instrument  will not fail validation if no identifier is supplied.</value>
        [DataMember(Name = "identifiers", EmitDefaultValue = true)]
        public Dictionary<string, string> Identifiers { get; set; }

        /// <summary>
        /// The dates at which the bond may be converted and associated information required about the conversion.
        /// </summary>
        /// <value>The dates at which the bond may be converted and associated information required about the conversion.</value>
        [DataMember(Name = "bondConversionEntries", EmitDefaultValue = true)]
        public List<BondConversionEntry> BondConversionEntries { get; set; }

        /// <summary>
        /// Corporate event that triggers a conversion    Supported string (enumeration) values are: [NextEquityFinancing, IpoConversion, KnownDates, SoftCall].
        /// </summary>
        /// <value>Corporate event that triggers a conversion    Supported string (enumeration) values are: [NextEquityFinancing, IpoConversion, KnownDates, SoftCall].</value>
        [DataMember(Name = "conversionTrigger", IsRequired = true, EmitDefaultValue = true)]
        public string ConversionTrigger { get; set; }

        /// <summary>
        /// Is a conversion made into cash or into shares?    Supported string (enumeration) values are: [Cash, Physical].
        /// </summary>
        /// <value>Is a conversion made into cash or into shares?    Supported string (enumeration) values are: [Cash, Physical].</value>
        [DataMember(Name = "deliveryType", EmitDefaultValue = true)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// The exercise type of the conversion schedule (American or European).  For American type, the bond is convertible from a given exercise date until the next date in the schedule, or until it matures.  For European type, the bond is only convertible on the given exercise date.    Supported string (enumeration) values are: [European, Bermudan, American].
        /// </summary>
        /// <value>The exercise type of the conversion schedule (American or European).  For American type, the bond is convertible from a given exercise date until the next date in the schedule, or until it matures.  For European type, the bond is only convertible on the given exercise date.    Supported string (enumeration) values are: [European, Bermudan, American].</value>
        [DataMember(Name = "exerciseType", IsRequired = true, EmitDefaultValue = true)]
        public string ExerciseType { get; set; }

        /// <summary>
        /// Set this to true if a accrued interest is included in the conversion. Defaults to true.
        /// </summary>
        /// <value>Set this to true if a accrued interest is included in the conversion. Defaults to true.</value>
        [DataMember(Name = "includesAccrued", EmitDefaultValue = true)]
        public bool IncludesAccrued { get; set; }

        /// <summary>
        /// Set this to true if a conversion is mandatory if the trigger occurs. Defaults to false.
        /// </summary>
        /// <value>Set this to true if a conversion is mandatory if the trigger occurs. Defaults to false.</value>
        [DataMember(Name = "mandatoryConversion", EmitDefaultValue = true)]
        public bool MandatoryConversion { get; set; }

        /// <summary>
        /// The last day in the notification period for the conversion of the bond
        /// </summary>
        /// <value>The last day in the notification period for the conversion of the bond</value>
        [DataMember(Name = "notificationPeriodEnd", EmitDefaultValue = false)]
        public DateTimeOffset NotificationPeriodEnd { get; set; }

        /// <summary>
        /// The first day in the notification period for the conversion of the bond
        /// </summary>
        /// <value>The first day in the notification period for the conversion of the bond</value>
        [DataMember(Name = "notificationPeriodStart", EmitDefaultValue = false)]
        public DateTimeOffset NotificationPeriodStart { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BondConversionScheduleAllOf {\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  BondConversionEntries: ").Append(BondConversionEntries).Append("\n");
            sb.Append("  ConversionTrigger: ").Append(ConversionTrigger).Append("\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  ExerciseType: ").Append(ExerciseType).Append("\n");
            sb.Append("  IncludesAccrued: ").Append(IncludesAccrued).Append("\n");
            sb.Append("  MandatoryConversion: ").Append(MandatoryConversion).Append("\n");
            sb.Append("  NotificationPeriodEnd: ").Append(NotificationPeriodEnd).Append("\n");
            sb.Append("  NotificationPeriodStart: ").Append(NotificationPeriodStart).Append("\n");
            sb.Append("  ScheduleType: ").Append(ScheduleType).Append("\n");
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
            return this.Equals(input as BondConversionScheduleAllOf);
        }

        /// <summary>
        /// Returns true if BondConversionScheduleAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of BondConversionScheduleAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BondConversionScheduleAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && 
                (
                    this.BondConversionEntries == input.BondConversionEntries ||
                    this.BondConversionEntries != null &&
                    input.BondConversionEntries != null &&
                    this.BondConversionEntries.SequenceEqual(input.BondConversionEntries)
                ) && 
                (
                    this.ConversionTrigger == input.ConversionTrigger ||
                    (this.ConversionTrigger != null &&
                    this.ConversionTrigger.Equals(input.ConversionTrigger))
                ) && 
                (
                    this.DeliveryType == input.DeliveryType ||
                    (this.DeliveryType != null &&
                    this.DeliveryType.Equals(input.DeliveryType))
                ) && 
                (
                    this.ExerciseType == input.ExerciseType ||
                    (this.ExerciseType != null &&
                    this.ExerciseType.Equals(input.ExerciseType))
                ) && 
                (
                    this.IncludesAccrued == input.IncludesAccrued ||
                    this.IncludesAccrued.Equals(input.IncludesAccrued)
                ) && 
                (
                    this.MandatoryConversion == input.MandatoryConversion ||
                    this.MandatoryConversion.Equals(input.MandatoryConversion)
                ) && 
                (
                    this.NotificationPeriodEnd == input.NotificationPeriodEnd ||
                    (this.NotificationPeriodEnd != null &&
                    this.NotificationPeriodEnd.Equals(input.NotificationPeriodEnd))
                ) && 
                (
                    this.NotificationPeriodStart == input.NotificationPeriodStart ||
                    (this.NotificationPeriodStart != null &&
                    this.NotificationPeriodStart.Equals(input.NotificationPeriodStart))
                ) && 
                (
                    this.ScheduleType == input.ScheduleType ||
                    this.ScheduleType.Equals(input.ScheduleType)
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
                if (this.Identifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Identifiers.GetHashCode();
                }
                if (this.BondConversionEntries != null)
                {
                    hashCode = (hashCode * 59) + this.BondConversionEntries.GetHashCode();
                }
                if (this.ConversionTrigger != null)
                {
                    hashCode = (hashCode * 59) + this.ConversionTrigger.GetHashCode();
                }
                if (this.DeliveryType != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryType.GetHashCode();
                }
                if (this.ExerciseType != null)
                {
                    hashCode = (hashCode * 59) + this.ExerciseType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncludesAccrued.GetHashCode();
                hashCode = (hashCode * 59) + this.MandatoryConversion.GetHashCode();
                if (this.NotificationPeriodEnd != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationPeriodEnd.GetHashCode();
                }
                if (this.NotificationPeriodStart != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationPeriodStart.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ScheduleType.GetHashCode();
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
            // ConversionTrigger (string) maxLength
            if (this.ConversionTrigger != null && this.ConversionTrigger.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConversionTrigger, length must be less than 50.", new [] { "ConversionTrigger" });
            }

            // ConversionTrigger (string) minLength
            if (this.ConversionTrigger != null && this.ConversionTrigger.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConversionTrigger, length must be greater than 0.", new [] { "ConversionTrigger" });
            }

            // DeliveryType (string) maxLength
            if (this.DeliveryType != null && this.DeliveryType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryType, length must be less than 50.", new [] { "DeliveryType" });
            }

            // DeliveryType (string) minLength
            if (this.DeliveryType != null && this.DeliveryType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeliveryType, length must be greater than 0.", new [] { "DeliveryType" });
            }

            // ExerciseType (string) maxLength
            if (this.ExerciseType != null && this.ExerciseType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExerciseType, length must be less than 50.", new [] { "ExerciseType" });
            }

            // ExerciseType (string) minLength
            if (this.ExerciseType != null && this.ExerciseType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExerciseType, length must be greater than 0.", new [] { "ExerciseType" });
            }

            yield break;
        }
    }
}
