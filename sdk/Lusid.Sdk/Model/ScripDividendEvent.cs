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
    /// A scrip dividend issued to shareholders.
    /// </summary>
    [DataContract(Name = "ScripDividendEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class ScripDividendEvent : InstrumentEvent, IEquatable<ScripDividendEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScripDividendEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScripDividendEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScripDividendEvent" /> class.
        /// </summary>
        /// <param name="announcementDate">Date on which the dividend was announced / declared..</param>
        /// <param name="exDate">The first business day on which the dividend is not owed to the buying party.  Typically this is T-1 from the RecordDate..</param>
        /// <param name="recordDate">Date you have to be the holder of record in order to participate in the tender..</param>
        /// <param name="paymentDate">The date the company pays out dividends to shareholders..</param>
        /// <param name="fractionalUnitsCashPrice">The cash price per unit paid in lieu when fractional units can not be distributed..</param>
        /// <param name="fractionalUnitsCashCurrency">The currency of the cash paid in lieu of fractional units..</param>
        /// <param name="unitsRatio">unitsRatio (required).</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent (required) (default to &quot;ScripDividendEvent&quot;).</param>
        public ScripDividendEvent(DateTimeOffset? announcementDate = default(DateTimeOffset?), DateTimeOffset exDate = default(DateTimeOffset), DateTimeOffset? recordDate = default(DateTimeOffset?), DateTimeOffset paymentDate = default(DateTimeOffset), decimal? fractionalUnitsCashPrice = default(decimal?), string fractionalUnitsCashCurrency = default(string), UnitsRatio unitsRatio = default(UnitsRatio), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            // to ensure "unitsRatio" is required (not null)
            if (unitsRatio == null)
            {
                throw new ArgumentNullException("unitsRatio is a required property for ScripDividendEvent and cannot be null");
            }
            this.UnitsRatio = unitsRatio;
            this.AnnouncementDate = announcementDate;
            this.ExDate = exDate;
            this.RecordDate = recordDate;
            this.PaymentDate = paymentDate;
            this.FractionalUnitsCashPrice = fractionalUnitsCashPrice;
            this.FractionalUnitsCashCurrency = fractionalUnitsCashCurrency;
        }

        /// <summary>
        /// Date on which the dividend was announced / declared.
        /// </summary>
        /// <value>Date on which the dividend was announced / declared.</value>
        [DataMember(Name = "announcementDate", EmitDefaultValue = true)]
        public DateTimeOffset? AnnouncementDate { get; set; }

        /// <summary>
        /// The first business day on which the dividend is not owed to the buying party.  Typically this is T-1 from the RecordDate.
        /// </summary>
        /// <value>The first business day on which the dividend is not owed to the buying party.  Typically this is T-1 from the RecordDate.</value>
        [DataMember(Name = "exDate", EmitDefaultValue = false)]
        public DateTimeOffset ExDate { get; set; }

        /// <summary>
        /// Date you have to be the holder of record in order to participate in the tender.
        /// </summary>
        /// <value>Date you have to be the holder of record in order to participate in the tender.</value>
        [DataMember(Name = "recordDate", EmitDefaultValue = true)]
        public DateTimeOffset? RecordDate { get; set; }

        /// <summary>
        /// The date the company pays out dividends to shareholders.
        /// </summary>
        /// <value>The date the company pays out dividends to shareholders.</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// The cash price per unit paid in lieu when fractional units can not be distributed.
        /// </summary>
        /// <value>The cash price per unit paid in lieu when fractional units can not be distributed.</value>
        [DataMember(Name = "fractionalUnitsCashPrice", EmitDefaultValue = true)]
        public decimal? FractionalUnitsCashPrice { get; set; }

        /// <summary>
        /// The currency of the cash paid in lieu of fractional units.
        /// </summary>
        /// <value>The currency of the cash paid in lieu of fractional units.</value>
        [DataMember(Name = "fractionalUnitsCashCurrency", EmitDefaultValue = true)]
        public string FractionalUnitsCashCurrency { get; set; }

        /// <summary>
        /// Gets or Sets UnitsRatio
        /// </summary>
        [DataMember(Name = "unitsRatio", IsRequired = true, EmitDefaultValue = true)]
        public UnitsRatio UnitsRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScripDividendEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AnnouncementDate: ").Append(AnnouncementDate).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  FractionalUnitsCashPrice: ").Append(FractionalUnitsCashPrice).Append("\n");
            sb.Append("  FractionalUnitsCashCurrency: ").Append(FractionalUnitsCashCurrency).Append("\n");
            sb.Append("  UnitsRatio: ").Append(UnitsRatio).Append("\n");
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
            return this.Equals(input as ScripDividendEvent);
        }

        /// <summary>
        /// Returns true if ScripDividendEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ScripDividendEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScripDividendEvent input)
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
                    this.UnitsRatio == input.UnitsRatio ||
                    (this.UnitsRatio != null &&
                    this.UnitsRatio.Equals(input.UnitsRatio))
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
                if (this.FractionalUnitsCashPrice != null)
                {
                    hashCode = (hashCode * 59) + this.FractionalUnitsCashPrice.GetHashCode();
                }
                if (this.FractionalUnitsCashCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.FractionalUnitsCashCurrency.GetHashCode();
                }
                if (this.UnitsRatio != null)
                {
                    hashCode = (hashCode * 59) + this.UnitsRatio.GetHashCode();
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
