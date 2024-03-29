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
    /// BatchUpsertPropertyDefinitionPropertiesResponse
    /// </summary>
    [DataContract(Name = "BatchUpsertPropertyDefinitionPropertiesResponse")]
    public partial class BatchUpsertPropertyDefinitionPropertiesResponse : IEquatable<BatchUpsertPropertyDefinitionPropertiesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUpsertPropertyDefinitionPropertiesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchUpsertPropertyDefinitionPropertiesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchUpsertPropertyDefinitionPropertiesResponse" /> class.
        /// </summary>
        /// <param name="values">The properties that have been successfully upserted (required).</param>
        /// <param name="failed">The properties that could not be upserted along with a reason for their failure. (required).</param>
        /// <param name="asAtDate">The as-at datetime at which properties were created or updated. (required).</param>
        /// <param name="links">links.</param>
        public BatchUpsertPropertyDefinitionPropertiesResponse(Dictionary<string, Property> values = default(Dictionary<string, Property>), Dictionary<string, ErrorDetail> failed = default(Dictionary<string, ErrorDetail>), DateTimeOffset asAtDate = default(DateTimeOffset), List<Link> links = default(List<Link>))
        {
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new ArgumentNullException("values is a required property for BatchUpsertPropertyDefinitionPropertiesResponse and cannot be null");
            }
            this.Values = values;
            // to ensure "failed" is required (not null)
            if (failed == null)
            {
                throw new ArgumentNullException("failed is a required property for BatchUpsertPropertyDefinitionPropertiesResponse and cannot be null");
            }
            this.Failed = failed;
            this.AsAtDate = asAtDate;
            this.Links = links;
        }

        /// <summary>
        /// The properties that have been successfully upserted
        /// </summary>
        /// <value>The properties that have been successfully upserted</value>
        [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Property> Values { get; set; }

        /// <summary>
        /// The properties that could not be upserted along with a reason for their failure.
        /// </summary>
        /// <value>The properties that could not be upserted along with a reason for their failure.</value>
        [DataMember(Name = "failed", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, ErrorDetail> Failed { get; set; }

        /// <summary>
        /// The as-at datetime at which properties were created or updated.
        /// </summary>
        /// <value>The as-at datetime at which properties were created or updated.</value>
        [DataMember(Name = "asAtDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset AsAtDate { get; set; }

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
            sb.Append("class BatchUpsertPropertyDefinitionPropertiesResponse {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  AsAtDate: ").Append(AsAtDate).Append("\n");
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
            return this.Equals(input as BatchUpsertPropertyDefinitionPropertiesResponse);
        }

        /// <summary>
        /// Returns true if BatchUpsertPropertyDefinitionPropertiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchUpsertPropertyDefinitionPropertiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchUpsertPropertyDefinitionPropertiesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.AsAtDate == input.AsAtDate ||
                    (this.AsAtDate != null &&
                    this.AsAtDate.Equals(input.AsAtDate))
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
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
                }
                if (this.Failed != null)
                {
                    hashCode = (hashCode * 59) + this.Failed.GetHashCode();
                }
                if (this.AsAtDate != null)
                {
                    hashCode = (hashCode * 59) + this.AsAtDate.GetHashCode();
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
