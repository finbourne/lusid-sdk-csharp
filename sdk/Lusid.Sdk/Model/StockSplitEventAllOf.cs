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
    /// StockSplitEventAllOf
    /// </summary>
    [DataContract(Name = "StockSplitEvent_allOf")]
    public partial class StockSplitEventAllOf : IEquatable<StockSplitEventAllOf>, IValidatableObject
    {
        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentEventTypeEnum
        {
            /// <summary>
            /// Enum TransitionEvent for value: TransitionEvent
            /// </summary>
            [EnumMember(Value = "TransitionEvent")]
            TransitionEvent = 1,

            /// <summary>
            /// Enum InformationalEvent for value: InformationalEvent
            /// </summary>
            [EnumMember(Value = "InformationalEvent")]
            InformationalEvent = 2,

            /// <summary>
            /// Enum OpenEvent for value: OpenEvent
            /// </summary>
            [EnumMember(Value = "OpenEvent")]
            OpenEvent = 3,

            /// <summary>
            /// Enum CloseEvent for value: CloseEvent
            /// </summary>
            [EnumMember(Value = "CloseEvent")]
            CloseEvent = 4,

            /// <summary>
            /// Enum StockSplitEvent for value: StockSplitEvent
            /// </summary>
            [EnumMember(Value = "StockSplitEvent")]
            StockSplitEvent = 5,

            /// <summary>
            /// Enum BondDefaultEvent for value: BondDefaultEvent
            /// </summary>
            [EnumMember(Value = "BondDefaultEvent")]
            BondDefaultEvent = 6,

            /// <summary>
            /// Enum CashDividendEvent for value: CashDividendEvent
            /// </summary>
            [EnumMember(Value = "CashDividendEvent")]
            CashDividendEvent = 7,

            /// <summary>
            /// Enum AmortisationEvent for value: AmortisationEvent
            /// </summary>
            [EnumMember(Value = "AmortisationEvent")]
            AmortisationEvent = 8,

            /// <summary>
            /// Enum CashFlowEvent for value: CashFlowEvent
            /// </summary>
            [EnumMember(Value = "CashFlowEvent")]
            CashFlowEvent = 9,

            /// <summary>
            /// Enum ExerciseEvent for value: ExerciseEvent
            /// </summary>
            [EnumMember(Value = "ExerciseEvent")]
            ExerciseEvent = 10,

            /// <summary>
            /// Enum ResetEvent for value: ResetEvent
            /// </summary>
            [EnumMember(Value = "ResetEvent")]
            ResetEvent = 11,

            /// <summary>
            /// Enum TriggerEvent for value: TriggerEvent
            /// </summary>
            [EnumMember(Value = "TriggerEvent")]
            TriggerEvent = 12,

            /// <summary>
            /// Enum RawVendorEvent for value: RawVendorEvent
            /// </summary>
            [EnumMember(Value = "RawVendorEvent")]
            RawVendorEvent = 13,

            /// <summary>
            /// Enum InformationalErrorEvent for value: InformationalErrorEvent
            /// </summary>
            [EnumMember(Value = "InformationalErrorEvent")]
            InformationalErrorEvent = 14,

            /// <summary>
            /// Enum BondCouponEvent for value: BondCouponEvent
            /// </summary>
            [EnumMember(Value = "BondCouponEvent")]
            BondCouponEvent = 15,

            /// <summary>
            /// Enum DividendReinvestmentEvent for value: DividendReinvestmentEvent
            /// </summary>
            [EnumMember(Value = "DividendReinvestmentEvent")]
            DividendReinvestmentEvent = 16,

            /// <summary>
            /// Enum AccumulationEvent for value: AccumulationEvent
            /// </summary>
            [EnumMember(Value = "AccumulationEvent")]
            AccumulationEvent = 17,

            /// <summary>
            /// Enum BondPrincipalEvent for value: BondPrincipalEvent
            /// </summary>
            [EnumMember(Value = "BondPrincipalEvent")]
            BondPrincipalEvent = 18,

            /// <summary>
            /// Enum DividendOptionEvent for value: DividendOptionEvent
            /// </summary>
            [EnumMember(Value = "DividendOptionEvent")]
            DividendOptionEvent = 19,

            /// <summary>
            /// Enum MaturityEvent for value: MaturityEvent
            /// </summary>
            [EnumMember(Value = "MaturityEvent")]
            MaturityEvent = 20,

            /// <summary>
            /// Enum FxForwardSettlementEvent for value: FxForwardSettlementEvent
            /// </summary>
            [EnumMember(Value = "FxForwardSettlementEvent")]
            FxForwardSettlementEvent = 21,

            /// <summary>
            /// Enum ExpiryEvent for value: ExpiryEvent
            /// </summary>
            [EnumMember(Value = "ExpiryEvent")]
            ExpiryEvent = 22,

            /// <summary>
            /// Enum ScripDividendEvent for value: ScripDividendEvent
            /// </summary>
            [EnumMember(Value = "ScripDividendEvent")]
            ScripDividendEvent = 23,

            /// <summary>
            /// Enum StockDividendEvent for value: StockDividendEvent
            /// </summary>
            [EnumMember(Value = "StockDividendEvent")]
            StockDividendEvent = 24,

            /// <summary>
            /// Enum ReverseStockSplitEvent for value: ReverseStockSplitEvent
            /// </summary>
            [EnumMember(Value = "ReverseStockSplitEvent")]
            ReverseStockSplitEvent = 25,

            /// <summary>
            /// Enum CapitalDistributionEvent for value: CapitalDistributionEvent
            /// </summary>
            [EnumMember(Value = "CapitalDistributionEvent")]
            CapitalDistributionEvent = 26,

            /// <summary>
            /// Enum SpinOffEvent for value: SpinOffEvent
            /// </summary>
            [EnumMember(Value = "SpinOffEvent")]
            SpinOffEvent = 27,

            /// <summary>
            /// Enum MergerEvent for value: MergerEvent
            /// </summary>
            [EnumMember(Value = "MergerEvent")]
            MergerEvent = 28,

            /// <summary>
            /// Enum FutureExpiryEvent for value: FutureExpiryEvent
            /// </summary>
            [EnumMember(Value = "FutureExpiryEvent")]
            FutureExpiryEvent = 29,

            /// <summary>
            /// Enum SwapCashFlowEvent for value: SwapCashFlowEvent
            /// </summary>
            [EnumMember(Value = "SwapCashFlowEvent")]
            SwapCashFlowEvent = 30,

            /// <summary>
            /// Enum SwapPrincipalEvent for value: SwapPrincipalEvent
            /// </summary>
            [EnumMember(Value = "SwapPrincipalEvent")]
            SwapPrincipalEvent = 31,

            /// <summary>
            /// Enum CreditPremiumCashFlowEvent for value: CreditPremiumCashFlowEvent
            /// </summary>
            [EnumMember(Value = "CreditPremiumCashFlowEvent")]
            CreditPremiumCashFlowEvent = 32,

            /// <summary>
            /// Enum CdsCreditEvent for value: CdsCreditEvent
            /// </summary>
            [EnumMember(Value = "CdsCreditEvent")]
            CdsCreditEvent = 33,

            /// <summary>
            /// Enum CdxCreditEvent for value: CdxCreditEvent
            /// </summary>
            [EnumMember(Value = "CdxCreditEvent")]
            CdxCreditEvent = 34,

            /// <summary>
            /// Enum MbsCouponEvent for value: MbsCouponEvent
            /// </summary>
            [EnumMember(Value = "MbsCouponEvent")]
            MbsCouponEvent = 35,

            /// <summary>
            /// Enum MbsPrincipalEvent for value: MbsPrincipalEvent
            /// </summary>
            [EnumMember(Value = "MbsPrincipalEvent")]
            MbsPrincipalEvent = 36,

            /// <summary>
            /// Enum BonusIssueEvent for value: BonusIssueEvent
            /// </summary>
            [EnumMember(Value = "BonusIssueEvent")]
            BonusIssueEvent = 37,

            /// <summary>
            /// Enum MbsPrincipalWriteOffEvent for value: MbsPrincipalWriteOffEvent
            /// </summary>
            [EnumMember(Value = "MbsPrincipalWriteOffEvent")]
            MbsPrincipalWriteOffEvent = 38,

            /// <summary>
            /// Enum MbsInterestDeferralEvent for value: MbsInterestDeferralEvent
            /// </summary>
            [EnumMember(Value = "MbsInterestDeferralEvent")]
            MbsInterestDeferralEvent = 39,

            /// <summary>
            /// Enum MbsInterestShortfallEvent for value: MbsInterestShortfallEvent
            /// </summary>
            [EnumMember(Value = "MbsInterestShortfallEvent")]
            MbsInterestShortfallEvent = 40,

            /// <summary>
            /// Enum TenderEvent for value: TenderEvent
            /// </summary>
            [EnumMember(Value = "TenderEvent")]
            TenderEvent = 41,

            /// <summary>
            /// Enum CallOnIntermediateSecuritiesEvent for value: CallOnIntermediateSecuritiesEvent
            /// </summary>
            [EnumMember(Value = "CallOnIntermediateSecuritiesEvent")]
            CallOnIntermediateSecuritiesEvent = 42,

            /// <summary>
            /// Enum IntermediateSecuritiesDistributionEvent for value: IntermediateSecuritiesDistributionEvent
            /// </summary>
            [EnumMember(Value = "IntermediateSecuritiesDistributionEvent")]
            IntermediateSecuritiesDistributionEvent = 43,

            /// <summary>
            /// Enum OptionExercisePhysicalEvent for value: OptionExercisePhysicalEvent
            /// </summary>
            [EnumMember(Value = "OptionExercisePhysicalEvent")]
            OptionExercisePhysicalEvent = 44,

            /// <summary>
            /// Enum OptionExerciseCashEvent for value: OptionExerciseCashEvent
            /// </summary>
            [EnumMember(Value = "OptionExerciseCashEvent")]
            OptionExerciseCashEvent = 45,

            /// <summary>
            /// Enum ProtectionPayoutCashFlowEvent for value: ProtectionPayoutCashFlowEvent
            /// </summary>
            [EnumMember(Value = "ProtectionPayoutCashFlowEvent")]
            ProtectionPayoutCashFlowEvent = 46

        }


        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent</value>
        [DataMember(Name = "instrumentEventType", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentEventTypeEnum InstrumentEventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StockSplitEventAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StockSplitEventAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StockSplitEventAllOf" /> class.
        /// </summary>
        /// <param name="paymentDate">Date on which the stock split takes effect. (required).</param>
        /// <param name="exDate">The first date on which the shares will trade at the post-split price. (required).</param>
        /// <param name="unitsRatio">unitsRatio (required).</param>
        /// <param name="recordDate">Date you have to be the holder of record in order to receive the additional shares..</param>
        /// <param name="announcementDate">Date the stock split was announced..</param>
        /// <param name="fractionalUnitsCashPrice">The cash price per unit paid in lieu when fractional units can not be distributed..</param>
        /// <param name="fractionalUnitsCashCurrency">The currency of the cash paid in lieu of fractional units..</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent (required).</param>
        public StockSplitEventAllOf(DateTimeOffset paymentDate = default(DateTimeOffset), DateTimeOffset exDate = default(DateTimeOffset), UnitsRatio unitsRatio = default(UnitsRatio), DateTimeOffset? recordDate = default(DateTimeOffset?), DateTimeOffset? announcementDate = default(DateTimeOffset?), decimal? fractionalUnitsCashPrice = default(decimal?), string fractionalUnitsCashCurrency = default(string), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum))
        {
            this.PaymentDate = paymentDate;
            this.ExDate = exDate;
            // to ensure "unitsRatio" is required (not null)
            if (unitsRatio == null)
            {
                throw new ArgumentNullException("unitsRatio is a required property for StockSplitEventAllOf and cannot be null");
            }
            this.UnitsRatio = unitsRatio;
            this.InstrumentEventType = instrumentEventType;
            this.RecordDate = recordDate;
            this.AnnouncementDate = announcementDate;
            this.FractionalUnitsCashPrice = fractionalUnitsCashPrice;
            this.FractionalUnitsCashCurrency = fractionalUnitsCashCurrency;
        }

        /// <summary>
        /// Date on which the stock split takes effect.
        /// </summary>
        /// <value>Date on which the stock split takes effect.</value>
        [DataMember(Name = "paymentDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// The first date on which the shares will trade at the post-split price.
        /// </summary>
        /// <value>The first date on which the shares will trade at the post-split price.</value>
        [DataMember(Name = "exDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset ExDate { get; set; }

        /// <summary>
        /// Gets or Sets UnitsRatio
        /// </summary>
        [DataMember(Name = "unitsRatio", IsRequired = true, EmitDefaultValue = true)]
        public UnitsRatio UnitsRatio { get; set; }

        /// <summary>
        /// Date you have to be the holder of record in order to receive the additional shares.
        /// </summary>
        /// <value>Date you have to be the holder of record in order to receive the additional shares.</value>
        [DataMember(Name = "recordDate", EmitDefaultValue = true)]
        public DateTimeOffset? RecordDate { get; set; }

        /// <summary>
        /// Date the stock split was announced.
        /// </summary>
        /// <value>Date the stock split was announced.</value>
        [DataMember(Name = "announcementDate", EmitDefaultValue = true)]
        public DateTimeOffset? AnnouncementDate { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StockSplitEventAllOf {\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  UnitsRatio: ").Append(UnitsRatio).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
            sb.Append("  AnnouncementDate: ").Append(AnnouncementDate).Append("\n");
            sb.Append("  FractionalUnitsCashPrice: ").Append(FractionalUnitsCashPrice).Append("\n");
            sb.Append("  FractionalUnitsCashCurrency: ").Append(FractionalUnitsCashCurrency).Append("\n");
            sb.Append("  InstrumentEventType: ").Append(InstrumentEventType).Append("\n");
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
            return this.Equals(input as StockSplitEventAllOf);
        }

        /// <summary>
        /// Returns true if StockSplitEventAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of StockSplitEventAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StockSplitEventAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.ExDate == input.ExDate ||
                    (this.ExDate != null &&
                    this.ExDate.Equals(input.ExDate))
                ) && 
                (
                    this.UnitsRatio == input.UnitsRatio ||
                    (this.UnitsRatio != null &&
                    this.UnitsRatio.Equals(input.UnitsRatio))
                ) && 
                (
                    this.RecordDate == input.RecordDate ||
                    (this.RecordDate != null &&
                    this.RecordDate.Equals(input.RecordDate))
                ) && 
                (
                    this.AnnouncementDate == input.AnnouncementDate ||
                    (this.AnnouncementDate != null &&
                    this.AnnouncementDate.Equals(input.AnnouncementDate))
                ) && 
                (
                    this.FractionalUnitsCashPrice == input.FractionalUnitsCashPrice ||
                    (this.FractionalUnitsCashPrice != null &&
                    this.FractionalUnitsCashPrice.Equals(input.FractionalUnitsCashPrice))
                ) && 
                (
                    this.FractionalUnitsCashCurrency == input.FractionalUnitsCashCurrency ||
                    (this.FractionalUnitsCashCurrency != null &&
                    this.FractionalUnitsCashCurrency.Equals(input.FractionalUnitsCashCurrency))
                ) && 
                (
                    this.InstrumentEventType == input.InstrumentEventType ||
                    this.InstrumentEventType.Equals(input.InstrumentEventType)
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
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                if (this.ExDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExDate.GetHashCode();
                }
                if (this.UnitsRatio != null)
                {
                    hashCode = (hashCode * 59) + this.UnitsRatio.GetHashCode();
                }
                if (this.RecordDate != null)
                {
                    hashCode = (hashCode * 59) + this.RecordDate.GetHashCode();
                }
                if (this.AnnouncementDate != null)
                {
                    hashCode = (hashCode * 59) + this.AnnouncementDate.GetHashCode();
                }
                if (this.FractionalUnitsCashPrice != null)
                {
                    hashCode = (hashCode * 59) + this.FractionalUnitsCashPrice.GetHashCode();
                }
                if (this.FractionalUnitsCashCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.FractionalUnitsCashCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InstrumentEventType.GetHashCode();
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
