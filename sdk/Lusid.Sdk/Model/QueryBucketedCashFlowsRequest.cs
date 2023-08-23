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
    /// Query for bucketed cashflows from one or more portfolios.
    /// </summary>
    [DataContract(Name = "QueryBucketedCashFlowsRequest")]
    public partial class QueryBucketedCashFlowsRequest : IEquatable<QueryBucketedCashFlowsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBucketedCashFlowsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryBucketedCashFlowsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBucketedCashFlowsRequest" /> class.
        /// </summary>
        /// <param name="asAt">The time of the system at which to query for bucketed cashflows..</param>
        /// <param name="windowStart">The start date of the window. (required).</param>
        /// <param name="windowEnd">The end date of the window. (required).</param>
        /// <param name="portfolioEntityIds">The set of portfolios and portfolio groups to which the instrument events must belong. (required).</param>
        /// <param name="effectiveAt">The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows (required).</param>
        /// <param name="recipeId">recipeId (required).</param>
        /// <param name="roundingMethod">When bucketing, there is not a unique way to allocate the bucket points. RoundingMethod Supported string (enumeration) values are: [RoundDown, RoundUp]. (required).</param>
        /// <param name="bucketingDates">A list of dates to perform cashflow bucketing upon. If this is provided, the list of tenors for bucketing should be empty..</param>
        /// <param name="bucketingTenors">A list of tenors to perform cashflow bucketing upon. If this is provided, the list of dates for bucketing should be empty..</param>
        /// <param name="reportCurrency">Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries. (required).</param>
        /// <param name="groupBy">The set of address keys to use to group the bucketed cash flows..</param>
        /// <param name="addresses">The set of items that the user wishes to see in the results. If empty, will be defaulted to standard ones..</param>
        /// <param name="equipWithSubtotals">Flag directing the Valuation call to populate the results with subtotals of aggregates..</param>
        public QueryBucketedCashFlowsRequest(DateTimeOffset? asAt = default(DateTimeOffset?), DateTimeOffset windowStart = default(DateTimeOffset), DateTimeOffset windowEnd = default(DateTimeOffset), List<PortfolioEntityId> portfolioEntityIds = default(List<PortfolioEntityId>), DateTimeOffset effectiveAt = default(DateTimeOffset), ResourceId recipeId = default(ResourceId), string roundingMethod = default(string), List<DateTimeOffset> bucketingDates = default(List<DateTimeOffset>), List<string> bucketingTenors = default(List<string>), string reportCurrency = default(string), List<string> groupBy = default(List<string>), List<string> addresses = default(List<string>), bool equipWithSubtotals = default(bool))
        {
            this.WindowStart = windowStart;
            this.WindowEnd = windowEnd;
            // to ensure "portfolioEntityIds" is required (not null)
            if (portfolioEntityIds == null)
            {
                throw new ArgumentNullException("portfolioEntityIds is a required property for QueryBucketedCashFlowsRequest and cannot be null");
            }
            this.PortfolioEntityIds = portfolioEntityIds;
            this.EffectiveAt = effectiveAt;
            // to ensure "recipeId" is required (not null)
            if (recipeId == null)
            {
                throw new ArgumentNullException("recipeId is a required property for QueryBucketedCashFlowsRequest and cannot be null");
            }
            this.RecipeId = recipeId;
            // to ensure "roundingMethod" is required (not null)
            if (roundingMethod == null)
            {
                throw new ArgumentNullException("roundingMethod is a required property for QueryBucketedCashFlowsRequest and cannot be null");
            }
            this.RoundingMethod = roundingMethod;
            // to ensure "reportCurrency" is required (not null)
            if (reportCurrency == null)
            {
                throw new ArgumentNullException("reportCurrency is a required property for QueryBucketedCashFlowsRequest and cannot be null");
            }
            this.ReportCurrency = reportCurrency;
            this.AsAt = asAt;
            this.BucketingDates = bucketingDates;
            this.BucketingTenors = bucketingTenors;
            this.GroupBy = groupBy;
            this.Addresses = addresses;
            this.EquipWithSubtotals = equipWithSubtotals;
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
        /// The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows
        /// </summary>
        /// <value>The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows</value>
        [DataMember(Name = "effectiveAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset EffectiveAt { get; set; }

        /// <summary>
        /// Gets or Sets RecipeId
        /// </summary>
        [DataMember(Name = "recipeId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId RecipeId { get; set; }

        /// <summary>
        /// When bucketing, there is not a unique way to allocate the bucket points. RoundingMethod Supported string (enumeration) values are: [RoundDown, RoundUp].
        /// </summary>
        /// <value>When bucketing, there is not a unique way to allocate the bucket points. RoundingMethod Supported string (enumeration) values are: [RoundDown, RoundUp].</value>
        [DataMember(Name = "roundingMethod", IsRequired = true, EmitDefaultValue = true)]
        public string RoundingMethod { get; set; }

        /// <summary>
        /// A list of dates to perform cashflow bucketing upon. If this is provided, the list of tenors for bucketing should be empty.
        /// </summary>
        /// <value>A list of dates to perform cashflow bucketing upon. If this is provided, the list of tenors for bucketing should be empty.</value>
        [DataMember(Name = "bucketingDates", EmitDefaultValue = true)]
        public List<DateTimeOffset> BucketingDates { get; set; }

        /// <summary>
        /// A list of tenors to perform cashflow bucketing upon. If this is provided, the list of dates for bucketing should be empty.
        /// </summary>
        /// <value>A list of tenors to perform cashflow bucketing upon. If this is provided, the list of dates for bucketing should be empty.</value>
        [DataMember(Name = "bucketingTenors", EmitDefaultValue = true)]
        public List<string> BucketingTenors { get; set; }

        /// <summary>
        /// Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries.
        /// </summary>
        /// <value>Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries.</value>
        [DataMember(Name = "reportCurrency", IsRequired = true, EmitDefaultValue = true)]
        public string ReportCurrency { get; set; }

        /// <summary>
        /// The set of address keys to use to group the bucketed cash flows.
        /// </summary>
        /// <value>The set of address keys to use to group the bucketed cash flows.</value>
        [DataMember(Name = "groupBy", EmitDefaultValue = true)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// The set of items that the user wishes to see in the results. If empty, will be defaulted to standard ones.
        /// </summary>
        /// <value>The set of items that the user wishes to see in the results. If empty, will be defaulted to standard ones.</value>
        [DataMember(Name = "addresses", EmitDefaultValue = true)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// Flag directing the Valuation call to populate the results with subtotals of aggregates.
        /// </summary>
        /// <value>Flag directing the Valuation call to populate the results with subtotals of aggregates.</value>
        [DataMember(Name = "equipWithSubtotals", EmitDefaultValue = true)]
        public bool EquipWithSubtotals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryBucketedCashFlowsRequest {\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  WindowStart: ").Append(WindowStart).Append("\n");
            sb.Append("  WindowEnd: ").Append(WindowEnd).Append("\n");
            sb.Append("  PortfolioEntityIds: ").Append(PortfolioEntityIds).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  RecipeId: ").Append(RecipeId).Append("\n");
            sb.Append("  RoundingMethod: ").Append(RoundingMethod).Append("\n");
            sb.Append("  BucketingDates: ").Append(BucketingDates).Append("\n");
            sb.Append("  BucketingTenors: ").Append(BucketingTenors).Append("\n");
            sb.Append("  ReportCurrency: ").Append(ReportCurrency).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  EquipWithSubtotals: ").Append(EquipWithSubtotals).Append("\n");
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
            return this.Equals(input as QueryBucketedCashFlowsRequest);
        }

        /// <summary>
        /// Returns true if QueryBucketedCashFlowsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryBucketedCashFlowsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryBucketedCashFlowsRequest input)
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
                    this.RoundingMethod == input.RoundingMethod ||
                    (this.RoundingMethod != null &&
                    this.RoundingMethod.Equals(input.RoundingMethod))
                ) && 
                (
                    this.BucketingDates == input.BucketingDates ||
                    this.BucketingDates != null &&
                    input.BucketingDates != null &&
                    this.BucketingDates.SequenceEqual(input.BucketingDates)
                ) && 
                (
                    this.BucketingTenors == input.BucketingTenors ||
                    this.BucketingTenors != null &&
                    input.BucketingTenors != null &&
                    this.BucketingTenors.SequenceEqual(input.BucketingTenors)
                ) && 
                (
                    this.ReportCurrency == input.ReportCurrency ||
                    (this.ReportCurrency != null &&
                    this.ReportCurrency.Equals(input.ReportCurrency))
                ) && 
                (
                    this.GroupBy == input.GroupBy ||
                    this.GroupBy != null &&
                    input.GroupBy != null &&
                    this.GroupBy.SequenceEqual(input.GroupBy)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.EquipWithSubtotals == input.EquipWithSubtotals ||
                    this.EquipWithSubtotals.Equals(input.EquipWithSubtotals)
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
                if (this.RoundingMethod != null)
                {
                    hashCode = (hashCode * 59) + this.RoundingMethod.GetHashCode();
                }
                if (this.BucketingDates != null)
                {
                    hashCode = (hashCode * 59) + this.BucketingDates.GetHashCode();
                }
                if (this.BucketingTenors != null)
                {
                    hashCode = (hashCode * 59) + this.BucketingTenors.GetHashCode();
                }
                if (this.ReportCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.ReportCurrency.GetHashCode();
                }
                if (this.GroupBy != null)
                {
                    hashCode = (hashCode * 59) + this.GroupBy.GetHashCode();
                }
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EquipWithSubtotals.GetHashCode();
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
            // RoundingMethod (string) minLength
            if (this.RoundingMethod != null && this.RoundingMethod.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoundingMethod, length must be greater than 1.", new [] { "RoundingMethod" });
            }

            // ReportCurrency (string) maxLength
            if (this.ReportCurrency != null && this.ReportCurrency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportCurrency, length must be less than 3.", new [] { "ReportCurrency" });
            }

            // ReportCurrency (string) minLength
            if (this.ReportCurrency != null && this.ReportCurrency.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportCurrency, length must be greater than 0.", new [] { "ReportCurrency" });
            }

            yield break;
        }
    }
}
