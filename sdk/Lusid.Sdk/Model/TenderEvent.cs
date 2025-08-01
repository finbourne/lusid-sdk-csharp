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
    /// Tender Event (TEND).
    /// </summary>
    [DataContract(Name = "TenderEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class TenderEvent : InstrumentEvent, IEquatable<TenderEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenderEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TenderEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenderEvent" /> class.
        /// </summary>
        /// <param name="announcementDate">The date the tender is announced..</param>
        /// <param name="exDate">The ex date (entitlement date) of the event..</param>
        /// <param name="recordDate">Date you have to be the holder of record in order to participate in the tender..</param>
        /// <param name="paymentDate">The payment date of the event..</param>
        /// <param name="newInstrument">newInstrument (required).</param>
        /// <param name="fractionalUnitsCashPrice">The cash price paid in lieu of fractionalUnits..</param>
        /// <param name="fractionalUnitsCashCurrency">The currency of the cash paid in lieu of fractionalUnits..</param>
        /// <param name="securityOfferElections">List of possible SecurityOfferElections for this event..</param>
        /// <param name="cashAndSecurityOfferElections">List of possible CashAndSecurityOfferElections for this event..</param>
        /// <param name="cashOfferElections">List of possible CashOfferElections for this event..</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent (required) (default to &quot;TenderEvent&quot;).</param>
        public TenderEvent(DateTimeOffset? announcementDate = default(DateTimeOffset?), DateTimeOffset exDate = default(DateTimeOffset), DateTimeOffset? recordDate = default(DateTimeOffset?), DateTimeOffset paymentDate = default(DateTimeOffset), NewInstrument newInstrument = default(NewInstrument), decimal? fractionalUnitsCashPrice = default(decimal?), string fractionalUnitsCashCurrency = default(string), List<SecurityOfferElection> securityOfferElections = default(List<SecurityOfferElection>), List<CashAndSecurityOfferElection> cashAndSecurityOfferElections = default(List<CashAndSecurityOfferElection>), List<CashOfferElection> cashOfferElections = default(List<CashOfferElection>), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            // to ensure "newInstrument" is required (not null)
            if (newInstrument == null)
            {
                throw new ArgumentNullException("newInstrument is a required property for TenderEvent and cannot be null");
            }
            this.NewInstrument = newInstrument;
            this.AnnouncementDate = announcementDate;
            this.ExDate = exDate;
            this.RecordDate = recordDate;
            this.PaymentDate = paymentDate;
            this.FractionalUnitsCashPrice = fractionalUnitsCashPrice;
            this.FractionalUnitsCashCurrency = fractionalUnitsCashCurrency;
            this.SecurityOfferElections = securityOfferElections;
            this.CashAndSecurityOfferElections = cashAndSecurityOfferElections;
            this.CashOfferElections = cashOfferElections;
        }

        /// <summary>
        /// The date the tender is announced.
        /// </summary>
        /// <value>The date the tender is announced.</value>
        [DataMember(Name = "announcementDate", EmitDefaultValue = true)]
        public DateTimeOffset? AnnouncementDate { get; set; }

        /// <summary>
        /// The ex date (entitlement date) of the event.
        /// </summary>
        /// <value>The ex date (entitlement date) of the event.</value>
        [DataMember(Name = "exDate", EmitDefaultValue = false)]
        public DateTimeOffset ExDate { get; set; }

        /// <summary>
        /// Date you have to be the holder of record in order to participate in the tender.
        /// </summary>
        /// <value>Date you have to be the holder of record in order to participate in the tender.</value>
        [DataMember(Name = "recordDate", EmitDefaultValue = true)]
        public DateTimeOffset? RecordDate { get; set; }

        /// <summary>
        /// The payment date of the event.
        /// </summary>
        /// <value>The payment date of the event.</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets NewInstrument
        /// </summary>
        [DataMember(Name = "newInstrument", IsRequired = true, EmitDefaultValue = true)]
        public NewInstrument NewInstrument { get; set; }

        /// <summary>
        /// The cash price paid in lieu of fractionalUnits.
        /// </summary>
        /// <value>The cash price paid in lieu of fractionalUnits.</value>
        [DataMember(Name = "fractionalUnitsCashPrice", EmitDefaultValue = true)]
        public decimal? FractionalUnitsCashPrice { get; set; }

        /// <summary>
        /// The currency of the cash paid in lieu of fractionalUnits.
        /// </summary>
        /// <value>The currency of the cash paid in lieu of fractionalUnits.</value>
        [DataMember(Name = "fractionalUnitsCashCurrency", EmitDefaultValue = true)]
        public string FractionalUnitsCashCurrency { get; set; }

        /// <summary>
        /// List of possible SecurityOfferElections for this event.
        /// </summary>
        /// <value>List of possible SecurityOfferElections for this event.</value>
        [DataMember(Name = "securityOfferElections", EmitDefaultValue = true)]
        public List<SecurityOfferElection> SecurityOfferElections { get; set; }

        /// <summary>
        /// List of possible CashAndSecurityOfferElections for this event.
        /// </summary>
        /// <value>List of possible CashAndSecurityOfferElections for this event.</value>
        [DataMember(Name = "cashAndSecurityOfferElections", EmitDefaultValue = true)]
        public List<CashAndSecurityOfferElection> CashAndSecurityOfferElections { get; set; }

        /// <summary>
        /// List of possible CashOfferElections for this event.
        /// </summary>
        /// <value>List of possible CashOfferElections for this event.</value>
        [DataMember(Name = "cashOfferElections", EmitDefaultValue = true)]
        public List<CashOfferElection> CashOfferElections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenderEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AnnouncementDate: ").Append(AnnouncementDate).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  NewInstrument: ").Append(NewInstrument).Append("\n");
            sb.Append("  FractionalUnitsCashPrice: ").Append(FractionalUnitsCashPrice).Append("\n");
            sb.Append("  FractionalUnitsCashCurrency: ").Append(FractionalUnitsCashCurrency).Append("\n");
            sb.Append("  SecurityOfferElections: ").Append(SecurityOfferElections).Append("\n");
            sb.Append("  CashAndSecurityOfferElections: ").Append(CashAndSecurityOfferElections).Append("\n");
            sb.Append("  CashOfferElections: ").Append(CashOfferElections).Append("\n");
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
            return this.Equals(input as TenderEvent);
        }

        /// <summary>
        /// Returns true if TenderEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TenderEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenderEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.AnnouncementDate == input.AnnouncementDate ||
                    (this.AnnouncementDate != null &&
                    this.AnnouncementDate.Equals(input.AnnouncementDate))
                ) && base.Equals(input) && 
                (
                    this.ExDate == input.ExDate ||
                    (this.ExDate != null &&
                    this.ExDate.Equals(input.ExDate))
                ) && base.Equals(input) && 
                (
                    this.RecordDate == input.RecordDate ||
                    (this.RecordDate != null &&
                    this.RecordDate.Equals(input.RecordDate))
                ) && base.Equals(input) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && base.Equals(input) && 
                (
                    this.NewInstrument == input.NewInstrument ||
                    (this.NewInstrument != null &&
                    this.NewInstrument.Equals(input.NewInstrument))
                ) && base.Equals(input) && 
                (
                    this.FractionalUnitsCashPrice == input.FractionalUnitsCashPrice ||
                    (this.FractionalUnitsCashPrice != null &&
                    this.FractionalUnitsCashPrice.Equals(input.FractionalUnitsCashPrice))
                ) && base.Equals(input) && 
                (
                    this.FractionalUnitsCashCurrency == input.FractionalUnitsCashCurrency ||
                    (this.FractionalUnitsCashCurrency != null &&
                    this.FractionalUnitsCashCurrency.Equals(input.FractionalUnitsCashCurrency))
                ) && base.Equals(input) && 
                (
                    this.SecurityOfferElections == input.SecurityOfferElections ||
                    this.SecurityOfferElections != null &&
                    input.SecurityOfferElections != null &&
                    this.SecurityOfferElections.SequenceEqual(input.SecurityOfferElections)
                ) && base.Equals(input) && 
                (
                    this.CashAndSecurityOfferElections == input.CashAndSecurityOfferElections ||
                    this.CashAndSecurityOfferElections != null &&
                    input.CashAndSecurityOfferElections != null &&
                    this.CashAndSecurityOfferElections.SequenceEqual(input.CashAndSecurityOfferElections)
                ) && base.Equals(input) && 
                (
                    this.CashOfferElections == input.CashOfferElections ||
                    this.CashOfferElections != null &&
                    input.CashOfferElections != null &&
                    this.CashOfferElections.SequenceEqual(input.CashOfferElections)
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
                if (this.AnnouncementDate != null)
                {
                    hashCode = (hashCode * 59) + this.AnnouncementDate.GetHashCode();
                }
                if (this.ExDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExDate.GetHashCode();
                }
                if (this.RecordDate != null)
                {
                    hashCode = (hashCode * 59) + this.RecordDate.GetHashCode();
                }
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                if (this.NewInstrument != null)
                {
                    hashCode = (hashCode * 59) + this.NewInstrument.GetHashCode();
                }
                if (this.FractionalUnitsCashPrice != null)
                {
                    hashCode = (hashCode * 59) + this.FractionalUnitsCashPrice.GetHashCode();
                }
                if (this.FractionalUnitsCashCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.FractionalUnitsCashCurrency.GetHashCode();
                }
                if (this.SecurityOfferElections != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityOfferElections.GetHashCode();
                }
                if (this.CashAndSecurityOfferElections != null)
                {
                    hashCode = (hashCode * 59) + this.CashAndSecurityOfferElections.GetHashCode();
                }
                if (this.CashOfferElections != null)
                {
                    hashCode = (hashCode * 59) + this.CashOfferElections.GetHashCode();
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
