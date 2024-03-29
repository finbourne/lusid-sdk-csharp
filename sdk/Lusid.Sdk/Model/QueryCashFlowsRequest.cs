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
    /// Query for cashflows from one or more portfolios
    /// </summary>
    [DataContract(Name = "QueryCashFlowsRequest")]
    public partial class QueryCashFlowsRequest : IEquatable<QueryCashFlowsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCashFlowsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryCashFlowsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryCashFlowsRequest" /> class.
        /// </summary>
        /// <param name="asAt">The time of the system at which to query for cashflows..</param>
        /// <param name="windowStart">The start date of the window. (required).</param>
        /// <param name="windowEnd">The end date of the window. (required).</param>
        /// <param name="portfolioEntityIds">The set of portfolios and portfolio groups to which the instrument events must belong. (required).</param>
        /// <param name="recipeId">recipeId (required).</param>
        /// <param name="effectiveAt">The Effective date used in the valuation of the cashflows. (required).</param>
        public QueryCashFlowsRequest(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOffset windowStart = default(DateTimeOffset), DateTimeOffset windowEnd = default(DateTimeOffset), List<PortfolioEntityId> portfolioEntityIds = default(List<PortfolioEntityId>), ResourceId recipeId = default(ResourceId), DateTimeOffset effectiveAt = default(DateTimeOffset))
        {
            this.WindowStart = windowStart;
            this.WindowEnd = windowEnd;
            // to ensure "portfolioEntityIds" is required (not null)
            if (portfolioEntityIds == null)
            {
                throw new ArgumentNullException("portfolioEntityIds is a required property for QueryCashFlowsRequest and cannot be null");
            }
            this.PortfolioEntityIds = portfolioEntityIds;
            // to ensure "recipeId" is required (not null)
            if (recipeId == null)
            {
                throw new ArgumentNullException("recipeId is a required property for QueryCashFlowsRequest and cannot be null");
            }
            this.RecipeId = recipeId;
            this.EffectiveAt = effectiveAt;
            this.AsAt = asAt;
        }

        /// <summary>
        /// The time of the system at which to query for cashflows.
        /// </summary>
        /// <value>The time of the system at which to query for cashflows.</value>
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
        /// Gets or Sets RecipeId
        /// </summary>
        [DataMember(Name = "recipeId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId RecipeId { get; set; }

        /// <summary>
        /// The Effective date used in the valuation of the cashflows.
        /// </summary>
        /// <value>The Effective date used in the valuation of the cashflows.</value>
        [DataMember(Name = "effectiveAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset EffectiveAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryCashFlowsRequest {\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  WindowStart: ").Append(WindowStart).Append("\n");
            sb.Append("  WindowEnd: ").Append(WindowEnd).Append("\n");
            sb.Append("  PortfolioEntityIds: ").Append(PortfolioEntityIds).Append("\n");
            sb.Append("  RecipeId: ").Append(RecipeId).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
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
            return this.Equals(input as QueryCashFlowsRequest);
        }

        /// <summary>
        /// Returns true if QueryCashFlowsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryCashFlowsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryCashFlowsRequest input)
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
                    this.RecipeId == input.RecipeId ||
                    (this.RecipeId != null &&
                    this.RecipeId.Equals(input.RecipeId))
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
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
                if (this.RecipeId != null)
                {
                    hashCode = (hashCode * 59) + this.RecipeId.GetHashCode();
                }
                if (this.EffectiveAt != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveAt.GetHashCode();
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
