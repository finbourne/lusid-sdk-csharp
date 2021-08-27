/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3438
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// Used to specify holdings target amounts at the tax-lot level
    /// </summary>
    [DataContract]
    public partial class TargetTaxLot :  IEquatable<TargetTaxLot>
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
        public TargetTaxLot(decimal? units = default(decimal?), CurrencyAndAmount cost = default(CurrencyAndAmount), decimal? portfolioCost = default(decimal?), decimal? price = default(decimal?), DateTimeOffset? purchaseDate = default(DateTimeOffset?), DateTimeOffset? settlementDate = default(DateTimeOffset?))
        {
            // to ensure "units" is required (not null)
            if (units == null)
            {
                throw new InvalidDataException("units is a required property for TargetTaxLot and cannot be null");
            }
            else
            {
                this.Units = units;
            }
            
            this.PortfolioCost = portfolioCost;
            this.Price = price;
            this.PurchaseDate = purchaseDate;
            this.SettlementDate = settlementDate;
            this.Cost = cost;
            this.PortfolioCost = portfolioCost;
            this.Price = price;
            this.PurchaseDate = purchaseDate;
            this.SettlementDate = settlementDate;
        }
        
        /// <summary>
        /// The number of units of the instrument in this tax-lot.
        /// </summary>
        /// <value>The number of units of the instrument in this tax-lot.</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public decimal? Units { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public CurrencyAndAmount Cost { get; set; }

        /// <summary>
        /// The total cost of the tax-lot in the transaction portfolio&#39;s base currency.
        /// </summary>
        /// <value>The total cost of the tax-lot in the transaction portfolio&#39;s base currency.</value>
        [DataMember(Name="portfolioCost", EmitDefaultValue=true)]
        public decimal? PortfolioCost { get; set; }

        /// <summary>
        /// The purchase price of each unit of the instrument held in this tax-lot. This forms part of the unique key required for multiple tax-lots.
        /// </summary>
        /// <value>The purchase price of each unit of the instrument held in this tax-lot. This forms part of the unique key required for multiple tax-lots.</value>
        [DataMember(Name="price", EmitDefaultValue=true)]
        public decimal? Price { get; set; }

        /// <summary>
        /// The purchase date of this tax-lot. This forms part of the unique key required for multiple tax-lots.
        /// </summary>
        /// <value>The purchase date of this tax-lot. This forms part of the unique key required for multiple tax-lots.</value>
        [DataMember(Name="purchaseDate", EmitDefaultValue=true)]
        public DateTimeOffset? PurchaseDate { get; set; }

        /// <summary>
        /// The settlement date of the tax-lot&#39;s opening transaction.
        /// </summary>
        /// <value>The settlement date of the tax-lot&#39;s opening transaction.</value>
        [DataMember(Name="settlementDate", EmitDefaultValue=true)]
        public DateTimeOffset? SettlementDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TargetTaxLot {\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  PortfolioCost: ").Append(PortfolioCost).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

            return 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
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
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.PortfolioCost != null)
                    hashCode = hashCode * 59 + this.PortfolioCost.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.PurchaseDate != null)
                    hashCode = hashCode * 59 + this.PurchaseDate.GetHashCode();
                if (this.SettlementDate != null)
                    hashCode = hashCode * 59 + this.SettlementDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
