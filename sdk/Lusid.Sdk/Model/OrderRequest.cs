/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3440
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
    /// A request to create or update an Order.
    /// </summary>
    [DataContract(Name = "OrderRequest")]
    public partial class OrderRequest : IEquatable<OrderRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest" /> class.
        /// </summary>
        /// <param name="properties">Client-defined properties associated with this order..</param>
        /// <param name="instrumentIdentifiers">The instrument ordered. (required).</param>
        /// <param name="quantity">The quantity of given instrument ordered. (required).</param>
        /// <param name="side">The client&#39;s representation of the order&#39;s side (buy, sell, short, etc) (required).</param>
        /// <param name="orderBookId">orderBookId.</param>
        /// <param name="portfolioId">portfolioId (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="state">The order&#39;s state (examples: New, PartiallyFilled, ...).</param>
        /// <param name="type">The order&#39;s type (examples: Limit, Market, ...).</param>
        /// <param name="timeInForce">The order&#39;s time in force (examples: Day, GoodTilCancel, ...).</param>
        /// <param name="date">The date on which the order was made.</param>
        /// <param name="price">price.</param>
        /// <param name="orderInstruction">orderInstruction.</param>
        /// <param name="package">package.</param>
        public OrderRequest(Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), int quantity = default(int), string side = default(string), ResourceId orderBookId = default(ResourceId), ResourceId portfolioId = default(ResourceId), ResourceId id = default(ResourceId), string state = default(string), string type = default(string), string timeInForce = default(string), DateTimeOffset date = default(DateTimeOffset), CurrencyAndAmount price = default(CurrencyAndAmount), ResourceId orderInstruction = default(ResourceId), ResourceId package = default(ResourceId))
        {
            // to ensure "instrumentIdentifiers" is required (not null)
            this.InstrumentIdentifiers = instrumentIdentifiers ?? throw new ArgumentNullException("instrumentIdentifiers is a required property for OrderRequest and cannot be null");
            this.Quantity = quantity;
            // to ensure "side" is required (not null)
            this.Side = side ?? throw new ArgumentNullException("side is a required property for OrderRequest and cannot be null");
            // to ensure "portfolioId" is required (not null)
            this.PortfolioId = portfolioId ?? throw new ArgumentNullException("portfolioId is a required property for OrderRequest and cannot be null");
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for OrderRequest and cannot be null");
            this.Properties = properties;
            this.OrderBookId = orderBookId;
            this.State = state;
            this.Type = type;
            this.TimeInForce = timeInForce;
            this.Date = date;
            this.Price = price;
            this.OrderInstruction = orderInstruction;
            this.Package = package;
        }

        /// <summary>
        /// Client-defined properties associated with this order.
        /// </summary>
        /// <value>Client-defined properties associated with this order.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The instrument ordered.
        /// </summary>
        /// <value>The instrument ordered.</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The quantity of given instrument ordered.
        /// </summary>
        /// <value>The quantity of given instrument ordered.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public int Quantity { get; set; }

        /// <summary>
        /// The client&#39;s representation of the order&#39;s side (buy, sell, short, etc)
        /// </summary>
        /// <value>The client&#39;s representation of the order&#39;s side (buy, sell, short, etc)</value>
        [DataMember(Name = "side", IsRequired = true, EmitDefaultValue = false)]
        public string Side { get; set; }

        /// <summary>
        /// Gets or Sets OrderBookId
        /// </summary>
        [DataMember(Name = "orderBookId", EmitDefaultValue = false)]
        public ResourceId OrderBookId { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name = "portfolioId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId PortfolioId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The order&#39;s state (examples: New, PartiallyFilled, ...)
        /// </summary>
        /// <value>The order&#39;s state (examples: New, PartiallyFilled, ...)</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The order&#39;s type (examples: Limit, Market, ...)
        /// </summary>
        /// <value>The order&#39;s type (examples: Limit, Market, ...)</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The order&#39;s time in force (examples: Day, GoodTilCancel, ...)
        /// </summary>
        /// <value>The order&#39;s time in force (examples: Day, GoodTilCancel, ...)</value>
        [DataMember(Name = "timeInForce", EmitDefaultValue = true)]
        public string TimeInForce { get; set; }

        /// <summary>
        /// The date on which the order was made
        /// </summary>
        /// <value>The date on which the order was made</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public CurrencyAndAmount Price { get; set; }

        /// <summary>
        /// Gets or Sets OrderInstruction
        /// </summary>
        [DataMember(Name = "orderInstruction", EmitDefaultValue = false)]
        public ResourceId OrderInstruction { get; set; }

        /// <summary>
        /// Gets or Sets Package
        /// </summary>
        [DataMember(Name = "package", EmitDefaultValue = false)]
        public ResourceId Package { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderRequest {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  OrderBookId: ").Append(OrderBookId).Append("\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  OrderInstruction: ").Append(OrderInstruction).Append("\n");
            sb.Append("  Package: ").Append(Package).Append("\n");
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
            return this.Equals(input as OrderRequest);
        }

        /// <summary>
        /// Returns true if OrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.OrderBookId == input.OrderBookId ||
                    (this.OrderBookId != null &&
                    this.OrderBookId.Equals(input.OrderBookId))
                ) && 
                (
                    this.PortfolioId == input.PortfolioId ||
                    (this.PortfolioId != null &&
                    this.PortfolioId.Equals(input.PortfolioId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    (this.TimeInForce != null &&
                    this.TimeInForce.Equals(input.TimeInForce))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.OrderInstruction == input.OrderInstruction ||
                    (this.OrderInstruction != null &&
                    this.OrderInstruction.Equals(input.OrderInstruction))
                ) && 
                (
                    this.Package == input.Package ||
                    (this.Package != null &&
                    this.Package.Equals(input.Package))
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
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.OrderBookId != null)
                    hashCode = hashCode * 59 + this.OrderBookId.GetHashCode();
                if (this.PortfolioId != null)
                    hashCode = hashCode * 59 + this.PortfolioId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TimeInForce != null)
                    hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.OrderInstruction != null)
                    hashCode = hashCode * 59 + this.OrderInstruction.GetHashCode();
                if (this.Package != null)
                    hashCode = hashCode * 59 + this.Package.GetHashCode();
                return hashCode;
            }
        }

    }
}
