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
    /// Supported pricing models for an instrument.
    /// </summary>
    [DataContract(Name = "InstrumentModels")]
    public partial class InstrumentModels : IEquatable<InstrumentModels>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentModels" /> class.
        /// </summary>
        /// <param name="instrumentId">The unique LUSID Instrument Identifier (LUID) of the instrument..</param>
        /// <param name="supportedModels">The pricing models supported by the instrument e.g. &#39;Discounting&#39;..</param>
        /// <param name="links">links.</param>
        public InstrumentModels(string instrumentId = default(string), List<string> supportedModels = default(List<string>), List<Link> links = default(List<Link>))
        {
            this.InstrumentId = instrumentId;
            this.SupportedModels = supportedModels;
            this.Links = links;
        }

        /// <summary>
        /// The unique LUSID Instrument Identifier (LUID) of the instrument.
        /// </summary>
        /// <value>The unique LUSID Instrument Identifier (LUID) of the instrument.</value>
        [DataMember(Name = "instrumentId", EmitDefaultValue = true)]
        public string InstrumentId { get; set; }

        /// <summary>
        /// The pricing models supported by the instrument e.g. &#39;Discounting&#39;.
        /// </summary>
        /// <value>The pricing models supported by the instrument e.g. &#39;Discounting&#39;.</value>
        [DataMember(Name = "supportedModels", EmitDefaultValue = true)]
        public List<string> SupportedModels { get; set; }

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
            sb.Append("class InstrumentModels {\n");
            sb.Append("  InstrumentId: ").Append(InstrumentId).Append("\n");
            sb.Append("  SupportedModels: ").Append(SupportedModels).Append("\n");
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
            return this.Equals(input as InstrumentModels);
        }

        /// <summary>
        /// Returns true if InstrumentModels instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentModels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentModels input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstrumentId == input.InstrumentId ||
                    (this.InstrumentId != null &&
                    this.InstrumentId.Equals(input.InstrumentId))
                ) && 
                (
                    this.SupportedModels == input.SupportedModels ||
                    this.SupportedModels != null &&
                    input.SupportedModels != null &&
                    this.SupportedModels.SequenceEqual(input.SupportedModels)
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
                if (this.InstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentId.GetHashCode();
                }
                if (this.SupportedModels != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedModels.GetHashCode();
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
