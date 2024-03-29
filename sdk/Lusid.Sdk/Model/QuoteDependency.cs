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
    /// For indicating a dependency on the value of an asset at a point in time.  If the time is omitted, then the dependency is interpreted as the latest value with respect to anything observing it.  E.g. An EquitySwap will declare a dependency on the current price of the underlying equity.
    /// </summary>
    [DataContract(Name = "QuoteDependency")]
    [JsonConverter(typeof(JsonSubtypes), "DependencyType")]
    public partial class QuoteDependency : EconomicDependency, IEquatable<QuoteDependency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteDependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteDependency" /> class.
        /// </summary>
        /// <param name="marketIdentifier">Type of the code identifying the asset, e.g. ISIN or CUSIP (required).</param>
        /// <param name="code">The code identifying the corresponding equity, e.g. US0378331005 if the MarketIdentifier was set to ISIN (required).</param>
        /// <param name="date">The effectiveAt of the quote for the identified entity. (required).</param>
        /// <param name="dependencyType">The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency (required) (default to &quot;QuoteDependency&quot;).</param>
        public QuoteDependency(string marketIdentifier = default(string), string code = default(string), DateTimeOffset date = default(DateTimeOffset), DependencyTypeEnum dependencyType = default(DependencyTypeEnum)) : base(dependencyType)
        {
            // to ensure "marketIdentifier" is required (not null)
            if (marketIdentifier == null)
            {
                throw new ArgumentNullException("marketIdentifier is a required property for QuoteDependency and cannot be null");
            }
            this.MarketIdentifier = marketIdentifier;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for QuoteDependency and cannot be null");
            }
            this.Code = code;
            this.Date = date;
        }

        /// <summary>
        /// Type of the code identifying the asset, e.g. ISIN or CUSIP
        /// </summary>
        /// <value>Type of the code identifying the asset, e.g. ISIN or CUSIP</value>
        [DataMember(Name = "marketIdentifier", IsRequired = true, EmitDefaultValue = true)]
        public string MarketIdentifier { get; set; }

        /// <summary>
        /// The code identifying the corresponding equity, e.g. US0378331005 if the MarketIdentifier was set to ISIN
        /// </summary>
        /// <value>The code identifying the corresponding equity, e.g. US0378331005 if the MarketIdentifier was set to ISIN</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The effectiveAt of the quote for the identified entity.
        /// </summary>
        /// <value>The effectiveAt of the quote for the identified entity.</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuoteDependency {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  MarketIdentifier: ").Append(MarketIdentifier).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as QuoteDependency);
        }

        /// <summary>
        /// Returns true if QuoteDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteDependency input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.MarketIdentifier == input.MarketIdentifier ||
                    (this.MarketIdentifier != null &&
                    this.MarketIdentifier.Equals(input.MarketIdentifier))
                ) && base.Equals(input) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.MarketIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.MarketIdentifier.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
            // MarketIdentifier (string) minLength
            if (this.MarketIdentifier != null && this.MarketIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MarketIdentifier, length must be greater than 1.", new [] { "MarketIdentifier" });
            }

            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 50.", new [] { "Code" });
            }

            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 0.", new [] { "Code" });
            }

            yield break;
        }
    }
}
