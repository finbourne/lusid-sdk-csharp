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
    /// Spin-off event (SOFF), representing the distribution of securities issued by another company.
    /// </summary>
    [DataContract(Name = "SpinOffEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class SpinOffEvent : InstrumentEvent, IEquatable<SpinOffEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpinOffEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpinOffEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpinOffEvent" /> class.
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
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent (required) (default to &quot;SpinOffEvent&quot;).</param>
        public SpinOffEvent(DateTimeOffset? announcementDate = default(DateTimeOffset?), DateTimeOffset exDate = default(DateTimeOffset), DateTimeOffset? recordDate = default(DateTimeOffset?), DateTimeOffset paymentDate = default(DateTimeOffset), NewInstrument newInstrument = default(NewInstrument), UnitsRatio unitsRatio = default(UnitsRatio), decimal? costFactor = default(decimal?), decimal? fractionalUnitsCashPrice = default(decimal?), string fractionalUnitsCashCurrency = default(string), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            this.ExDate = exDate;
            this.PaymentDate = paymentDate;
            // to ensure "newInstrument" is required (not null)
            if (newInstrument == null)
            {
                throw new ArgumentNullException("newInstrument is a required property for SpinOffEvent and cannot be null");
            }
            this.NewInstrument = newInstrument;
            // to ensure "unitsRatio" is required (not null)
            if (unitsRatio == null)
            {
                throw new ArgumentNullException("unitsRatio is a required property for SpinOffEvent and cannot be null");
            }
            this.UnitsRatio = unitsRatio;
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
            sb.Append("class SpinOffEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AnnouncementDate: ").Append(AnnouncementDate).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  NewInstrument: ").Append(NewInstrument).Append("\n");
            sb.Append("  UnitsRatio: ").Append(UnitsRatio).Append("\n");
            sb.Append("  CostFactor: ").Append(CostFactor).Append("\n");
            sb.Append("  FractionalUnitsCashPrice: ").Append(FractionalUnitsCashPrice).Append("\n");
            sb.Append("  FractionalUnitsCashCurrency: ").Append(FractionalUnitsCashCurrency).Append("\n");
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
            return this.Equals(input as SpinOffEvent);
        }

        /// <summary>
        /// Returns true if SpinOffEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SpinOffEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpinOffEvent input)
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
                    this.UnitsRatio == input.UnitsRatio ||
                    (this.UnitsRatio != null &&
                    this.UnitsRatio.Equals(input.UnitsRatio))
                ) && base.Equals(input) && 
                (
                    this.CostFactor == input.CostFactor ||
                    (this.CostFactor != null &&
                    this.CostFactor.Equals(input.CostFactor))
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
