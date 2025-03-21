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
    /// Representation of a Relationship between a requested entity with the stated entity as RelatedEntityId
    /// </summary>
    [DataContract(Name = "Relationship")]
    public partial class Relationship : IEquatable<Relationship>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationship" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Relationship() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Relationship" /> class.
        /// </summary>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="relationshipDefinitionId">relationshipDefinitionId (required).</param>
        /// <param name="relatedEntity">relatedEntity (required).</param>
        /// <param name="traversalDirection">Direction of relationship between the requested entity and related entity. This can be &#39;In&#39; or &#39;Out&#39;. Read more about relationships traversal direction in LUSID Knowledge Base here https://support.lusid.com/knowledgebase/article/KA-01679. (required).</param>
        /// <param name="traversalDescription">Description of the relationship based on relationship&#39;s traversal direction. If &#39;TraversalDirection&#39; is &#39;Out&#39;, this description would be &#39;OutwardDescription&#39; from the associated relationship definition. If &#39;TraversalDirection&#39; is &#39;In&#39;, this description would be &#39;InwardDescription&#39; from the associated relationship definition. (required).</param>
        /// <param name="effectiveFrom">The effective datetime from which the relationship is valid..</param>
        /// <param name="effectiveUntil">The effective datetime until which the relationship is valid. If no future deletions are present or an effective until has not been set for the relationship, this will be indefinite and represented by the maximum date..</param>
        public Relationship(ModelVersion varVersion = default(ModelVersion), ResourceId relationshipDefinitionId = default(ResourceId), RelatedEntity relatedEntity = default(RelatedEntity), string traversalDirection = default(string), string traversalDescription = default(string), DateTimeOffset effectiveFrom = default(DateTimeOffset), DateTimeOffset effectiveUntil = default(DateTimeOffset))
        {
            // to ensure "relationshipDefinitionId" is required (not null)
            if (relationshipDefinitionId == null)
            {
                throw new ArgumentNullException("relationshipDefinitionId is a required property for Relationship and cannot be null");
            }
            this.RelationshipDefinitionId = relationshipDefinitionId;
            // to ensure "relatedEntity" is required (not null)
            if (relatedEntity == null)
            {
                throw new ArgumentNullException("relatedEntity is a required property for Relationship and cannot be null");
            }
            this.RelatedEntity = relatedEntity;
            // to ensure "traversalDirection" is required (not null)
            if (traversalDirection == null)
            {
                throw new ArgumentNullException("traversalDirection is a required property for Relationship and cannot be null");
            }
            this.TraversalDirection = traversalDirection;
            // to ensure "traversalDescription" is required (not null)
            if (traversalDescription == null)
            {
                throw new ArgumentNullException("traversalDescription is a required property for Relationship and cannot be null");
            }
            this.TraversalDescription = traversalDescription;
            this.VarVersion = varVersion;
            this.EffectiveFrom = effectiveFrom;
            this.EffectiveUntil = effectiveUntil;
        }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public ModelVersion VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets RelationshipDefinitionId
        /// </summary>
        [DataMember(Name = "relationshipDefinitionId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId RelationshipDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets RelatedEntity
        /// </summary>
        [DataMember(Name = "relatedEntity", IsRequired = true, EmitDefaultValue = true)]
        public RelatedEntity RelatedEntity { get; set; }

        /// <summary>
        /// Direction of relationship between the requested entity and related entity. This can be &#39;In&#39; or &#39;Out&#39;. Read more about relationships traversal direction in LUSID Knowledge Base here https://support.lusid.com/knowledgebase/article/KA-01679.
        /// </summary>
        /// <value>Direction of relationship between the requested entity and related entity. This can be &#39;In&#39; or &#39;Out&#39;. Read more about relationships traversal direction in LUSID Knowledge Base here https://support.lusid.com/knowledgebase/article/KA-01679.</value>
        [DataMember(Name = "traversalDirection", IsRequired = true, EmitDefaultValue = true)]
        public string TraversalDirection { get; set; }

        /// <summary>
        /// Description of the relationship based on relationship&#39;s traversal direction. If &#39;TraversalDirection&#39; is &#39;Out&#39;, this description would be &#39;OutwardDescription&#39; from the associated relationship definition. If &#39;TraversalDirection&#39; is &#39;In&#39;, this description would be &#39;InwardDescription&#39; from the associated relationship definition.
        /// </summary>
        /// <value>Description of the relationship based on relationship&#39;s traversal direction. If &#39;TraversalDirection&#39; is &#39;Out&#39;, this description would be &#39;OutwardDescription&#39; from the associated relationship definition. If &#39;TraversalDirection&#39; is &#39;In&#39;, this description would be &#39;InwardDescription&#39; from the associated relationship definition.</value>
        [DataMember(Name = "traversalDescription", IsRequired = true, EmitDefaultValue = true)]
        public string TraversalDescription { get; set; }

        /// <summary>
        /// The effective datetime from which the relationship is valid.
        /// </summary>
        /// <value>The effective datetime from which the relationship is valid.</value>
        [DataMember(Name = "effectiveFrom", EmitDefaultValue = false)]
        public DateTimeOffset EffectiveFrom { get; set; }

        /// <summary>
        /// The effective datetime until which the relationship is valid. If no future deletions are present or an effective until has not been set for the relationship, this will be indefinite and represented by the maximum date.
        /// </summary>
        /// <value>The effective datetime until which the relationship is valid. If no future deletions are present or an effective until has not been set for the relationship, this will be indefinite and represented by the maximum date.</value>
        [DataMember(Name = "effectiveUntil", EmitDefaultValue = false)]
        public DateTimeOffset EffectiveUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Relationship {\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  RelationshipDefinitionId: ").Append(RelationshipDefinitionId).Append("\n");
            sb.Append("  RelatedEntity: ").Append(RelatedEntity).Append("\n");
            sb.Append("  TraversalDirection: ").Append(TraversalDirection).Append("\n");
            sb.Append("  TraversalDescription: ").Append(TraversalDescription).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
            sb.Append("  EffectiveUntil: ").Append(EffectiveUntil).Append("\n");
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
            return this.Equals(input as Relationship);
        }

        /// <summary>
        /// Returns true if Relationship instances are equal
        /// </summary>
        /// <param name="input">Instance of Relationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Relationship input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarVersion == input.VarVersion ||
                    (this.VarVersion != null &&
                    this.VarVersion.Equals(input.VarVersion))
                ) && 
                (
                    this.RelationshipDefinitionId == input.RelationshipDefinitionId ||
                    (this.RelationshipDefinitionId != null &&
                    this.RelationshipDefinitionId.Equals(input.RelationshipDefinitionId))
                ) && 
                (
                    this.RelatedEntity == input.RelatedEntity ||
                    (this.RelatedEntity != null &&
                    this.RelatedEntity.Equals(input.RelatedEntity))
                ) && 
                (
                    this.TraversalDirection == input.TraversalDirection ||
                    (this.TraversalDirection != null &&
                    this.TraversalDirection.Equals(input.TraversalDirection))
                ) && 
                (
                    this.TraversalDescription == input.TraversalDescription ||
                    (this.TraversalDescription != null &&
                    this.TraversalDescription.Equals(input.TraversalDescription))
                ) && 
                (
                    this.EffectiveFrom == input.EffectiveFrom ||
                    (this.EffectiveFrom != null &&
                    this.EffectiveFrom.Equals(input.EffectiveFrom))
                ) && 
                (
                    this.EffectiveUntil == input.EffectiveUntil ||
                    (this.EffectiveUntil != null &&
                    this.EffectiveUntil.Equals(input.EffectiveUntil))
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
                if (this.VarVersion != null)
                {
                    hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                }
                if (this.RelationshipDefinitionId != null)
                {
                    hashCode = (hashCode * 59) + this.RelationshipDefinitionId.GetHashCode();
                }
                if (this.RelatedEntity != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedEntity.GetHashCode();
                }
                if (this.TraversalDirection != null)
                {
                    hashCode = (hashCode * 59) + this.TraversalDirection.GetHashCode();
                }
                if (this.TraversalDescription != null)
                {
                    hashCode = (hashCode * 59) + this.TraversalDescription.GetHashCode();
                }
                if (this.EffectiveFrom != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveFrom.GetHashCode();
                }
                if (this.EffectiveUntil != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveUntil.GetHashCode();
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
            // TraversalDirection (string) minLength
            if (this.TraversalDirection != null && this.TraversalDirection.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TraversalDirection, length must be greater than 1.", new [] { "TraversalDirection" });
            }

            // TraversalDescription (string) minLength
            if (this.TraversalDescription != null && this.TraversalDescription.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TraversalDescription, length must be greater than 1.", new [] { "TraversalDescription" });
            }

            yield break;
        }
    }
}
