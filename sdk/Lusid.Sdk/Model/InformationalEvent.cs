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
    /// A generic event derived from the economic definition of an instrument. This should be considered purely  informational; any data provided by this event is not guaranteed to be processable by LUSID.
    /// </summary>
    [DataContract(Name = "InformationalEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class InformationalEvent : InstrumentEvent, IEquatable<InformationalEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InformationalEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InformationalEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InformationalEvent" /> class.
        /// </summary>
        /// <param name="anchorDate">In the case of a point event, the single date on which the event occurs. In the case of an event which is  spread over a window, e.g. a barrier or American option, the start of that window. (required).</param>
        /// <param name="diagnostics">diagnostics.</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent (required) (default to &quot;InformationalEvent&quot;).</param>
        public InformationalEvent(DateTimeOffset anchorDate = default(DateTimeOffset), ResultValueDictionary diagnostics = default(ResultValueDictionary), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            this.AnchorDate = anchorDate;
            this.Diagnostics = diagnostics;
        }

        /// <summary>
        /// What type of internal event does this represent; reset, exercise, amortisation etc.
        /// </summary>
        /// <value>What type of internal event does this represent; reset, exercise, amortisation etc.</value>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public string EventType { get; private set; }

        /// <summary>
        /// Returns false as EventType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEventType()
        {
            return false;
        }
        /// <summary>
        /// In the case of a point event, the single date on which the event occurs. In the case of an event which is  spread over a window, e.g. a barrier or American option, the start of that window.
        /// </summary>
        /// <value>In the case of a point event, the single date on which the event occurs. In the case of an event which is  spread over a window, e.g. a barrier or American option, the start of that window.</value>
        [DataMember(Name = "anchorDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset AnchorDate { get; set; }

        /// <summary>
        /// In the case of a point event this is identical to the anchor date. In the case of an event that is spread over a window,  this is the end of that window.
        /// </summary>
        /// <value>In the case of a point event this is identical to the anchor date. In the case of an event that is spread over a window,  this is the end of that window.</value>
        [DataMember(Name = "eventWindowEnd", EmitDefaultValue = false)]
        public DateTimeOffset EventWindowEnd { get; private set; }

        /// <summary>
        /// Returns false as EventWindowEnd should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEventWindowEnd()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Diagnostics
        /// </summary>
        [DataMember(Name = "diagnostics", EmitDefaultValue = false)]
        public ResultValueDictionary Diagnostics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InformationalEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  AnchorDate: ").Append(AnchorDate).Append("\n");
            sb.Append("  EventWindowEnd: ").Append(EventWindowEnd).Append("\n");
            sb.Append("  Diagnostics: ").Append(Diagnostics).Append("\n");
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
            return this.Equals(input as InformationalEvent);
        }

        /// <summary>
        /// Returns true if InformationalEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of InformationalEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InformationalEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && base.Equals(input) && 
                (
                    this.AnchorDate == input.AnchorDate ||
                    (this.AnchorDate != null &&
                    this.AnchorDate.Equals(input.AnchorDate))
                ) && base.Equals(input) && 
                (
                    this.EventWindowEnd == input.EventWindowEnd ||
                    (this.EventWindowEnd != null &&
                    this.EventWindowEnd.Equals(input.EventWindowEnd))
                ) && base.Equals(input) && 
                (
                    this.Diagnostics == input.Diagnostics ||
                    (this.Diagnostics != null &&
                    this.Diagnostics.Equals(input.Diagnostics))
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
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.AnchorDate != null)
                {
                    hashCode = (hashCode * 59) + this.AnchorDate.GetHashCode();
                }
                if (this.EventWindowEnd != null)
                {
                    hashCode = (hashCode * 59) + this.EventWindowEnd.GetHashCode();
                }
                if (this.Diagnostics != null)
                {
                    hashCode = (hashCode * 59) + this.Diagnostics.GetHashCode();
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
            // EventType (string) minLength
            if (this.EventType != null && this.EventType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventType, length must be greater than 1.", new [] { "EventType" });
            }

            yield break;
        }
    }
}
