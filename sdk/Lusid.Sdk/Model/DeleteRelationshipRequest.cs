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
    /// DeleteRelationshipRequest
    /// </summary>
    [DataContract(Name = "DeleteRelationshipRequest")]
    public partial class DeleteRelationshipRequest : IEquatable<DeleteRelationshipRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRelationshipRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteRelationshipRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRelationshipRequest" /> class.
        /// </summary>
        /// <param name="sourceEntityId">The identifier of the source entity of the relationship to be deleted. (required).</param>
        /// <param name="targetEntityId">The identifier of the target entity of the relationship to be deleted. (required).</param>
        /// <param name="effectiveFrom">The effective date of the relationship to be deleted.</param>
        /// <param name="effectiveUntil">The effective datetime until which the relationship will be deleted. If not supplied the deletion will be permanent..</param>
        public DeleteRelationshipRequest(Dictionary<string, string> sourceEntityId = default(Dictionary<string, string>), Dictionary<string, string> targetEntityId = default(Dictionary<string, string>), DateTimeOrCutLabel effectiveFrom = default(DateTimeOrCutLabel), DateTimeOrCutLabel effectiveUntil = default(DateTimeOrCutLabel))
        {
            // to ensure "sourceEntityId" is required (not null)
            if (sourceEntityId == null)
            {
                throw new ArgumentNullException("sourceEntityId is a required property for DeleteRelationshipRequest and cannot be null");
            }
            this.SourceEntityId = sourceEntityId;
            // to ensure "targetEntityId" is required (not null)
            if (targetEntityId == null)
            {
                throw new ArgumentNullException("targetEntityId is a required property for DeleteRelationshipRequest and cannot be null");
            }
            this.TargetEntityId = targetEntityId;
            this.EffectiveFrom = effectiveFrom;
            this.EffectiveUntil = effectiveUntil;
        }

        /// <summary>
        /// The identifier of the source entity of the relationship to be deleted.
        /// </summary>
        /// <value>The identifier of the source entity of the relationship to be deleted.</value>
        [DataMember(Name = "sourceEntityId", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> SourceEntityId { get; set; }

        /// <summary>
        /// The identifier of the target entity of the relationship to be deleted.
        /// </summary>
        /// <value>The identifier of the target entity of the relationship to be deleted.</value>
        [DataMember(Name = "targetEntityId", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> TargetEntityId { get; set; }

        /// <summary>
        /// The effective date of the relationship to be deleted
        /// </summary>
        /// <value>The effective date of the relationship to be deleted</value>
        [DataMember(Name = "effectiveFrom", EmitDefaultValue = true)]
        public DateTimeOrCutLabel EffectiveFrom { get; set; }

        /// <summary>
        /// The effective datetime until which the relationship will be deleted. If not supplied the deletion will be permanent.
        /// </summary>
        /// <value>The effective datetime until which the relationship will be deleted. If not supplied the deletion will be permanent.</value>
        [DataMember(Name = "effectiveUntil", EmitDefaultValue = true)]
        public DateTimeOrCutLabel EffectiveUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteRelationshipRequest {\n");
            sb.Append("  SourceEntityId: ").Append(SourceEntityId).Append("\n");
            sb.Append("  TargetEntityId: ").Append(TargetEntityId).Append("\n");
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
            return this.Equals(input as DeleteRelationshipRequest);
        }

        /// <summary>
        /// Returns true if DeleteRelationshipRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteRelationshipRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteRelationshipRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceEntityId == input.SourceEntityId ||
                    this.SourceEntityId != null &&
                    input.SourceEntityId != null &&
                    this.SourceEntityId.SequenceEqual(input.SourceEntityId)
                ) && 
                (
                    this.TargetEntityId == input.TargetEntityId ||
                    this.TargetEntityId != null &&
                    input.TargetEntityId != null &&
                    this.TargetEntityId.SequenceEqual(input.TargetEntityId)
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
                if (this.SourceEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceEntityId.GetHashCode();
                }
                if (this.TargetEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetEntityId.GetHashCode();
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
            // EffectiveFrom (DateTimeOrCutLabel) maxLength
            if (this.EffectiveFrom != null && this.EffectiveFrom.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EffectiveFrom, length must be less than 256.", new [] { "EffectiveFrom" });
            }

            // EffectiveFrom (DateTimeOrCutLabel) minLength
            if (this.EffectiveFrom != null && this.EffectiveFrom.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EffectiveFrom, length must be greater than 0.", new [] { "EffectiveFrom" });
            }

            // EffectiveFrom (DateTimeOrCutLabel) pattern
            Regex regexEffectiveFrom = new Regex(@"^[a-zA-Z0-9\-_\+:\.]+$", RegexOptions.CultureInvariant);
            if (false == regexEffectiveFrom.Match(this.EffectiveFrom).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EffectiveFrom, must match a pattern of " + regexEffectiveFrom, new [] { "EffectiveFrom" });
            }

            // EffectiveUntil (DateTimeOrCutLabel) maxLength
            if (this.EffectiveUntil != null && this.EffectiveUntil.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EffectiveUntil, length must be less than 256.", new [] { "EffectiveUntil" });
            }

            // EffectiveUntil (DateTimeOrCutLabel) minLength
            if (this.EffectiveUntil != null && this.EffectiveUntil.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EffectiveUntil, length must be greater than 0.", new [] { "EffectiveUntil" });
            }

            // EffectiveUntil (DateTimeOrCutLabel) pattern
            Regex regexEffectiveUntil = new Regex(@"^[a-zA-Z0-9\-_\+:\.]+$", RegexOptions.CultureInvariant);
            if (false == regexEffectiveUntil.Match(this.EffectiveUntil).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EffectiveUntil, must match a pattern of " + regexEffectiveUntil, new [] { "EffectiveUntil" });
            }

            yield break;
        }
    }
}
