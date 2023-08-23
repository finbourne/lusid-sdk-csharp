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
    /// DeleteRelationRequest
    /// </summary>
    [DataContract(Name = "DeleteRelationRequest")]
    public partial class DeleteRelationRequest : IEquatable<DeleteRelationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRelationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteRelationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRelationRequest" /> class.
        /// </summary>
        /// <param name="sourceEntityId">The identifier of the source entity of the relation to be deleted. (required).</param>
        /// <param name="targetEntityId">The identifier of the target entity of the relation to be deleted. (required).</param>
        public DeleteRelationRequest(Dictionary<string, string> sourceEntityId = default(Dictionary<string, string>), Dictionary<string, string> targetEntityId = default(Dictionary<string, string>))
        {
            // to ensure "sourceEntityId" is required (not null)
            if (sourceEntityId == null)
            {
                throw new ArgumentNullException("sourceEntityId is a required property for DeleteRelationRequest and cannot be null");
            }
            this.SourceEntityId = sourceEntityId;
            // to ensure "targetEntityId" is required (not null)
            if (targetEntityId == null)
            {
                throw new ArgumentNullException("targetEntityId is a required property for DeleteRelationRequest and cannot be null");
            }
            this.TargetEntityId = targetEntityId;
        }

        /// <summary>
        /// The identifier of the source entity of the relation to be deleted.
        /// </summary>
        /// <value>The identifier of the source entity of the relation to be deleted.</value>
        [DataMember(Name = "sourceEntityId", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> SourceEntityId { get; set; }

        /// <summary>
        /// The identifier of the target entity of the relation to be deleted.
        /// </summary>
        /// <value>The identifier of the target entity of the relation to be deleted.</value>
        [DataMember(Name = "targetEntityId", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> TargetEntityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteRelationRequest {\n");
            sb.Append("  SourceEntityId: ").Append(SourceEntityId).Append("\n");
            sb.Append("  TargetEntityId: ").Append(TargetEntityId).Append("\n");
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
            return this.Equals(input as DeleteRelationRequest);
        }

        /// <summary>
        /// Returns true if DeleteRelationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteRelationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteRelationRequest input)
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
