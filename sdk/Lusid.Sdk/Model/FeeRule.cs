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
    /// FeeRule
    /// </summary>
    [DataContract(Name = "FeeRule")]
    public partial class FeeRule : IEquatable<FeeRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeRule" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="transactionPropertyKey">transactionPropertyKey (required).</param>
        /// <param name="transactionType">transactionType (required).</param>
        /// <param name="country">country (required).</param>
        /// <param name="counterparty">counterparty (required).</param>
        /// <param name="transactionCurrency">transactionCurrency (required).</param>
        /// <param name="settlementCurrency">settlementCurrency (required).</param>
        /// <param name="executionBroker">executionBroker (required).</param>
        /// <param name="custodian">custodian (required).</param>
        /// <param name="exchange">exchange (required).</param>
        /// <param name="fee">fee (required).</param>
        /// <param name="minFee">minFee.</param>
        /// <param name="maxFee">maxFee.</param>
        /// <param name="additionalKeys">additionalKeys.</param>
        /// <param name="description">description.</param>
        /// <param name="version">version.</param>
        /// <param name="links">links.</param>
        public FeeRule(string code = default(string), string transactionPropertyKey = default(string), string transactionType = default(string), string country = default(string), string counterparty = default(string), string transactionCurrency = default(string), string settlementCurrency = default(string), string executionBroker = default(string), string custodian = default(string), string exchange = default(string), CalculationInfo fee = default(CalculationInfo), CalculationInfo minFee = default(CalculationInfo), CalculationInfo maxFee = default(CalculationInfo), Dictionary<string, string> additionalKeys = default(Dictionary<string, string>), string description = default(string), ModelVersion version = default(ModelVersion), List<Link> links = default(List<Link>))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for FeeRule and cannot be null");
            }
            this.Code = code;
            // to ensure "transactionPropertyKey" is required (not null)
            if (transactionPropertyKey == null)
            {
                throw new ArgumentNullException("transactionPropertyKey is a required property for FeeRule and cannot be null");
            }
            this.TransactionPropertyKey = transactionPropertyKey;
            // to ensure "transactionType" is required (not null)
            if (transactionType == null)
            {
                throw new ArgumentNullException("transactionType is a required property for FeeRule and cannot be null");
            }
            this.TransactionType = transactionType;
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for FeeRule and cannot be null");
            }
            this.Country = country;
            // to ensure "counterparty" is required (not null)
            if (counterparty == null)
            {
                throw new ArgumentNullException("counterparty is a required property for FeeRule and cannot be null");
            }
            this.Counterparty = counterparty;
            // to ensure "transactionCurrency" is required (not null)
            if (transactionCurrency == null)
            {
                throw new ArgumentNullException("transactionCurrency is a required property for FeeRule and cannot be null");
            }
            this.TransactionCurrency = transactionCurrency;
            // to ensure "settlementCurrency" is required (not null)
            if (settlementCurrency == null)
            {
                throw new ArgumentNullException("settlementCurrency is a required property for FeeRule and cannot be null");
            }
            this.SettlementCurrency = settlementCurrency;
            // to ensure "executionBroker" is required (not null)
            if (executionBroker == null)
            {
                throw new ArgumentNullException("executionBroker is a required property for FeeRule and cannot be null");
            }
            this.ExecutionBroker = executionBroker;
            // to ensure "custodian" is required (not null)
            if (custodian == null)
            {
                throw new ArgumentNullException("custodian is a required property for FeeRule and cannot be null");
            }
            this.Custodian = custodian;
            // to ensure "exchange" is required (not null)
            if (exchange == null)
            {
                throw new ArgumentNullException("exchange is a required property for FeeRule and cannot be null");
            }
            this.Exchange = exchange;
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new ArgumentNullException("fee is a required property for FeeRule and cannot be null");
            }
            this.Fee = fee;
            this.MinFee = minFee;
            this.MaxFee = maxFee;
            this.AdditionalKeys = additionalKeys;
            this.Description = description;
            this._Version = version;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets TransactionPropertyKey
        /// </summary>
        [DataMember(Name = "transactionPropertyKey", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionPropertyKey { get; set; }

        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name = "transactionType", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Counterparty
        /// </summary>
        [DataMember(Name = "counterparty", IsRequired = true, EmitDefaultValue = true)]
        public string Counterparty { get; set; }

        /// <summary>
        /// Gets or Sets TransactionCurrency
        /// </summary>
        [DataMember(Name = "transactionCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionCurrency { get; set; }

        /// <summary>
        /// Gets or Sets SettlementCurrency
        /// </summary>
        [DataMember(Name = "settlementCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionBroker
        /// </summary>
        [DataMember(Name = "executionBroker", IsRequired = true, EmitDefaultValue = true)]
        public string ExecutionBroker { get; set; }

        /// <summary>
        /// Gets or Sets Custodian
        /// </summary>
        [DataMember(Name = "custodian", IsRequired = true, EmitDefaultValue = true)]
        public string Custodian { get; set; }

        /// <summary>
        /// Gets or Sets Exchange
        /// </summary>
        [DataMember(Name = "exchange", IsRequired = true, EmitDefaultValue = true)]
        public string Exchange { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", IsRequired = true, EmitDefaultValue = true)]
        public CalculationInfo Fee { get; set; }

        /// <summary>
        /// Gets or Sets MinFee
        /// </summary>
        [DataMember(Name = "minFee", EmitDefaultValue = false)]
        public CalculationInfo MinFee { get; set; }

        /// <summary>
        /// Gets or Sets MaxFee
        /// </summary>
        [DataMember(Name = "maxFee", EmitDefaultValue = false)]
        public CalculationInfo MaxFee { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalKeys
        /// </summary>
        [DataMember(Name = "additionalKeys", EmitDefaultValue = true)]
        public Dictionary<string, string> AdditionalKeys { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public ModelVersion _Version { get; set; }

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
            sb.Append("class FeeRule {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  TransactionPropertyKey: ").Append(TransactionPropertyKey).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
            sb.Append("  TransactionCurrency: ").Append(TransactionCurrency).Append("\n");
            sb.Append("  SettlementCurrency: ").Append(SettlementCurrency).Append("\n");
            sb.Append("  ExecutionBroker: ").Append(ExecutionBroker).Append("\n");
            sb.Append("  Custodian: ").Append(Custodian).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  MinFee: ").Append(MinFee).Append("\n");
            sb.Append("  MaxFee: ").Append(MaxFee).Append("\n");
            sb.Append("  AdditionalKeys: ").Append(AdditionalKeys).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as FeeRule);
        }

        /// <summary>
        /// Returns true if FeeRule instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.TransactionPropertyKey == input.TransactionPropertyKey ||
                    (this.TransactionPropertyKey != null &&
                    this.TransactionPropertyKey.Equals(input.TransactionPropertyKey))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Counterparty == input.Counterparty ||
                    (this.Counterparty != null &&
                    this.Counterparty.Equals(input.Counterparty))
                ) && 
                (
                    this.TransactionCurrency == input.TransactionCurrency ||
                    (this.TransactionCurrency != null &&
                    this.TransactionCurrency.Equals(input.TransactionCurrency))
                ) && 
                (
                    this.SettlementCurrency == input.SettlementCurrency ||
                    (this.SettlementCurrency != null &&
                    this.SettlementCurrency.Equals(input.SettlementCurrency))
                ) && 
                (
                    this.ExecutionBroker == input.ExecutionBroker ||
                    (this.ExecutionBroker != null &&
                    this.ExecutionBroker.Equals(input.ExecutionBroker))
                ) && 
                (
                    this.Custodian == input.Custodian ||
                    (this.Custodian != null &&
                    this.Custodian.Equals(input.Custodian))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.MinFee == input.MinFee ||
                    (this.MinFee != null &&
                    this.MinFee.Equals(input.MinFee))
                ) && 
                (
                    this.MaxFee == input.MaxFee ||
                    (this.MaxFee != null &&
                    this.MaxFee.Equals(input.MaxFee))
                ) && 
                (
                    this.AdditionalKeys == input.AdditionalKeys ||
                    this.AdditionalKeys != null &&
                    input.AdditionalKeys != null &&
                    this.AdditionalKeys.SequenceEqual(input.AdditionalKeys)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.TransactionPropertyKey != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionPropertyKey.GetHashCode();
                }
                if (this.TransactionType != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionType.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Counterparty != null)
                {
                    hashCode = (hashCode * 59) + this.Counterparty.GetHashCode();
                }
                if (this.TransactionCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionCurrency.GetHashCode();
                }
                if (this.SettlementCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementCurrency.GetHashCode();
                }
                if (this.ExecutionBroker != null)
                {
                    hashCode = (hashCode * 59) + this.ExecutionBroker.GetHashCode();
                }
                if (this.Custodian != null)
                {
                    hashCode = (hashCode * 59) + this.Custodian.GetHashCode();
                }
                if (this.Exchange != null)
                {
                    hashCode = (hashCode * 59) + this.Exchange.GetHashCode();
                }
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.MinFee != null)
                {
                    hashCode = (hashCode * 59) + this.MinFee.GetHashCode();
                }
                if (this.MaxFee != null)
                {
                    hashCode = (hashCode * 59) + this.MaxFee.GetHashCode();
                }
                if (this.AdditionalKeys != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalKeys.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            // TransactionType (string) minLength
            if (this.TransactionType != null && this.TransactionType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionType, length must be greater than 1.", new [] { "TransactionType" });
            }

            // Country (string) minLength
            if (this.Country != null && this.Country.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be greater than 1.", new [] { "Country" });
            }

            // Counterparty (string) minLength
            if (this.Counterparty != null && this.Counterparty.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Counterparty, length must be greater than 1.", new [] { "Counterparty" });
            }

            // TransactionCurrency (string) minLength
            if (this.TransactionCurrency != null && this.TransactionCurrency.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionCurrency, length must be greater than 1.", new [] { "TransactionCurrency" });
            }

            // SettlementCurrency (string) minLength
            if (this.SettlementCurrency != null && this.SettlementCurrency.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SettlementCurrency, length must be greater than 1.", new [] { "SettlementCurrency" });
            }

            // ExecutionBroker (string) minLength
            if (this.ExecutionBroker != null && this.ExecutionBroker.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExecutionBroker, length must be greater than 1.", new [] { "ExecutionBroker" });
            }

            // Custodian (string) minLength
            if (this.Custodian != null && this.Custodian.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Custodian, length must be greater than 1.", new [] { "Custodian" });
            }

            // Exchange (string) minLength
            if (this.Exchange != null && this.Exchange.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Exchange, length must be greater than 1.", new [] { "Exchange" });
            }

            yield break;
        }
    }
}
