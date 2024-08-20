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
    /// SpinOffEventAllOf
    /// </summary>
    [DataContract(Name = "SpinOffEvent_allOf")]
    public partial class SpinOffEventAllOf : IEquatable<SpinOffEventAllOf>, IValidatableObject
    {
        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent</value>
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
            SwapPrincipalEvent = 31

        }


        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent</value>
        [DataMember(Name = "instrumentEventType", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentEventTypeEnum InstrumentEventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpinOffEventAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpinOffEventAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpinOffEventAllOf" /> class.
        /// </summary>
        /// <param name="announcementDate">Optional.  The date the spin-off is announced..</param>
        /// <param name="exDate">The first date on which the holder of record has entitled ownership of the new shares. (required).</param>
        /// <param name="recordDate">Optional.  Date you have to be the holder of record in order to receive the additional shares..</param>
        /// <param name="paymentDate">Date on which the distribution of shares takes place. (required).</param>
        /// <param name="newInstrument">newInstrument (required).</param>
        /// <param name="unitsRatio">unitsRatio (required).</param>
        /// <param name="costFactor">Optional. The fraction of cost that is transferred from the existing shares to the new shares..</param>
        /// <param name="fractionalUnitsCashPrice">Optional. Used in calculating cash-in-lieu of fractional shares..</param>
        /// <param name="fractionalUnitsCashCurrency">Optional. Used in calculating cash-in-lieu of fractional shares..</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent (required).</param>
        public SpinOffEventAllOf(DateTimeOffset? announcementDate = default(DateTimeOffset?), DateTimeOffset exDate = default(DateTimeOffset), DateTimeOffset? recordDate = default(DateTimeOffset?), DateTimeOffset paymentDate = default(DateTimeOffset), NewInstrument newInstrument = default(NewInstrument), UnitsRatio unitsRatio = default(UnitsRatio), decimal? costFactor = default(decimal?), decimal? fractionalUnitsCashPrice = default(decimal?), string fractionalUnitsCashCurrency = default(string), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum))
        {
            this.ExDate = exDate;
            this.PaymentDate = paymentDate;
            // to ensure "newInstrument" is required (not null)
            if (newInstrument == null)
            {
                throw new ArgumentNullException("newInstrument is a required property for SpinOffEventAllOf and cannot be null");
            }
            this.NewInstrument = newInstrument;
            // to ensure "unitsRatio" is required (not null)
            if (unitsRatio == null)
            {
                throw new ArgumentNullException("unitsRatio is a required property for SpinOffEventAllOf and cannot be null");
            }
            this.UnitsRatio = unitsRatio;
            this.InstrumentEventType = instrumentEventType;
            this.AnnouncementDate = announcementDate;
            this.RecordDate = recordDate;
            this.CostFactor = costFactor;
            this.FractionalUnitsCashPrice = fractionalUnitsCashPrice;
            this.FractionalUnitsCashCurrency = fractionalUnitsCashCurrency;
        }

        /// <summary>
        /// Optional.  The date the spin-off is announced.
        /// </summary>
        /// <value>Optional.  The date the spin-off is announced.</value>
        [DataMember(Name = "announcementDate", EmitDefaultValue = true)]
        public DateTimeOffset? AnnouncementDate { get; set; }

        /// <summary>
        /// The first date on which the holder of record has entitled ownership of the new shares.
        /// </summary>
        /// <value>The first date on which the holder of record has entitled ownership of the new shares.</value>
        [DataMember(Name = "exDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset ExDate { get; set; }

        /// <summary>
        /// Optional.  Date you have to be the holder of record in order to receive the additional shares.
        /// </summary>
        /// <value>Optional.  Date you have to be the holder of record in order to receive the additional shares.</value>
        [DataMember(Name = "recordDate", EmitDefaultValue = true)]
        public DateTimeOffset? RecordDate { get; set; }

        /// <summary>
        /// Date on which the distribution of shares takes place.
        /// </summary>
        /// <value>Date on which the distribution of shares takes place.</value>
        [DataMember(Name = "paymentDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets NewInstrument
        /// </summary>
        [DataMember(Name = "newInstrument", IsRequired = true, EmitDefaultValue = true)]
        public NewInstrument NewInstrument { get; set; }

        /// <summary>
        /// Gets or Sets UnitsRatio
        /// </summary>
        [DataMember(Name = "unitsRatio", IsRequired = true, EmitDefaultValue = true)]
        public UnitsRatio UnitsRatio { get; set; }

        /// <summary>
        /// Optional. The fraction of cost that is transferred from the existing shares to the new shares.
        /// </summary>
        /// <value>Optional. The fraction of cost that is transferred from the existing shares to the new shares.</value>
        [DataMember(Name = "costFactor", EmitDefaultValue = true)]
        public decimal? CostFactor { get; set; }

        /// <summary>
        /// Optional. Used in calculating cash-in-lieu of fractional shares.
        /// </summary>
        /// <value>Optional. Used in calculating cash-in-lieu of fractional shares.</value>
        [DataMember(Name = "fractionalUnitsCashPrice", EmitDefaultValue = true)]
        public decimal? FractionalUnitsCashPrice { get; set; }

        /// <summary>
        /// Optional. Used in calculating cash-in-lieu of fractional shares.
        /// </summary>
        /// <value>Optional. Used in calculating cash-in-lieu of fractional shares.</value>
        [DataMember(Name = "fractionalUnitsCashCurrency", EmitDefaultValue = true)]
        public string FractionalUnitsCashCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpinOffEventAllOf {\n");
            sb.Append("  AnnouncementDate: ").Append(AnnouncementDate).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  NewInstrument: ").Append(NewInstrument).Append("\n");
            sb.Append("  UnitsRatio: ").Append(UnitsRatio).Append("\n");
            sb.Append("  CostFactor: ").Append(CostFactor).Append("\n");
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
            return this.Equals(input as SpinOffEventAllOf);
        }

        /// <summary>
        /// Returns true if SpinOffEventAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SpinOffEventAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpinOffEventAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AnnouncementDate == input.AnnouncementDate ||
                    (this.AnnouncementDate != null &&
                    this.AnnouncementDate.Equals(input.AnnouncementDate))
                ) && 
                (
                    this.ExDate == input.ExDate ||
                    (this.ExDate != null &&
                    this.ExDate.Equals(input.ExDate))
                ) && 
                (
                    this.RecordDate == input.RecordDate ||
                    (this.RecordDate != null &&
                    this.RecordDate.Equals(input.RecordDate))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.NewInstrument == input.NewInstrument ||
                    (this.NewInstrument != null &&
                    this.NewInstrument.Equals(input.NewInstrument))
                ) && 
                (
                    this.UnitsRatio == input.UnitsRatio ||
                    (this.UnitsRatio != null &&
                    this.UnitsRatio.Equals(input.UnitsRatio))
                ) && 
                (
                    this.CostFactor == input.CostFactor ||
                    (this.CostFactor != null &&
                    this.CostFactor.Equals(input.CostFactor))
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
                if (this.UnitsRatio != null)
                {
                    hashCode = (hashCode * 59) + this.UnitsRatio.GetHashCode();
                }
                if (this.CostFactor != null)
                {
                    hashCode = (hashCode * 59) + this.CostFactor.GetHashCode();
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
