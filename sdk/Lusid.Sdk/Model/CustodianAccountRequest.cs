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
    /// CustodianAccountRequest
    /// </summary>
    [DataContract(Name = "CustodianAccountRequest")]
    public partial class CustodianAccountRequest : IEquatable<CustodianAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustodianAccountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustodianAccountRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustodianAccountRequest" /> class.
        /// </summary>
        /// <param name="scope">The Scope assigned to the Custodian Account, where left blank the parent Portfolio Scope will be used.</param>
        /// <param name="code">Unique Code representing the Custodian Account (required).</param>
        /// <param name="status">The Account status. Can be Active, Inactive or Deleted..</param>
        /// <param name="accountNumber">The Custodian Account Number (required).</param>
        /// <param name="accountName">The identifiable name given to the Custodian Account (required).</param>
        /// <param name="accountingMethod">The Accounting method to be used (required).</param>
        /// <param name="currency">The Currency for the Account (required).</param>
        /// <param name="properties">Set of unique Custodian Account properties and associated values to store with the Custodian Account. Each property must be from the &#39;CustodianAccount&#39; domain..</param>
        /// <param name="custodianIdentifier">custodianIdentifier (required).</param>
        /// <param name="accountType">The Type of the Custodian Account. Can be Margin, Cash or Swap. Defaults to Margin..</param>
        public CustodianAccountRequest(string scope = default(string), string code = default(string), string status = default(string), string accountNumber = default(string), string accountName = default(string), string accountingMethod = default(string), string currency = default(string), Dictionary<string, Property> properties = default(Dictionary<string, Property>), TypedResourceId custodianIdentifier = default(TypedResourceId), string accountType = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for CustodianAccountRequest and cannot be null");
            }
            this.Code = code;
            // to ensure "accountNumber" is required (not null)
            if (accountNumber == null)
            {
                throw new ArgumentNullException("accountNumber is a required property for CustodianAccountRequest and cannot be null");
            }
            this.AccountNumber = accountNumber;
            // to ensure "accountName" is required (not null)
            if (accountName == null)
            {
                throw new ArgumentNullException("accountName is a required property for CustodianAccountRequest and cannot be null");
            }
            this.AccountName = accountName;
            // to ensure "accountingMethod" is required (not null)
            if (accountingMethod == null)
            {
                throw new ArgumentNullException("accountingMethod is a required property for CustodianAccountRequest and cannot be null");
            }
            this.AccountingMethod = accountingMethod;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for CustodianAccountRequest and cannot be null");
            }
            this.Currency = currency;
            // to ensure "custodianIdentifier" is required (not null)
            if (custodianIdentifier == null)
            {
                throw new ArgumentNullException("custodianIdentifier is a required property for CustodianAccountRequest and cannot be null");
            }
            this.CustodianIdentifier = custodianIdentifier;
            this.Scope = scope;
            this.Status = status;
            this.Properties = properties;
            this.AccountType = accountType;
        }

        /// <summary>
        /// The Scope assigned to the Custodian Account, where left blank the parent Portfolio Scope will be used
        /// </summary>
        /// <value>The Scope assigned to the Custodian Account, where left blank the parent Portfolio Scope will be used</value>
        [DataMember(Name = "scope", EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// Unique Code representing the Custodian Account
        /// </summary>
        /// <value>Unique Code representing the Custodian Account</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The Account status. Can be Active, Inactive or Deleted.
        /// </summary>
        /// <value>The Account status. Can be Active, Inactive or Deleted.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// The Custodian Account Number
        /// </summary>
        /// <value>The Custodian Account Number</value>
        [DataMember(Name = "accountNumber", IsRequired = true, EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The identifiable name given to the Custodian Account
        /// </summary>
        /// <value>The identifiable name given to the Custodian Account</value>
        [DataMember(Name = "accountName", IsRequired = true, EmitDefaultValue = true)]
        public string AccountName { get; set; }

        /// <summary>
        /// The Accounting method to be used
        /// </summary>
        /// <value>The Accounting method to be used</value>
        [DataMember(Name = "accountingMethod", IsRequired = true, EmitDefaultValue = true)]
        public string AccountingMethod { get; set; }

        /// <summary>
        /// The Currency for the Account
        /// </summary>
        /// <value>The Currency for the Account</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Set of unique Custodian Account properties and associated values to store with the Custodian Account. Each property must be from the &#39;CustodianAccount&#39; domain.
        /// </summary>
        /// <value>Set of unique Custodian Account properties and associated values to store with the Custodian Account. Each property must be from the &#39;CustodianAccount&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// Gets or Sets CustodianIdentifier
        /// </summary>
        [DataMember(Name = "custodianIdentifier", IsRequired = true, EmitDefaultValue = true)]
        public TypedResourceId CustodianIdentifier { get; set; }

        /// <summary>
        /// The Type of the Custodian Account. Can be Margin, Cash or Swap. Defaults to Margin.
        /// </summary>
        /// <value>The Type of the Custodian Account. Can be Margin, Cash or Swap. Defaults to Margin.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = true)]
        public string AccountType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustodianAccountRequest {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountingMethod: ").Append(AccountingMethod).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  CustodianIdentifier: ").Append(CustodianIdentifier).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
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
            return this.Equals(input as CustodianAccountRequest);
        }

        /// <summary>
        /// Returns true if CustodianAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CustodianAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustodianAccountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AccountingMethod == input.AccountingMethod ||
                    (this.AccountingMethod != null &&
                    this.AccountingMethod.Equals(input.AccountingMethod))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.CustodianIdentifier == input.CustodianIdentifier ||
                    (this.CustodianIdentifier != null &&
                    this.CustodianIdentifier.Equals(input.CustodianIdentifier))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
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
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.AccountingMethod != null)
                {
                    hashCode = (hashCode * 59) + this.AccountingMethod.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.CustodianIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.CustodianIdentifier.GetHashCode();
                }
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
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
            // Scope (string) maxLength
            if (this.Scope != null && this.Scope.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be less than 64.", new [] { "Scope" });
            }

            // Scope (string) minLength
            if (this.Scope != null && this.Scope.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be greater than 0.", new [] { "Scope" });
            }

            // Scope (string) pattern
            Regex regexScope = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexScope.Match(this.Scope).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, must match a pattern of " + regexScope, new [] { "Scope" });
            }

            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 64.", new [] { "Code" });
            }

            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            // Code (string) pattern
            Regex regexCode = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexCode.Match(this.Code).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, must match a pattern of " + regexCode, new [] { "Code" });
            }

            // AccountNumber (string) maxLength
            if (this.AccountNumber != null && this.AccountNumber.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 64.", new [] { "AccountNumber" });
            }

            // AccountNumber (string) minLength
            if (this.AccountNumber != null && this.AccountNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 1.", new [] { "AccountNumber" });
            }

            // AccountName (string) maxLength
            if (this.AccountName != null && this.AccountName.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountName, length must be less than 512.", new [] { "AccountName" });
            }

            // AccountName (string) minLength
            if (this.AccountName != null && this.AccountName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountName, length must be greater than 1.", new [] { "AccountName" });
            }

            // AccountName (string) pattern
            Regex regexAccountName = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexAccountName.Match(this.AccountName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountName, must match a pattern of " + regexAccountName, new [] { "AccountName" });
            }

            // AccountingMethod (string) minLength
            if (this.AccountingMethod != null && this.AccountingMethod.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountingMethod, length must be greater than 1.", new [] { "AccountingMethod" });
            }

            yield break;
        }
    }
}
