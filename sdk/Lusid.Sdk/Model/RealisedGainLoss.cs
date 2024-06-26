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
    /// RealisedGainLoss
    /// </summary>
    [DataContract(Name = "RealisedGainLoss")]
    public partial class RealisedGainLoss : IEquatable<RealisedGainLoss>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealisedGainLoss" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RealisedGainLoss() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RealisedGainLoss" /> class.
        /// </summary>
        /// <param name="instrumentScope">The scope in which the instrument lies..</param>
        /// <param name="instrumentUid">The unique Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with. (required).</param>
        /// <param name="units">The number of units of the associated instrument against which the gain or loss has been realised. (required).</param>
        /// <param name="purchasePrice">The purchase price of each unit associated with this gain or loss..</param>
        /// <param name="costTradeCcy">costTradeCcy (required).</param>
        /// <param name="costPortfolioCcy">costPortfolioCcy (required).</param>
        /// <param name="realisedTradeCcy">realisedTradeCcy (required).</param>
        /// <param name="realisedTotal">realisedTotal (required).</param>
        /// <param name="realisedMarket">realisedMarket.</param>
        /// <param name="realisedCurrency">realisedCurrency.</param>
        public RealisedGainLoss(string instrumentScope = default(string), string instrumentUid = default(string), decimal units = default(decimal), decimal? purchasePrice = default(decimal?), CurrencyAndAmount costTradeCcy = default(CurrencyAndAmount), CurrencyAndAmount costPortfolioCcy = default(CurrencyAndAmount), CurrencyAndAmount realisedTradeCcy = default(CurrencyAndAmount), CurrencyAndAmount realisedTotal = default(CurrencyAndAmount), CurrencyAndAmount realisedMarket = default(CurrencyAndAmount), CurrencyAndAmount realisedCurrency = default(CurrencyAndAmount))
        {
            // to ensure "instrumentUid" is required (not null)
            if (instrumentUid == null)
            {
                throw new ArgumentNullException("instrumentUid is a required property for RealisedGainLoss and cannot be null");
            }
            this.InstrumentUid = instrumentUid;
            this.Units = units;
            // to ensure "costTradeCcy" is required (not null)
            if (costTradeCcy == null)
            {
                throw new ArgumentNullException("costTradeCcy is a required property for RealisedGainLoss and cannot be null");
            }
            this.CostTradeCcy = costTradeCcy;
            // to ensure "costPortfolioCcy" is required (not null)
            if (costPortfolioCcy == null)
            {
                throw new ArgumentNullException("costPortfolioCcy is a required property for RealisedGainLoss and cannot be null");
            }
            this.CostPortfolioCcy = costPortfolioCcy;
            // to ensure "realisedTradeCcy" is required (not null)
            if (realisedTradeCcy == null)
            {
                throw new ArgumentNullException("realisedTradeCcy is a required property for RealisedGainLoss and cannot be null");
            }
            this.RealisedTradeCcy = realisedTradeCcy;
            // to ensure "realisedTotal" is required (not null)
            if (realisedTotal == null)
            {
                throw new ArgumentNullException("realisedTotal is a required property for RealisedGainLoss and cannot be null");
            }
            this.RealisedTotal = realisedTotal;
            this.InstrumentScope = instrumentScope;
            this.PurchasePrice = purchasePrice;
            this.RealisedMarket = realisedMarket;
            this.RealisedCurrency = realisedCurrency;
        }

        /// <summary>
        /// The scope in which the instrument lies.
        /// </summary>
        /// <value>The scope in which the instrument lies.</value>
        [DataMember(Name = "instrumentScope", EmitDefaultValue = true)]
        public string InstrumentScope { get; set; }

        /// <summary>
        /// The unique Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with.
        /// </summary>
        /// <value>The unique Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with.</value>
        [DataMember(Name = "instrumentUid", IsRequired = true, EmitDefaultValue = true)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// The number of units of the associated instrument against which the gain or loss has been realised.
        /// </summary>
        /// <value>The number of units of the associated instrument against which the gain or loss has been realised.</value>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public decimal Units { get; set; }

        /// <summary>
        /// The effective datetime at which the units associated with this gain or loss were originally purchased.
        /// </summary>
        /// <value>The effective datetime at which the units associated with this gain or loss were originally purchased.</value>
        [DataMember(Name = "purchaseTradeDate", EmitDefaultValue = true)]
        public DateTimeOffset? PurchaseTradeDate { get; private set; }

        /// <summary>
        /// Returns false as PurchaseTradeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePurchaseTradeDate()
        {
            return false;
        }
        /// <summary>
        /// The effective datetime at which the units associated with this gain or loss were originally settled.
        /// </summary>
        /// <value>The effective datetime at which the units associated with this gain or loss were originally settled.</value>
        [DataMember(Name = "purchaseSettlementDate", EmitDefaultValue = true)]
        public DateTimeOffset? PurchaseSettlementDate { get; private set; }

        /// <summary>
        /// Returns false as PurchaseSettlementDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePurchaseSettlementDate()
        {
            return false;
        }
        /// <summary>
        /// The purchase price of each unit associated with this gain or loss.
        /// </summary>
        /// <value>The purchase price of each unit associated with this gain or loss.</value>
        [DataMember(Name = "purchasePrice", EmitDefaultValue = true)]
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets CostTradeCcy
        /// </summary>
        [DataMember(Name = "costTradeCcy", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyAndAmount CostTradeCcy { get; set; }

        /// <summary>
        /// Gets or Sets CostPortfolioCcy
        /// </summary>
        [DataMember(Name = "costPortfolioCcy", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyAndAmount CostPortfolioCcy { get; set; }

        /// <summary>
        /// Gets or Sets RealisedTradeCcy
        /// </summary>
        [DataMember(Name = "realisedTradeCcy", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyAndAmount RealisedTradeCcy { get; set; }

        /// <summary>
        /// Gets or Sets RealisedTotal
        /// </summary>
        [DataMember(Name = "realisedTotal", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyAndAmount RealisedTotal { get; set; }

        /// <summary>
        /// Gets or Sets RealisedMarket
        /// </summary>
        [DataMember(Name = "realisedMarket", EmitDefaultValue = false)]
        public CurrencyAndAmount RealisedMarket { get; set; }

        /// <summary>
        /// Gets or Sets RealisedCurrency
        /// </summary>
        [DataMember(Name = "realisedCurrency", EmitDefaultValue = false)]
        public CurrencyAndAmount RealisedCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RealisedGainLoss {\n");
            sb.Append("  InstrumentScope: ").Append(InstrumentScope).Append("\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  PurchaseTradeDate: ").Append(PurchaseTradeDate).Append("\n");
            sb.Append("  PurchaseSettlementDate: ").Append(PurchaseSettlementDate).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  CostTradeCcy: ").Append(CostTradeCcy).Append("\n");
            sb.Append("  CostPortfolioCcy: ").Append(CostPortfolioCcy).Append("\n");
            sb.Append("  RealisedTradeCcy: ").Append(RealisedTradeCcy).Append("\n");
            sb.Append("  RealisedTotal: ").Append(RealisedTotal).Append("\n");
            sb.Append("  RealisedMarket: ").Append(RealisedMarket).Append("\n");
            sb.Append("  RealisedCurrency: ").Append(RealisedCurrency).Append("\n");
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
            return this.Equals(input as RealisedGainLoss);
        }

        /// <summary>
        /// Returns true if RealisedGainLoss instances are equal
        /// </summary>
        /// <param name="input">Instance of RealisedGainLoss to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealisedGainLoss input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstrumentScope == input.InstrumentScope ||
                    (this.InstrumentScope != null &&
                    this.InstrumentScope.Equals(input.InstrumentScope))
                ) && 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.PurchaseTradeDate == input.PurchaseTradeDate ||
                    (this.PurchaseTradeDate != null &&
                    this.PurchaseTradeDate.Equals(input.PurchaseTradeDate))
                ) && 
                (
                    this.PurchaseSettlementDate == input.PurchaseSettlementDate ||
                    (this.PurchaseSettlementDate != null &&
                    this.PurchaseSettlementDate.Equals(input.PurchaseSettlementDate))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.CostTradeCcy == input.CostTradeCcy ||
                    (this.CostTradeCcy != null &&
                    this.CostTradeCcy.Equals(input.CostTradeCcy))
                ) && 
                (
                    this.CostPortfolioCcy == input.CostPortfolioCcy ||
                    (this.CostPortfolioCcy != null &&
                    this.CostPortfolioCcy.Equals(input.CostPortfolioCcy))
                ) && 
                (
                    this.RealisedTradeCcy == input.RealisedTradeCcy ||
                    (this.RealisedTradeCcy != null &&
                    this.RealisedTradeCcy.Equals(input.RealisedTradeCcy))
                ) && 
                (
                    this.RealisedTotal == input.RealisedTotal ||
                    (this.RealisedTotal != null &&
                    this.RealisedTotal.Equals(input.RealisedTotal))
                ) && 
                (
                    this.RealisedMarket == input.RealisedMarket ||
                    (this.RealisedMarket != null &&
                    this.RealisedMarket.Equals(input.RealisedMarket))
                ) && 
                (
                    this.RealisedCurrency == input.RealisedCurrency ||
                    (this.RealisedCurrency != null &&
                    this.RealisedCurrency.Equals(input.RealisedCurrency))
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
                if (this.InstrumentScope != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentScope.GetHashCode();
                }
                if (this.InstrumentUid != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentUid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
                if (this.PurchaseTradeDate != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseTradeDate.GetHashCode();
                }
                if (this.PurchaseSettlementDate != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseSettlementDate.GetHashCode();
                }
                if (this.PurchasePrice != null)
                {
                    hashCode = (hashCode * 59) + this.PurchasePrice.GetHashCode();
                }
                if (this.CostTradeCcy != null)
                {
                    hashCode = (hashCode * 59) + this.CostTradeCcy.GetHashCode();
                }
                if (this.CostPortfolioCcy != null)
                {
                    hashCode = (hashCode * 59) + this.CostPortfolioCcy.GetHashCode();
                }
                if (this.RealisedTradeCcy != null)
                {
                    hashCode = (hashCode * 59) + this.RealisedTradeCcy.GetHashCode();
                }
                if (this.RealisedTotal != null)
                {
                    hashCode = (hashCode * 59) + this.RealisedTotal.GetHashCode();
                }
                if (this.RealisedMarket != null)
                {
                    hashCode = (hashCode * 59) + this.RealisedMarket.GetHashCode();
                }
                if (this.RealisedCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.RealisedCurrency.GetHashCode();
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
            // InstrumentUid (string) minLength
            if (this.InstrumentUid != null && this.InstrumentUid.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentUid, length must be greater than 1.", new [] { "InstrumentUid" });
            }

            yield break;
        }
    }
}
