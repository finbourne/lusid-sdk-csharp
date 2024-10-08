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
    /// FixedScheduleAllOf
    /// </summary>
    [DataContract(Name = "FixedSchedule_allOf")]
    public partial class FixedScheduleAllOf : IEquatable<FixedScheduleAllOf>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="FixedScheduleAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedScheduleAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedScheduleAllOf" /> class.
        /// </summary>
        /// <param name="startDate">Date from which LUSID starts generating the payment schedule. (required).</param>
        /// <param name="maturityDate">Last date of the payment generation schedule. May not necessarily be the maturity date  of the underlying instrument (e.g. in case the instrument has multiple payment schedules). (required).</param>
        /// <param name="flowConventions">flowConventions.</param>
        /// <param name="couponRate">Coupon rate given as a fraction..</param>
        /// <param name="conventionName">conventionName.</param>
        /// <param name="exDividendDays">Optional. Number of calendar days in the ex-dividend period.  If the settlement date falls in the ex-dividend period then the coupon paid is zero and the accrued interest is negative.  If set, this must be a non-negative number.  If not set, or set to 0, then there is no ex-dividend period.                NOTE: This field is deprecated.  If you wish to set the ExDividendDays on a bond, please use the ExDividendConfiguration..</param>
        /// <param name="notional">Scaling factor, the quantity outstanding on which the rate will be paid..</param>
        /// <param name="paymentCurrency">Payment currency. This does not have to be the same as the nominal bond or observation/reset currency. (required).</param>
        /// <param name="stubType">When a payment schedule doesn&#39;t have regular payment intervals just because of the  first and/or last coupons of the schedule, we call those irregular coupons stubs.  This configuration specifies what type of stub is used when building the schedule  Supported values are:  None &#x3D; this is a regular payment schedule with no stubs. DO NOT use it with irregular schedules or you will get incorrect and unexpected behaviour.  ShortFront &#x3D; this is an irregular payment schedule where only the first coupon is irregular, and covers a payment period that is shorter than the regular payment period.  ShortBack &#x3D; this is an irregular payment schedule where only the last coupon is irregular, and covers a payment period that is shorter than the regular payment period.  LongFront &#x3D; this is an irregular payment schedule where only the first coupon is irregular, and covers a payment period that is longer than the regular payment period.  LongBack &#x3D; this is an irregular payment schedule where only the last coupon is irregular, and covers a payment period that is longer than the regular payment period.  Both &#x3D; this is an irregular payment schedule where both the first and the last coupons are irregular, and the length of these periods is calculated based on the first coupon payment date that should have been explicitly set..</param>
        /// <param name="exDividendConfiguration">exDividendConfiguration.</param>
        /// <param name="scheduleType">The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid (required).</param>
        public FixedScheduleAllOf(DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset maturityDate = default(DateTimeOffset), FlowConventions flowConventions = default(FlowConventions), decimal couponRate = default(decimal), FlowConventionName conventionName = default(FlowConventionName), int? exDividendDays = default(int?), decimal notional = default(decimal), string paymentCurrency = default(string), string stubType = default(string), ExDividendConfiguration exDividendConfiguration = default(ExDividendConfiguration), ScheduleTypeEnum scheduleType = default(ScheduleTypeEnum))
        {
            this.StartDate = startDate;
            this.MaturityDate = maturityDate;
            // to ensure "paymentCurrency" is required (not null)
            if (paymentCurrency == null)
            {
                throw new ArgumentNullException("paymentCurrency is a required property for FixedScheduleAllOf and cannot be null");
            }
            this.PaymentCurrency = paymentCurrency;
            this.ScheduleType = scheduleType;
            this.FlowConventions = flowConventions;
            this.CouponRate = couponRate;
            this.ConventionName = conventionName;
            this.ExDividendDays = exDividendDays;
            this.Notional = notional;
            this.StubType = stubType;
            this.ExDividendConfiguration = exDividendConfiguration;
        }

        /// <summary>
        /// Date from which LUSID starts generating the payment schedule.
        /// </summary>
        /// <value>Date from which LUSID starts generating the payment schedule.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Last date of the payment generation schedule. May not necessarily be the maturity date  of the underlying instrument (e.g. in case the instrument has multiple payment schedules).
        /// </summary>
        /// <value>Last date of the payment generation schedule. May not necessarily be the maturity date  of the underlying instrument (e.g. in case the instrument has multiple payment schedules).</value>
        [DataMember(Name = "maturityDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset MaturityDate { get; set; }

        /// <summary>
        /// Gets or Sets FlowConventions
        /// </summary>
        [DataMember(Name = "flowConventions", EmitDefaultValue = false)]
        public FlowConventions FlowConventions { get; set; }

        /// <summary>
        /// Coupon rate given as a fraction.
        /// </summary>
        /// <value>Coupon rate given as a fraction.</value>
        [DataMember(Name = "couponRate", EmitDefaultValue = true)]
        public decimal CouponRate { get; set; }

        /// <summary>
        /// Gets or Sets ConventionName
        /// </summary>
        [DataMember(Name = "conventionName", EmitDefaultValue = false)]
        public FlowConventionName ConventionName { get; set; }

        /// <summary>
        /// Optional. Number of calendar days in the ex-dividend period.  If the settlement date falls in the ex-dividend period then the coupon paid is zero and the accrued interest is negative.  If set, this must be a non-negative number.  If not set, or set to 0, then there is no ex-dividend period.                NOTE: This field is deprecated.  If you wish to set the ExDividendDays on a bond, please use the ExDividendConfiguration.
        /// </summary>
        /// <value>Optional. Number of calendar days in the ex-dividend period.  If the settlement date falls in the ex-dividend period then the coupon paid is zero and the accrued interest is negative.  If set, this must be a non-negative number.  If not set, or set to 0, then there is no ex-dividend period.                NOTE: This field is deprecated.  If you wish to set the ExDividendDays on a bond, please use the ExDividendConfiguration.</value>
        [DataMember(Name = "exDividendDays", EmitDefaultValue = true)]
        public int? ExDividendDays { get; set; }

        /// <summary>
        /// Scaling factor, the quantity outstanding on which the rate will be paid.
        /// </summary>
        /// <value>Scaling factor, the quantity outstanding on which the rate will be paid.</value>
        [DataMember(Name = "notional", EmitDefaultValue = true)]
        public decimal Notional { get; set; }

        /// <summary>
        /// Payment currency. This does not have to be the same as the nominal bond or observation/reset currency.
        /// </summary>
        /// <value>Payment currency. This does not have to be the same as the nominal bond or observation/reset currency.</value>
        [DataMember(Name = "paymentCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string PaymentCurrency { get; set; }

        /// <summary>
        /// When a payment schedule doesn&#39;t have regular payment intervals just because of the  first and/or last coupons of the schedule, we call those irregular coupons stubs.  This configuration specifies what type of stub is used when building the schedule  Supported values are:  None &#x3D; this is a regular payment schedule with no stubs. DO NOT use it with irregular schedules or you will get incorrect and unexpected behaviour.  ShortFront &#x3D; this is an irregular payment schedule where only the first coupon is irregular, and covers a payment period that is shorter than the regular payment period.  ShortBack &#x3D; this is an irregular payment schedule where only the last coupon is irregular, and covers a payment period that is shorter than the regular payment period.  LongFront &#x3D; this is an irregular payment schedule where only the first coupon is irregular, and covers a payment period that is longer than the regular payment period.  LongBack &#x3D; this is an irregular payment schedule where only the last coupon is irregular, and covers a payment period that is longer than the regular payment period.  Both &#x3D; this is an irregular payment schedule where both the first and the last coupons are irregular, and the length of these periods is calculated based on the first coupon payment date that should have been explicitly set.
        /// </summary>
        /// <value>When a payment schedule doesn&#39;t have regular payment intervals just because of the  first and/or last coupons of the schedule, we call those irregular coupons stubs.  This configuration specifies what type of stub is used when building the schedule  Supported values are:  None &#x3D; this is a regular payment schedule with no stubs. DO NOT use it with irregular schedules or you will get incorrect and unexpected behaviour.  ShortFront &#x3D; this is an irregular payment schedule where only the first coupon is irregular, and covers a payment period that is shorter than the regular payment period.  ShortBack &#x3D; this is an irregular payment schedule where only the last coupon is irregular, and covers a payment period that is shorter than the regular payment period.  LongFront &#x3D; this is an irregular payment schedule where only the first coupon is irregular, and covers a payment period that is longer than the regular payment period.  LongBack &#x3D; this is an irregular payment schedule where only the last coupon is irregular, and covers a payment period that is longer than the regular payment period.  Both &#x3D; this is an irregular payment schedule where both the first and the last coupons are irregular, and the length of these periods is calculated based on the first coupon payment date that should have been explicitly set.</value>
        [DataMember(Name = "stubType", EmitDefaultValue = true)]
        public string StubType { get; set; }

        /// <summary>
        /// Gets or Sets ExDividendConfiguration
        /// </summary>
        [DataMember(Name = "exDividendConfiguration", EmitDefaultValue = false)]
        public ExDividendConfiguration ExDividendConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FixedScheduleAllOf {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  FlowConventions: ").Append(FlowConventions).Append("\n");
            sb.Append("  CouponRate: ").Append(CouponRate).Append("\n");
            sb.Append("  ConventionName: ").Append(ConventionName).Append("\n");
            sb.Append("  ExDividendDays: ").Append(ExDividendDays).Append("\n");
            sb.Append("  Notional: ").Append(Notional).Append("\n");
            sb.Append("  PaymentCurrency: ").Append(PaymentCurrency).Append("\n");
            sb.Append("  StubType: ").Append(StubType).Append("\n");
            sb.Append("  ExDividendConfiguration: ").Append(ExDividendConfiguration).Append("\n");
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
            return this.Equals(input as FixedScheduleAllOf);
        }

        /// <summary>
        /// Returns true if FixedScheduleAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedScheduleAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedScheduleAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && 
                (
                    this.FlowConventions == input.FlowConventions ||
                    (this.FlowConventions != null &&
                    this.FlowConventions.Equals(input.FlowConventions))
                ) && 
                (
                    this.CouponRate == input.CouponRate ||
                    this.CouponRate.Equals(input.CouponRate)
                ) && 
                (
                    this.ConventionName == input.ConventionName ||
                    (this.ConventionName != null &&
                    this.ConventionName.Equals(input.ConventionName))
                ) && 
                (
                    this.ExDividendDays == input.ExDividendDays ||
                    (this.ExDividendDays != null &&
                    this.ExDividendDays.Equals(input.ExDividendDays))
                ) && 
                (
                    this.Notional == input.Notional ||
                    this.Notional.Equals(input.Notional)
                ) && 
                (
                    this.PaymentCurrency == input.PaymentCurrency ||
                    (this.PaymentCurrency != null &&
                    this.PaymentCurrency.Equals(input.PaymentCurrency))
                ) && 
                (
                    this.StubType == input.StubType ||
                    (this.StubType != null &&
                    this.StubType.Equals(input.StubType))
                ) && 
                (
                    this.ExDividendConfiguration == input.ExDividendConfiguration ||
                    (this.ExDividendConfiguration != null &&
                    this.ExDividendConfiguration.Equals(input.ExDividendConfiguration))
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.MaturityDate != null)
                {
                    hashCode = (hashCode * 59) + this.MaturityDate.GetHashCode();
                }
                if (this.FlowConventions != null)
                {
                    hashCode = (hashCode * 59) + this.FlowConventions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CouponRate.GetHashCode();
                if (this.ConventionName != null)
                {
                    hashCode = (hashCode * 59) + this.ConventionName.GetHashCode();
                }
                if (this.ExDividendDays != null)
                {
                    hashCode = (hashCode * 59) + this.ExDividendDays.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Notional.GetHashCode();
                if (this.PaymentCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentCurrency.GetHashCode();
                }
                if (this.StubType != null)
                {
                    hashCode = (hashCode * 59) + this.StubType.GetHashCode();
                }
                if (this.ExDividendConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.ExDividendConfiguration.GetHashCode();
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
            yield break;
        }
    }
}
