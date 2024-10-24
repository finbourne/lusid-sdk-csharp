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
    /// FxForwardSettlementEventAllOf
    /// </summary>
    [DataContract(Name = "FxForwardSettlementEvent_allOf")]
    public partial class FxForwardSettlementEventAllOf : IEquatable<FxForwardSettlementEventAllOf>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="FxForwardSettlementEventAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxForwardSettlementEventAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForwardSettlementEventAllOf" /> class.
        /// </summary>
        /// <param name="maturityDate">Maturity date of the forward (required).</param>
        /// <param name="domAmountPerUnit">Amount per unit in the DomCcy (domestic currency) (required).</param>
        /// <param name="domCcy">The domestic currency of the forward (required).</param>
        /// <param name="fgnAmountPerUnit">Amount per unit in the FgnCcy (foreign currency) (required).</param>
        /// <param name="fgnCcy">The foreign currency of the forward. (required).</param>
        /// <param name="isNdf">Is this settlement corresponding to a deliverable forward, or an NDF (required).</param>
        /// <param name="fixingDate">Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  Date of the FxRate fixings..</param>
        /// <param name="settlementCcy">Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  May be set to either DomCcy or FgnCcy, or a third currency..</param>
        /// <param name="cashFlowPerUnit">Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  CashFlow per unit.  Paid in the SettlementCcy..</param>
        /// <param name="domesticToForeignRate">Domestic currency to foreign currency FX rate.  Not required, only used to override quotes..</param>
        /// <param name="domesticToSettlementRate">Domestic currency to settlement currency FX rate  Not required, only used to override quotes..</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent (required).</param>
        public FxForwardSettlementEventAllOf(DateTimeOffset maturityDate = default(DateTimeOffset), decimal domAmountPerUnit = default(decimal), string domCcy = default(string), decimal fgnAmountPerUnit = default(decimal), string fgnCcy = default(string), bool isNdf = default(bool), DateTimeOffset? fixingDate = default(DateTimeOffset?), string settlementCcy = default(string), decimal? cashFlowPerUnit = default(decimal?), decimal? domesticToForeignRate = default(decimal?), decimal? domesticToSettlementRate = default(decimal?), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum))
        {
            this.MaturityDate = maturityDate;
            this.DomAmountPerUnit = domAmountPerUnit;
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new ArgumentNullException("domCcy is a required property for FxForwardSettlementEventAllOf and cannot be null");
            }
            this.DomCcy = domCcy;
            this.FgnAmountPerUnit = fgnAmountPerUnit;
            // to ensure "fgnCcy" is required (not null)
            if (fgnCcy == null)
            {
                throw new ArgumentNullException("fgnCcy is a required property for FxForwardSettlementEventAllOf and cannot be null");
            }
            this.FgnCcy = fgnCcy;
            this.IsNdf = isNdf;
            this.InstrumentEventType = instrumentEventType;
            this.FixingDate = fixingDate;
            this.SettlementCcy = settlementCcy;
            this.CashFlowPerUnit = cashFlowPerUnit;
            this.DomesticToForeignRate = domesticToForeignRate;
            this.DomesticToSettlementRate = domesticToSettlementRate;
        }

        /// <summary>
        /// Maturity date of the forward
        /// </summary>
        /// <value>Maturity date of the forward</value>
        [DataMember(Name = "maturityDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset MaturityDate { get; set; }

        /// <summary>
        /// Amount per unit in the DomCcy (domestic currency)
        /// </summary>
        /// <value>Amount per unit in the DomCcy (domestic currency)</value>
        [DataMember(Name = "domAmountPerUnit", IsRequired = true, EmitDefaultValue = true)]
        public decimal DomAmountPerUnit { get; set; }

        /// <summary>
        /// The domestic currency of the forward
        /// </summary>
        /// <value>The domestic currency of the forward</value>
        [DataMember(Name = "domCcy", IsRequired = true, EmitDefaultValue = true)]
        public string DomCcy { get; set; }

        /// <summary>
        /// Amount per unit in the FgnCcy (foreign currency)
        /// </summary>
        /// <value>Amount per unit in the FgnCcy (foreign currency)</value>
        [DataMember(Name = "fgnAmountPerUnit", IsRequired = true, EmitDefaultValue = true)]
        public decimal FgnAmountPerUnit { get; set; }

        /// <summary>
        /// The foreign currency of the forward.
        /// </summary>
        /// <value>The foreign currency of the forward.</value>
        [DataMember(Name = "fgnCcy", IsRequired = true, EmitDefaultValue = true)]
        public string FgnCcy { get; set; }

        /// <summary>
        /// Is this settlement corresponding to a deliverable forward, or an NDF
        /// </summary>
        /// <value>Is this settlement corresponding to a deliverable forward, or an NDF</value>
        [DataMember(Name = "isNdf", IsRequired = true, EmitDefaultValue = true)]
        public bool IsNdf { get; set; }

        /// <summary>
        /// Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  Date of the FxRate fixings.
        /// </summary>
        /// <value>Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  Date of the FxRate fixings.</value>
        [DataMember(Name = "fixingDate", EmitDefaultValue = true)]
        public DateTimeOffset? FixingDate { get; set; }

        /// <summary>
        /// Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  May be set to either DomCcy or FgnCcy, or a third currency.
        /// </summary>
        /// <value>Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  May be set to either DomCcy or FgnCcy, or a third currency.</value>
        [DataMember(Name = "settlementCcy", EmitDefaultValue = true)]
        public string SettlementCcy { get; set; }

        /// <summary>
        /// Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  CashFlow per unit.  Paid in the SettlementCcy.
        /// </summary>
        /// <value>Optional.  Required if the event is an NDF (i.e. if IsNdf &#x3D; true).  CashFlow per unit.  Paid in the SettlementCcy.</value>
        [DataMember(Name = "cashFlowPerUnit", EmitDefaultValue = true)]
        public decimal? CashFlowPerUnit { get; set; }

        /// <summary>
        /// Domestic currency to foreign currency FX rate.  Not required, only used to override quotes.
        /// </summary>
        /// <value>Domestic currency to foreign currency FX rate.  Not required, only used to override quotes.</value>
        [DataMember(Name = "domesticToForeignRate", EmitDefaultValue = true)]
        public decimal? DomesticToForeignRate { get; set; }

        /// <summary>
        /// Domestic currency to settlement currency FX rate  Not required, only used to override quotes.
        /// </summary>
        /// <value>Domestic currency to settlement currency FX rate  Not required, only used to override quotes.</value>
        [DataMember(Name = "domesticToSettlementRate", EmitDefaultValue = true)]
        public decimal? DomesticToSettlementRate { get; set; }

        /// <summary>
        /// Foreign currency to settlement currency FX rate  Not required, only used to override quotes.
        /// </summary>
        /// <value>Foreign currency to settlement currency FX rate  Not required, only used to override quotes.</value>
        [DataMember(Name = "foreignToSettlementRate", EmitDefaultValue = true)]
        public decimal? ForeignToSettlementRate { get; private set; }

        /// <summary>
        /// Returns false as ForeignToSettlementRate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeForeignToSettlementRate()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FxForwardSettlementEventAllOf {\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  DomAmountPerUnit: ").Append(DomAmountPerUnit).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  FgnAmountPerUnit: ").Append(FgnAmountPerUnit).Append("\n");
            sb.Append("  FgnCcy: ").Append(FgnCcy).Append("\n");
            sb.Append("  IsNdf: ").Append(IsNdf).Append("\n");
            sb.Append("  FixingDate: ").Append(FixingDate).Append("\n");
            sb.Append("  SettlementCcy: ").Append(SettlementCcy).Append("\n");
            sb.Append("  CashFlowPerUnit: ").Append(CashFlowPerUnit).Append("\n");
            sb.Append("  DomesticToForeignRate: ").Append(DomesticToForeignRate).Append("\n");
            sb.Append("  DomesticToSettlementRate: ").Append(DomesticToSettlementRate).Append("\n");
            sb.Append("  ForeignToSettlementRate: ").Append(ForeignToSettlementRate).Append("\n");
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
            return this.Equals(input as FxForwardSettlementEventAllOf);
        }

        /// <summary>
        /// Returns true if FxForwardSettlementEventAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of FxForwardSettlementEventAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxForwardSettlementEventAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && 
                (
                    this.DomAmountPerUnit == input.DomAmountPerUnit ||
                    this.DomAmountPerUnit.Equals(input.DomAmountPerUnit)
                ) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && 
                (
                    this.FgnAmountPerUnit == input.FgnAmountPerUnit ||
                    this.FgnAmountPerUnit.Equals(input.FgnAmountPerUnit)
                ) && 
                (
                    this.FgnCcy == input.FgnCcy ||
                    (this.FgnCcy != null &&
                    this.FgnCcy.Equals(input.FgnCcy))
                ) && 
                (
                    this.IsNdf == input.IsNdf ||
                    this.IsNdf.Equals(input.IsNdf)
                ) && 
                (
                    this.FixingDate == input.FixingDate ||
                    (this.FixingDate != null &&
                    this.FixingDate.Equals(input.FixingDate))
                ) && 
                (
                    this.SettlementCcy == input.SettlementCcy ||
                    (this.SettlementCcy != null &&
                    this.SettlementCcy.Equals(input.SettlementCcy))
                ) && 
                (
                    this.CashFlowPerUnit == input.CashFlowPerUnit ||
                    (this.CashFlowPerUnit != null &&
                    this.CashFlowPerUnit.Equals(input.CashFlowPerUnit))
                ) && 
                (
                    this.DomesticToForeignRate == input.DomesticToForeignRate ||
                    (this.DomesticToForeignRate != null &&
                    this.DomesticToForeignRate.Equals(input.DomesticToForeignRate))
                ) && 
                (
                    this.DomesticToSettlementRate == input.DomesticToSettlementRate ||
                    (this.DomesticToSettlementRate != null &&
                    this.DomesticToSettlementRate.Equals(input.DomesticToSettlementRate))
                ) && 
                (
                    this.ForeignToSettlementRate == input.ForeignToSettlementRate ||
                    (this.ForeignToSettlementRate != null &&
                    this.ForeignToSettlementRate.Equals(input.ForeignToSettlementRate))
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
                if (this.MaturityDate != null)
                {
                    hashCode = (hashCode * 59) + this.MaturityDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DomAmountPerUnit.GetHashCode();
                if (this.DomCcy != null)
                {
                    hashCode = (hashCode * 59) + this.DomCcy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FgnAmountPerUnit.GetHashCode();
                if (this.FgnCcy != null)
                {
                    hashCode = (hashCode * 59) + this.FgnCcy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsNdf.GetHashCode();
                if (this.FixingDate != null)
                {
                    hashCode = (hashCode * 59) + this.FixingDate.GetHashCode();
                }
                if (this.SettlementCcy != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementCcy.GetHashCode();
                }
                if (this.CashFlowPerUnit != null)
                {
                    hashCode = (hashCode * 59) + this.CashFlowPerUnit.GetHashCode();
                }
                if (this.DomesticToForeignRate != null)
                {
                    hashCode = (hashCode * 59) + this.DomesticToForeignRate.GetHashCode();
                }
                if (this.DomesticToSettlementRate != null)
                {
                    hashCode = (hashCode * 59) + this.DomesticToSettlementRate.GetHashCode();
                }
                if (this.ForeignToSettlementRate != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignToSettlementRate.GetHashCode();
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
