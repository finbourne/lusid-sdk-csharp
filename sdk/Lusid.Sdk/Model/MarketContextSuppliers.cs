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
    /// It is possible to control which supplier is used for a given asset class.  This field is deprecated in favour of market data rules, which subsumes its functionality.
    /// </summary>
    [DataContract(Name = "MarketContext_suppliers")]
    public partial class MarketContextSuppliers : IEquatable<MarketContextSuppliers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketContextSuppliers" /> class.
        /// </summary>
        /// <param name="commodity">commodity.</param>
        /// <param name="credit">credit.</param>
        /// <param name="equity">equity.</param>
        /// <param name="fx">fx.</param>
        /// <param name="rates">rates.</param>
        public MarketContextSuppliers(string commodity = default(string), string credit = default(string), string equity = default(string), string fx = default(string), string rates = default(string))
        {
            this.Commodity = commodity;
            this.Credit = credit;
            this.Equity = equity;
            this.Fx = fx;
            this.Rates = rates;
        }

        /// <summary>
        /// Gets or Sets Commodity
        /// </summary>
        [DataMember(Name = "Commodity", EmitDefaultValue = false)]
        public string Commodity { get; set; }

        /// <summary>
        /// Gets or Sets Credit
        /// </summary>
        [DataMember(Name = "Credit", EmitDefaultValue = false)]
        public string Credit { get; set; }

        /// <summary>
        /// Gets or Sets Equity
        /// </summary>
        [DataMember(Name = "Equity", EmitDefaultValue = false)]
        public string Equity { get; set; }

        /// <summary>
        /// Gets or Sets Fx
        /// </summary>
        [DataMember(Name = "Fx", EmitDefaultValue = false)]
        public string Fx { get; set; }

        /// <summary>
        /// Gets or Sets Rates
        /// </summary>
        [DataMember(Name = "Rates", EmitDefaultValue = false)]
        public string Rates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarketContextSuppliers {\n");
            sb.Append("  Commodity: ").Append(Commodity).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Equity: ").Append(Equity).Append("\n");
            sb.Append("  Fx: ").Append(Fx).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
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
            return this.Equals(input as MarketContextSuppliers);
        }

        /// <summary>
        /// Returns true if MarketContextSuppliers instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketContextSuppliers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketContextSuppliers input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Commodity == input.Commodity ||
                    (this.Commodity != null &&
                    this.Commodity.Equals(input.Commodity))
                ) && 
                (
                    this.Credit == input.Credit ||
                    (this.Credit != null &&
                    this.Credit.Equals(input.Credit))
                ) && 
                (
                    this.Equity == input.Equity ||
                    (this.Equity != null &&
                    this.Equity.Equals(input.Equity))
                ) && 
                (
                    this.Fx == input.Fx ||
                    (this.Fx != null &&
                    this.Fx.Equals(input.Fx))
                ) && 
                (
                    this.Rates == input.Rates ||
                    (this.Rates != null &&
                    this.Rates.Equals(input.Rates))
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
                if (this.Commodity != null)
                {
                    hashCode = (hashCode * 59) + this.Commodity.GetHashCode();
                }
                if (this.Credit != null)
                {
                    hashCode = (hashCode * 59) + this.Credit.GetHashCode();
                }
                if (this.Equity != null)
                {
                    hashCode = (hashCode * 59) + this.Equity.GetHashCode();
                }
                if (this.Fx != null)
                {
                    hashCode = (hashCode * 59) + this.Fx.GetHashCode();
                }
                if (this.Rates != null)
                {
                    hashCode = (hashCode * 59) + this.Rates.GetHashCode();
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
