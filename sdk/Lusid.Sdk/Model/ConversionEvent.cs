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
    /// Conversion Event (CONV) - Conversion of securities (generally convertible bonds or preferred shares) into  another form of securities (usually common shares) at a pre-stated price/ratio.
    /// </summary>
    [DataContract(Name = "ConversionEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class ConversionEvent : InstrumentEvent, IEquatable<ConversionEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversionEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionEvent" /> class.
        /// </summary>
        /// <param name="recordDate">Required.  Date at which positions are struck at the end of the day to  note which parties will receive the relevant amount of  entitlement, due to be distributed on the Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.PaymentDate..</param>
        /// <param name="paymentDate">Required. Date on which the movement is due to take place (cash and/or securities)..</param>
        /// <param name="newInstrument">newInstrument (required).</param>
        /// <param name="responseDeadlineDate">Date/time that the account servicer has set as the deadline to respond,  with instructions, to an outstanding event. Not required..</param>
        /// <param name="marketDeadlineDate">Date/time which the issuer or issuer&#39;s agent has set as the deadline to respond,  with an instruction, to an outstanding offer or privilege. Not required..</param>
        /// <param name="periodOfAction">periodOfAction.</param>
        /// <param name="fractionalUnitsCashPrice">The cash price paid in lieu of fractionalUnits. Not required.  If provided, must have Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.FractionalUnitsCashCurrency too..</param>
        /// <param name="fractionalUnitsCashCurrency">Optional. Used in calculating cash-in-lieu of fractional shares. Not required.  If provided, must have Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.FractionalUnitsCashPrice too..</param>
        /// <param name="securityOfferElections">List of possible security offers for this conversion event. There must be at most one election of this type.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Mandatory:  This list must have exactly one election that is chosen and default.  Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashAndSecurityOfferElections and Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashOfferElections&lt;b&gt; must be null or empty&lt;/b&gt;.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Voluntary:  This list can be empty,  so long as Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashAndSecurityOfferElections or Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashOfferElections  has at least one election. None of these elections have to be chosen or default..</param>
        /// <param name="cashAndSecurityOfferElections">List of possible cash and security offers for this conversion event. There must be at most one election of this type.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Mandatory:  This list &lt;b&gt; must be null or empty&lt;/b&gt;.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Voluntary:  This list can be empty,  so long as Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.SecurityOfferElections or Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashOfferElections  has at least one election. None of these elections have to be chosen or default..</param>
        /// <param name="cashOfferElections">List of possible cash offers for this conversion event. There must be at most one election of this type.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Mandatory:  This list &lt;b&gt; must be null or empty&lt;/b&gt;.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Voluntary:  This list can be empty,  so long as Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.SecurityOfferElections or Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashAndSecurityOfferElections  has at least one election. None of these elections have to be chosen or default..</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent (required) (default to &quot;ConversionEvent&quot;).</param>
        public ConversionEvent(DateTimeOffset recordDate = default(DateTimeOffset), DateTimeOffset paymentDate = default(DateTimeOffset), NewInstrument newInstrument = default(NewInstrument), DateTimeOffset? responseDeadlineDate = default(DateTimeOffset?), DateTimeOffset? marketDeadlineDate = default(DateTimeOffset?), EventDateRange periodOfAction = default(EventDateRange), decimal? fractionalUnitsCashPrice = default(decimal?), string fractionalUnitsCashCurrency = default(string), List<SecurityOfferElection> securityOfferElections = default(List<SecurityOfferElection>), List<CashAndSecurityOfferElection> cashAndSecurityOfferElections = default(List<CashAndSecurityOfferElection>), List<CashOfferElection> cashOfferElections = default(List<CashOfferElection>), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            // to ensure "newInstrument" is required (not null)
            if (newInstrument == null)
            {
                throw new ArgumentNullException("newInstrument is a required property for ConversionEvent and cannot be null");
            }
            this.NewInstrument = newInstrument;
            this.RecordDate = recordDate;
            this.PaymentDate = paymentDate;
            this.ResponseDeadlineDate = responseDeadlineDate;
            this.MarketDeadlineDate = marketDeadlineDate;
            this.PeriodOfAction = periodOfAction;
            this.FractionalUnitsCashPrice = fractionalUnitsCashPrice;
            this.FractionalUnitsCashCurrency = fractionalUnitsCashCurrency;
            this.SecurityOfferElections = securityOfferElections;
            this.CashAndSecurityOfferElections = cashAndSecurityOfferElections;
            this.CashOfferElections = cashOfferElections;
        }

        /// <summary>
        /// Required.  Date at which positions are struck at the end of the day to  note which parties will receive the relevant amount of  entitlement, due to be distributed on the Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.PaymentDate.
        /// </summary>
        /// <value>Required.  Date at which positions are struck at the end of the day to  note which parties will receive the relevant amount of  entitlement, due to be distributed on the Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.PaymentDate.</value>
        [DataMember(Name = "recordDate", EmitDefaultValue = false)]
        public DateTimeOffset RecordDate { get; set; }

        /// <summary>
        /// Required. Date on which the movement is due to take place (cash and/or securities).
        /// </summary>
        /// <value>Required. Date on which the movement is due to take place (cash and/or securities).</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets NewInstrument
        /// </summary>
        [DataMember(Name = "newInstrument", IsRequired = true, EmitDefaultValue = true)]
        public NewInstrument NewInstrument { get; set; }

        /// <summary>
        /// Date/time that the account servicer has set as the deadline to respond,  with instructions, to an outstanding event. Not required.
        /// </summary>
        /// <value>Date/time that the account servicer has set as the deadline to respond,  with instructions, to an outstanding event. Not required.</value>
        [DataMember(Name = "responseDeadlineDate", EmitDefaultValue = true)]
        public DateTimeOffset? ResponseDeadlineDate { get; set; }

        /// <summary>
        /// Date/time which the issuer or issuer&#39;s agent has set as the deadline to respond,  with an instruction, to an outstanding offer or privilege. Not required.
        /// </summary>
        /// <value>Date/time which the issuer or issuer&#39;s agent has set as the deadline to respond,  with an instruction, to an outstanding offer or privilege. Not required.</value>
        [DataMember(Name = "marketDeadlineDate", EmitDefaultValue = true)]
        public DateTimeOffset? MarketDeadlineDate { get; set; }

        /// <summary>
        /// Gets or Sets PeriodOfAction
        /// </summary>
        [DataMember(Name = "periodOfAction", EmitDefaultValue = false)]
        public EventDateRange PeriodOfAction { get; set; }

        /// <summary>
        /// The cash price paid in lieu of fractionalUnits. Not required.  If provided, must have Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.FractionalUnitsCashCurrency too.
        /// </summary>
        /// <value>The cash price paid in lieu of fractionalUnits. Not required.  If provided, must have Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.FractionalUnitsCashCurrency too.</value>
        [DataMember(Name = "fractionalUnitsCashPrice", EmitDefaultValue = true)]
        public decimal? FractionalUnitsCashPrice { get; set; }

        /// <summary>
        /// Optional. Used in calculating cash-in-lieu of fractional shares. Not required.  If provided, must have Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.FractionalUnitsCashPrice too.
        /// </summary>
        /// <value>Optional. Used in calculating cash-in-lieu of fractional shares. Not required.  If provided, must have Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.FractionalUnitsCashPrice too.</value>
        [DataMember(Name = "fractionalUnitsCashCurrency", EmitDefaultValue = true)]
        public string FractionalUnitsCashCurrency { get; set; }

        /// <summary>
        /// List of possible security offers for this conversion event. There must be at most one election of this type.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Mandatory:  This list must have exactly one election that is chosen and default.  Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashAndSecurityOfferElections and Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashOfferElections&lt;b&gt; must be null or empty&lt;/b&gt;.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Voluntary:  This list can be empty,  so long as Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashAndSecurityOfferElections or Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashOfferElections  has at least one election. None of these elections have to be chosen or default.
        /// </summary>
        /// <value>List of possible security offers for this conversion event. There must be at most one election of this type.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Mandatory:  This list must have exactly one election that is chosen and default.  Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashAndSecurityOfferElections and Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashOfferElections&lt;b&gt; must be null or empty&lt;/b&gt;.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Voluntary:  This list can be empty,  so long as Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashAndSecurityOfferElections or Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashOfferElections  has at least one election. None of these elections have to be chosen or default.</value>
        [DataMember(Name = "securityOfferElections", EmitDefaultValue = true)]
        public List<SecurityOfferElection> SecurityOfferElections { get; set; }

        /// <summary>
        /// List of possible cash and security offers for this conversion event. There must be at most one election of this type.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Mandatory:  This list &lt;b&gt; must be null or empty&lt;/b&gt;.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Voluntary:  This list can be empty,  so long as Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.SecurityOfferElections or Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashOfferElections  has at least one election. None of these elections have to be chosen or default.
        /// </summary>
        /// <value>List of possible cash and security offers for this conversion event. There must be at most one election of this type.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Mandatory:  This list &lt;b&gt; must be null or empty&lt;/b&gt;.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Voluntary:  This list can be empty,  so long as Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.SecurityOfferElections or Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashOfferElections  has at least one election. None of these elections have to be chosen or default.</value>
        [DataMember(Name = "cashAndSecurityOfferElections", EmitDefaultValue = true)]
        public List<CashAndSecurityOfferElection> CashAndSecurityOfferElections { get; set; }

        /// <summary>
        /// List of possible cash offers for this conversion event. There must be at most one election of this type.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Mandatory:  This list &lt;b&gt; must be null or empty&lt;/b&gt;.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Voluntary:  This list can be empty,  so long as Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.SecurityOfferElections or Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashAndSecurityOfferElections  has at least one election. None of these elections have to be chosen or default.
        /// </summary>
        /// <value>List of possible cash offers for this conversion event. There must be at most one election of this type.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Mandatory:  This list &lt;b&gt; must be null or empty&lt;/b&gt;.  If the Finbourne.LusidInstruments.Events.ParticipationType is Finbourne.LusidInstruments.Events.ParticipationType.Voluntary:  This list can be empty,  so long as Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.SecurityOfferElections or Finbourne.WebApi.Interface.Dto.InstrumentEvents.ConversionEvent.CashAndSecurityOfferElections  has at least one election. None of these elections have to be chosen or default.</value>
        [DataMember(Name = "cashOfferElections", EmitDefaultValue = true)]
        public List<CashOfferElection> CashOfferElections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConversionEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  NewInstrument: ").Append(NewInstrument).Append("\n");
            sb.Append("  ResponseDeadlineDate: ").Append(ResponseDeadlineDate).Append("\n");
            sb.Append("  MarketDeadlineDate: ").Append(MarketDeadlineDate).Append("\n");
            sb.Append("  PeriodOfAction: ").Append(PeriodOfAction).Append("\n");
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
            return this.Equals(input as ConversionEvent);
        }

        /// <summary>
        /// Returns true if ConversionEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversionEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversionEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
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
                    this.ResponseDeadlineDate == input.ResponseDeadlineDate ||
                    (this.ResponseDeadlineDate != null &&
                    this.ResponseDeadlineDate.Equals(input.ResponseDeadlineDate))
                ) && base.Equals(input) && 
                (
                    this.MarketDeadlineDate == input.MarketDeadlineDate ||
                    (this.MarketDeadlineDate != null &&
                    this.MarketDeadlineDate.Equals(input.MarketDeadlineDate))
                ) && base.Equals(input) && 
                (
                    this.PeriodOfAction == input.PeriodOfAction ||
                    (this.PeriodOfAction != null &&
                    this.PeriodOfAction.Equals(input.PeriodOfAction))
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
                if (this.ResponseDeadlineDate != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseDeadlineDate.GetHashCode();
                }
                if (this.MarketDeadlineDate != null)
                {
                    hashCode = (hashCode * 59) + this.MarketDeadlineDate.GetHashCode();
                }
                if (this.PeriodOfAction != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodOfAction.GetHashCode();
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
