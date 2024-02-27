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
    /// Definition of a Bond Coupon Event  This is an event that describes the occurence of a cashflow due to a fixed rate bond coupon payment.
    /// </summary>
    [DataContract(Name = "BondCouponEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class BondCouponEvent : InstrumentEvent, IEquatable<BondCouponEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BondCouponEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BondCouponEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BondCouponEvent" /> class.
        /// </summary>
        /// <param name="exDate">Ex-Dividend date of the coupon payment (required).</param>
        /// <param name="paymentDate">Payment date of the coupon payment (required).</param>
        /// <param name="currency">Currency of the coupon payment (required).</param>
        /// <param name="couponPerUnit">CouponRate*Principal (required).</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent (required) (default to &quot;BondCouponEvent&quot;).</param>
        public BondCouponEvent(DateTimeOffset exDate = default(DateTimeOffset), DateTimeOffset paymentDate = default(DateTimeOffset), string currency = default(string), decimal couponPerUnit = default(decimal), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            this.ExDate = exDate;
            this.PaymentDate = paymentDate;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for BondCouponEvent and cannot be null");
            }
            this.Currency = currency;
            this.CouponPerUnit = couponPerUnit;
        }

        /// <summary>
        /// Ex-Dividend date of the coupon payment
        /// </summary>
        /// <value>Ex-Dividend date of the coupon payment</value>
        [DataMember(Name = "exDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset ExDate { get; set; }

        /// <summary>
        /// Payment date of the coupon payment
        /// </summary>
        /// <value>Payment date of the coupon payment</value>
        [DataMember(Name = "paymentDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// Currency of the coupon payment
        /// </summary>
        /// <value>Currency of the coupon payment</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// CouponRate*Principal
        /// </summary>
        /// <value>CouponRate*Principal</value>
        [DataMember(Name = "couponPerUnit", IsRequired = true, EmitDefaultValue = true)]
        public decimal CouponPerUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BondCouponEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CouponPerUnit: ").Append(CouponPerUnit).Append("\n");
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
            return this.Equals(input as BondCouponEvent);
        }

        /// <summary>
        /// Returns true if BondCouponEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of BondCouponEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BondCouponEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ExDate == input.ExDate ||
                    (this.ExDate != null &&
                    this.ExDate.Equals(input.ExDate))
                ) && base.Equals(input) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.CouponPerUnit == input.CouponPerUnit ||
                    this.CouponPerUnit.Equals(input.CouponPerUnit)
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
                if (this.ExDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExDate.GetHashCode();
                }
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CouponPerUnit.GetHashCode();
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