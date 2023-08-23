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
    /// An Order for a certain quantity of a specific instrument
    /// </summary>
    [DataContract(Name = "Order")]
    public partial class Order : IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Order() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="properties">Client-defined properties associated with this order..</param>
        /// <param name="version">version.</param>
        /// <param name="instrumentIdentifiers">The instrument ordered. (required).</param>
        /// <param name="quantity">The quantity of given instrument ordered. (required).</param>
        /// <param name="side">The client&#39;s representation of the order&#39;s side (buy, sell, short, etc) (required).</param>
        /// <param name="orderBookId">orderBookId.</param>
        /// <param name="portfolioId">portfolioId.</param>
        /// <param name="id">id (required).</param>
        /// <param name="instrumentScope">The scope in which the instrument lies.</param>
        /// <param name="lusidInstrumentId">The LUSID instrument id for the instrument ordered. (required).</param>
        /// <param name="state">The order&#39;s state (examples: New, PartiallyFilled, ...).</param>
        /// <param name="type">The order&#39;s type (examples: Limit, Market, ...).</param>
        /// <param name="timeInForce">The order&#39;s time in force (examples: Day, GoodTilCancel, ...).</param>
        /// <param name="date">The date on which the order was made.</param>
        /// <param name="price">price.</param>
        /// <param name="limitPrice">limitPrice.</param>
        /// <param name="stopPrice">stopPrice.</param>
        /// <param name="orderInstructionId">orderInstructionId.</param>
        /// <param name="packageId">packageId.</param>
        /// <param name="links">links.</param>
        public Order(Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), ModelVersion version = default(ModelVersion), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), decimal quantity = default(decimal), string side = default(string), ResourceId orderBookId = default(ResourceId), ResourceId portfolioId = default(ResourceId), ResourceId id = default(ResourceId), string instrumentScope = default(string), string lusidInstrumentId = default(string), string state = default(string), string type = default(string), string timeInForce = default(string), DateTimeOffset date = default(DateTimeOffset), CurrencyAndAmount price = default(CurrencyAndAmount), CurrencyAndAmount limitPrice = default(CurrencyAndAmount), CurrencyAndAmount stopPrice = default(CurrencyAndAmount), ResourceId orderInstructionId = default(ResourceId), ResourceId packageId = default(ResourceId), List<Link> links = default(List<Link>))
        {
            // to ensure "instrumentIdentifiers" is required (not null)
            if (instrumentIdentifiers == null)
            {
                throw new ArgumentNullException("instrumentIdentifiers is a required property for Order and cannot be null");
            }
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.Quantity = quantity;
            // to ensure "side" is required (not null)
            if (side == null)
            {
                throw new ArgumentNullException("side is a required property for Order and cannot be null");
            }
            this.Side = side;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Order and cannot be null");
            }
            this.Id = id;
            // to ensure "lusidInstrumentId" is required (not null)
            if (lusidInstrumentId == null)
            {
                throw new ArgumentNullException("lusidInstrumentId is a required property for Order and cannot be null");
            }
            this.LusidInstrumentId = lusidInstrumentId;
            this.Properties = properties;
            this._Version = version;
            this.OrderBookId = orderBookId;
            this.PortfolioId = portfolioId;
            this.InstrumentScope = instrumentScope;
            this.State = state;
            this.Type = type;
            this.TimeInForce = timeInForce;
            this.Date = date;
            this.Price = price;
            this.LimitPrice = limitPrice;
            this.StopPrice = stopPrice;
            this.OrderInstructionId = orderInstructionId;
            this.PackageId = packageId;
            this.Links = links;
        }

        /// <summary>
        /// Client-defined properties associated with this order.
        /// </summary>
        /// <value>Client-defined properties associated with this order.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public ModelVersion _Version { get; set; }

        /// <summary>
        /// The instrument ordered.
        /// </summary>
        /// <value>The instrument ordered.</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The quantity of given instrument ordered.
        /// </summary>
        /// <value>The quantity of given instrument ordered.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The client&#39;s representation of the order&#39;s side (buy, sell, short, etc)
        /// </summary>
        /// <value>The client&#39;s representation of the order&#39;s side (buy, sell, short, etc)</value>
        [DataMember(Name = "side", IsRequired = true, EmitDefaultValue = true)]
        public string Side { get; set; }

        /// <summary>
        /// Gets or Sets OrderBookId
        /// </summary>
        [DataMember(Name = "orderBookId", EmitDefaultValue = false)]
        public ResourceId OrderBookId { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name = "portfolioId", EmitDefaultValue = false)]
        public ResourceId PortfolioId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The scope in which the instrument lies
        /// </summary>
        /// <value>The scope in which the instrument lies</value>
        [DataMember(Name = "instrumentScope", EmitDefaultValue = true)]
        public string InstrumentScope { get; set; }

        /// <summary>
        /// The LUSID instrument id for the instrument ordered.
        /// </summary>
        /// <value>The LUSID instrument id for the instrument ordered.</value>
        [DataMember(Name = "lusidInstrumentId", IsRequired = true, EmitDefaultValue = true)]
        public string LusidInstrumentId { get; set; }

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
        /// Gets or Sets LimitPrice
        /// </summary>
        [DataMember(Name = "limitPrice", EmitDefaultValue = false)]
        public CurrencyAndAmount LimitPrice { get; set; }

        /// <summary>
        /// Gets or Sets StopPrice
        /// </summary>
        [DataMember(Name = "stopPrice", EmitDefaultValue = false)]
        public CurrencyAndAmount StopPrice { get; set; }

        /// <summary>
        /// Gets or Sets OrderInstructionId
        /// </summary>
        [DataMember(Name = "orderInstructionId", EmitDefaultValue = false)]
        public ResourceId OrderInstructionId { get; set; }

        /// <summary>
        /// Gets or Sets PackageId
        /// </summary>
        [DataMember(Name = "packageId", EmitDefaultValue = false)]
        public ResourceId PackageId { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  OrderBookId: ").Append(OrderBookId).Append("\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstrumentScope: ").Append(InstrumentScope).Append("\n");
            sb.Append("  LusidInstrumentId: ").Append(LusidInstrumentId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  LimitPrice: ").Append(LimitPrice).Append("\n");
            sb.Append("  StopPrice: ").Append(StopPrice).Append("\n");
            sb.Append("  OrderInstructionId: ").Append(OrderInstructionId).Append("\n");
            sb.Append("  PackageId: ").Append(PackageId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="input">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                    this.InstrumentScope == input.InstrumentScope ||
                    (this.InstrumentScope != null &&
                    this.InstrumentScope.Equals(input.InstrumentScope))
                ) && 
                (
                    this.LusidInstrumentId == input.LusidInstrumentId ||
                    (this.LusidInstrumentId != null &&
                    this.LusidInstrumentId.Equals(input.LusidInstrumentId))
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
                    this.LimitPrice == input.LimitPrice ||
                    (this.LimitPrice != null &&
                    this.LimitPrice.Equals(input.LimitPrice))
                ) && 
                (
                    this.StopPrice == input.StopPrice ||
                    (this.StopPrice != null &&
                    this.StopPrice.Equals(input.StopPrice))
                ) && 
                (
                    this.OrderInstructionId == input.OrderInstructionId ||
                    (this.OrderInstructionId != null &&
                    this.OrderInstructionId.Equals(input.OrderInstructionId))
                ) && 
                (
                    this.PackageId == input.PackageId ||
                    (this.PackageId != null &&
                    this.PackageId.Equals(input.PackageId))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.InstrumentIdentifiers != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentIdentifiers.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.Side != null)
                {
                    hashCode = (hashCode * 59) + this.Side.GetHashCode();
                }
                if (this.OrderBookId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderBookId.GetHashCode();
                }
                if (this.PortfolioId != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.InstrumentScope != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentScope.GetHashCode();
                }
                if (this.LusidInstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.LusidInstrumentId.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.TimeInForce != null)
                {
                    hashCode = (hashCode * 59) + this.TimeInForce.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.LimitPrice != null)
                {
                    hashCode = (hashCode * 59) + this.LimitPrice.GetHashCode();
                }
                if (this.StopPrice != null)
                {
                    hashCode = (hashCode * 59) + this.StopPrice.GetHashCode();
                }
                if (this.OrderInstructionId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderInstructionId.GetHashCode();
                }
                if (this.PackageId != null)
                {
                    hashCode = (hashCode * 59) + this.PackageId.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
            // Side (string) minLength
            if (this.Side != null && this.Side.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Side, length must be greater than 1.", new [] { "Side" });
            }

            // LusidInstrumentId (string) minLength
            if (this.LusidInstrumentId != null && this.LusidInstrumentId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LusidInstrumentId, length must be greater than 1.", new [] { "LusidInstrumentId" });
            }

            yield break;
        }
    }
}
