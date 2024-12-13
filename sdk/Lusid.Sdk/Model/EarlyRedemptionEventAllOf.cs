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
    /// EarlyRedemptionEventAllOf
    /// </summary>
    [DataContract(Name = "EarlyRedemptionEvent_allOf")]
    public partial class EarlyRedemptionEventAllOf : IEquatable<EarlyRedemptionEventAllOf>, IValidatableObject
    {
        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent</value>
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
            ProtectionPayoutCashFlowEvent = 46,

            /// <summary>
            /// Enum TermDepositInterestEvent for value: TermDepositInterestEvent
            /// </summary>
            [EnumMember(Value = "TermDepositInterestEvent")]
            TermDepositInterestEvent = 47,

            /// <summary>
            /// Enum TermDepositPrincipalEvent for value: TermDepositPrincipalEvent
            /// </summary>
            [EnumMember(Value = "TermDepositPrincipalEvent")]
            TermDepositPrincipalEvent = 48,

            /// <summary>
            /// Enum EarlyRedemptionEvent for value: EarlyRedemptionEvent
            /// </summary>
            [EnumMember(Value = "EarlyRedemptionEvent")]
            EarlyRedemptionEvent = 49,

            /// <summary>
            /// Enum FutureMarkToMarketEvent for value: FutureMarkToMarketEvent
            /// </summary>
            [EnumMember(Value = "FutureMarkToMarketEvent")]
            FutureMarkToMarketEvent = 50,

            /// <summary>
            /// Enum AdjustGlobalCommitmentEvent for value: AdjustGlobalCommitmentEvent
            /// </summary>
            [EnumMember(Value = "AdjustGlobalCommitmentEvent")]
            AdjustGlobalCommitmentEvent = 51,

            /// <summary>
            /// Enum ContractInitialisationEvent for value: ContractInitialisationEvent
            /// </summary>
            [EnumMember(Value = "ContractInitialisationEvent")]
            ContractInitialisationEvent = 52,

            /// <summary>
            /// Enum DrawdownEvent for value: DrawdownEvent
            /// </summary>
            [EnumMember(Value = "DrawdownEvent")]
            DrawdownEvent = 53,

            /// <summary>
            /// Enum LoanInterestRepaymentEvent for value: LoanInterestRepaymentEvent
            /// </summary>
            [EnumMember(Value = "LoanInterestRepaymentEvent")]
            LoanInterestRepaymentEvent = 54

        }


        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent</value>
        [DataMember(Name = "instrumentEventType", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentEventTypeEnum InstrumentEventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EarlyRedemptionEventAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EarlyRedemptionEventAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EarlyRedemptionEventAllOf" /> class.
        /// </summary>
        /// <param name="effectiveDate">Date of redemption.  For internally generated European callables, this is set to the exercise date.  For internally generated American callables, this is set to the start of the exercise period..</param>
        /// <param name="currency">Currency of the redemption. (required).</param>
        /// <param name="earlyRedemptionElections">EarlyRedemptionElection for the redemption.  Used to trigger the redemption. (required).</param>
        /// <param name="redemptionPercentage">Percentage of the original issue that is redeemed, where 0.5 implies 50%.  Defaults to 1 if not set.  Must be between 0 and 1..</param>
        /// <param name="pricePerUnit">The price, or strike, that each unit is redeemed at..</param>
        /// <param name="accruedInterestPerUnit">Unpaid accrued interest also repaid as part of the redemption, per unit.  Optional field.  If left empty, will be resolved internally by calculating the accrued owed on the EffectiveDate.  This process may require additional market data..</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent (required).</param>
        public EarlyRedemptionEventAllOf(DateTimeOffset? effectiveDate = default(DateTimeOffset?), string currency = default(string), List<EarlyRedemptionElection> earlyRedemptionElections = default(List<EarlyRedemptionElection>), decimal redemptionPercentage = default(decimal), decimal? pricePerUnit = default(decimal?), decimal? accruedInterestPerUnit = default(decimal?), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for EarlyRedemptionEventAllOf and cannot be null");
            }
            this.Currency = currency;
            // to ensure "earlyRedemptionElections" is required (not null)
            if (earlyRedemptionElections == null)
            {
                throw new ArgumentNullException("earlyRedemptionElections is a required property for EarlyRedemptionEventAllOf and cannot be null");
            }
            this.EarlyRedemptionElections = earlyRedemptionElections;
            this.InstrumentEventType = instrumentEventType;
            this.EffectiveDate = effectiveDate;
            this.RedemptionPercentage = redemptionPercentage;
            this.PricePerUnit = pricePerUnit;
            this.AccruedInterestPerUnit = accruedInterestPerUnit;
        }

        /// <summary>
        /// Date of redemption.  For internally generated European callables, this is set to the exercise date.  For internally generated American callables, this is set to the start of the exercise period.
        /// </summary>
        /// <value>Date of redemption.  For internally generated European callables, this is set to the exercise date.  For internally generated American callables, this is set to the start of the exercise period.</value>
        [DataMember(Name = "effectiveDate", EmitDefaultValue = true)]
        public DateTimeOffset? EffectiveDate { get; set; }

        /// <summary>
        /// Currency of the redemption.
        /// </summary>
        /// <value>Currency of the redemption.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// EarlyRedemptionElection for the redemption.  Used to trigger the redemption.
        /// </summary>
        /// <value>EarlyRedemptionElection for the redemption.  Used to trigger the redemption.</value>
        [DataMember(Name = "earlyRedemptionElections", IsRequired = true, EmitDefaultValue = true)]
        public List<EarlyRedemptionElection> EarlyRedemptionElections { get; set; }

        /// <summary>
        /// Percentage of the original issue that is redeemed, where 0.5 implies 50%.  Defaults to 1 if not set.  Must be between 0 and 1.
        /// </summary>
        /// <value>Percentage of the original issue that is redeemed, where 0.5 implies 50%.  Defaults to 1 if not set.  Must be between 0 and 1.</value>
        [DataMember(Name = "redemptionPercentage", EmitDefaultValue = true)]
        public decimal RedemptionPercentage { get; set; }

        /// <summary>
        /// The price, or strike, that each unit is redeemed at.
        /// </summary>
        /// <value>The price, or strike, that each unit is redeemed at.</value>
        [DataMember(Name = "pricePerUnit", EmitDefaultValue = true)]
        public decimal? PricePerUnit { get; set; }

        /// <summary>
        /// Unpaid accrued interest also repaid as part of the redemption, per unit.  Optional field.  If left empty, will be resolved internally by calculating the accrued owed on the EffectiveDate.  This process may require additional market data.
        /// </summary>
        /// <value>Unpaid accrued interest also repaid as part of the redemption, per unit.  Optional field.  If left empty, will be resolved internally by calculating the accrued owed on the EffectiveDate.  This process may require additional market data.</value>
        [DataMember(Name = "accruedInterestPerUnit", EmitDefaultValue = true)]
        public decimal? AccruedInterestPerUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EarlyRedemptionEventAllOf {\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  EarlyRedemptionElections: ").Append(EarlyRedemptionElections).Append("\n");
            sb.Append("  RedemptionPercentage: ").Append(RedemptionPercentage).Append("\n");
            sb.Append("  PricePerUnit: ").Append(PricePerUnit).Append("\n");
            sb.Append("  AccruedInterestPerUnit: ").Append(AccruedInterestPerUnit).Append("\n");
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
            return this.Equals(input as EarlyRedemptionEventAllOf);
        }

        /// <summary>
        /// Returns true if EarlyRedemptionEventAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of EarlyRedemptionEventAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarlyRedemptionEventAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.EarlyRedemptionElections == input.EarlyRedemptionElections ||
                    this.EarlyRedemptionElections != null &&
                    input.EarlyRedemptionElections != null &&
                    this.EarlyRedemptionElections.SequenceEqual(input.EarlyRedemptionElections)
                ) && 
                (
                    this.RedemptionPercentage == input.RedemptionPercentage ||
                    this.RedemptionPercentage.Equals(input.RedemptionPercentage)
                ) && 
                (
                    this.PricePerUnit == input.PricePerUnit ||
                    (this.PricePerUnit != null &&
                    this.PricePerUnit.Equals(input.PricePerUnit))
                ) && 
                (
                    this.AccruedInterestPerUnit == input.AccruedInterestPerUnit ||
                    (this.AccruedInterestPerUnit != null &&
                    this.AccruedInterestPerUnit.Equals(input.AccruedInterestPerUnit))
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
                if (this.EffectiveDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveDate.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.EarlyRedemptionElections != null)
                {
                    hashCode = (hashCode * 59) + this.EarlyRedemptionElections.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RedemptionPercentage.GetHashCode();
                if (this.PricePerUnit != null)
                {
                    hashCode = (hashCode * 59) + this.PricePerUnit.GetHashCode();
                }
                if (this.AccruedInterestPerUnit != null)
                {
                    hashCode = (hashCode * 59) + this.AccruedInterestPerUnit.GetHashCode();
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
