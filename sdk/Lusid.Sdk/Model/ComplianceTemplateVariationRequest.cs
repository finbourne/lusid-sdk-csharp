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
    /// ComplianceTemplateVariationRequest
    /// </summary>
    [DataContract(Name = "ComplianceTemplateVariationRequest")]
    public partial class ComplianceTemplateVariationRequest : IEquatable<ComplianceTemplateVariationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceTemplateVariationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComplianceTemplateVariationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceTemplateVariationRequest" /> class.
        /// </summary>
        /// <param name="label">label (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="outcomeDescription">outcomeDescription.</param>
        /// <param name="referencedGroupLabel">referencedGroupLabel.</param>
        /// <param name="steps">steps (required).</param>
        public ComplianceTemplateVariationRequest(string label = default(string), string description = default(string), string outcomeDescription = default(string), string referencedGroupLabel = default(string), List<ComplianceStepRequest> steps = default(List<ComplianceStepRequest>))
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for ComplianceTemplateVariationRequest and cannot be null");
            }
            this.Label = label;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ComplianceTemplateVariationRequest and cannot be null");
            }
            this.Description = description;
            // to ensure "steps" is required (not null)
            if (steps == null)
            {
                throw new ArgumentNullException("steps is a required property for ComplianceTemplateVariationRequest and cannot be null");
            }
            this.Steps = steps;
            this.OutcomeDescription = outcomeDescription;
            this.ReferencedGroupLabel = referencedGroupLabel;
        }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets OutcomeDescription
        /// </summary>
        [DataMember(Name = "outcomeDescription", EmitDefaultValue = true)]
        public string OutcomeDescription { get; set; }

        /// <summary>
        /// Gets or Sets ReferencedGroupLabel
        /// </summary>
        [DataMember(Name = "referencedGroupLabel", EmitDefaultValue = true)]
        public string ReferencedGroupLabel { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", IsRequired = true, EmitDefaultValue = true)]
        public List<ComplianceStepRequest> Steps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComplianceTemplateVariationRequest {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OutcomeDescription: ").Append(OutcomeDescription).Append("\n");
            sb.Append("  ReferencedGroupLabel: ").Append(ReferencedGroupLabel).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
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
            return this.Equals(input as ComplianceTemplateVariationRequest);
        }

        /// <summary>
        /// Returns true if ComplianceTemplateVariationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplianceTemplateVariationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplianceTemplateVariationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.OutcomeDescription == input.OutcomeDescription ||
                    (this.OutcomeDescription != null &&
                    this.OutcomeDescription.Equals(input.OutcomeDescription))
                ) && 
                (
                    this.ReferencedGroupLabel == input.ReferencedGroupLabel ||
                    (this.ReferencedGroupLabel != null &&
                    this.ReferencedGroupLabel.Equals(input.ReferencedGroupLabel))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
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
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.OutcomeDescription != null)
                {
                    hashCode = (hashCode * 59) + this.OutcomeDescription.GetHashCode();
                }
                if (this.ReferencedGroupLabel != null)
                {
                    hashCode = (hashCode * 59) + this.ReferencedGroupLabel.GetHashCode();
                }
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
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
            // Label (string) maxLength
            if (this.Label != null && this.Label.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Label, length must be less than 64.", new [] { "Label" });
            }

            // Label (string) minLength
            if (this.Label != null && this.Label.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Label, length must be greater than 1.", new [] { "Label" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Description (string) pattern
            Regex regexDescription = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexDescription.Match(this.Description).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, must match a pattern of " + regexDescription, new [] { "Description" });
            }

            // OutcomeDescription (string) maxLength
            if (this.OutcomeDescription != null && this.OutcomeDescription.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OutcomeDescription, length must be less than 1024.", new [] { "OutcomeDescription" });
            }

            // OutcomeDescription (string) minLength
            if (this.OutcomeDescription != null && this.OutcomeDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OutcomeDescription, length must be greater than 0.", new [] { "OutcomeDescription" });
            }

            // OutcomeDescription (string) pattern
            Regex regexOutcomeDescription = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexOutcomeDescription.Match(this.OutcomeDescription).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OutcomeDescription, must match a pattern of " + regexOutcomeDescription, new [] { "OutcomeDescription" });
            }

            // ReferencedGroupLabel (string) maxLength
            if (this.ReferencedGroupLabel != null && this.ReferencedGroupLabel.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferencedGroupLabel, length must be less than 64.", new [] { "ReferencedGroupLabel" });
            }

            // ReferencedGroupLabel (string) minLength
            if (this.ReferencedGroupLabel != null && this.ReferencedGroupLabel.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferencedGroupLabel, length must be greater than 1.", new [] { "ReferencedGroupLabel" });
            }

            yield break;
        }
    }
}