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
    /// Base class for representing instrument events in LUSID, such as dividends, stock splits, and option exercises.  This base class should not be directly instantiated; each supported InstrumentEventType has a corresponding inherited class.
    /// </summary>
    [DataContract(Name = "InstrumentEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    [JsonSubtypes.KnownSubType(typeof(AccumulationEvent), "AccumulationEvent")]
    [JsonSubtypes.KnownSubType(typeof(AmortisationEvent), "AmortisationEvent")]
    [JsonSubtypes.KnownSubType(typeof(BondCouponEvent), "BondCouponEvent")]
    [JsonSubtypes.KnownSubType(typeof(BondDefaultEvent), "BondDefaultEvent")]
    [JsonSubtypes.KnownSubType(typeof(BondPrincipalEvent), "BondPrincipalEvent")]
    [JsonSubtypes.KnownSubType(typeof(CapitalDistributionEvent), "CapitalDistributionEvent")]
    [JsonSubtypes.KnownSubType(typeof(CashDividendEvent), "CashDividendEvent")]
    [JsonSubtypes.KnownSubType(typeof(CashFlowEvent), "CashFlowEvent")]
    [JsonSubtypes.KnownSubType(typeof(CloseEvent), "CloseEvent")]
    [JsonSubtypes.KnownSubType(typeof(DividendOptionEvent), "DividendOptionEvent")]
    [JsonSubtypes.KnownSubType(typeof(DividendReinvestmentEvent), "DividendReinvestmentEvent")]
    [JsonSubtypes.KnownSubType(typeof(ExerciseEvent), "ExerciseEvent")]
    [JsonSubtypes.KnownSubType(typeof(ExpiryEvent), "ExpiryEvent")]
    [JsonSubtypes.KnownSubType(typeof(FutureExpiryEvent), "FutureExpiryEvent")]
    [JsonSubtypes.KnownSubType(typeof(FxForwardSettlementEvent), "FxForwardSettlementEvent")]
    [JsonSubtypes.KnownSubType(typeof(InformationalErrorEvent), "InformationalErrorEvent")]
    [JsonSubtypes.KnownSubType(typeof(InformationalEvent), "InformationalEvent")]
    [JsonSubtypes.KnownSubType(typeof(MaturityEvent), "MaturityEvent")]
    [JsonSubtypes.KnownSubType(typeof(MergerEvent), "MergerEvent")]
    [JsonSubtypes.KnownSubType(typeof(OpenEvent), "OpenEvent")]
    [JsonSubtypes.KnownSubType(typeof(RawVendorEvent), "RawVendorEvent")]
    [JsonSubtypes.KnownSubType(typeof(ResetEvent), "ResetEvent")]
    [JsonSubtypes.KnownSubType(typeof(ReverseStockSplitEvent), "ReverseStockSplitEvent")]
    [JsonSubtypes.KnownSubType(typeof(ScripDividendEvent), "ScripDividendEvent")]
    [JsonSubtypes.KnownSubType(typeof(SpinOffEvent), "SpinOffEvent")]
    [JsonSubtypes.KnownSubType(typeof(StockDividendEvent), "StockDividendEvent")]
    [JsonSubtypes.KnownSubType(typeof(StockSplitEvent), "StockSplitEvent")]
    [JsonSubtypes.KnownSubType(typeof(SwapCashFlowEvent), "SwapCashFlowEvent")]
    [JsonSubtypes.KnownSubType(typeof(SwapPrincipalEvent), "SwapPrincipalEvent")]
    [JsonSubtypes.KnownSubType(typeof(TransitionEvent), "TransitionEvent")]
    [JsonSubtypes.KnownSubType(typeof(TriggerEvent), "TriggerEvent")]
    public partial class InstrumentEvent : IEquatable<InstrumentEvent>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="InstrumentEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstrumentEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentEvent" /> class.
        /// </summary>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent (required).</param>
        public InstrumentEvent(InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum))
        {
            this.InstrumentEventType = instrumentEventType;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstrumentEvent {\n");
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
            return this.Equals(input as InstrumentEvent);
        }

        /// <summary>
        /// Returns true if InstrumentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
