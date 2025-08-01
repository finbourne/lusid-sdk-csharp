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
    /// Definition of a Swap Principal Event.  This is an event that describes the occurence of a cashflow due to the principal payment.
    /// </summary>
    [DataContract(Name = "SwapPrincipalEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class SwapPrincipalEvent : InstrumentEvent, IEquatable<SwapPrincipalEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwapPrincipalEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SwapPrincipalEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SwapPrincipalEvent" /> class.
        /// </summary>
        /// <param name="exDate">The entitlement date of the principal payment..</param>
        /// <param name="paymentDate">The payment date of the principal..</param>
        /// <param name="currency">The currency in which the principal is paid. (required).</param>
        /// <param name="principalPerUnit">The principal amount received for each unit of the instrument held on the ex date..</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent (required) (default to &quot;SwapPrincipalEvent&quot;).</param>
        public SwapPrincipalEvent(DateTimeOffset exDate = default(DateTimeOffset), DateTimeOffset paymentDate = default(DateTimeOffset), string currency = default(string), decimal principalPerUnit = default(decimal), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for SwapPrincipalEvent and cannot be null");
            }
            this.Currency = currency;
            this.ExDate = exDate;
            this.PaymentDate = paymentDate;
            this.PrincipalPerUnit = principalPerUnit;
        }

        /// <summary>
        /// The entitlement date of the principal payment.
        /// </summary>
        /// <value>The entitlement date of the principal payment.</value>
        [DataMember(Name = "exDate", EmitDefaultValue = false)]
        public DateTimeOffset ExDate { get; set; }

        /// <summary>
        /// The payment date of the principal.
        /// </summary>
        /// <value>The payment date of the principal.</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// The currency in which the principal is paid.
        /// </summary>
        /// <value>The currency in which the principal is paid.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The principal amount received for each unit of the instrument held on the ex date.
        /// </summary>
        /// <value>The principal amount received for each unit of the instrument held on the ex date.</value>
        [DataMember(Name = "principalPerUnit", EmitDefaultValue = true)]
        public decimal PrincipalPerUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SwapPrincipalEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PrincipalPerUnit: ").Append(PrincipalPerUnit).Append("\n");
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
            return this.Equals(input as SwapPrincipalEvent);
        }

        /// <summary>
        /// Returns true if SwapPrincipalEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SwapPrincipalEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwapPrincipalEvent input)
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
                    this.PrincipalPerUnit == input.PrincipalPerUnit ||
                    this.PrincipalPerUnit.Equals(input.PrincipalPerUnit)
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
                hashCode = (hashCode * 59) + this.PrincipalPerUnit.GetHashCode();
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
