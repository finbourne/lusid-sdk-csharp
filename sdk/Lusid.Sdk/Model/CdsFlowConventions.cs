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
    /// CdsFlowConventions
    /// </summary>
    [DataContract(Name = "CdsFlowConventions")]
    public partial class CdsFlowConventions : IEquatable<CdsFlowConventions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CdsFlowConventions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CdsFlowConventions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CdsFlowConventions" /> class.
        /// </summary>
        /// <param name="rollFrequency">The frequency at which the reference bonds are updated, this defaults to 6M, but can be 3M, exp for historically issued products.    For more information on tenors, see [knowledge base article KA-02097](https://support.lusid.com/knowledgebase/article/KA-02097).</param>
        /// <param name="currency">Currency of the flow convention. (required).</param>
        /// <param name="paymentFrequency">When generating a multiperiod flow, or when the maturity of the flow is not given but the start date is,  the tenor is the time-step from the anchor-date to the nominal maturity of the flow prior to any adjustment. (required).</param>
        /// <param name="dayCountConvention">when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year  and difference between them.  For more information on day counts, see [knowledge base article KA-01798](https://support.lusid.com/knowledgebase/article/KA-01798)                Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM]. (required).</param>
        /// <param name="rollConvention">For backward compatibility, this can either specify a business day convention or a roll convention. If the business  day convention is provided using the BusinessDayConvention property, this must be a valid roll convention.                When used as a roll convention:  The conventions specifying the rule used to generate dates in a schedule.    Supported string (enumeration) values are: [None, EndOfMonth, IMM, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, FirstMonday, FirstTuesday, FirstWednesday, FirstThursday, FirstFriday, SecondMonday, SecondTuesday, SecondWednesday, SecondThursday, SecondFriday, ThirdMonday, ThirdTuesday, ThirdWednesday, ThirdThursday, ThirdFriday, FourthMonday, FourthTuesday, FourthWednesday, FourthThursday, FourthFriday, LastMonday, LastTuesday, LastWednesday, LastThursday, LastFriday].                When in backward compatible mode:  Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing]. (required).</param>
        /// <param name="paymentCalendars">An array of strings denoting holiday calendars that apply to generation of payment schedules. (required).</param>
        /// <param name="resetCalendars">An array of strings denoting holiday calendars that apply to generation of reset schedules. (required).</param>
        /// <param name="settleDays">Number of Good Business Days between the trade date and the effective or settlement date of the instrument. Defaults to 0 if not set..</param>
        /// <param name="resetDays">The number of Good Business Days between determination and payment of reset. Defaults to 0 if not set..</param>
        /// <param name="businessDayConvention">When generating a set of dates, what convention should be used for adjusting dates that coincide with a non-business day.    Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest]..</param>
        /// <param name="scope">The scope used when updating or inserting the convention..</param>
        /// <param name="code">The code of the convention..</param>
        public CdsFlowConventions(string rollFrequency = default(string), string currency = default(string), string paymentFrequency = default(string), string dayCountConvention = default(string), string rollConvention = default(string), List<string> paymentCalendars = default(List<string>), List<string> resetCalendars = default(List<string>), int settleDays = default(int), int resetDays = default(int), string businessDayConvention = default(string), string scope = default(string), string code = default(string))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for CdsFlowConventions and cannot be null");
            }
            this.Currency = currency;
            // to ensure "paymentFrequency" is required (not null)
            if (paymentFrequency == null)
            {
                throw new ArgumentNullException("paymentFrequency is a required property for CdsFlowConventions and cannot be null");
            }
            this.PaymentFrequency = paymentFrequency;
            // to ensure "dayCountConvention" is required (not null)
            if (dayCountConvention == null)
            {
                throw new ArgumentNullException("dayCountConvention is a required property for CdsFlowConventions and cannot be null");
            }
            this.DayCountConvention = dayCountConvention;
            // to ensure "rollConvention" is required (not null)
            if (rollConvention == null)
            {
                throw new ArgumentNullException("rollConvention is a required property for CdsFlowConventions and cannot be null");
            }
            this.RollConvention = rollConvention;
            // to ensure "paymentCalendars" is required (not null)
            if (paymentCalendars == null)
            {
                throw new ArgumentNullException("paymentCalendars is a required property for CdsFlowConventions and cannot be null");
            }
            this.PaymentCalendars = paymentCalendars;
            // to ensure "resetCalendars" is required (not null)
            if (resetCalendars == null)
            {
                throw new ArgumentNullException("resetCalendars is a required property for CdsFlowConventions and cannot be null");
            }
            this.ResetCalendars = resetCalendars;
            this.RollFrequency = rollFrequency;
            this.SettleDays = settleDays;
            this.ResetDays = resetDays;
            this.BusinessDayConvention = businessDayConvention;
            this.Scope = scope;
            this.Code = code;
        }

        /// <summary>
        /// The frequency at which the reference bonds are updated, this defaults to 6M, but can be 3M, exp for historically issued products.    For more information on tenors, see [knowledge base article KA-02097](https://support.lusid.com/knowledgebase/article/KA-02097)
        /// </summary>
        /// <value>The frequency at which the reference bonds are updated, this defaults to 6M, but can be 3M, exp for historically issued products.    For more information on tenors, see [knowledge base article KA-02097](https://support.lusid.com/knowledgebase/article/KA-02097)</value>
        [DataMember(Name = "rollFrequency", EmitDefaultValue = true)]
        public string RollFrequency { get; set; }

        /// <summary>
        /// Currency of the flow convention.
        /// </summary>
        /// <value>Currency of the flow convention.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// When generating a multiperiod flow, or when the maturity of the flow is not given but the start date is,  the tenor is the time-step from the anchor-date to the nominal maturity of the flow prior to any adjustment.
        /// </summary>
        /// <value>When generating a multiperiod flow, or when the maturity of the flow is not given but the start date is,  the tenor is the time-step from the anchor-date to the nominal maturity of the flow prior to any adjustment.</value>
        [DataMember(Name = "paymentFrequency", IsRequired = true, EmitDefaultValue = true)]
        public string PaymentFrequency { get; set; }

        /// <summary>
        /// when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year  and difference between them.  For more information on day counts, see [knowledge base article KA-01798](https://support.lusid.com/knowledgebase/article/KA-01798)                Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM].
        /// </summary>
        /// <value>when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year  and difference between them.  For more information on day counts, see [knowledge base article KA-01798](https://support.lusid.com/knowledgebase/article/KA-01798)                Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM].</value>
        [DataMember(Name = "dayCountConvention", IsRequired = true, EmitDefaultValue = true)]
        public string DayCountConvention { get; set; }

        /// <summary>
        /// For backward compatibility, this can either specify a business day convention or a roll convention. If the business  day convention is provided using the BusinessDayConvention property, this must be a valid roll convention.                When used as a roll convention:  The conventions specifying the rule used to generate dates in a schedule.    Supported string (enumeration) values are: [None, EndOfMonth, IMM, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, FirstMonday, FirstTuesday, FirstWednesday, FirstThursday, FirstFriday, SecondMonday, SecondTuesday, SecondWednesday, SecondThursday, SecondFriday, ThirdMonday, ThirdTuesday, ThirdWednesday, ThirdThursday, ThirdFriday, FourthMonday, FourthTuesday, FourthWednesday, FourthThursday, FourthFriday, LastMonday, LastTuesday, LastWednesday, LastThursday, LastFriday].                When in backward compatible mode:  Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing].
        /// </summary>
        /// <value>For backward compatibility, this can either specify a business day convention or a roll convention. If the business  day convention is provided using the BusinessDayConvention property, this must be a valid roll convention.                When used as a roll convention:  The conventions specifying the rule used to generate dates in a schedule.    Supported string (enumeration) values are: [None, EndOfMonth, IMM, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, FirstMonday, FirstTuesday, FirstWednesday, FirstThursday, FirstFriday, SecondMonday, SecondTuesday, SecondWednesday, SecondThursday, SecondFriday, ThirdMonday, ThirdTuesday, ThirdWednesday, ThirdThursday, ThirdFriday, FourthMonday, FourthTuesday, FourthWednesday, FourthThursday, FourthFriday, LastMonday, LastTuesday, LastWednesday, LastThursday, LastFriday].                When in backward compatible mode:  Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing].</value>
        [DataMember(Name = "rollConvention", IsRequired = true, EmitDefaultValue = true)]
        public string RollConvention { get; set; }

        /// <summary>
        /// An array of strings denoting holiday calendars that apply to generation of payment schedules.
        /// </summary>
        /// <value>An array of strings denoting holiday calendars that apply to generation of payment schedules.</value>
        [DataMember(Name = "paymentCalendars", IsRequired = true, EmitDefaultValue = true)]
        public List<string> PaymentCalendars { get; set; }

        /// <summary>
        /// An array of strings denoting holiday calendars that apply to generation of reset schedules.
        /// </summary>
        /// <value>An array of strings denoting holiday calendars that apply to generation of reset schedules.</value>
        [DataMember(Name = "resetCalendars", IsRequired = true, EmitDefaultValue = true)]
        public List<string> ResetCalendars { get; set; }

        /// <summary>
        /// Number of Good Business Days between the trade date and the effective or settlement date of the instrument. Defaults to 0 if not set.
        /// </summary>
        /// <value>Number of Good Business Days between the trade date and the effective or settlement date of the instrument. Defaults to 0 if not set.</value>
        [DataMember(Name = "settleDays", EmitDefaultValue = true)]
        public int SettleDays { get; set; }

        /// <summary>
        /// The number of Good Business Days between determination and payment of reset. Defaults to 0 if not set.
        /// </summary>
        /// <value>The number of Good Business Days between determination and payment of reset. Defaults to 0 if not set.</value>
        [DataMember(Name = "resetDays", EmitDefaultValue = true)]
        public int ResetDays { get; set; }

        /// <summary>
        /// When generating a set of dates, what convention should be used for adjusting dates that coincide with a non-business day.    Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest].
        /// </summary>
        /// <value>When generating a set of dates, what convention should be used for adjusting dates that coincide with a non-business day.    Supported string (enumeration) values are: [NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest].</value>
        [DataMember(Name = "businessDayConvention", EmitDefaultValue = true)]
        public string BusinessDayConvention { get; set; }

        /// <summary>
        /// The scope used when updating or inserting the convention.
        /// </summary>
        /// <value>The scope used when updating or inserting the convention.</value>
        [DataMember(Name = "scope", EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// The code of the convention.
        /// </summary>
        /// <value>The code of the convention.</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CdsFlowConventions {\n");
            sb.Append("  RollFrequency: ").Append(RollFrequency).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentFrequency: ").Append(PaymentFrequency).Append("\n");
            sb.Append("  DayCountConvention: ").Append(DayCountConvention).Append("\n");
            sb.Append("  RollConvention: ").Append(RollConvention).Append("\n");
            sb.Append("  PaymentCalendars: ").Append(PaymentCalendars).Append("\n");
            sb.Append("  ResetCalendars: ").Append(ResetCalendars).Append("\n");
            sb.Append("  SettleDays: ").Append(SettleDays).Append("\n");
            sb.Append("  ResetDays: ").Append(ResetDays).Append("\n");
            sb.Append("  BusinessDayConvention: ").Append(BusinessDayConvention).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as CdsFlowConventions);
        }

        /// <summary>
        /// Returns true if CdsFlowConventions instances are equal
        /// </summary>
        /// <param name="input">Instance of CdsFlowConventions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CdsFlowConventions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RollFrequency == input.RollFrequency ||
                    (this.RollFrequency != null &&
                    this.RollFrequency.Equals(input.RollFrequency))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.PaymentFrequency == input.PaymentFrequency ||
                    (this.PaymentFrequency != null &&
                    this.PaymentFrequency.Equals(input.PaymentFrequency))
                ) && 
                (
                    this.DayCountConvention == input.DayCountConvention ||
                    (this.DayCountConvention != null &&
                    this.DayCountConvention.Equals(input.DayCountConvention))
                ) && 
                (
                    this.RollConvention == input.RollConvention ||
                    (this.RollConvention != null &&
                    this.RollConvention.Equals(input.RollConvention))
                ) && 
                (
                    this.PaymentCalendars == input.PaymentCalendars ||
                    this.PaymentCalendars != null &&
                    input.PaymentCalendars != null &&
                    this.PaymentCalendars.SequenceEqual(input.PaymentCalendars)
                ) && 
                (
                    this.ResetCalendars == input.ResetCalendars ||
                    this.ResetCalendars != null &&
                    input.ResetCalendars != null &&
                    this.ResetCalendars.SequenceEqual(input.ResetCalendars)
                ) && 
                (
                    this.SettleDays == input.SettleDays ||
                    this.SettleDays.Equals(input.SettleDays)
                ) && 
                (
                    this.ResetDays == input.ResetDays ||
                    this.ResetDays.Equals(input.ResetDays)
                ) && 
                (
                    this.BusinessDayConvention == input.BusinessDayConvention ||
                    (this.BusinessDayConvention != null &&
                    this.BusinessDayConvention.Equals(input.BusinessDayConvention))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.RollFrequency != null)
                {
                    hashCode = (hashCode * 59) + this.RollFrequency.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.PaymentFrequency != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentFrequency.GetHashCode();
                }
                if (this.DayCountConvention != null)
                {
                    hashCode = (hashCode * 59) + this.DayCountConvention.GetHashCode();
                }
                if (this.RollConvention != null)
                {
                    hashCode = (hashCode * 59) + this.RollConvention.GetHashCode();
                }
                if (this.PaymentCalendars != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentCalendars.GetHashCode();
                }
                if (this.ResetCalendars != null)
                {
                    hashCode = (hashCode * 59) + this.ResetCalendars.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SettleDays.GetHashCode();
                hashCode = (hashCode * 59) + this.ResetDays.GetHashCode();
                if (this.BusinessDayConvention != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessDayConvention.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
            // RollFrequency (string) maxLength
            if (this.RollFrequency != null && this.RollFrequency.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RollFrequency, length must be less than 16.", new [] { "RollFrequency" });
            }

            // RollFrequency (string) minLength
            if (this.RollFrequency != null && this.RollFrequency.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RollFrequency, length must be greater than 0.", new [] { "RollFrequency" });
            }

            // PaymentFrequency (string) maxLength
            if (this.PaymentFrequency != null && this.PaymentFrequency.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentFrequency, length must be less than 50.", new [] { "PaymentFrequency" });
            }

            // PaymentFrequency (string) minLength
            if (this.PaymentFrequency != null && this.PaymentFrequency.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentFrequency, length must be greater than 0.", new [] { "PaymentFrequency" });
            }

            // DayCountConvention (string) maxLength
            if (this.DayCountConvention != null && this.DayCountConvention.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DayCountConvention, length must be less than 50.", new [] { "DayCountConvention" });
            }

            // DayCountConvention (string) minLength
            if (this.DayCountConvention != null && this.DayCountConvention.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DayCountConvention, length must be greater than 0.", new [] { "DayCountConvention" });
            }

            // RollConvention (string) maxLength
            if (this.RollConvention != null && this.RollConvention.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RollConvention, length must be less than 50.", new [] { "RollConvention" });
            }

            // RollConvention (string) minLength
            if (this.RollConvention != null && this.RollConvention.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RollConvention, length must be greater than 0.", new [] { "RollConvention" });
            }

            // Scope (string) maxLength
            if (this.Scope != null && this.Scope.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be less than 256.", new [] { "Scope" });
            }

            // Scope (string) minLength
            if (this.Scope != null && this.Scope.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be greater than 1.", new [] { "Scope" });
            }

            // Scope (string) pattern
            Regex regexScope = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexScope.Match(this.Scope).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, must match a pattern of " + regexScope, new [] { "Scope" });
            }

            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 256.", new [] { "Code" });
            }

            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            // Code (string) pattern
            Regex regexCode = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexCode.Match(this.Code).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, must match a pattern of " + regexCode, new [] { "Code" });
            }

            yield break;
        }
    }
}
