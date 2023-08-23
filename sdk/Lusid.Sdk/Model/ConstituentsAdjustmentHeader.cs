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
    /// ConstituentsAdjustmentHeader
    /// </summary>
    [DataContract(Name = "ConstituentsAdjustmentHeader")]
    public partial class ConstituentsAdjustmentHeader : IEquatable<ConstituentsAdjustmentHeader>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstituentsAdjustmentHeader" /> class.
        /// </summary>
        /// <param name="effectiveAt">There can be at most one holdings adjustment for a portfolio at a  specific effective time so this uniquely identifies the adjustment..</param>
        /// <param name="version">version.</param>
        /// <param name="links">links.</param>
        public ConstituentsAdjustmentHeader(DateTimeOffset effectiveAt = default(DateTimeOffset), ModelVersion version = default(ModelVersion), List<Link> links = default(List<Link>))
        {
            this.EffectiveAt = effectiveAt;
            this._Version = version;
            this.Links = links;
        }

        /// <summary>
        /// There can be at most one holdings adjustment for a portfolio at a  specific effective time so this uniquely identifies the adjustment.
        /// </summary>
        /// <value>There can be at most one holdings adjustment for a portfolio at a  specific effective time so this uniquely identifies the adjustment.</value>
        [DataMember(Name = "effectiveAt", EmitDefaultValue = false)]
        public DateTimeOffset EffectiveAt { get; set; }

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
            sb.Append("class ConstituentsAdjustmentHeader {\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
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
            return this.Equals(input as ConstituentsAdjustmentHeader);
        }

        /// <summary>
        /// Returns true if ConstituentsAdjustmentHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstituentsAdjustmentHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstituentsAdjustmentHeader input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
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
                if (this.EffectiveAt != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveAt.GetHashCode();
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
