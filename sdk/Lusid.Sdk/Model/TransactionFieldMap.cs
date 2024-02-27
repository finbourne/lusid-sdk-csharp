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
    /// TransactionFieldMap
    /// </summary>
    [DataContract(Name = "TransactionFieldMap")]
    public partial class TransactionFieldMap : IEquatable<TransactionFieldMap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFieldMap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionFieldMap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFieldMap" /> class.
        /// </summary>
        /// <param name="transactionId">transactionId (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="source">source (required).</param>
        /// <param name="instrument">instrument (required).</param>
        /// <param name="transactionDate">transactionDate (required).</param>
        /// <param name="settlementDate">settlementDate (required).</param>
        /// <param name="units">units (required).</param>
        /// <param name="transactionPrice">transactionPrice (required).</param>
        /// <param name="transactionCurrency">transactionCurrency (required).</param>
        /// <param name="exchangeRate">exchangeRate (required).</param>
        /// <param name="totalConsideration">totalConsideration (required).</param>
        public TransactionFieldMap(string transactionId = default(string), string type = default(string), string source = default(string), string instrument = default(string), string transactionDate = default(string), string settlementDate = default(string), string units = default(string), TransactionPriceAndType transactionPrice = default(TransactionPriceAndType), string transactionCurrency = default(string), string exchangeRate = default(string), TransactionCurrencyAndAmount totalConsideration = default(TransactionCurrencyAndAmount))
        {
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new ArgumentNullException("transactionId is a required property for TransactionFieldMap and cannot be null");
            }
            this.TransactionId = transactionId;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for TransactionFieldMap and cannot be null");
            }
            this.Type = type;
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for TransactionFieldMap and cannot be null");
            }
            this.Source = source;
            // to ensure "instrument" is required (not null)
            if (instrument == null)
            {
                throw new ArgumentNullException("instrument is a required property for TransactionFieldMap and cannot be null");
            }
            this.Instrument = instrument;
            // to ensure "transactionDate" is required (not null)
            if (transactionDate == null)
            {
                throw new ArgumentNullException("transactionDate is a required property for TransactionFieldMap and cannot be null");
            }
            this.TransactionDate = transactionDate;
            // to ensure "settlementDate" is required (not null)
            if (settlementDate == null)
            {
                throw new ArgumentNullException("settlementDate is a required property for TransactionFieldMap and cannot be null");
            }
            this.SettlementDate = settlementDate;
            // to ensure "units" is required (not null)
            if (units == null)
            {
                throw new ArgumentNullException("units is a required property for TransactionFieldMap and cannot be null");
            }
            this.Units = units;
            // to ensure "transactionPrice" is required (not null)
            if (transactionPrice == null)
            {
                throw new ArgumentNullException("transactionPrice is a required property for TransactionFieldMap and cannot be null");
            }
            this.TransactionPrice = transactionPrice;
            // to ensure "transactionCurrency" is required (not null)
            if (transactionCurrency == null)
            {
                throw new ArgumentNullException("transactionCurrency is a required property for TransactionFieldMap and cannot be null");
            }
            this.TransactionCurrency = transactionCurrency;
            // to ensure "exchangeRate" is required (not null)
            if (exchangeRate == null)
            {
                throw new ArgumentNullException("exchangeRate is a required property for TransactionFieldMap and cannot be null");
            }
            this.ExchangeRate = exchangeRate;
            // to ensure "totalConsideration" is required (not null)
            if (totalConsideration == null)
            {
                throw new ArgumentNullException("totalConsideration is a required property for TransactionFieldMap and cannot be null");
            }
            this.TotalConsideration = totalConsideration;
        }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Instrument
        /// </summary>
        [DataMember(Name = "instrument", IsRequired = true, EmitDefaultValue = true)]
        public string Instrument { get; set; }

        /// <summary>
        /// Gets or Sets TransactionDate
        /// </summary>
        [DataMember(Name = "transactionDate", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionDate { get; set; }

        /// <summary>
        /// Gets or Sets SettlementDate
        /// </summary>
        [DataMember(Name = "settlementDate", IsRequired = true, EmitDefaultValue = true)]
        public string SettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public string Units { get; set; }

        /// <summary>
        /// Gets or Sets TransactionPrice
        /// </summary>
        [DataMember(Name = "transactionPrice", IsRequired = true, EmitDefaultValue = true)]
        public TransactionPriceAndType TransactionPrice { get; set; }

        /// <summary>
        /// Gets or Sets TransactionCurrency
        /// </summary>
        [DataMember(Name = "transactionCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionCurrency { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name = "exchangeRate", IsRequired = true, EmitDefaultValue = true)]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets TotalConsideration
        /// </summary>
        [DataMember(Name = "totalConsideration", IsRequired = true, EmitDefaultValue = true)]
        public TransactionCurrencyAndAmount TotalConsideration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionFieldMap {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  TransactionPrice: ").Append(TransactionPrice).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  TotalConsideration: ").Append(TotalConsideration).Append("\n");
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
            return this.Equals(input as TransactionFieldMap);
        }

        /// <summary>
        /// Returns true if TransactionFieldMap instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionFieldMap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionFieldMap input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Instrument == input.Instrument ||
                    (this.Instrument != null &&
                    this.Instrument.Equals(input.Instrument))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.TransactionPrice == input.TransactionPrice ||
                    (this.TransactionPrice != null &&
                    this.TransactionPrice.Equals(input.TransactionPrice))
                ) && 
                (
                    this.TransactionCurrency == input.TransactionCurrency ||
                    (this.TransactionCurrency != null &&
                    this.TransactionCurrency.Equals(input.TransactionCurrency))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.TotalConsideration == input.TotalConsideration ||
                    (this.TotalConsideration != null &&
                    this.TotalConsideration.Equals(input.TotalConsideration))
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
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Instrument != null)
                {
                    hashCode = (hashCode * 59) + this.Instrument.GetHashCode();
                }
                if (this.TransactionDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionDate.GetHashCode();
                }
                if (this.SettlementDate != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementDate.GetHashCode();
                }
                if (this.Units != null)
                {
                    hashCode = (hashCode * 59) + this.Units.GetHashCode();
                }
                if (this.TransactionPrice != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionPrice.GetHashCode();
                }
                if (this.TransactionCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionCurrency.GetHashCode();
                }
                if (this.ExchangeRate != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeRate.GetHashCode();
                }
                if (this.TotalConsideration != null)
                {
                    hashCode = (hashCode * 59) + this.TotalConsideration.GetHashCode();
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
            // TransactionId (string) maxLength
            if (this.TransactionId != null && this.TransactionId.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, length must be less than 1024.", new [] { "TransactionId" });
            }

            // TransactionId (string) minLength
            if (this.TransactionId != null && this.TransactionId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, length must be greater than 0.", new [] { "TransactionId" });
            }

            // Type (string) maxLength
            if (this.Type != null && this.Type.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be less than 1024.", new [] { "Type" });
            }

            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 0.", new [] { "Type" });
            }

            // Source (string) maxLength
            if (this.Source != null && this.Source.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Source, length must be less than 1024.", new [] { "Source" });
            }

            // Source (string) minLength
            if (this.Source != null && this.Source.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Source, length must be greater than 0.", new [] { "Source" });
            }

            // Instrument (string) maxLength
            if (this.Instrument != null && this.Instrument.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Instrument, length must be less than 1024.", new [] { "Instrument" });
            }

            // Instrument (string) minLength
            if (this.Instrument != null && this.Instrument.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Instrument, length must be greater than 0.", new [] { "Instrument" });
            }

            // TransactionDate (string) maxLength
            if (this.TransactionDate != null && this.TransactionDate.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionDate, length must be less than 1024.", new [] { "TransactionDate" });
            }

            // TransactionDate (string) minLength
            if (this.TransactionDate != null && this.TransactionDate.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionDate, length must be greater than 0.", new [] { "TransactionDate" });
            }

            // SettlementDate (string) maxLength
            if (this.SettlementDate != null && this.SettlementDate.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SettlementDate, length must be less than 1024.", new [] { "SettlementDate" });
            }

            // SettlementDate (string) minLength
            if (this.SettlementDate != null && this.SettlementDate.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SettlementDate, length must be greater than 0.", new [] { "SettlementDate" });
            }

            // Units (string) maxLength
            if (this.Units != null && this.Units.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Units, length must be less than 1024.", new [] { "Units" });
            }

            // Units (string) minLength
            if (this.Units != null && this.Units.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Units, length must be greater than 0.", new [] { "Units" });
            }

            // TransactionCurrency (string) maxLength
            if (this.TransactionCurrency != null && this.TransactionCurrency.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionCurrency, length must be less than 1024.", new [] { "TransactionCurrency" });
            }

            // TransactionCurrency (string) minLength
            if (this.TransactionCurrency != null && this.TransactionCurrency.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionCurrency, length must be greater than 0.", new [] { "TransactionCurrency" });
            }

            // ExchangeRate (string) maxLength
            if (this.ExchangeRate != null && this.ExchangeRate.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExchangeRate, length must be less than 1024.", new [] { "ExchangeRate" });
            }

            // ExchangeRate (string) minLength
            if (this.ExchangeRate != null && this.ExchangeRate.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExchangeRate, length must be greater than 0.", new [] { "ExchangeRate" });
            }

            yield break;
        }
    }
}