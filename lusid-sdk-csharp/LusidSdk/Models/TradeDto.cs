// <auto-generated>
// Copyright © 2018 FINBOURNE TECHNOLOGY LTD
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
// </auto-generated>

namespace Finbourne.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TradeDto
    {
        /// <summary>
        /// Initializes a new instance of the TradeDto class.
        /// </summary>
        public TradeDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TradeDto class.
        /// </summary>
        /// <param name="tradeId">Unique trade identifier</param>
        /// <param name="type">LUSID transaction type code - Buy, Sell,
        /// StockIn, StockOut, etc</param>
        /// <param name="settlementCurrency">Settlement currency</param>
        /// <param name="securityUid">Unique security identifier</param>
        /// <param name="tradeDate">Trade date</param>
        /// <param name="settlementDate">Settlement date</param>
        /// <param name="units">Quantity of trade in units of the
        /// security</param>
        /// <param name="tradePrice">Execution price for the trade</param>
        /// <param name="totalConsideration">Total value of the trade</param>
        /// <param name="exchangeRate">Rate between trade and settle
        /// currency</param>
        /// <param name="tradeCurrency">Trade currency</param>
        /// <param name="counterpartyId">Counterparty identifier</param>
        /// <param name="source">Where this trade came from, either Client or
        /// System. Possible values include: 'System', 'Client'</param>
        /// <param name="dividendState">Possible values include: 'Default',
        /// 'ExDividend', 'CumDividend'</param>
        /// <param name="tradePriceType">Possible values include: 'Price',
        /// 'Yield', 'Spread'</param>
        /// <param name="unitType">Possible values include: 'Nominal',
        /// 'Shares', 'FaceValue', 'Contracts'</param>
        public TradeDto(string tradeId, string type, string settlementCurrency, string securityUid = default(string), System.DateTimeOffset? tradeDate = default(System.DateTimeOffset?), System.DateTimeOffset? settlementDate = default(System.DateTimeOffset?), double? units = default(double?), double? tradePrice = default(double?), double? totalConsideration = default(double?), double? exchangeRate = default(double?), string tradeCurrency = default(string), IList<PropertyDto> properties = default(IList<PropertyDto>), string counterpartyId = default(string), string source = default(string), string dividendState = default(string), string tradePriceType = default(string), string unitType = default(string), string nettingSet = default(string))
        {
            TradeId = tradeId;
            Type = type;
            SecurityUid = securityUid;
            TradeDate = tradeDate;
            SettlementDate = settlementDate;
            Units = units;
            TradePrice = tradePrice;
            TotalConsideration = totalConsideration;
            ExchangeRate = exchangeRate;
            SettlementCurrency = settlementCurrency;
            TradeCurrency = tradeCurrency;
            Properties = properties;
            CounterpartyId = counterpartyId;
            Source = source;
            DividendState = dividendState;
            TradePriceType = tradePriceType;
            UnitType = unitType;
            NettingSet = nettingSet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique trade identifier
        /// </summary>
        [JsonProperty(PropertyName = "tradeId")]
        public string TradeId { get; set; }

        /// <summary>
        /// Gets or sets LUSID transaction type code - Buy, Sell, StockIn,
        /// StockOut, etc
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets unique security identifier
        /// </summary>
        [JsonProperty(PropertyName = "securityUid")]
        public string SecurityUid { get; set; }

        /// <summary>
        /// Gets or sets trade date
        /// </summary>
        [JsonProperty(PropertyName = "tradeDate")]
        public System.DateTimeOffset? TradeDate { get; set; }

        /// <summary>
        /// Gets or sets settlement date
        /// </summary>
        [JsonProperty(PropertyName = "settlementDate")]
        public System.DateTimeOffset? SettlementDate { get; set; }

        /// <summary>
        /// Gets or sets quantity of trade in units of the security
        /// </summary>
        [JsonProperty(PropertyName = "units")]
        public double? Units { get; set; }

        /// <summary>
        /// Gets or sets execution price for the trade
        /// </summary>
        [JsonProperty(PropertyName = "tradePrice")]
        public double? TradePrice { get; set; }

        /// <summary>
        /// Gets or sets total value of the trade
        /// </summary>
        [JsonProperty(PropertyName = "totalConsideration")]
        public double? TotalConsideration { get; set; }

        /// <summary>
        /// Gets or sets rate between trade and settle currency
        /// </summary>
        [JsonProperty(PropertyName = "exchangeRate")]
        public double? ExchangeRate { get; set; }

        /// <summary>
        /// Gets or sets settlement currency
        /// </summary>
        [JsonProperty(PropertyName = "settlementCurrency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// Gets or sets trade currency
        /// </summary>
        [JsonProperty(PropertyName = "tradeCurrency")]
        public string TradeCurrency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<PropertyDto> Properties { get; set; }

        /// <summary>
        /// Gets or sets counterparty identifier
        /// </summary>
        [JsonProperty(PropertyName = "counterpartyId")]
        public string CounterpartyId { get; set; }

        /// <summary>
        /// Gets or sets where this trade came from, either Client or System.
        /// Possible values include: 'System', 'Client'
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Default', 'ExDividend',
        /// 'CumDividend'
        /// </summary>
        [JsonProperty(PropertyName = "dividendState")]
        public string DividendState { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Price', 'Yield', 'Spread'
        /// </summary>
        [JsonProperty(PropertyName = "tradePriceType")]
        public string TradePriceType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Nominal', 'Shares',
        /// 'FaceValue', 'Contracts'
        /// </summary>
        [JsonProperty(PropertyName = "unitType")]
        public string UnitType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nettingSet")]
        public string NettingSet { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TradeId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TradeId");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (SettlementCurrency == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SettlementCurrency");
            }
            if (Properties != null)
            {
                foreach (var element in Properties)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
