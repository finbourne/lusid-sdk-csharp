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
    /// ResultDataKeyRule
    /// </summary>
    [DataContract(Name = "ResultDataKeyRule")]
    [JsonConverter(typeof(JsonSubtypes), "ResultKeyRuleType")]
    public partial class ResultDataKeyRule : ResultKeyRule, IEquatable<ResultDataKeyRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDataKeyRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResultDataKeyRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultDataKeyRule" /> class.
        /// </summary>
        /// <param name="supplier">the result resource supplier (where the data comes from) (required).</param>
        /// <param name="dataScope">which is the scope in which the data should be found (required).</param>
        /// <param name="documentCode">document code that defines which document is desired (required).</param>
        /// <param name="quoteInterval">Shorthand for the time interval used to select result data. This must be a dot-separated string              specifying a start and end date, for example &#39;5D.0D&#39; to look back 5 days from today (0 days ago)..</param>
        /// <param name="asAt">The AsAt predicate specification..</param>
        /// <param name="resourceKey">The result data key that identifies the address pattern that this is a rule for (required).</param>
        /// <param name="documentResultType">documentResultType (required).</param>
        /// <param name="resultKeyRuleType">The available values are: Invalid, ResultDataKeyRule, PortfolioResultDataKeyRule (required) (default to &quot;ResultDataKeyRule&quot;).</param>
        public ResultDataKeyRule(string supplier = default(string), string dataScope = default(string), string documentCode = default(string), string quoteInterval = default(string), DateTimeOffset? asAt = default(DateTimeOffset?), string resourceKey = default(string), string documentResultType = default(string), ResultKeyRuleTypeEnum resultKeyRuleType = default(ResultKeyRuleTypeEnum)) : base(resultKeyRuleType)
        {
            // to ensure "supplier" is required (not null)
            if (supplier == null)
            {
                throw new ArgumentNullException("supplier is a required property for ResultDataKeyRule and cannot be null");
            }
            this.Supplier = supplier;
            // to ensure "dataScope" is required (not null)
            if (dataScope == null)
            {
                throw new ArgumentNullException("dataScope is a required property for ResultDataKeyRule and cannot be null");
            }
            this.DataScope = dataScope;
            // to ensure "documentCode" is required (not null)
            if (documentCode == null)
            {
                throw new ArgumentNullException("documentCode is a required property for ResultDataKeyRule and cannot be null");
            }
            this.DocumentCode = documentCode;
            // to ensure "resourceKey" is required (not null)
            if (resourceKey == null)
            {
                throw new ArgumentNullException("resourceKey is a required property for ResultDataKeyRule and cannot be null");
            }
            this.ResourceKey = resourceKey;
            // to ensure "documentResultType" is required (not null)
            if (documentResultType == null)
            {
                throw new ArgumentNullException("documentResultType is a required property for ResultDataKeyRule and cannot be null");
            }
            this.DocumentResultType = documentResultType;
            this.QuoteInterval = quoteInterval;
            this.AsAt = asAt;
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
        /// The result data key that identifies the address pattern that this is a rule for
        /// </summary>
        /// <value>The result data key that identifies the address pattern that this is a rule for</value>
        [DataMember(Name = "resourceKey", IsRequired = true, EmitDefaultValue = true)]
        public string ResourceKey { get; set; }

        /// <summary>
        /// Gets or Sets DocumentResultType
        /// </summary>
        [DataMember(Name = "documentResultType", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentResultType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResultDataKeyRule {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  DataScope: ").Append(DataScope).Append("\n");
            sb.Append("  DocumentCode: ").Append(DocumentCode).Append("\n");
            sb.Append("  QuoteInterval: ").Append(QuoteInterval).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  ResourceKey: ").Append(ResourceKey).Append("\n");
            sb.Append("  DocumentResultType: ").Append(DocumentResultType).Append("\n");
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
            return this.Equals(input as ResultDataKeyRule);
        }

        /// <summary>
        /// Returns true if ResultDataKeyRule instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultDataKeyRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultDataKeyRule input)
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
                    this.ResourceKey == input.ResourceKey ||
                    (this.ResourceKey != null &&
                    this.ResourceKey.Equals(input.ResourceKey))
                ) && base.Equals(input) && 
                (
                    this.DocumentResultType == input.DocumentResultType ||
                    (this.DocumentResultType != null &&
                    this.DocumentResultType.Equals(input.DocumentResultType))
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
                if (this.ResourceKey != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceKey.GetHashCode();
                }
                if (this.DocumentResultType != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentResultType.GetHashCode();
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

            // ResourceKey (string) maxLength
            if (this.ResourceKey != null && this.ResourceKey.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResourceKey, length must be less than 256.", new [] { "ResourceKey" });
            }

            // ResourceKey (string) minLength
            if (this.ResourceKey != null && this.ResourceKey.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResourceKey, length must be greater than 0.", new [] { "ResourceKey" });
            }

            // DocumentResultType (string) minLength
            if (this.DocumentResultType != null && this.DocumentResultType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentResultType, length must be greater than 1.", new [] { "DocumentResultType" });
            }

            yield break;
        }
    }
}
