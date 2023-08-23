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
    /// Instrument event query.
    /// </summary>
    [DataContract(Name = "QueryInstrumentEventsRequest")]
    public partial class QueryInstrumentEventsRequest : IEquatable<QueryInstrumentEventsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryInstrumentEventsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryInstrumentEventsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryInstrumentEventsRequest" /> class.
        /// </summary>
        /// <param name="asAt">The time of the system at which to query for bucketed cashflows..</param>
        /// <param name="windowStart">The start date of the window. (required).</param>
        /// <param name="windowEnd">The end date of the window. (required).</param>
        /// <param name="portfolioEntityIds">The set of portfolios and portfolio groups to which the instrument events must belong. (required).</param>
        /// <param name="effectiveAt">The Effective date used in the valuation of the cashflows. (required).</param>
        /// <param name="recipeId">recipeId (required).</param>
        /// <param name="filterInstrumentEvents">Expression to filter the result set..</param>
        public QueryInstrumentEventsRequest(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOffset windowStart = default(DateTimeOffset), DateTimeOffset windowEnd = default(DateTimeOffset), List<PortfolioEntityId> portfolioEntityIds = default(List<PortfolioEntityId>), DateTimeOffset effectiveAt = default(DateTimeOffset), ResourceId recipeId = default(ResourceId), string filterInstrumentEvents = default(string))
        {
            this.WindowStart = windowStart;
            this.WindowEnd = windowEnd;
            // to ensure "portfolioEntityIds" is required (not null)
            if (portfolioEntityIds == null)
            {
                throw new ArgumentNullException("portfolioEntityIds is a required property for QueryInstrumentEventsRequest and cannot be null");
            }
            this.PortfolioEntityIds = portfolioEntityIds;
            this.EffectiveAt = effectiveAt;
            // to ensure "recipeId" is required (not null)
            if (recipeId == null)
            {
                throw new ArgumentNullException("recipeId is a required property for QueryInstrumentEventsRequest and cannot be null");
            }
            this.RecipeId = recipeId;
            this.AsAt = asAt;
            this.FilterInstrumentEvents = filterInstrumentEvents;
        }

        /// <summary>
        /// The time of the system at which to query for bucketed cashflows.
        /// </summary>
        /// <value>The time of the system at which to query for bucketed cashflows.</value>
        [DataMember(Name = "asAt", EmitDefaultValue = true)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// The start date of the window.
        /// </summary>
        /// <value>The start date of the window.</value>
        [DataMember(Name = "windowStart", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset WindowStart { get; set; }

        /// <summary>
        /// The end date of the window.
        /// </summary>
        /// <value>The end date of the window.</value>
        [DataMember(Name = "windowEnd", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset WindowEnd { get; set; }

        /// <summary>
        /// The set of portfolios and portfolio groups to which the instrument events must belong.
        /// </summary>
        /// <value>The set of portfolios and portfolio groups to which the instrument events must belong.</value>
        [DataMember(Name = "portfolioEntityIds", IsRequired = true, EmitDefaultValue = true)]
        public List<PortfolioEntityId> PortfolioEntityIds { get; set; }

        /// <summary>
        /// The Effective date used in the valuation of the cashflows.
        /// </summary>
        /// <value>The Effective date used in the valuation of the cashflows.</value>
        [DataMember(Name = "effectiveAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset EffectiveAt { get; set; }

        /// <summary>
        /// Gets or Sets RecipeId
        /// </summary>
        [DataMember(Name = "recipeId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId RecipeId { get; set; }

        /// <summary>
        /// Expression to filter the result set.
        /// </summary>
        /// <value>Expression to filter the result set.</value>
        [DataMember(Name = "filterInstrumentEvents", EmitDefaultValue = true)]
        public string FilterInstrumentEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryInstrumentEventsRequest {\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  WindowStart: ").Append(WindowStart).Append("\n");
            sb.Append("  WindowEnd: ").Append(WindowEnd).Append("\n");
            sb.Append("  PortfolioEntityIds: ").Append(PortfolioEntityIds).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  RecipeId: ").Append(RecipeId).Append("\n");
            sb.Append("  FilterInstrumentEvents: ").Append(FilterInstrumentEvents).Append("\n");
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
            return this.Equals(input as QueryInstrumentEventsRequest);
        }

        /// <summary>
        /// Returns true if QueryInstrumentEventsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryInstrumentEventsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryInstrumentEventsRequest input)
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
                    this.WindowStart == input.WindowStart ||
                    (this.WindowStart != null &&
                    this.WindowStart.Equals(input.WindowStart))
                ) && 
                (
                    this.WindowEnd == input.WindowEnd ||
                    (this.WindowEnd != null &&
                    this.WindowEnd.Equals(input.WindowEnd))
                ) && 
                (
                    this.PortfolioEntityIds == input.PortfolioEntityIds ||
                    this.PortfolioEntityIds != null &&
                    input.PortfolioEntityIds != null &&
                    this.PortfolioEntityIds.SequenceEqual(input.PortfolioEntityIds)
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
                ) && 
                (
                    this.RecipeId == input.RecipeId ||
                    (this.RecipeId != null &&
                    this.RecipeId.Equals(input.RecipeId))
                ) && 
                (
                    this.FilterInstrumentEvents == input.FilterInstrumentEvents ||
                    (this.FilterInstrumentEvents != null &&
                    this.FilterInstrumentEvents.Equals(input.FilterInstrumentEvents))
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
                if (this.WindowStart != null)
                {
                    hashCode = (hashCode * 59) + this.WindowStart.GetHashCode();
                }
                if (this.WindowEnd != null)
                {
                    hashCode = (hashCode * 59) + this.WindowEnd.GetHashCode();
                }
                if (this.PortfolioEntityIds != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioEntityIds.GetHashCode();
                }
                if (this.EffectiveAt != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveAt.GetHashCode();
                }
                if (this.RecipeId != null)
                {
                    hashCode = (hashCode * 59) + this.RecipeId.GetHashCode();
                }
                if (this.FilterInstrumentEvents != null)
                {
                    hashCode = (hashCode * 59) + this.FilterInstrumentEvents.GetHashCode();
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
            // FilterInstrumentEvents (string) maxLength
            if (this.FilterInstrumentEvents != null && this.FilterInstrumentEvents.Length > 16384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FilterInstrumentEvents, length must be less than 16384.", new [] { "FilterInstrumentEvents" });
            }

            // FilterInstrumentEvents (string) minLength
            if (this.FilterInstrumentEvents != null && this.FilterInstrumentEvents.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FilterInstrumentEvents, length must be greater than 0.", new [] { "FilterInstrumentEvents" });
            }

            // FilterInstrumentEvents (string) pattern
            Regex regexFilterInstrumentEvents = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexFilterInstrumentEvents.Match(this.FilterInstrumentEvents).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FilterInstrumentEvents, must match a pattern of " + regexFilterInstrumentEvents, new [] { "FilterInstrumentEvents" });
            }

            yield break;
        }
    }
}
