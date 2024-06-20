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
    /// CashOfferElection for events for merger events resulting in cash
    /// </summary>
    [DataContract(Name = "CashOfferElection")]
    public partial class CashOfferElection : IEquatable<CashOfferElection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashOfferElection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CashOfferElection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashOfferElection" /> class.
        /// </summary>
        /// <param name="cashOfferCurrency">Currency of the cash offer (required).</param>
        /// <param name="cashOfferPrice">Price per share of the cash offer (required).</param>
        /// <param name="electionKey">Unique key associated to this election. (required).</param>
        /// <param name="isChosen">Is this the election that has been explicitly chosen from multiple options..</param>
        /// <param name="isDefault">Is this election automatically applied in the absence of an election having been made.  May only be true for one election if multiple are provided..</param>
        public CashOfferElection(string cashOfferCurrency = default(string), decimal cashOfferPrice = default(decimal), string electionKey = default(string), bool isChosen = default(bool), bool isDefault = default(bool))
        {
            // to ensure "cashOfferCurrency" is required (not null)
            if (cashOfferCurrency == null)
            {
                throw new ArgumentNullException("cashOfferCurrency is a required property for CashOfferElection and cannot be null");
            }
            this.CashOfferCurrency = cashOfferCurrency;
            this.CashOfferPrice = cashOfferPrice;
            // to ensure "electionKey" is required (not null)
            if (electionKey == null)
            {
                throw new ArgumentNullException("electionKey is a required property for CashOfferElection and cannot be null");
            }
            this.ElectionKey = electionKey;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CashOfferElection {\n");
            sb.Append("  CashOfferCurrency: ").Append(CashOfferCurrency).Append("\n");
            sb.Append("  CashOfferPrice: ").Append(CashOfferPrice).Append("\n");
            sb.Append("  ElectionKey: ").Append(ElectionKey).Append("\n");
            sb.Append("  IsChosen: ").Append(IsChosen).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
            return this.Equals(input as CashOfferElection);
        }

        /// <summary>
        /// Returns true if CashOfferElection instances are equal
        /// </summary>
        /// <param name="input">Instance of CashOfferElection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashOfferElection input)
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
                if (this.ElectionKey != null)
                {
                    hashCode = (hashCode * 59) + this.ElectionKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsChosen.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
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