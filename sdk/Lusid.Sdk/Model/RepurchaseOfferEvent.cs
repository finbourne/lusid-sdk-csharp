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
    /// Representation of a repurchase offer corporate action.  Represents an offer by the issuer to repurchase its own shares from a shareholder at a given price.
    /// </summary>
    [DataContract(Name = "RepurchaseOfferEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class RepurchaseOfferEvent : InstrumentEvent, IEquatable<RepurchaseOfferEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepurchaseOfferEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepurchaseOfferEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepurchaseOfferEvent" /> class.
        /// </summary>
        /// <param name="paymentDate">Payment date of the event..</param>
        /// <param name="marketDeadlineDate">Date set by the issuer or by an agent of the issuer as the latest date to respond to the offer. Must be before or equal to the PaymentDate..</param>
        /// <param name="repurchaseQuantity">Quantity of the security to be repurchased. (required).</param>
        /// <param name="cashOfferElections">List of possible CashOfferElections for this event. Only 1 should be provided. (required).</param>
        /// <param name="lapseElections">List of possible LapseElections for this event. Only 1 should be provided.  Allows the user to opt out of the offer. (required).</param>
        /// <param name="tenderOfferElections">List of possible TenderOfferElections for this event. Only 1 should be provided. (required).</param>
        /// <param name="prorationRate">The fraction used to calculate a proportional adjustment for RepurchaseQuantity when a full period is not used.  Defaults to 1 if not set. Must be greater than 0 and less than or equal to 1. (default to 1D).</param>
        /// <param name="responseDeadlineDate">Date set by the account servicer as the latest date to respond to the offer.  Optional. If set, must be before or equal to MarketDeadlineDate.  Defaults to MarketDeadlineDate if not set..</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent (required) (default to &quot;RepurchaseOfferEvent&quot;).</param>
        public RepurchaseOfferEvent(DateTimeOffset paymentDate = default(DateTimeOffset), DateTimeOffset marketDeadlineDate = default(DateTimeOffset), decimal repurchaseQuantity = default(decimal), List<CashOfferElection> cashOfferElections = default(List<CashOfferElection>), List<LapseElection> lapseElections = default(List<LapseElection>), List<TenderOfferElection> tenderOfferElections = default(List<TenderOfferElection>), decimal prorationRate = (decimal)1D, DateTimeOffset? responseDeadlineDate = default(DateTimeOffset?), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            this.RepurchaseQuantity = repurchaseQuantity;
            // to ensure "cashOfferElections" is required (not null)
            if (cashOfferElections == null)
            {
                throw new ArgumentNullException("cashOfferElections is a required property for RepurchaseOfferEvent and cannot be null");
            }
            this.CashOfferElections = cashOfferElections;
            // to ensure "lapseElections" is required (not null)
            if (lapseElections == null)
            {
                throw new ArgumentNullException("lapseElections is a required property for RepurchaseOfferEvent and cannot be null");
            }
            this.LapseElections = lapseElections;
            // to ensure "tenderOfferElections" is required (not null)
            if (tenderOfferElections == null)
            {
                throw new ArgumentNullException("tenderOfferElections is a required property for RepurchaseOfferEvent and cannot be null");
            }
            this.TenderOfferElections = tenderOfferElections;
            this.PaymentDate = paymentDate;
            this.MarketDeadlineDate = marketDeadlineDate;
            this.ProrationRate = prorationRate;
            this.ResponseDeadlineDate = responseDeadlineDate;
        }

        /// <summary>
        /// Payment date of the event.
        /// </summary>
        /// <value>Payment date of the event.</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// Date set by the issuer or by an agent of the issuer as the latest date to respond to the offer. Must be before or equal to the PaymentDate.
        /// </summary>
        /// <value>Date set by the issuer or by an agent of the issuer as the latest date to respond to the offer. Must be before or equal to the PaymentDate.</value>
        [DataMember(Name = "marketDeadlineDate", EmitDefaultValue = false)]
        public DateTimeOffset MarketDeadlineDate { get; set; }

        /// <summary>
        /// Quantity of the security to be repurchased.
        /// </summary>
        /// <value>Quantity of the security to be repurchased.</value>
        [DataMember(Name = "repurchaseQuantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal RepurchaseQuantity { get; set; }

        /// <summary>
        /// List of possible CashOfferElections for this event. Only 1 should be provided.
        /// </summary>
        /// <value>List of possible CashOfferElections for this event. Only 1 should be provided.</value>
        [DataMember(Name = "cashOfferElections", IsRequired = true, EmitDefaultValue = true)]
        public List<CashOfferElection> CashOfferElections { get; set; }

        /// <summary>
        /// List of possible LapseElections for this event. Only 1 should be provided.  Allows the user to opt out of the offer.
        /// </summary>
        /// <value>List of possible LapseElections for this event. Only 1 should be provided.  Allows the user to opt out of the offer.</value>
        [DataMember(Name = "lapseElections", IsRequired = true, EmitDefaultValue = true)]
        public List<LapseElection> LapseElections { get; set; }

        /// <summary>
        /// List of possible TenderOfferElections for this event. Only 1 should be provided.
        /// </summary>
        /// <value>List of possible TenderOfferElections for this event. Only 1 should be provided.</value>
        [DataMember(Name = "tenderOfferElections", IsRequired = true, EmitDefaultValue = true)]
        public List<TenderOfferElection> TenderOfferElections { get; set; }

        /// <summary>
        /// The fraction used to calculate a proportional adjustment for RepurchaseQuantity when a full period is not used.  Defaults to 1 if not set. Must be greater than 0 and less than or equal to 1.
        /// </summary>
        /// <value>The fraction used to calculate a proportional adjustment for RepurchaseQuantity when a full period is not used.  Defaults to 1 if not set. Must be greater than 0 and less than or equal to 1.</value>
        [DataMember(Name = "prorationRate", EmitDefaultValue = true)]
        public decimal ProrationRate { get; set; }

        /// <summary>
        /// Date set by the account servicer as the latest date to respond to the offer.  Optional. If set, must be before or equal to MarketDeadlineDate.  Defaults to MarketDeadlineDate if not set.
        /// </summary>
        /// <value>Date set by the account servicer as the latest date to respond to the offer.  Optional. If set, must be before or equal to MarketDeadlineDate.  Defaults to MarketDeadlineDate if not set.</value>
        [DataMember(Name = "responseDeadlineDate", EmitDefaultValue = true)]
        public DateTimeOffset? ResponseDeadlineDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RepurchaseOfferEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  MarketDeadlineDate: ").Append(MarketDeadlineDate).Append("\n");
            sb.Append("  RepurchaseQuantity: ").Append(RepurchaseQuantity).Append("\n");
            sb.Append("  CashOfferElections: ").Append(CashOfferElections).Append("\n");
            sb.Append("  LapseElections: ").Append(LapseElections).Append("\n");
            sb.Append("  TenderOfferElections: ").Append(TenderOfferElections).Append("\n");
            sb.Append("  ProrationRate: ").Append(ProrationRate).Append("\n");
            sb.Append("  ResponseDeadlineDate: ").Append(ResponseDeadlineDate).Append("\n");
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
            return this.Equals(input as RepurchaseOfferEvent);
        }

        /// <summary>
        /// Returns true if RepurchaseOfferEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of RepurchaseOfferEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepurchaseOfferEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && base.Equals(input) && 
                (
                    this.MarketDeadlineDate == input.MarketDeadlineDate ||
                    (this.MarketDeadlineDate != null &&
                    this.MarketDeadlineDate.Equals(input.MarketDeadlineDate))
                ) && base.Equals(input) && 
                (
                    this.RepurchaseQuantity == input.RepurchaseQuantity ||
                    this.RepurchaseQuantity.Equals(input.RepurchaseQuantity)
                ) && base.Equals(input) && 
                (
                    this.CashOfferElections == input.CashOfferElections ||
                    this.CashOfferElections != null &&
                    input.CashOfferElections != null &&
                    this.CashOfferElections.SequenceEqual(input.CashOfferElections)
                ) && base.Equals(input) && 
                (
                    this.LapseElections == input.LapseElections ||
                    this.LapseElections != null &&
                    input.LapseElections != null &&
                    this.LapseElections.SequenceEqual(input.LapseElections)
                ) && base.Equals(input) && 
                (
                    this.TenderOfferElections == input.TenderOfferElections ||
                    this.TenderOfferElections != null &&
                    input.TenderOfferElections != null &&
                    this.TenderOfferElections.SequenceEqual(input.TenderOfferElections)
                ) && base.Equals(input) && 
                (
                    this.ProrationRate == input.ProrationRate ||
                    this.ProrationRate.Equals(input.ProrationRate)
                ) && base.Equals(input) && 
                (
                    this.ResponseDeadlineDate == input.ResponseDeadlineDate ||
                    (this.ResponseDeadlineDate != null &&
                    this.ResponseDeadlineDate.Equals(input.ResponseDeadlineDate))
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
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                if (this.MarketDeadlineDate != null)
                {
                    hashCode = (hashCode * 59) + this.MarketDeadlineDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RepurchaseQuantity.GetHashCode();
                if (this.CashOfferElections != null)
                {
                    hashCode = (hashCode * 59) + this.CashOfferElections.GetHashCode();
                }
                if (this.LapseElections != null)
                {
                    hashCode = (hashCode * 59) + this.LapseElections.GetHashCode();
                }
                if (this.TenderOfferElections != null)
                {
                    hashCode = (hashCode * 59) + this.TenderOfferElections.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProrationRate.GetHashCode();
                if (this.ResponseDeadlineDate != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseDeadlineDate.GetHashCode();
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
