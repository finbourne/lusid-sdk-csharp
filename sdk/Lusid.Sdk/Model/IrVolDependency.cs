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
    /// Economic dependency required to price interest rate products that contain optionality, for example swaptions.  For example, can indicate a dependency on an IrVolCubeData.
    /// </summary>
    [DataContract(Name = "IrVolDependency")]
    [JsonConverter(typeof(JsonSubtypes), "DependencyType")]
    public partial class IrVolDependency : EconomicDependency, IEquatable<IrVolDependency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IrVolDependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IrVolDependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IrVolDependency" /> class.
        /// </summary>
        /// <param name="currency">The domestic currency of the instrument declaring this dependency. (required).</param>
        /// <param name="volType">Volatility type e.g. \&quot;LN\&quot; and \&quot;N\&quot; for log-normal and normal volatility. (required).</param>
        /// <param name="date">The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date. (required).</param>
        /// <param name="dependencyType">The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor (required) (default to &quot;IrVolDependency&quot;).</param>
        public IrVolDependency(string currency = default(string), string volType = default(string), DateTimeOffset date = default(DateTimeOffset), DependencyTypeEnum dependencyType = default(DependencyTypeEnum)) : base(dependencyType)
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for IrVolDependency and cannot be null");
            }
            this.Currency = currency;
            // to ensure "volType" is required (not null)
            if (volType == null)
            {
                throw new ArgumentNullException("volType is a required property for IrVolDependency and cannot be null");
            }
            this.VolType = volType;
            this.Date = date;
        }

        /// <summary>
        /// The domestic currency of the instrument declaring this dependency.
        /// </summary>
        /// <value>The domestic currency of the instrument declaring this dependency.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Volatility type e.g. \&quot;LN\&quot; and \&quot;N\&quot; for log-normal and normal volatility.
        /// </summary>
        /// <value>Volatility type e.g. \&quot;LN\&quot; and \&quot;N\&quot; for log-normal and normal volatility.</value>
        [DataMember(Name = "volType", IsRequired = true, EmitDefaultValue = true)]
        public string VolType { get; set; }

        /// <summary>
        /// The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date.
        /// </summary>
        /// <value>The effectiveDate of the entity that this is a dependency for.  Unless there is an obvious date this should be, like for a historic reset, then this is the valuation date.</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IrVolDependency {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  VolType: ").Append(VolType).Append("\n");
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
            return this.Equals(input as IrVolDependency);
        }

        /// <summary>
        /// Returns true if IrVolDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of IrVolDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IrVolDependency input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.VolType == input.VolType ||
                    (this.VolType != null &&
                    this.VolType.Equals(input.VolType))
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
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.VolType != null)
                {
                    hashCode = (hashCode * 59) + this.VolType.GetHashCode();
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
            // VolType (string) maxLength
            if (this.VolType != null && this.VolType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VolType, length must be less than 50.", new [] { "VolType" });
            }

            // VolType (string) minLength
            if (this.VolType != null && this.VolType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VolType, length must be greater than 0.", new [] { "VolType" });
            }

            yield break;
        }
    }
}
