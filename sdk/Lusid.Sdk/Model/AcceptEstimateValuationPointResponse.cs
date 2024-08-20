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
    /// The Valuation Point Data Response for AcceptEstimate called on the Fund and specified date.
    /// </summary>
    [DataContract(Name = "AcceptEstimateValuationPointResponse")]
    public partial class AcceptEstimateValuationPointResponse : IEquatable<AcceptEstimateValuationPointResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptEstimateValuationPointResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AcceptEstimateValuationPointResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptEstimateValuationPointResponse" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="candidateValuationPoint">candidateValuationPoint (required).</param>
        /// <param name="latestValuationPoint">latestValuationPoint.</param>
        /// <param name="links">links.</param>
        public AcceptEstimateValuationPointResponse(string href = default(string), ValuationPointDataResponse candidateValuationPoint = default(ValuationPointDataResponse), ValuationPointDataResponse latestValuationPoint = default(ValuationPointDataResponse), List<Link> links = default(List<Link>))
        {
            // to ensure "candidateValuationPoint" is required (not null)
            if (candidateValuationPoint == null)
            {
                throw new ArgumentNullException("candidateValuationPoint is a required property for AcceptEstimateValuationPointResponse and cannot be null");
            }
            this.CandidateValuationPoint = candidateValuationPoint;
            this.Href = href;
            this.LatestValuationPoint = latestValuationPoint;
            this.Links = links;
        }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets CandidateValuationPoint
        /// </summary>
        [DataMember(Name = "candidateValuationPoint", IsRequired = true, EmitDefaultValue = true)]
        public ValuationPointDataResponse CandidateValuationPoint { get; set; }

        /// <summary>
        /// Gets or Sets LatestValuationPoint
        /// </summary>
        [DataMember(Name = "latestValuationPoint", EmitDefaultValue = false)]
        public ValuationPointDataResponse LatestValuationPoint { get; set; }

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
            sb.Append("class AcceptEstimateValuationPointResponse {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  CandidateValuationPoint: ").Append(CandidateValuationPoint).Append("\n");
            sb.Append("  LatestValuationPoint: ").Append(LatestValuationPoint).Append("\n");
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
            return this.Equals(input as AcceptEstimateValuationPointResponse);
        }

        /// <summary>
        /// Returns true if AcceptEstimateValuationPointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AcceptEstimateValuationPointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcceptEstimateValuationPointResponse input)
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
                    this.CandidateValuationPoint == input.CandidateValuationPoint ||
                    (this.CandidateValuationPoint != null &&
                    this.CandidateValuationPoint.Equals(input.CandidateValuationPoint))
                ) && 
                (
                    this.LatestValuationPoint == input.LatestValuationPoint ||
                    (this.LatestValuationPoint != null &&
                    this.LatestValuationPoint.Equals(input.LatestValuationPoint))
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
                if (this.CandidateValuationPoint != null)
                {
                    hashCode = (hashCode * 59) + this.CandidateValuationPoint.GetHashCode();
                }
                if (this.LatestValuationPoint != null)
                {
                    hashCode = (hashCode * 59) + this.LatestValuationPoint.GetHashCode();
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
