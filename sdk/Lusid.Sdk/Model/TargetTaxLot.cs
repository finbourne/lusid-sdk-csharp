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
    /// Used to specify holdings target amounts at the tax-lot level
    /// </summary>
    [DataContract(Name = "TargetTaxLot")]
    public partial class TargetTaxLot : IEquatable<TargetTaxLot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetTaxLot" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TargetTaxLot() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetTaxLot" /> class.
        /// </summary>
        /// <param name="units">The number of units of the instrument in this tax-lot. (required).</param>
        /// <param name="cost">cost.</param>
        /// <param name="portfolioCost">The total cost of the tax-lot in the transaction portfolio&#39;s base currency..</param>
        /// <param name="price">The purchase price of each unit of the instrument held in this tax-lot. This forms part of the unique key required for multiple tax-lots..</param>
        /// <param name="purchaseDate">The purchase date of this tax-lot. This forms part of the unique key required for multiple tax-lots..</param>
        /// <param name="settlementDate">The settlement date of the tax-lot&#39;s opening transaction..</param>
        /// <param name="notionalCost">The notional cost of the tax-lot&#39;s opening transaction..</param>
        /// <param name="variationMargin">The variation margin of the tax-lot&#39;s opening transaction..</param>
        /// <param name="variationMarginPortfolioCcy">The variation margin in portfolio currency of the tax-lot&#39;s opening transaction..</param>
        public TargetTaxLot(decimal units = default(decimal), CurrencyAndAmount cost = default(CurrencyAndAmount), decimal? portfolioCost = default(decimal?), decimal? price = default(decimal?), DateTimeOffset? purchaseDate = default(DateTimeOffset?), DateTimeOffset? settlementDate = default(DateTimeOffset?), decimal? notionalCost = default(decimal?), decimal? variationMargin = default(decimal?), decimal? variationMarginPortfolioCcy = default(decimal?))
        {
            this.Units = units;
            this.Cost = cost;
            this.PortfolioCost = portfolioCost;
            this.Price = price;
            this.PurchaseDate = purchaseDate;
            this.SettlementDate = settlementDate;
            this.NotionalCost = notionalCost;
            this.VariationMargin = variationMargin;
            this.VariationMarginPortfolioCcy = variationMarginPortfolioCcy;
        }

        /// <summary>
        /// The number of units of the instrument in this tax-lot.
        /// </summary>
        /// <value>The number of units of the instrument in this tax-lot.</value>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public decimal Units { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        public CurrencyAndAmount Cost { get; set; }

        /// <summary>
        /// The total cost of the tax-lot in the transaction portfolio&#39;s base currency.
        /// </summary>
        /// <value>The total cost of the tax-lot in the transaction portfolio&#39;s base currency.</value>
        [DataMember(Name = "portfolioCost", EmitDefaultValue = true)]
        public decimal? PortfolioCost { get; set; }

        /// <summary>
        /// The purchase price of each unit of the instrument held in this tax-lot. This forms part of the unique key required for multiple tax-lots.
        /// </summary>
        /// <value>The purchase price of each unit of the instrument held in this tax-lot. This forms part of the unique key required for multiple tax-lots.</value>
        [DataMember(Name = "price", EmitDefaultValue = true)]
        public decimal? Price { get; set; }

        /// <summary>
        /// The purchase date of this tax-lot. This forms part of the unique key required for multiple tax-lots.
        /// </summary>
        /// <value>The purchase date of this tax-lot. This forms part of the unique key required for multiple tax-lots.</value>
        [DataMember(Name = "purchaseDate", EmitDefaultValue = true)]
        public DateTimeOffset? PurchaseDate { get; set; }

        /// <summary>
        /// The settlement date of the tax-lot&#39;s opening transaction.
        /// </summary>
        /// <value>The settlement date of the tax-lot&#39;s opening transaction.</value>
        [DataMember(Name = "settlementDate", EmitDefaultValue = true)]
        public DateTimeOffset? SettlementDate { get; set; }

        /// <summary>
        /// The notional cost of the tax-lot&#39;s opening transaction.
        /// </summary>
        /// <value>The notional cost of the tax-lot&#39;s opening transaction.</value>
        [DataMember(Name = "notionalCost", EmitDefaultValue = true)]
        public decimal? NotionalCost { get; set; }

        /// <summary>
        /// The variation margin of the tax-lot&#39;s opening transaction.
        /// </summary>
        /// <value>The variation margin of the tax-lot&#39;s opening transaction.</value>
        [DataMember(Name = "variationMargin", EmitDefaultValue = true)]
        public decimal? VariationMargin { get; set; }

        /// <summary>
        /// The variation margin in portfolio currency of the tax-lot&#39;s opening transaction.
        /// </summary>
        /// <value>The variation margin in portfolio currency of the tax-lot&#39;s opening transaction.</value>
        [DataMember(Name = "variationMarginPortfolioCcy", EmitDefaultValue = true)]
        public decimal? VariationMarginPortfolioCcy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TargetTaxLot {\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  PortfolioCost: ").Append(PortfolioCost).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  NotionalCost: ").Append(NotionalCost).Append("\n");
            sb.Append("  VariationMargin: ").Append(VariationMargin).Append("\n");
            sb.Append("  VariationMarginPortfolioCcy: ").Append(VariationMarginPortfolioCcy).Append("\n");
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
            return this.Equals(input as TargetTaxLot);
        }

        /// <summary>
        /// Returns true if TargetTaxLot instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetTaxLot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetTaxLot input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.PortfolioCost == input.PortfolioCost ||
                    (this.PortfolioCost != null &&
                    this.PortfolioCost.Equals(input.PortfolioCost))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.PurchaseDate == input.PurchaseDate ||
                    (this.PurchaseDate != null &&
                    this.PurchaseDate.Equals(input.PurchaseDate))
                ) && 
                (
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.NotionalCost == input.NotionalCost ||
                    (this.NotionalCost != null &&
                    this.NotionalCost.Equals(input.NotionalCost))
                ) && 
                (
                    this.VariationMargin == input.VariationMargin ||
                    (this.VariationMargin != null &&
                    this.VariationMargin.Equals(input.VariationMargin))
                ) && 
                (
                    this.VariationMarginPortfolioCcy == input.VariationMarginPortfolioCcy ||
                    (this.VariationMarginPortfolioCcy != null &&
                    this.VariationMarginPortfolioCcy.Equals(input.VariationMarginPortfolioCcy))
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
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
                if (this.Cost != null)
                {
                    hashCode = (hashCode * 59) + this.Cost.GetHashCode();
                }
                if (this.PortfolioCost != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioCost.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.PurchaseDate != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseDate.GetHashCode();
                }
                if (this.SettlementDate != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementDate.GetHashCode();
                }
                if (this.NotionalCost != null)
                {
                    hashCode = (hashCode * 59) + this.NotionalCost.GetHashCode();
                }
                if (this.VariationMargin != null)
                {
                    hashCode = (hashCode * 59) + this.VariationMargin.GetHashCode();
                }
                if (this.VariationMarginPortfolioCcy != null)
                {
                    hashCode = (hashCode * 59) + this.VariationMarginPortfolioCcy.GetHashCode();
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
            yield break;
        }
    }
}
