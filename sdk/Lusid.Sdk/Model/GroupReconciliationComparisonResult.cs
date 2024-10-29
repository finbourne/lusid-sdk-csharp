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
    /// GroupReconciliationComparisonResult
    /// </summary>
    [DataContract(Name = "GroupReconciliationComparisonResult")]
    public partial class GroupReconciliationComparisonResult : IEquatable<GroupReconciliationComparisonResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReconciliationComparisonResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupReconciliationComparisonResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupReconciliationComparisonResult" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="reconciliationType">The type of reconciliation to perform. \&quot;Holding\&quot; | \&quot;Transaction\&quot; | \&quot;Valuation\&quot; (required).</param>
        /// <param name="groupReconciliationDefinitionId">groupReconciliationDefinitionId (required).</param>
        /// <param name="instanceId">instanceId (required).</param>
        /// <param name="comparisonResultId">Comparison result identifier, encoded value for core attribute results, aggregate attribute results, reconciliation type and run instanceId. (required).</param>
        /// <param name="reconciliationRunAsAt">The timestamp when the run occurred. (required).</param>
        /// <param name="resultType">Reconciliation run general result. \&quot;Break\&quot; | \&quot;Match\&quot; | \&quot;PartialMatch\&quot; | \&quot;NotFound (required).</param>
        /// <param name="resultStatus">Indicates how a particular result evolves from one run to the next. \&quot;New\&quot; | \&quot;Confirmed\&quot; | \&quot;Changed\&quot; (required).</param>
        /// <param name="reviewStatus">Status of whether user has provided any input (comments, manual matches, break codes). \&quot;Pending\&quot; | \&quot;Reviewed\&quot; | \&quot;Matched\&quot; | \&quot;Invalid\&quot; (required).</param>
        /// <param name="datesReconciled">datesReconciled (required).</param>
        /// <param name="coreAttributes">coreAttributes (required).</param>
        /// <param name="aggregateAttributes">aggregateAttributes (required).</param>
        /// <param name="userReview">userReview.</param>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="version">version.</param>
        /// <param name="links">links.</param>
        public GroupReconciliationComparisonResult(ResourceId id = default(ResourceId), string reconciliationType = default(string), ResourceId groupReconciliationDefinitionId = default(ResourceId), GroupReconciliationInstanceId instanceId = default(GroupReconciliationInstanceId), string comparisonResultId = default(string), DateTimeOffset reconciliationRunAsAt = default(DateTimeOffset), string resultType = default(string), string resultStatus = default(string), string reviewStatus = default(string), GroupReconciliationDates datesReconciled = default(GroupReconciliationDates), GroupReconciliationCoreAttributeValues coreAttributes = default(GroupReconciliationCoreAttributeValues), GroupReconciliationAggregateAttributeValues aggregateAttributes = default(GroupReconciliationAggregateAttributeValues), GroupReconciliationUserReview userReview = default(GroupReconciliationUserReview), string href = default(string), ModelVersion version = default(ModelVersion), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.Id = id;
            // to ensure "reconciliationType" is required (not null)
            if (reconciliationType == null)
            {
                throw new ArgumentNullException("reconciliationType is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.ReconciliationType = reconciliationType;
            // to ensure "groupReconciliationDefinitionId" is required (not null)
            if (groupReconciliationDefinitionId == null)
            {
                throw new ArgumentNullException("groupReconciliationDefinitionId is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.GroupReconciliationDefinitionId = groupReconciliationDefinitionId;
            // to ensure "instanceId" is required (not null)
            if (instanceId == null)
            {
                throw new ArgumentNullException("instanceId is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.InstanceId = instanceId;
            // to ensure "comparisonResultId" is required (not null)
            if (comparisonResultId == null)
            {
                throw new ArgumentNullException("comparisonResultId is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.ComparisonResultId = comparisonResultId;
            this.ReconciliationRunAsAt = reconciliationRunAsAt;
            // to ensure "resultType" is required (not null)
            if (resultType == null)
            {
                throw new ArgumentNullException("resultType is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.ResultType = resultType;
            // to ensure "resultStatus" is required (not null)
            if (resultStatus == null)
            {
                throw new ArgumentNullException("resultStatus is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.ResultStatus = resultStatus;
            // to ensure "reviewStatus" is required (not null)
            if (reviewStatus == null)
            {
                throw new ArgumentNullException("reviewStatus is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.ReviewStatus = reviewStatus;
            // to ensure "datesReconciled" is required (not null)
            if (datesReconciled == null)
            {
                throw new ArgumentNullException("datesReconciled is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.DatesReconciled = datesReconciled;
            // to ensure "coreAttributes" is required (not null)
            if (coreAttributes == null)
            {
                throw new ArgumentNullException("coreAttributes is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.CoreAttributes = coreAttributes;
            // to ensure "aggregateAttributes" is required (not null)
            if (aggregateAttributes == null)
            {
                throw new ArgumentNullException("aggregateAttributes is a required property for GroupReconciliationComparisonResult and cannot be null");
            }
            this.AggregateAttributes = aggregateAttributes;
            this.UserReview = userReview;
            this.Href = href;
            this._Version = version;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The type of reconciliation to perform. \&quot;Holding\&quot; | \&quot;Transaction\&quot; | \&quot;Valuation\&quot;
        /// </summary>
        /// <value>The type of reconciliation to perform. \&quot;Holding\&quot; | \&quot;Transaction\&quot; | \&quot;Valuation\&quot;</value>
        [DataMember(Name = "reconciliationType", IsRequired = true, EmitDefaultValue = true)]
        public string ReconciliationType { get; set; }

        /// <summary>
        /// Gets or Sets GroupReconciliationDefinitionId
        /// </summary>
        [DataMember(Name = "groupReconciliationDefinitionId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId GroupReconciliationDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name = "instanceId", IsRequired = true, EmitDefaultValue = true)]
        public GroupReconciliationInstanceId InstanceId { get; set; }

        /// <summary>
        /// Comparison result identifier, encoded value for core attribute results, aggregate attribute results, reconciliation type and run instanceId.
        /// </summary>
        /// <value>Comparison result identifier, encoded value for core attribute results, aggregate attribute results, reconciliation type and run instanceId.</value>
        [DataMember(Name = "comparisonResultId", IsRequired = true, EmitDefaultValue = true)]
        public string ComparisonResultId { get; set; }

        /// <summary>
        /// The timestamp when the run occurred.
        /// </summary>
        /// <value>The timestamp when the run occurred.</value>
        [DataMember(Name = "reconciliationRunAsAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset ReconciliationRunAsAt { get; set; }

        /// <summary>
        /// Reconciliation run general result. \&quot;Break\&quot; | \&quot;Match\&quot; | \&quot;PartialMatch\&quot; | \&quot;NotFound
        /// </summary>
        /// <value>Reconciliation run general result. \&quot;Break\&quot; | \&quot;Match\&quot; | \&quot;PartialMatch\&quot; | \&quot;NotFound</value>
        [DataMember(Name = "resultType", IsRequired = true, EmitDefaultValue = true)]
        public string ResultType { get; set; }

        /// <summary>
        /// Indicates how a particular result evolves from one run to the next. \&quot;New\&quot; | \&quot;Confirmed\&quot; | \&quot;Changed\&quot;
        /// </summary>
        /// <value>Indicates how a particular result evolves from one run to the next. \&quot;New\&quot; | \&quot;Confirmed\&quot; | \&quot;Changed\&quot;</value>
        [DataMember(Name = "resultStatus", IsRequired = true, EmitDefaultValue = true)]
        public string ResultStatus { get; set; }

        /// <summary>
        /// Status of whether user has provided any input (comments, manual matches, break codes). \&quot;Pending\&quot; | \&quot;Reviewed\&quot; | \&quot;Matched\&quot; | \&quot;Invalid\&quot;
        /// </summary>
        /// <value>Status of whether user has provided any input (comments, manual matches, break codes). \&quot;Pending\&quot; | \&quot;Reviewed\&quot; | \&quot;Matched\&quot; | \&quot;Invalid\&quot;</value>
        [DataMember(Name = "reviewStatus", IsRequired = true, EmitDefaultValue = true)]
        public string ReviewStatus { get; set; }

        /// <summary>
        /// Gets or Sets DatesReconciled
        /// </summary>
        [DataMember(Name = "datesReconciled", IsRequired = true, EmitDefaultValue = true)]
        public GroupReconciliationDates DatesReconciled { get; set; }

        /// <summary>
        /// Gets or Sets CoreAttributes
        /// </summary>
        [DataMember(Name = "coreAttributes", IsRequired = true, EmitDefaultValue = true)]
        public GroupReconciliationCoreAttributeValues CoreAttributes { get; set; }

        /// <summary>
        /// Gets or Sets AggregateAttributes
        /// </summary>
        [DataMember(Name = "aggregateAttributes", IsRequired = true, EmitDefaultValue = true)]
        public GroupReconciliationAggregateAttributeValues AggregateAttributes { get; set; }

        /// <summary>
        /// Gets or Sets UserReview
        /// </summary>
        [DataMember(Name = "userReview", EmitDefaultValue = false)]
        public GroupReconciliationUserReview UserReview { get; set; }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

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
            sb.Append("class GroupReconciliationComparisonResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReconciliationType: ").Append(ReconciliationType).Append("\n");
            sb.Append("  GroupReconciliationDefinitionId: ").Append(GroupReconciliationDefinitionId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  ComparisonResultId: ").Append(ComparisonResultId).Append("\n");
            sb.Append("  ReconciliationRunAsAt: ").Append(ReconciliationRunAsAt).Append("\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
            sb.Append("  ResultStatus: ").Append(ResultStatus).Append("\n");
            sb.Append("  ReviewStatus: ").Append(ReviewStatus).Append("\n");
            sb.Append("  DatesReconciled: ").Append(DatesReconciled).Append("\n");
            sb.Append("  CoreAttributes: ").Append(CoreAttributes).Append("\n");
            sb.Append("  AggregateAttributes: ").Append(AggregateAttributes).Append("\n");
            sb.Append("  UserReview: ").Append(UserReview).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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
            return this.Equals(input as GroupReconciliationComparisonResult);
        }

        /// <summary>
        /// Returns true if GroupReconciliationComparisonResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupReconciliationComparisonResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupReconciliationComparisonResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ReconciliationType == input.ReconciliationType ||
                    (this.ReconciliationType != null &&
                    this.ReconciliationType.Equals(input.ReconciliationType))
                ) && 
                (
                    this.GroupReconciliationDefinitionId == input.GroupReconciliationDefinitionId ||
                    (this.GroupReconciliationDefinitionId != null &&
                    this.GroupReconciliationDefinitionId.Equals(input.GroupReconciliationDefinitionId))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.ComparisonResultId == input.ComparisonResultId ||
                    (this.ComparisonResultId != null &&
                    this.ComparisonResultId.Equals(input.ComparisonResultId))
                ) && 
                (
                    this.ReconciliationRunAsAt == input.ReconciliationRunAsAt ||
                    (this.ReconciliationRunAsAt != null &&
                    this.ReconciliationRunAsAt.Equals(input.ReconciliationRunAsAt))
                ) && 
                (
                    this.ResultType == input.ResultType ||
                    (this.ResultType != null &&
                    this.ResultType.Equals(input.ResultType))
                ) && 
                (
                    this.ResultStatus == input.ResultStatus ||
                    (this.ResultStatus != null &&
                    this.ResultStatus.Equals(input.ResultStatus))
                ) && 
                (
                    this.ReviewStatus == input.ReviewStatus ||
                    (this.ReviewStatus != null &&
                    this.ReviewStatus.Equals(input.ReviewStatus))
                ) && 
                (
                    this.DatesReconciled == input.DatesReconciled ||
                    (this.DatesReconciled != null &&
                    this.DatesReconciled.Equals(input.DatesReconciled))
                ) && 
                (
                    this.CoreAttributes == input.CoreAttributes ||
                    (this.CoreAttributes != null &&
                    this.CoreAttributes.Equals(input.CoreAttributes))
                ) && 
                (
                    this.AggregateAttributes == input.AggregateAttributes ||
                    (this.AggregateAttributes != null &&
                    this.AggregateAttributes.Equals(input.AggregateAttributes))
                ) && 
                (
                    this.UserReview == input.UserReview ||
                    (this.UserReview != null &&
                    this.UserReview.Equals(input.UserReview))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ReconciliationType != null)
                {
                    hashCode = (hashCode * 59) + this.ReconciliationType.GetHashCode();
                }
                if (this.GroupReconciliationDefinitionId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupReconciliationDefinitionId.GetHashCode();
                }
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }
                if (this.ComparisonResultId != null)
                {
                    hashCode = (hashCode * 59) + this.ComparisonResultId.GetHashCode();
                }
                if (this.ReconciliationRunAsAt != null)
                {
                    hashCode = (hashCode * 59) + this.ReconciliationRunAsAt.GetHashCode();
                }
                if (this.ResultType != null)
                {
                    hashCode = (hashCode * 59) + this.ResultType.GetHashCode();
                }
                if (this.ResultStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ResultStatus.GetHashCode();
                }
                if (this.ReviewStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewStatus.GetHashCode();
                }
                if (this.DatesReconciled != null)
                {
                    hashCode = (hashCode * 59) + this.DatesReconciled.GetHashCode();
                }
                if (this.CoreAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.CoreAttributes.GetHashCode();
                }
                if (this.AggregateAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.AggregateAttributes.GetHashCode();
                }
                if (this.UserReview != null)
                {
                    hashCode = (hashCode * 59) + this.UserReview.GetHashCode();
                }
                if (this.Href != null)
                {
                    hashCode = (hashCode * 59) + this.Href.GetHashCode();
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
            // ReconciliationType (string) minLength
            if (this.ReconciliationType != null && this.ReconciliationType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconciliationType, length must be greater than 1.", new [] { "ReconciliationType" });
            }

            // ComparisonResultId (string) minLength
            if (this.ComparisonResultId != null && this.ComparisonResultId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ComparisonResultId, length must be greater than 1.", new [] { "ComparisonResultId" });
            }

            // ResultType (string) minLength
            if (this.ResultType != null && this.ResultType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultType, length must be greater than 1.", new [] { "ResultType" });
            }

            // ResultStatus (string) minLength
            if (this.ResultStatus != null && this.ResultStatus.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultStatus, length must be greater than 1.", new [] { "ResultStatus" });
            }

            // ReviewStatus (string) minLength
            if (this.ReviewStatus != null && this.ReviewStatus.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReviewStatus, length must be greater than 1.", new [] { "ReviewStatus" });
            }

            yield break;
        }
    }
}