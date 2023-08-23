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
    /// PortfolioGroup
    /// </summary>
    [DataContract(Name = "PortfolioGroup")]
    public partial class PortfolioGroup : IEquatable<PortfolioGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfolioGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroup" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">The name of the portfolio group. (required).</param>
        /// <param name="description">The long form description of the portfolio group..</param>
        /// <param name="created">The effective datetime at which the portfolio group was created. No portfolios or sub groups can be added to the group before this date..</param>
        /// <param name="portfolios">The collection of resource identifiers for the portfolios contained in the portfolio group..</param>
        /// <param name="subGroups">The collection of resource identifiers for the portfolio groups contained in the portfolio group as sub groups..</param>
        /// <param name="relationships">A set of relationships associated to the portfolio group..</param>
        /// <param name="version">version.</param>
        /// <param name="links">links.</param>
        public PortfolioGroup(string href = default(string), ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), DateTimeOffset created = default(DateTimeOffset), List<ResourceId> portfolios = default(List<ResourceId>), List<ResourceId> subGroups = default(List<ResourceId>), List<Relationship> relationships = default(List<Relationship>), ModelVersion version = default(ModelVersion), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PortfolioGroup and cannot be null");
            }
            this.Id = id;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for PortfolioGroup and cannot be null");
            }
            this.DisplayName = displayName;
            this.Href = href;
            this.Description = description;
            this.Created = created;
            this.Portfolios = portfolios;
            this.SubGroups = subGroups;
            this.Relationships = relationships;
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
        /// The name of the portfolio group.
        /// </summary>
        /// <value>The name of the portfolio group.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The long form description of the portfolio group.
        /// </summary>
        /// <value>The long form description of the portfolio group.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The effective datetime at which the portfolio group was created. No portfolios or sub groups can be added to the group before this date.
        /// </summary>
        /// <value>The effective datetime at which the portfolio group was created. No portfolios or sub groups can be added to the group before this date.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// The collection of resource identifiers for the portfolios contained in the portfolio group.
        /// </summary>
        /// <value>The collection of resource identifiers for the portfolios contained in the portfolio group.</value>
        [DataMember(Name = "portfolios", EmitDefaultValue = true)]
        public List<ResourceId> Portfolios { get; set; }

        /// <summary>
        /// The collection of resource identifiers for the portfolio groups contained in the portfolio group as sub groups.
        /// </summary>
        /// <value>The collection of resource identifiers for the portfolio groups contained in the portfolio group as sub groups.</value>
        [DataMember(Name = "subGroups", EmitDefaultValue = true)]
        public List<ResourceId> SubGroups { get; set; }

        /// <summary>
        /// A set of relationships associated to the portfolio group.
        /// </summary>
        /// <value>A set of relationships associated to the portfolio group.</value>
        [DataMember(Name = "relationships", EmitDefaultValue = true)]
        public List<Relationship> Relationships { get; set; }

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
            sb.Append("class PortfolioGroup {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Portfolios: ").Append(Portfolios).Append("\n");
            sb.Append("  SubGroups: ").Append(SubGroups).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
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
            return this.Equals(input as PortfolioGroup);
        }

        /// <summary>
        /// Returns true if PortfolioGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioGroup input)
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
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Portfolios == input.Portfolios ||
                    this.Portfolios != null &&
                    input.Portfolios != null &&
                    this.Portfolios.SequenceEqual(input.Portfolios)
                ) && 
                (
                    this.SubGroups == input.SubGroups ||
                    this.SubGroups != null &&
                    input.SubGroups != null &&
                    this.SubGroups.SequenceEqual(input.SubGroups)
                ) && 
                (
                    this.Relationships == input.Relationships ||
                    this.Relationships != null &&
                    input.Relationships != null &&
                    this.Relationships.SequenceEqual(input.Relationships)
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
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Portfolios != null)
                {
                    hashCode = (hashCode * 59) + this.Portfolios.GetHashCode();
                }
                if (this.SubGroups != null)
                {
                    hashCode = (hashCode * 59) + this.SubGroups.GetHashCode();
                }
                if (this.Relationships != null)
                {
                    hashCode = (hashCode * 59) + this.Relationships.GetHashCode();
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
            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            yield break;
        }
    }
}
