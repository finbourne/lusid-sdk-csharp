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
    /// PeriodDiaryEntriesReopenedResponse
    /// </summary>
    [DataContract(Name = "PeriodDiaryEntriesReopenedResponse")]
    public partial class PeriodDiaryEntriesReopenedResponse : IEquatable<PeriodDiaryEntriesReopenedResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodDiaryEntriesReopenedResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PeriodDiaryEntriesReopenedResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodDiaryEntriesReopenedResponse" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="effectiveFrom">The effective datetime at which the deletion became valid. May be null in the case where multiple date times are applicable..</param>
        /// <param name="asAt">The asAt datetime at which the deletion was committed to LUSID. (required).</param>
        /// <param name="periodDiaryEntriesRemoved">Number of Diary Entries removed as a result of reopening periods (required).</param>
        /// <param name="periodDiaryEntriesFrom">The start point where periods were removed from (required).</param>
        /// <param name="periodDiaryEntriesTo">The end point where periods were removed to (required).</param>
        /// <param name="links">links.</param>
        public PeriodDiaryEntriesReopenedResponse(string href = default(string), DateTimeOffset? effectiveFrom = default(DateTimeOffset?), DateTimeOffset asAt = default(DateTimeOffset), int periodDiaryEntriesRemoved = default(int), DateTimeOffset periodDiaryEntriesFrom = default(DateTimeOffset), DateTimeOffset periodDiaryEntriesTo = default(DateTimeOffset), List<Link> links = default(List<Link>))
        {
            this.AsAt = asAt;
            this.PeriodDiaryEntriesRemoved = periodDiaryEntriesRemoved;
            this.PeriodDiaryEntriesFrom = periodDiaryEntriesFrom;
            this.PeriodDiaryEntriesTo = periodDiaryEntriesTo;
            this.Href = href;
            this.EffectiveFrom = effectiveFrom;
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
        /// Number of Diary Entries removed as a result of reopening periods
        /// </summary>
        /// <value>Number of Diary Entries removed as a result of reopening periods</value>
        [DataMember(Name = "periodDiaryEntriesRemoved", IsRequired = true, EmitDefaultValue = true)]
        public int PeriodDiaryEntriesRemoved { get; set; }

        /// <summary>
        /// The start point where periods were removed from
        /// </summary>
        /// <value>The start point where periods were removed from</value>
        [DataMember(Name = "periodDiaryEntriesFrom", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset PeriodDiaryEntriesFrom { get; set; }

        /// <summary>
        /// The end point where periods were removed to
        /// </summary>
        /// <value>The end point where periods were removed to</value>
        [DataMember(Name = "periodDiaryEntriesTo", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset PeriodDiaryEntriesTo { get; set; }

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
            sb.Append("class PeriodDiaryEntriesReopenedResponse {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  PeriodDiaryEntriesRemoved: ").Append(PeriodDiaryEntriesRemoved).Append("\n");
            sb.Append("  PeriodDiaryEntriesFrom: ").Append(PeriodDiaryEntriesFrom).Append("\n");
            sb.Append("  PeriodDiaryEntriesTo: ").Append(PeriodDiaryEntriesTo).Append("\n");
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
            return this.Equals(input as PeriodDiaryEntriesReopenedResponse);
        }

        /// <summary>
        /// Returns true if PeriodDiaryEntriesReopenedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PeriodDiaryEntriesReopenedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeriodDiaryEntriesReopenedResponse input)
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
                    this.PeriodDiaryEntriesRemoved == input.PeriodDiaryEntriesRemoved ||
                    this.PeriodDiaryEntriesRemoved.Equals(input.PeriodDiaryEntriesRemoved)
                ) && 
                (
                    this.PeriodDiaryEntriesFrom == input.PeriodDiaryEntriesFrom ||
                    (this.PeriodDiaryEntriesFrom != null &&
                    this.PeriodDiaryEntriesFrom.Equals(input.PeriodDiaryEntriesFrom))
                ) && 
                (
                    this.PeriodDiaryEntriesTo == input.PeriodDiaryEntriesTo ||
                    (this.PeriodDiaryEntriesTo != null &&
                    this.PeriodDiaryEntriesTo.Equals(input.PeriodDiaryEntriesTo))
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
                hashCode = (hashCode * 59) + this.PeriodDiaryEntriesRemoved.GetHashCode();
                if (this.PeriodDiaryEntriesFrom != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodDiaryEntriesFrom.GetHashCode();
                }
                if (this.PeriodDiaryEntriesTo != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodDiaryEntriesTo.GetHashCode();
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
