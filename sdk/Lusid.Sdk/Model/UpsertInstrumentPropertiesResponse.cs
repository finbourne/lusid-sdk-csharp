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
    /// UpsertInstrumentPropertiesResponse
    /// </summary>
    [DataContract(Name = "UpsertInstrumentPropertiesResponse")]
    public partial class UpsertInstrumentPropertiesResponse : IEquatable<UpsertInstrumentPropertiesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertInstrumentPropertiesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertInstrumentPropertiesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertInstrumentPropertiesResponse" /> class.
        /// </summary>
        /// <param name="asAtDate">The as-at datetime at which properties were created or updated. (required).</param>
        /// <param name="links">links.</param>
        public UpsertInstrumentPropertiesResponse(DateTimeOffset asAtDate = default(DateTimeOffset), List<Link> links = default(List<Link>))
        {
            this.AsAtDate = asAtDate;
            this.Links = links;
        }

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
            sb.Append("class UpsertInstrumentPropertiesResponse {\n");
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
            return this.Equals(input as UpsertInstrumentPropertiesResponse);
        }

        /// <summary>
        /// Returns true if UpsertInstrumentPropertiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertInstrumentPropertiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertInstrumentPropertiesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
