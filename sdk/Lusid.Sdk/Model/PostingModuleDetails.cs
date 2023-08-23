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
    /// A posting Module request definition
    /// </summary>
    [DataContract(Name = "PostingModuleDetails")]
    public partial class PostingModuleDetails : IEquatable<PostingModuleDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostingModuleDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostingModuleDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostingModuleDetails" /> class.
        /// </summary>
        /// <param name="chartOfAccountsId">chartOfAccountsId (required).</param>
        /// <param name="name">The name to identify the Posting Module by (required).</param>
        /// <param name="description">The description for the posting module.</param>
        /// <param name="status">The Posting Module status. Can be Active, Inactive or Deleted. Defaults to Active. (required).</param>
        public PostingModuleDetails(ResourceId chartOfAccountsId = default(ResourceId), string name = default(string), string description = default(string), string status = default(string))
        {
            // to ensure "chartOfAccountsId" is required (not null)
            if (chartOfAccountsId == null)
            {
                throw new ArgumentNullException("chartOfAccountsId is a required property for PostingModuleDetails and cannot be null");
            }
            this.ChartOfAccountsId = chartOfAccountsId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PostingModuleDetails and cannot be null");
            }
            this.Name = name;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for PostingModuleDetails and cannot be null");
            }
            this.Status = status;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets ChartOfAccountsId
        /// </summary>
        [DataMember(Name = "chartOfAccountsId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId ChartOfAccountsId { get; set; }

        /// <summary>
        /// The name to identify the Posting Module by
        /// </summary>
        /// <value>The name to identify the Posting Module by</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The description for the posting module
        /// </summary>
        /// <value>The description for the posting module</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The Posting Module status. Can be Active, Inactive or Deleted. Defaults to Active.
        /// </summary>
        /// <value>The Posting Module status. Can be Active, Inactive or Deleted. Defaults to Active.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostingModuleDetails {\n");
            sb.Append("  ChartOfAccountsId: ").Append(ChartOfAccountsId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PostingModuleDetails);
        }

        /// <summary>
        /// Returns true if PostingModuleDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PostingModuleDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostingModuleDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChartOfAccountsId == input.ChartOfAccountsId ||
                    (this.ChartOfAccountsId != null &&
                    this.ChartOfAccountsId.Equals(input.ChartOfAccountsId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ChartOfAccountsId != null)
                {
                    hashCode = (hashCode * 59) + this.ChartOfAccountsId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 256.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^[^\\<>&\""]+$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
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
