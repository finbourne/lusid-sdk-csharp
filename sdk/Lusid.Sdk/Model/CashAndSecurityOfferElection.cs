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
    /// Election for events that result in both cash and equity via a merger or acquisition
    /// </summary>
    [DataContract(Name = "CashAndSecurityOfferElection")]
    public partial class CashAndSecurityOfferElection : IEquatable<CashAndSecurityOfferElection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashAndSecurityOfferElection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CashAndSecurityOfferElection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashAndSecurityOfferElection" /> class.
        /// </summary>
        /// <param name="cashOfferCurrency">Currency of the cash offer (required).</param>
        /// <param name="cashOfferPrice">Price per share of the cash offer (required).</param>
        /// <param name="costFactor">Optional. The fraction of cost that is transferred from the existing shares to the new shares..</param>
        /// <param name="electionKey">Unique key associated to this election. (required).</param>
        /// <param name="isChosen">Is this the election that has been explicitly chosen from multiple options..</param>
        /// <param name="isDefault">Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided..</param>
        /// <param name="unitsRatio">unitsRatio (required).</param>
        public CashAndSecurityOfferElection(string cashOfferCurrency = default(string), decimal cashOfferPrice = default(decimal), decimal? costFactor = default(decimal?), string electionKey = default(string), bool isChosen = default(bool), bool isDefault = default(bool), UnitsRatio unitsRatio = default(UnitsRatio))
        {
            // to ensure "cashOfferCurrency" is required (not null)
            if (cashOfferCurrency == null)
            {
                throw new ArgumentNullException("cashOfferCurrency is a required property for CashAndSecurityOfferElection and cannot be null");
            }
            this.CashOfferCurrency = cashOfferCurrency;
            this.CashOfferPrice = cashOfferPrice;
            // to ensure "electionKey" is required (not null)
            if (electionKey == null)
            {
                throw new ArgumentNullException("electionKey is a required property for CashAndSecurityOfferElection and cannot be null");
            }
            this.ElectionKey = electionKey;
            // to ensure "unitsRatio" is required (not null)
            if (unitsRatio == null)
            {
                throw new ArgumentNullException("unitsRatio is a required property for CashAndSecurityOfferElection and cannot be null");
            }
            this.UnitsRatio = unitsRatio;
            this.CostFactor = costFactor;
            this.IsChosen = isChosen;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Currency of the cash offer
        /// </summary>
        /// <value>Currency of the cash offer</value>
        [DataMember(Name = "cashOfferCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string CashOfferCurrency { get; set; }

        /// <summary>
        /// Price per share of the cash offer
        /// </summary>
        /// <value>Price per share of the cash offer</value>
        [DataMember(Name = "cashOfferPrice", IsRequired = true, EmitDefaultValue = true)]
        public decimal CashOfferPrice { get; set; }

        /// <summary>
        /// Optional. The fraction of cost that is transferred from the existing shares to the new shares.
        /// </summary>
        /// <value>Optional. The fraction of cost that is transferred from the existing shares to the new shares.</value>
        [DataMember(Name = "costFactor", EmitDefaultValue = true)]
        public decimal? CostFactor { get; set; }

        /// <summary>
        /// Unique key associated to this election.
        /// </summary>
        /// <value>Unique key associated to this election.</value>
        [DataMember(Name = "electionKey", IsRequired = true, EmitDefaultValue = true)]
        public string ElectionKey { get; set; }

        /// <summary>
        /// Is this the election that has been explicitly chosen from multiple options.
        /// </summary>
        /// <value>Is this the election that has been explicitly chosen from multiple options.</value>
        [DataMember(Name = "isChosen", EmitDefaultValue = true)]
        public bool IsChosen { get; set; }

        /// <summary>
        /// Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided.
        /// </summary>
        /// <value>Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided.</value>
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets UnitsRatio
        /// </summary>
        [DataMember(Name = "unitsRatio", IsRequired = true, EmitDefaultValue = true)]
        public UnitsRatio UnitsRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CashAndSecurityOfferElection {\n");
            sb.Append("  CashOfferCurrency: ").Append(CashOfferCurrency).Append("\n");
            sb.Append("  CashOfferPrice: ").Append(CashOfferPrice).Append("\n");
            sb.Append("  CostFactor: ").Append(CostFactor).Append("\n");
            sb.Append("  ElectionKey: ").Append(ElectionKey).Append("\n");
            sb.Append("  IsChosen: ").Append(IsChosen).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  UnitsRatio: ").Append(UnitsRatio).Append("\n");
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
            return this.Equals(input as CashAndSecurityOfferElection);
        }

        /// <summary>
        /// Returns true if CashAndSecurityOfferElection instances are equal
        /// </summary>
        /// <param name="input">Instance of CashAndSecurityOfferElection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashAndSecurityOfferElection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CashOfferCurrency == input.CashOfferCurrency ||
                    (this.CashOfferCurrency != null &&
                    this.CashOfferCurrency.Equals(input.CashOfferCurrency))
                ) && 
                (
                    this.CashOfferPrice == input.CashOfferPrice ||
                    this.CashOfferPrice.Equals(input.CashOfferPrice)
                ) && 
                (
                    this.CostFactor == input.CostFactor ||
                    (this.CostFactor != null &&
                    this.CostFactor.Equals(input.CostFactor))
                ) && 
                (
                    this.ElectionKey == input.ElectionKey ||
                    (this.ElectionKey != null &&
                    this.ElectionKey.Equals(input.ElectionKey))
                ) && 
                (
                    this.IsChosen == input.IsChosen ||
                    this.IsChosen.Equals(input.IsChosen)
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.UnitsRatio == input.UnitsRatio ||
                    (this.UnitsRatio != null &&
                    this.UnitsRatio.Equals(input.UnitsRatio))
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
                if (this.CashOfferCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.CashOfferCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CashOfferPrice.GetHashCode();
                if (this.CostFactor != null)
                {
                    hashCode = (hashCode * 59) + this.CostFactor.GetHashCode();
                }
                if (this.ElectionKey != null)
                {
                    hashCode = (hashCode * 59) + this.ElectionKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsChosen.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                if (this.UnitsRatio != null)
                {
                    hashCode = (hashCode * 59) + this.UnitsRatio.GetHashCode();
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
            // ElectionKey (string) minLength
            if (this.ElectionKey != null && this.ElectionKey.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ElectionKey, length must be greater than 1.", new [] { "ElectionKey" });
            }

            yield break;
        }
    }
}
