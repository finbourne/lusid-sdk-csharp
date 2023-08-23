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
    /// GetVirtualDocumentResponse
    /// </summary>
    [DataContract(Name = "GetVirtualDocumentResponse")]
    public partial class GetVirtualDocumentResponse : IEquatable<GetVirtualDocumentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVirtualDocumentResponse" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="values">The set of values that were successfully retrieved..</param>
        /// <param name="failed">The set of calues that could not be retrieved along with a reason for this, e.g. badly formed request..</param>
        /// <param name="links">links.</param>
        public GetVirtualDocumentResponse(string href = default(string), Dictionary<string, VirtualDocument> values = default(Dictionary<string, VirtualDocument>), Dictionary<string, ErrorDetail> failed = default(Dictionary<string, ErrorDetail>), List<Link> links = default(List<Link>))
        {
            this.Href = href;
            this.Values = values;
            this.Failed = failed;
            this.Links = links;
        }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// The set of values that were successfully retrieved.
        /// </summary>
        /// <value>The set of values that were successfully retrieved.</value>
        [DataMember(Name = "values", EmitDefaultValue = true)]
        public Dictionary<string, VirtualDocument> Values { get; set; }

        /// <summary>
        /// The set of calues that could not be retrieved along with a reason for this, e.g. badly formed request.
        /// </summary>
        /// <value>The set of calues that could not be retrieved along with a reason for this, e.g. badly formed request.</value>
        [DataMember(Name = "failed", EmitDefaultValue = true)]
        public Dictionary<string, ErrorDetail> Failed { get; set; }

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
            sb.Append("class GetVirtualDocumentResponse {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
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
            return this.Equals(input as GetVirtualDocumentResponse);
        }

        /// <summary>
        /// Returns true if GetVirtualDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetVirtualDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetVirtualDocumentResponse input)
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
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Failed == input.Failed ||
                    this.Failed != null &&
                    input.Failed != null &&
                    this.Failed.SequenceEqual(input.Failed)
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
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
                }
                if (this.Failed != null)
                {
                    hashCode = (hashCode * 59) + this.Failed.GetHashCode();
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
