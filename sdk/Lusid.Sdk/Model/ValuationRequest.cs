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
    /// Specification object for the parameters of a valuation
    /// </summary>
    [DataContract(Name = "ValuationRequest")]
    public partial class ValuationRequest : IEquatable<ValuationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValuationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuationRequest" /> class.
        /// </summary>
        /// <param name="recipeId">recipeId (required).</param>
        /// <param name="asAt">The asAt date to use.</param>
        /// <param name="metrics">The set of specifications to calculate or retrieve during the valuation and present in the results. For example:  AggregateSpec(&#39;Valuation/PV&#39;,&#39;Sum&#39;) for returning the PV (present value) of holdings  AggregateSpec(&#39;Holding/default/Units&#39;,&#39;Sum&#39;) for returning the units of holidays  AggregateSpec(&#39;Instrument/default/LusidInstrumentId&#39;,&#39;Value&#39;) for returning the Lusid Instrument identifier (required).</param>
        /// <param name="groupBy">The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out..</param>
        /// <param name="filters">A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value..</param>
        /// <param name="sort">A (possibly empty/null) set of specifications for how to order the results..</param>
        /// <param name="reportCurrency">Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries.  If not present, then the currency of the relevant portfolio will be used in its place..</param>
        /// <param name="equipWithSubtotals">Flag directing the Valuation call to populate the results with subtotals of aggregates..</param>
        /// <param name="returnResultAsExpandedTypes">Financially meaningful results can be presented as either simple flat types or more complex expanded types.  For example, the present value (PV) of a holding could be represented either as a simple decimal (with currency implied)  or as a decimal-currency pair. This flag allows either representation to be returned. In the PV example,  the returned value would be the decimal-currency pair if this flag is true, or the decimal only if this flag is false..</param>
        /// <param name="portfolioEntityIds">The set of portfolio or portfolio group identifier(s) that is to be valued. (required).</param>
        /// <param name="valuationSchedule">valuationSchedule (required).</param>
        /// <param name="marketDataOverrides">marketDataOverrides.</param>
        public ValuationRequest(ResourceId recipeId = default(ResourceId), DateTimeOffset? asAt = default(DateTimeOffset?), List<AggregateSpec> metrics = default(List<AggregateSpec>), List<string> groupBy = default(List<string>), List<PropertyFilter> filters = default(List<PropertyFilter>), List<OrderBySpec> sort = default(List<OrderBySpec>), string reportCurrency = default(string), bool equipWithSubtotals = default(bool), bool returnResultAsExpandedTypes = default(bool), List<PortfolioEntityId> portfolioEntityIds = default(List<PortfolioEntityId>), ValuationSchedule valuationSchedule = default(ValuationSchedule), MarketDataOverrides marketDataOverrides = default(MarketDataOverrides))
        {
            // to ensure "recipeId" is required (not null)
            if (recipeId == null)
            {
                throw new ArgumentNullException("recipeId is a required property for ValuationRequest and cannot be null");
            }
            this.RecipeId = recipeId;
            // to ensure "metrics" is required (not null)
            if (metrics == null)
            {
                throw new ArgumentNullException("metrics is a required property for ValuationRequest and cannot be null");
            }
            this.Metrics = metrics;
            // to ensure "portfolioEntityIds" is required (not null)
            if (portfolioEntityIds == null)
            {
                throw new ArgumentNullException("portfolioEntityIds is a required property for ValuationRequest and cannot be null");
            }
            this.PortfolioEntityIds = portfolioEntityIds;
            // to ensure "valuationSchedule" is required (not null)
            if (valuationSchedule == null)
            {
                throw new ArgumentNullException("valuationSchedule is a required property for ValuationRequest and cannot be null");
            }
            this.ValuationSchedule = valuationSchedule;
            this.AsAt = asAt;
            this.GroupBy = groupBy;
            this.Filters = filters;
            this.Sort = sort;
            this.ReportCurrency = reportCurrency;
            this.EquipWithSubtotals = equipWithSubtotals;
            this.ReturnResultAsExpandedTypes = returnResultAsExpandedTypes;
            this.MarketDataOverrides = marketDataOverrides;
        }

        /// <summary>
        /// Gets or Sets RecipeId
        /// </summary>
        [DataMember(Name = "recipeId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId RecipeId { get; set; }

        /// <summary>
        /// The asAt date to use
        /// </summary>
        /// <value>The asAt date to use</value>
        [DataMember(Name = "asAt", EmitDefaultValue = true)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// The set of specifications to calculate or retrieve during the valuation and present in the results. For example:  AggregateSpec(&#39;Valuation/PV&#39;,&#39;Sum&#39;) for returning the PV (present value) of holdings  AggregateSpec(&#39;Holding/default/Units&#39;,&#39;Sum&#39;) for returning the units of holidays  AggregateSpec(&#39;Instrument/default/LusidInstrumentId&#39;,&#39;Value&#39;) for returning the Lusid Instrument identifier
        /// </summary>
        /// <value>The set of specifications to calculate or retrieve during the valuation and present in the results. For example:  AggregateSpec(&#39;Valuation/PV&#39;,&#39;Sum&#39;) for returning the PV (present value) of holdings  AggregateSpec(&#39;Holding/default/Units&#39;,&#39;Sum&#39;) for returning the units of holidays  AggregateSpec(&#39;Instrument/default/LusidInstrumentId&#39;,&#39;Value&#39;) for returning the Lusid Instrument identifier</value>
        [DataMember(Name = "metrics", IsRequired = true, EmitDefaultValue = true)]
        public List<AggregateSpec> Metrics { get; set; }

        /// <summary>
        /// The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out.
        /// </summary>
        /// <value>The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out.</value>
        [DataMember(Name = "groupBy", EmitDefaultValue = true)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value.
        /// </summary>
        /// <value>A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value.</value>
        [DataMember(Name = "filters", EmitDefaultValue = true)]
        public List<PropertyFilter> Filters { get; set; }

        /// <summary>
        /// A (possibly empty/null) set of specifications for how to order the results.
        /// </summary>
        /// <value>A (possibly empty/null) set of specifications for how to order the results.</value>
        [DataMember(Name = "sort", EmitDefaultValue = true)]
        public List<OrderBySpec> Sort { get; set; }

        /// <summary>
        /// Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries.  If not present, then the currency of the relevant portfolio will be used in its place.
        /// </summary>
        /// <value>Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries.  If not present, then the currency of the relevant portfolio will be used in its place.</value>
        [DataMember(Name = "reportCurrency", EmitDefaultValue = true)]
        public string ReportCurrency { get; set; }

        /// <summary>
        /// Flag directing the Valuation call to populate the results with subtotals of aggregates.
        /// </summary>
        /// <value>Flag directing the Valuation call to populate the results with subtotals of aggregates.</value>
        [DataMember(Name = "equipWithSubtotals", EmitDefaultValue = true)]
        public bool EquipWithSubtotals { get; set; }

        /// <summary>
        /// Financially meaningful results can be presented as either simple flat types or more complex expanded types.  For example, the present value (PV) of a holding could be represented either as a simple decimal (with currency implied)  or as a decimal-currency pair. This flag allows either representation to be returned. In the PV example,  the returned value would be the decimal-currency pair if this flag is true, or the decimal only if this flag is false.
        /// </summary>
        /// <value>Financially meaningful results can be presented as either simple flat types or more complex expanded types.  For example, the present value (PV) of a holding could be represented either as a simple decimal (with currency implied)  or as a decimal-currency pair. This flag allows either representation to be returned. In the PV example,  the returned value would be the decimal-currency pair if this flag is true, or the decimal only if this flag is false.</value>
        [DataMember(Name = "returnResultAsExpandedTypes", EmitDefaultValue = true)]
        public bool ReturnResultAsExpandedTypes { get; set; }

        /// <summary>
        /// The set of portfolio or portfolio group identifier(s) that is to be valued.
        /// </summary>
        /// <value>The set of portfolio or portfolio group identifier(s) that is to be valued.</value>
        [DataMember(Name = "portfolioEntityIds", IsRequired = true, EmitDefaultValue = true)]
        public List<PortfolioEntityId> PortfolioEntityIds { get; set; }

        /// <summary>
        /// Gets or Sets ValuationSchedule
        /// </summary>
        [DataMember(Name = "valuationSchedule", IsRequired = true, EmitDefaultValue = true)]
        public ValuationSchedule ValuationSchedule { get; set; }

        /// <summary>
        /// Gets or Sets MarketDataOverrides
        /// </summary>
        [DataMember(Name = "marketDataOverrides", EmitDefaultValue = false)]
        public MarketDataOverrides MarketDataOverrides { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValuationRequest {\n");
            sb.Append("  RecipeId: ").Append(RecipeId).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  ReportCurrency: ").Append(ReportCurrency).Append("\n");
            sb.Append("  EquipWithSubtotals: ").Append(EquipWithSubtotals).Append("\n");
            sb.Append("  ReturnResultAsExpandedTypes: ").Append(ReturnResultAsExpandedTypes).Append("\n");
            sb.Append("  PortfolioEntityIds: ").Append(PortfolioEntityIds).Append("\n");
            sb.Append("  ValuationSchedule: ").Append(ValuationSchedule).Append("\n");
            sb.Append("  MarketDataOverrides: ").Append(MarketDataOverrides).Append("\n");
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
            return this.Equals(input as ValuationRequest);
        }

        /// <summary>
        /// Returns true if ValuationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ValuationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValuationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RecipeId == input.RecipeId ||
                    (this.RecipeId != null &&
                    this.RecipeId.Equals(input.RecipeId))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) && 
                (
                    this.GroupBy == input.GroupBy ||
                    this.GroupBy != null &&
                    input.GroupBy != null &&
                    this.GroupBy.SequenceEqual(input.GroupBy)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.Sort == input.Sort ||
                    this.Sort != null &&
                    input.Sort != null &&
                    this.Sort.SequenceEqual(input.Sort)
                ) && 
                (
                    this.ReportCurrency == input.ReportCurrency ||
                    (this.ReportCurrency != null &&
                    this.ReportCurrency.Equals(input.ReportCurrency))
                ) && 
                (
                    this.EquipWithSubtotals == input.EquipWithSubtotals ||
                    this.EquipWithSubtotals.Equals(input.EquipWithSubtotals)
                ) && 
                (
                    this.ReturnResultAsExpandedTypes == input.ReturnResultAsExpandedTypes ||
                    this.ReturnResultAsExpandedTypes.Equals(input.ReturnResultAsExpandedTypes)
                ) && 
                (
                    this.PortfolioEntityIds == input.PortfolioEntityIds ||
                    this.PortfolioEntityIds != null &&
                    input.PortfolioEntityIds != null &&
                    this.PortfolioEntityIds.SequenceEqual(input.PortfolioEntityIds)
                ) && 
                (
                    this.ValuationSchedule == input.ValuationSchedule ||
                    (this.ValuationSchedule != null &&
                    this.ValuationSchedule.Equals(input.ValuationSchedule))
                ) && 
                (
                    this.MarketDataOverrides == input.MarketDataOverrides ||
                    (this.MarketDataOverrides != null &&
                    this.MarketDataOverrides.Equals(input.MarketDataOverrides))
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
                if (this.RecipeId != null)
                {
                    hashCode = (hashCode * 59) + this.RecipeId.GetHashCode();
                }
                if (this.AsAt != null)
                {
                    hashCode = (hashCode * 59) + this.AsAt.GetHashCode();
                }
                if (this.Metrics != null)
                {
                    hashCode = (hashCode * 59) + this.Metrics.GetHashCode();
                }
                if (this.GroupBy != null)
                {
                    hashCode = (hashCode * 59) + this.GroupBy.GetHashCode();
                }
                if (this.Filters != null)
                {
                    hashCode = (hashCode * 59) + this.Filters.GetHashCode();
                }
                if (this.Sort != null)
                {
                    hashCode = (hashCode * 59) + this.Sort.GetHashCode();
                }
                if (this.ReportCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.ReportCurrency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EquipWithSubtotals.GetHashCode();
                hashCode = (hashCode * 59) + this.ReturnResultAsExpandedTypes.GetHashCode();
                if (this.PortfolioEntityIds != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioEntityIds.GetHashCode();
                }
                if (this.ValuationSchedule != null)
                {
                    hashCode = (hashCode * 59) + this.ValuationSchedule.GetHashCode();
                }
                if (this.MarketDataOverrides != null)
                {
                    hashCode = (hashCode * 59) + this.MarketDataOverrides.GetHashCode();
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
