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
    /// DeleteInstrumentPropertiesResponse
    /// </summary>
    [DataContract(Name = "DeleteInstrumentPropertiesResponse")]
    public partial class DeleteInstrumentPropertiesResponse : IEquatable<DeleteInstrumentPropertiesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInstrumentPropertiesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteInstrumentPropertiesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInstrumentPropertiesResponse" /> class.
        /// </summary>
        /// <param name="asAt">The as-at datetime at which properties were deleted. (required).</param>
        /// <param name="stagedModifications">stagedModifications.</param>
        /// <param name="links">links.</param>
        public DeleteInstrumentPropertiesResponse(DateTimeOffset asAt = default(DateTimeOffset), StagedModificationsInfo stagedModifications = default(StagedModificationsInfo), List<Link> links = default(List<Link>))
        {
            this.AsAt = asAt;
            this.StagedModifications = stagedModifications;
            this.Links = links;
        }

        /// <summary>
        /// The as-at datetime at which properties were deleted.
        /// </summary>
        /// <value>The as-at datetime at which properties were deleted.</value>
        [DataMember(Name = "asAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset AsAt { get; set; }

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
            sb.Append("class DeleteInstrumentPropertiesResponse {\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
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
            return this.Equals(input as DeleteInstrumentPropertiesResponse);
        }

        /// <summary>
        /// Returns true if DeleteInstrumentPropertiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteInstrumentPropertiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteInstrumentPropertiesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
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
                if (this.AsAt != null)
                {
                    hashCode = (hashCode * 59) + this.AsAt.GetHashCode();
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
