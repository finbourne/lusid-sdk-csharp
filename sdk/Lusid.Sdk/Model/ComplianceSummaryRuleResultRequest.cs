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
    /// ComplianceSummaryRuleResultRequest
    /// </summary>
    [DataContract(Name = "ComplianceSummaryRuleResultRequest")]
    public partial class ComplianceSummaryRuleResultRequest : IEquatable<ComplianceSummaryRuleResultRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceSummaryRuleResultRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComplianceSummaryRuleResultRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceSummaryRuleResultRequest" /> class.
        /// </summary>
        /// <param name="ruleId">ruleId (required).</param>
        /// <param name="templateId">templateId (required).</param>
        /// <param name="variation">variation (required).</param>
        /// <param name="ruleStatus">ruleStatus (required).</param>
        /// <param name="affectedPortfolios">affectedPortfolios (required).</param>
        /// <param name="affectedOrders">affectedOrders (required).</param>
        /// <param name="ruleBreakdown">ruleBreakdown (required).</param>
        public ComplianceSummaryRuleResultRequest(ResourceId ruleId = default(ResourceId), ResourceId templateId = default(ResourceId), string variation = default(string), string ruleStatus = default(string), List<ResourceId> affectedPortfolios = default(List<ResourceId>), List<ResourceId> affectedOrders = default(List<ResourceId>), Dictionary<string, ComplianceRuleBreakdownRequest> ruleBreakdown = default(Dictionary<string, ComplianceRuleBreakdownRequest>))
        {
            // to ensure "ruleId" is required (not null)
            if (ruleId == null)
            {
                throw new ArgumentNullException("ruleId is a required property for ComplianceSummaryRuleResultRequest and cannot be null");
            }
            this.RuleId = ruleId;
            // to ensure "templateId" is required (not null)
            if (templateId == null)
            {
                throw new ArgumentNullException("templateId is a required property for ComplianceSummaryRuleResultRequest and cannot be null");
            }
            this.TemplateId = templateId;
            // to ensure "variation" is required (not null)
            if (variation == null)
            {
                throw new ArgumentNullException("variation is a required property for ComplianceSummaryRuleResultRequest and cannot be null");
            }
            this.Variation = variation;
            // to ensure "ruleStatus" is required (not null)
            if (ruleStatus == null)
            {
                throw new ArgumentNullException("ruleStatus is a required property for ComplianceSummaryRuleResultRequest and cannot be null");
            }
            this.RuleStatus = ruleStatus;
            // to ensure "affectedPortfolios" is required (not null)
            if (affectedPortfolios == null)
            {
                throw new ArgumentNullException("affectedPortfolios is a required property for ComplianceSummaryRuleResultRequest and cannot be null");
            }
            this.AffectedPortfolios = affectedPortfolios;
            // to ensure "affectedOrders" is required (not null)
            if (affectedOrders == null)
            {
                throw new ArgumentNullException("affectedOrders is a required property for ComplianceSummaryRuleResultRequest and cannot be null");
            }
            this.AffectedOrders = affectedOrders;
            // to ensure "ruleBreakdown" is required (not null)
            if (ruleBreakdown == null)
            {
                throw new ArgumentNullException("ruleBreakdown is a required property for ComplianceSummaryRuleResultRequest and cannot be null");
            }
            this.RuleBreakdown = ruleBreakdown;
        }

        /// <summary>
        /// Gets or Sets RuleId
        /// </summary>
        [DataMember(Name = "ruleId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId RuleId { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name = "templateId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets Variation
        /// </summary>
        [DataMember(Name = "variation", IsRequired = true, EmitDefaultValue = true)]
        public string Variation { get; set; }

        /// <summary>
        /// Gets or Sets RuleStatus
        /// </summary>
        [DataMember(Name = "ruleStatus", IsRequired = true, EmitDefaultValue = true)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// Gets or Sets AffectedPortfolios
        /// </summary>
        [DataMember(Name = "affectedPortfolios", IsRequired = true, EmitDefaultValue = true)]
        public List<ResourceId> AffectedPortfolios { get; set; }

        /// <summary>
        /// Gets or Sets AffectedOrders
        /// </summary>
        [DataMember(Name = "affectedOrders", IsRequired = true, EmitDefaultValue = true)]
        public List<ResourceId> AffectedOrders { get; set; }

        /// <summary>
        /// Gets or Sets RuleBreakdown
        /// </summary>
        [DataMember(Name = "ruleBreakdown", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, ComplianceRuleBreakdownRequest> RuleBreakdown { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComplianceSummaryRuleResultRequest {\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Variation: ").Append(Variation).Append("\n");
            sb.Append("  RuleStatus: ").Append(RuleStatus).Append("\n");
            sb.Append("  AffectedPortfolios: ").Append(AffectedPortfolios).Append("\n");
            sb.Append("  AffectedOrders: ").Append(AffectedOrders).Append("\n");
            sb.Append("  RuleBreakdown: ").Append(RuleBreakdown).Append("\n");
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
            return this.Equals(input as ComplianceSummaryRuleResultRequest);
        }

        /// <summary>
        /// Returns true if ComplianceSummaryRuleResultRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplianceSummaryRuleResultRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplianceSummaryRuleResultRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Variation == input.Variation ||
                    (this.Variation != null &&
                    this.Variation.Equals(input.Variation))
                ) && 
                (
                    this.RuleStatus == input.RuleStatus ||
                    (this.RuleStatus != null &&
                    this.RuleStatus.Equals(input.RuleStatus))
                ) && 
                (
                    this.AffectedPortfolios == input.AffectedPortfolios ||
                    this.AffectedPortfolios != null &&
                    input.AffectedPortfolios != null &&
                    this.AffectedPortfolios.SequenceEqual(input.AffectedPortfolios)
                ) && 
                (
                    this.AffectedOrders == input.AffectedOrders ||
                    this.AffectedOrders != null &&
                    input.AffectedOrders != null &&
                    this.AffectedOrders.SequenceEqual(input.AffectedOrders)
                ) && 
                (
                    this.RuleBreakdown == input.RuleBreakdown ||
                    this.RuleBreakdown != null &&
                    input.RuleBreakdown != null &&
                    this.RuleBreakdown.SequenceEqual(input.RuleBreakdown)
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
                if (this.RuleId != null)
                {
                    hashCode = (hashCode * 59) + this.RuleId.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.Variation != null)
                {
                    hashCode = (hashCode * 59) + this.Variation.GetHashCode();
                }
                if (this.RuleStatus != null)
                {
                    hashCode = (hashCode * 59) + this.RuleStatus.GetHashCode();
                }
                if (this.AffectedPortfolios != null)
                {
                    hashCode = (hashCode * 59) + this.AffectedPortfolios.GetHashCode();
                }
                if (this.AffectedOrders != null)
                {
                    hashCode = (hashCode * 59) + this.AffectedOrders.GetHashCode();
                }
                if (this.RuleBreakdown != null)
                {
                    hashCode = (hashCode * 59) + this.RuleBreakdown.GetHashCode();
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
            // Variation (string) maxLength
            if (this.Variation != null && this.Variation.Length > 6000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Variation, length must be less than 6000.", new [] { "Variation" });
            }

            // Variation (string) minLength
            if (this.Variation != null && this.Variation.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Variation, length must be greater than 0.", new [] { "Variation" });
            }

            // RuleStatus (string) maxLength
            if (this.RuleStatus != null && this.RuleStatus.Length > 6000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RuleStatus, length must be less than 6000.", new [] { "RuleStatus" });
            }

            // RuleStatus (string) minLength
            if (this.RuleStatus != null && this.RuleStatus.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RuleStatus, length must be greater than 0.", new [] { "RuleStatus" });
            }

            yield break;
        }
    }
}