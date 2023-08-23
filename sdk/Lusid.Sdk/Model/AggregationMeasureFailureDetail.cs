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
    /// AggregationMeasureFailureDetail
    /// </summary>
    [DataContract(Name = "AggregationMeasureFailureDetail")]
    public partial class AggregationMeasureFailureDetail : IEquatable<AggregationMeasureFailureDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationMeasureFailureDetail" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="effectiveAt">effectiveAt.</param>
        /// <param name="measure">measure.</param>
        /// <param name="reason">reason.</param>
        /// <param name="detail">detail.</param>
        public AggregationMeasureFailureDetail(string id = default(string), DateTimeOffset effectiveAt = default(DateTimeOffset), string measure = default(string), string reason = default(string), string detail = default(string))
        {
            this.Id = id;
            this.EffectiveAt = effectiveAt;
            this.Measure = measure;
            this.Reason = reason;
            this.Detail = detail;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveAt
        /// </summary>
        [DataMember(Name = "effectiveAt", EmitDefaultValue = false)]
        public DateTimeOffset EffectiveAt { get; set; }

        /// <summary>
        /// Gets or Sets Measure
        /// </summary>
        [DataMember(Name = "measure", EmitDefaultValue = true)]
        public string Measure { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = true)]
        public string Detail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AggregationMeasureFailureDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  Measure: ").Append(Measure).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
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
            return this.Equals(input as AggregationMeasureFailureDetail);
        }

        /// <summary>
        /// Returns true if AggregationMeasureFailureDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregationMeasureFailureDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationMeasureFailureDetail input)
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
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
                ) && 
                (
                    this.Measure == input.Measure ||
                    (this.Measure != null &&
                    this.Measure.Equals(input.Measure))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
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
                if (this.EffectiveAt != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveAt.GetHashCode();
                }
                if (this.Measure != null)
                {
                    hashCode = (hashCode * 59) + this.Measure.GetHashCode();
                }
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                }
                if (this.Detail != null)
                {
                    hashCode = (hashCode * 59) + this.Detail.GetHashCode();
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
