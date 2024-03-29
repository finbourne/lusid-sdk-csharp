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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// For indicating a dependency on an fx rate.  For example domestic-foreign for USD-JPY  means that 1 unit (dollar) of domestic currency will buy you \&quot;X\&quot; units of foreign (Yen) currency; currently somewhere around 100.  This is equivalently denoted as USDJPY and USD/JPY                On the assumption that you wish to convert an amount in the domestic currency to the foreign, you would want the (dom,fgn) dependency; domfgn currency pair.  On the assumption that you wish to convert an amount in the foreign currency to the domestic, you would want the (fgn,dom) dependency; fgndom currency pair.                NB: There alternate descriptions for currency pairs that seem to vary between different banks and sectors of the industry, e.g. base and contract                In pricing we are taking the convention that we will convert from FGN to DOM by DIVIDING through by the DOMFGN spot rate.
    /// </summary>
    [DataContract(Name = "FxDependency")]
    [JsonConverter(typeof(JsonSubtypes), "DependencyType")]
    public partial class FxDependency : EconomicDependency, IEquatable<FxDependency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FxDependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxDependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxDependency" /> class.
        /// </summary>
        /// <param name="domesticCurrency">DomesticCurrency is the first currency in a currency pair quote e.g. eur-gbp, eur is the domestic currency. (required).</param>
        /// <param name="foreignCurrency">ForeignCurrency is the second currency in a currency pair quote e.g. eur-gbp, gbp is the foreign currency. (required).</param>
        /// <param name="date">The effectiveAt of the fx rate. (required).</param>
        /// <param name="dependencyType">The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency (required) (default to &quot;FxDependency&quot;).</param>
        public FxDependency(string domesticCurrency = default(string), string foreignCurrency = default(string), DateTimeOffset date = default(DateTimeOffset), DependencyTypeEnum dependencyType = default(DependencyTypeEnum)) : base(dependencyType)
        {
            // to ensure "domesticCurrency" is required (not null)
            if (domesticCurrency == null)
            {
                throw new ArgumentNullException("domesticCurrency is a required property for FxDependency and cannot be null");
            }
            this.DomesticCurrency = domesticCurrency;
            // to ensure "foreignCurrency" is required (not null)
            if (foreignCurrency == null)
            {
                throw new ArgumentNullException("foreignCurrency is a required property for FxDependency and cannot be null");
            }
            this.ForeignCurrency = foreignCurrency;
            this.Date = date;
        }

        /// <summary>
        /// DomesticCurrency is the first currency in a currency pair quote e.g. eur-gbp, eur is the domestic currency.
        /// </summary>
        /// <value>DomesticCurrency is the first currency in a currency pair quote e.g. eur-gbp, eur is the domestic currency.</value>
        [DataMember(Name = "domesticCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string DomesticCurrency { get; set; }

        /// <summary>
        /// ForeignCurrency is the second currency in a currency pair quote e.g. eur-gbp, gbp is the foreign currency.
        /// </summary>
        /// <value>ForeignCurrency is the second currency in a currency pair quote e.g. eur-gbp, gbp is the foreign currency.</value>
        [DataMember(Name = "foreignCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string ForeignCurrency { get; set; }

        /// <summary>
        /// The effectiveAt of the fx rate.
        /// </summary>
        /// <value>The effectiveAt of the fx rate.</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FxDependency {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DomesticCurrency: ").Append(DomesticCurrency).Append("\n");
            sb.Append("  ForeignCurrency: ").Append(ForeignCurrency).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as FxDependency);
        }

        /// <summary>
        /// Returns true if FxDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of FxDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxDependency input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.DomesticCurrency == input.DomesticCurrency ||
                    (this.DomesticCurrency != null &&
                    this.DomesticCurrency.Equals(input.DomesticCurrency))
                ) && base.Equals(input) && 
                (
                    this.ForeignCurrency == input.ForeignCurrency ||
                    (this.ForeignCurrency != null &&
                    this.ForeignCurrency.Equals(input.ForeignCurrency))
                ) && base.Equals(input) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                int hashCode = base.GetHashCode();
                if (this.DomesticCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.DomesticCurrency.GetHashCode();
                }
                if (this.ForeignCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignCurrency.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }
}
