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
    /// An AborConfiguration entity.
    /// </summary>
    [DataContract(Name = "AborConfiguration")]
    public partial class AborConfiguration : IEquatable<AborConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AborConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AborConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AborConfiguration" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">The name of the Abor Configuration..</param>
        /// <param name="description">A description for the Abor Configuration..</param>
        /// <param name="recipeId">recipeId.</param>
        /// <param name="chartOfAccountsId">chartOfAccountsId (required).</param>
        /// <param name="postingModuleCodes">The Posting Module Codes from which the rules to be applied are retrieved..</param>
        /// <param name="cleardownModuleCodes">The Cleardown Module Codes from which the rules to be applied are retrieved..</param>
        /// <param name="properties">A set of properties for the Abor Configuration..</param>
        /// <param name="version">version.</param>
        /// <param name="links">links.</param>
        public AborConfiguration(string href = default(string), ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), ResourceId recipeId = default(ResourceId), ResourceId chartOfAccountsId = default(ResourceId), List<string> postingModuleCodes = default(List<string>), List<string> cleardownModuleCodes = default(List<string>), Dictionary<string, Property> properties = default(Dictionary<string, Property>), ModelVersion version = default(ModelVersion), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AborConfiguration and cannot be null");
            }
            this.Id = id;
            // to ensure "chartOfAccountsId" is required (not null)
            if (chartOfAccountsId == null)
            {
                throw new ArgumentNullException("chartOfAccountsId is a required property for AborConfiguration and cannot be null");
            }
            this.ChartOfAccountsId = chartOfAccountsId;
            this.Href = href;
            this.DisplayName = displayName;
            this.Description = description;
            this.RecipeId = recipeId;
            this.PostingModuleCodes = postingModuleCodes;
            this.CleardownModuleCodes = cleardownModuleCodes;
            this.Properties = properties;
            this._Version = version;
            this.Links = links;
        }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The name of the Abor Configuration.
        /// </summary>
        /// <value>The name of the Abor Configuration.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A description for the Abor Configuration.
        /// </summary>
        /// <value>A description for the Abor Configuration.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets RecipeId
        /// </summary>
        [DataMember(Name = "recipeId", EmitDefaultValue = false)]
        public ResourceId RecipeId { get; set; }

        /// <summary>
        /// Gets or Sets ChartOfAccountsId
        /// </summary>
        [DataMember(Name = "chartOfAccountsId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId ChartOfAccountsId { get; set; }

        /// <summary>
        /// The Posting Module Codes from which the rules to be applied are retrieved.
        /// </summary>
        /// <value>The Posting Module Codes from which the rules to be applied are retrieved.</value>
        [DataMember(Name = "postingModuleCodes", EmitDefaultValue = true)]
        public List<string> PostingModuleCodes { get; set; }

        /// <summary>
        /// The Cleardown Module Codes from which the rules to be applied are retrieved.
        /// </summary>
        /// <value>The Cleardown Module Codes from which the rules to be applied are retrieved.</value>
        [DataMember(Name = "cleardownModuleCodes", EmitDefaultValue = true)]
        public List<string> CleardownModuleCodes { get; set; }

        /// <summary>
        /// A set of properties for the Abor Configuration.
        /// </summary>
        /// <value>A set of properties for the Abor Configuration.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public ModelVersion _Version { get; set; }

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
            sb.Append("class AborConfiguration {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RecipeId: ").Append(RecipeId).Append("\n");
            sb.Append("  ChartOfAccountsId: ").Append(ChartOfAccountsId).Append("\n");
            sb.Append("  PostingModuleCodes: ").Append(PostingModuleCodes).Append("\n");
            sb.Append("  CleardownModuleCodes: ").Append(CleardownModuleCodes).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as AborConfiguration);
        }

        /// <summary>
        /// Returns true if AborConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of AborConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AborConfiguration input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.RecipeId == input.RecipeId ||
                    (this.RecipeId != null &&
                    this.RecipeId.Equals(input.RecipeId))
                ) && 
                (
                    this.ChartOfAccountsId == input.ChartOfAccountsId ||
                    (this.ChartOfAccountsId != null &&
                    this.ChartOfAccountsId.Equals(input.ChartOfAccountsId))
                ) && 
                (
                    this.PostingModuleCodes == input.PostingModuleCodes ||
                    this.PostingModuleCodes != null &&
                    input.PostingModuleCodes != null &&
                    this.PostingModuleCodes.SequenceEqual(input.PostingModuleCodes)
                ) && 
                (
                    this.CleardownModuleCodes == input.CleardownModuleCodes ||
                    this.CleardownModuleCodes != null &&
                    input.CleardownModuleCodes != null &&
                    this.CleardownModuleCodes.SequenceEqual(input.CleardownModuleCodes)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.RecipeId != null)
                {
                    hashCode = (hashCode * 59) + this.RecipeId.GetHashCode();
                }
                if (this.ChartOfAccountsId != null)
                {
                    hashCode = (hashCode * 59) + this.ChartOfAccountsId.GetHashCode();
                }
                if (this.PostingModuleCodes != null)
                {
                    hashCode = (hashCode * 59) + this.PostingModuleCodes.GetHashCode();
                }
                if (this.CleardownModuleCodes != null)
                {
                    hashCode = (hashCode * 59) + this.CleardownModuleCodes.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
            yield break;
        }
    }
}
