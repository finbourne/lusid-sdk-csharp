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
    /// DeletedEntityResponse
    /// </summary>
    [DataContract(Name = "DeletedEntityResponse")]
    public partial class DeletedEntityResponse : IEquatable<DeletedEntityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedEntityResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeletedEntityResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedEntityResponse" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="effectiveFrom">The effective datetime at which the deletion became valid. May be null in the case where multiple date times are applicable..</param>
        /// <param name="asAt">The asAt datetime at which the deletion was committed to LUSID. (required).</param>
        /// <param name="entityType">The type of the entity that the deleted response applies to..</param>
        /// <param name="entityUniqueId">The unique Id of the entity that the deleted response applies to..</param>
        /// <param name="stagedModifications">stagedModifications.</param>
        /// <param name="links">links.</param>
        public DeletedEntityResponse(string href = default(string), DateTimeOffset? effectiveFrom = default(DateTimeOffset?), DateTimeOffset asAt = default(DateTimeOffset), string entityType = default(string), string entityUniqueId = default(string), StagedModificationsInfo stagedModifications = default(StagedModificationsInfo), List<Link> links = default(List<Link>))
        {
            this.AsAt = asAt;
            this.Href = href;
            this.EffectiveFrom = effectiveFrom;
            this.EntityType = entityType;
            this.EntityUniqueId = entityUniqueId;
            this.StagedModifications = stagedModifications;
            this.Links = links;
        }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// The effective datetime at which the deletion became valid. May be null in the case where multiple date times are applicable.
        /// </summary>
        /// <value>The effective datetime at which the deletion became valid. May be null in the case where multiple date times are applicable.</value>
        [DataMember(Name = "effectiveFrom", EmitDefaultValue = true)]
        public DateTimeOffset? EffectiveFrom { get; set; }

        /// <summary>
        /// The asAt datetime at which the deletion was committed to LUSID.
        /// </summary>
        /// <value>The asAt datetime at which the deletion was committed to LUSID.</value>
        [DataMember(Name = "asAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset AsAt { get; set; }

        /// <summary>
        /// The type of the entity that the deleted response applies to.
        /// </summary>
        /// <value>The type of the entity that the deleted response applies to.</value>
        [DataMember(Name = "entityType", EmitDefaultValue = true)]
        public string EntityType { get; set; }

        /// <summary>
        /// The unique Id of the entity that the deleted response applies to.
        /// </summary>
        /// <value>The unique Id of the entity that the deleted response applies to.</value>
        [DataMember(Name = "entityUniqueId", EmitDefaultValue = true)]
        public string EntityUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets StagedModifications
        /// </summary>
        [DataMember(Name = "stagedModifications", EmitDefaultValue = false)]
        public StagedModificationsInfo StagedModifications { get; set; }

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
            sb.Append("class DeletedEntityResponse {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  EntityUniqueId: ").Append(EntityUniqueId).Append("\n");
            sb.Append("  StagedModifications: ").Append(StagedModifications).Append("\n");
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
            return this.Equals(input as DeletedEntityResponse);
        }

        /// <summary>
        /// Returns true if DeletedEntityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeletedEntityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletedEntityResponse input)
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
                    this.EffectiveFrom == input.EffectiveFrom ||
                    (this.EffectiveFrom != null &&
                    this.EffectiveFrom.Equals(input.EffectiveFrom))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.EntityUniqueId == input.EntityUniqueId ||
                    (this.EntityUniqueId != null &&
                    this.EntityUniqueId.Equals(input.EntityUniqueId))
                ) && 
                (
                    this.StagedModifications == input.StagedModifications ||
                    (this.StagedModifications != null &&
                    this.StagedModifications.Equals(input.StagedModifications))
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
                if (this.EffectiveFrom != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveFrom.GetHashCode();
                }
                if (this.AsAt != null)
                {
                    hashCode = (hashCode * 59) + this.AsAt.GetHashCode();
                }
                if (this.EntityType != null)
                {
                    hashCode = (hashCode * 59) + this.EntityType.GetHashCode();
                }
                if (this.EntityUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.EntityUniqueId.GetHashCode();
                }
                if (this.StagedModifications != null)
                {
                    hashCode = (hashCode * 59) + this.StagedModifications.GetHashCode();
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
