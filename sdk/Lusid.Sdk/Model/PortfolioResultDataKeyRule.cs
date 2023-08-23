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
    /// PortfolioResultDataKeyRule
    /// </summary>
    [DataContract(Name = "PortfolioResultDataKeyRule")]
    [JsonConverter(typeof(JsonSubtypes), "ResultKeyRuleType")]
    public partial class PortfolioResultDataKeyRule : ResultKeyRule, IEquatable<PortfolioResultDataKeyRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioResultDataKeyRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfolioResultDataKeyRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioResultDataKeyRule" /> class.
        /// </summary>
        /// <param name="supplier">the result resource supplier (where the data comes from) (required).</param>
        /// <param name="dataScope">which is the scope in which the data should be found (required).</param>
        /// <param name="documentCode">document code that defines which document is desired (required).</param>
        /// <param name="quoteInterval">Shorthand for the time interval used to select result data. This must be a dot-separated string              specifying a start and end date, for example &#39;5D.0D&#39; to look back 5 days from today (0 days ago)..</param>
        /// <param name="asAt">The AsAt predicate specification..</param>
        /// <param name="portfolioCode">portfolioCode.</param>
        /// <param name="portfolioScope">portfolioScope.</param>
        /// <param name="resultKeyRuleType">The available values are: Invalid, ResultDataKeyRule, PortfolioResultDataKeyRule (required) (default to &quot;PortfolioResultDataKeyRule&quot;).</param>
        public PortfolioResultDataKeyRule(string supplier = default(string), string dataScope = default(string), string documentCode = default(string), string quoteInterval = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string portfolioCode = default(string), string portfolioScope = default(string), ResultKeyRuleTypeEnum resultKeyRuleType = default(ResultKeyRuleTypeEnum)) : base(resultKeyRuleType)
        {
            // to ensure "supplier" is required (not null)
            if (supplier == null)
            {
                throw new ArgumentNullException("supplier is a required property for PortfolioResultDataKeyRule and cannot be null");
            }
            this.Supplier = supplier;
            // to ensure "dataScope" is required (not null)
            if (dataScope == null)
            {
                throw new ArgumentNullException("dataScope is a required property for PortfolioResultDataKeyRule and cannot be null");
            }
            this.DataScope = dataScope;
            // to ensure "documentCode" is required (not null)
            if (documentCode == null)
            {
                throw new ArgumentNullException("documentCode is a required property for PortfolioResultDataKeyRule and cannot be null");
            }
            this.DocumentCode = documentCode;
            this.QuoteInterval = quoteInterval;
            this.AsAt = asAt;
            this.PortfolioCode = portfolioCode;
            this.PortfolioScope = portfolioScope;
        }

        /// <summary>
        /// the result resource supplier (where the data comes from)
        /// </summary>
        /// <value>the result resource supplier (where the data comes from)</value>
        [DataMember(Name = "supplier", IsRequired = true, EmitDefaultValue = true)]
        public string Supplier { get; set; }

        /// <summary>
        /// which is the scope in which the data should be found
        /// </summary>
        /// <value>which is the scope in which the data should be found</value>
        [DataMember(Name = "dataScope", IsRequired = true, EmitDefaultValue = true)]
        public string DataScope { get; set; }

        /// <summary>
        /// document code that defines which document is desired
        /// </summary>
        /// <value>document code that defines which document is desired</value>
        [DataMember(Name = "documentCode", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentCode { get; set; }

        /// <summary>
        /// Shorthand for the time interval used to select result data. This must be a dot-separated string              specifying a start and end date, for example &#39;5D.0D&#39; to look back 5 days from today (0 days ago).
        /// </summary>
        /// <value>Shorthand for the time interval used to select result data. This must be a dot-separated string              specifying a start and end date, for example &#39;5D.0D&#39; to look back 5 days from today (0 days ago).</value>
        [DataMember(Name = "quoteInterval", EmitDefaultValue = true)]
        public string QuoteInterval { get; set; }

        /// <summary>
        /// The AsAt predicate specification.
        /// </summary>
        /// <value>The AsAt predicate specification.</value>
        [DataMember(Name = "asAt", EmitDefaultValue = true)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioCode
        /// </summary>
        [DataMember(Name = "portfolioCode", EmitDefaultValue = true)]
        public string PortfolioCode { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioScope
        /// </summary>
        [DataMember(Name = "portfolioScope", EmitDefaultValue = true)]
        public string PortfolioScope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PortfolioResultDataKeyRule {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  DataScope: ").Append(DataScope).Append("\n");
            sb.Append("  DocumentCode: ").Append(DocumentCode).Append("\n");
            sb.Append("  QuoteInterval: ").Append(QuoteInterval).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  PortfolioCode: ").Append(PortfolioCode).Append("\n");
            sb.Append("  PortfolioScope: ").Append(PortfolioScope).Append("\n");
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
            return this.Equals(input as PortfolioResultDataKeyRule);
        }

        /// <summary>
        /// Returns true if PortfolioResultDataKeyRule instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioResultDataKeyRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioResultDataKeyRule input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Supplier == input.Supplier ||
                    (this.Supplier != null &&
                    this.Supplier.Equals(input.Supplier))
                ) && base.Equals(input) && 
                (
                    this.DataScope == input.DataScope ||
                    (this.DataScope != null &&
                    this.DataScope.Equals(input.DataScope))
                ) && base.Equals(input) && 
                (
                    this.DocumentCode == input.DocumentCode ||
                    (this.DocumentCode != null &&
                    this.DocumentCode.Equals(input.DocumentCode))
                ) && base.Equals(input) && 
                (
                    this.QuoteInterval == input.QuoteInterval ||
                    (this.QuoteInterval != null &&
                    this.QuoteInterval.Equals(input.QuoteInterval))
                ) && base.Equals(input) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
                ) && base.Equals(input) && 
                (
                    this.PortfolioCode == input.PortfolioCode ||
                    (this.PortfolioCode != null &&
                    this.PortfolioCode.Equals(input.PortfolioCode))
                ) && base.Equals(input) && 
                (
                    this.PortfolioScope == input.PortfolioScope ||
                    (this.PortfolioScope != null &&
                    this.PortfolioScope.Equals(input.PortfolioScope))
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
                if (this.Supplier != null)
                {
                    hashCode = (hashCode * 59) + this.Supplier.GetHashCode();
                }
                if (this.DataScope != null)
                {
                    hashCode = (hashCode * 59) + this.DataScope.GetHashCode();
                }
                if (this.DocumentCode != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentCode.GetHashCode();
                }
                if (this.QuoteInterval != null)
                {
                    hashCode = (hashCode * 59) + this.QuoteInterval.GetHashCode();
                }
                if (this.AsAt != null)
                {
                    hashCode = (hashCode * 59) + this.AsAt.GetHashCode();
                }
                if (this.PortfolioCode != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioCode.GetHashCode();
                }
                if (this.PortfolioScope != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioScope.GetHashCode();
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
            // Supplier (string) maxLength
            if (this.Supplier != null && this.Supplier.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Supplier, length must be less than 32.", new [] { "Supplier" });
            }

            // Supplier (string) minLength
            if (this.Supplier != null && this.Supplier.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Supplier, length must be greater than 0.", new [] { "Supplier" });
            }

            // DataScope (string) maxLength
            if (this.DataScope != null && this.DataScope.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DataScope, length must be less than 256.", new [] { "DataScope" });
            }

            // DataScope (string) minLength
            if (this.DataScope != null && this.DataScope.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DataScope, length must be greater than 1.", new [] { "DataScope" });
            }

            // DataScope (string) pattern
            Regex regexDataScope = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexDataScope.Match(this.DataScope).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DataScope, must match a pattern of " + regexDataScope, new [] { "DataScope" });
            }

            // DocumentCode (string) maxLength
            if (this.DocumentCode != null && this.DocumentCode.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentCode, length must be less than 256.", new [] { "DocumentCode" });
            }

            // DocumentCode (string) minLength
            if (this.DocumentCode != null && this.DocumentCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentCode, length must be greater than 1.", new [] { "DocumentCode" });
            }

            // QuoteInterval (string) maxLength
            if (this.QuoteInterval != null && this.QuoteInterval.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for QuoteInterval, length must be less than 16.", new [] { "QuoteInterval" });
            }

            // QuoteInterval (string) minLength
            if (this.QuoteInterval != null && this.QuoteInterval.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for QuoteInterval, length must be greater than 0.", new [] { "QuoteInterval" });
            }

            // PortfolioCode (string) maxLength
            if (this.PortfolioCode != null && this.PortfolioCode.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioCode, length must be less than 256.", new [] { "PortfolioCode" });
            }

            // PortfolioCode (string) minLength
            if (this.PortfolioCode != null && this.PortfolioCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioCode, length must be greater than 1.", new [] { "PortfolioCode" });
            }

            // PortfolioCode (string) pattern
            Regex regexPortfolioCode = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexPortfolioCode.Match(this.PortfolioCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioCode, must match a pattern of " + regexPortfolioCode, new [] { "PortfolioCode" });
            }

            // PortfolioScope (string) maxLength
            if (this.PortfolioScope != null && this.PortfolioScope.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioScope, length must be less than 256.", new [] { "PortfolioScope" });
            }

            // PortfolioScope (string) minLength
            if (this.PortfolioScope != null && this.PortfolioScope.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioScope, length must be greater than 1.", new [] { "PortfolioScope" });
            }

            // PortfolioScope (string) pattern
            Regex regexPortfolioScope = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexPortfolioScope.Match(this.PortfolioScope).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioScope, must match a pattern of " + regexPortfolioScope, new [] { "PortfolioScope" });
            }

            yield break;
        }
    }
}
