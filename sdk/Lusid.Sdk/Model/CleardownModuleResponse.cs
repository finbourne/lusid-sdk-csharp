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
    /// A Cleardown Module definition
    /// </summary>
    [DataContract(Name = "CleardownModuleResponse")]
    public partial class CleardownModuleResponse : IEquatable<CleardownModuleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CleardownModuleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CleardownModuleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CleardownModuleResponse" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="cleardownModuleCode">The code of the Cleardown Module. (required).</param>
        /// <param name="chartOfAccountsId">chartOfAccountsId (required).</param>
        /// <param name="displayName">The name of the Cleardown Module. (required).</param>
        /// <param name="description">A description for the Cleardown Module..</param>
        /// <param name="rules">The Cleardown Rules that apply for the Cleardown Module. Rules are evaluated in the order they occur in this collection..</param>
        /// <param name="status">The Cleardown Module status. Can be Active, Inactive or Deleted. Defaults to Active. (required).</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="links">links.</param>
        public CleardownModuleResponse(string href = default(string), string cleardownModuleCode = default(string), ResourceId chartOfAccountsId = default(ResourceId), string displayName = default(string), string description = default(string), List<CleardownModuleRule> rules = default(List<CleardownModuleRule>), string status = default(string), ModelVersion varVersion = default(ModelVersion), List<Link> links = default(List<Link>))
        {
            // to ensure "cleardownModuleCode" is required (not null)
            if (cleardownModuleCode == null)
            {
                throw new ArgumentNullException("cleardownModuleCode is a required property for CleardownModuleResponse and cannot be null");
            }
            this.CleardownModuleCode = cleardownModuleCode;
            // to ensure "chartOfAccountsId" is required (not null)
            if (chartOfAccountsId == null)
            {
                throw new ArgumentNullException("chartOfAccountsId is a required property for CleardownModuleResponse and cannot be null");
            }
            this.ChartOfAccountsId = chartOfAccountsId;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for CleardownModuleResponse and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for CleardownModuleResponse and cannot be null");
            }
            this.Status = status;
            this.Href = href;
            this.Description = description;
            this.Rules = rules;
            this.VarVersion = varVersion;
            this.Links = links;
        }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// The code of the Cleardown Module.
        /// </summary>
        /// <value>The code of the Cleardown Module.</value>
        [DataMember(Name = "cleardownModuleCode", IsRequired = true, EmitDefaultValue = true)]
        public string CleardownModuleCode { get; set; }

        /// <summary>
        /// Gets or Sets ChartOfAccountsId
        /// </summary>
        [DataMember(Name = "chartOfAccountsId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId ChartOfAccountsId { get; set; }

        /// <summary>
        /// The name of the Cleardown Module.
        /// </summary>
        /// <value>The name of the Cleardown Module.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A description for the Cleardown Module.
        /// </summary>
        /// <value>A description for the Cleardown Module.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The Cleardown Rules that apply for the Cleardown Module. Rules are evaluated in the order they occur in this collection.
        /// </summary>
        /// <value>The Cleardown Rules that apply for the Cleardown Module. Rules are evaluated in the order they occur in this collection.</value>
        [DataMember(Name = "rules", EmitDefaultValue = true)]
        public List<CleardownModuleRule> Rules { get; set; }

        /// <summary>
        /// The Cleardown Module status. Can be Active, Inactive or Deleted. Defaults to Active.
        /// </summary>
        /// <value>The Cleardown Module status. Can be Active, Inactive or Deleted. Defaults to Active.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public ModelVersion VarVersion { get; set; }

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
            sb.Append("class CleardownModuleResponse {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  CleardownModuleCode: ").Append(CleardownModuleCode).Append("\n");
            sb.Append("  ChartOfAccountsId: ").Append(ChartOfAccountsId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            return this.Equals(input as CleardownModuleResponse);
        }

        /// <summary>
        /// Returns true if CleardownModuleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CleardownModuleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CleardownModuleResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.CleardownModuleCode == input.CleardownModuleCode ||
                    (this.CleardownModuleCode != null &&
                    this.CleardownModuleCode.Equals(input.CleardownModuleCode))
                ) && 
                (
                    this.ChartOfAccountsId == input.ChartOfAccountsId ||
                    (this.ChartOfAccountsId != null &&
                    this.ChartOfAccountsId.Equals(input.ChartOfAccountsId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    (this.VarVersion != null &&
                    this.VarVersion.Equals(input.VarVersion))
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
                if (this.Href != null)
                {
                    hashCode = (hashCode * 59) + this.Href.GetHashCode();
                }
                if (this.CleardownModuleCode != null)
                {
                    hashCode = (hashCode * 59) + this.CleardownModuleCode.GetHashCode();
                }
                if (this.ChartOfAccountsId != null)
                {
                    hashCode = (hashCode * 59) + this.ChartOfAccountsId.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.VarVersion != null)
                {
                    hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
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
            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Description (string) pattern
            Regex regexDescription = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexDescription.Match(this.Description).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, must match a pattern of " + regexDescription, new [] { "Description" });
            }

            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            yield break;
        }
    }
}
