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
    /// What is the provenance of an instrument. This defines who creates/owns it, what format it is in (e.g. a proprietary format or a common and known one)              and what the version of that is.
    /// </summary>
    [DataContract(Name = "InstrumentDefinitionFormat")]
    public partial class InstrumentDefinitionFormat : IEquatable<InstrumentDefinitionFormat>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentDefinitionFormat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstrumentDefinitionFormat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentDefinitionFormat" /> class.
        /// </summary>
        /// <param name="sourceSystem">which source system does the format originate from (required).</param>
        /// <param name="vendor">An instrument will potentially have been created by any number of different organisations. Some will be understood completely (e.g. LUSID&#39;s), some won&#39;t.              The provenance of an instrument indicates who \&quot;owns\&quot; the associated format. (required).</param>
        /// <param name="version">Version of the document. Would be preferable to avoid the need, but LUSID will not control other organisations&#39; trade formats. (required).</param>
        public InstrumentDefinitionFormat(string sourceSystem = default(string), string vendor = default(string), string version = default(string))
        {
            // to ensure "sourceSystem" is required (not null)
            if (sourceSystem == null)
            {
                throw new ArgumentNullException("sourceSystem is a required property for InstrumentDefinitionFormat and cannot be null");
            }
            this.SourceSystem = sourceSystem;
            // to ensure "vendor" is required (not null)
            if (vendor == null)
            {
                throw new ArgumentNullException("vendor is a required property for InstrumentDefinitionFormat and cannot be null");
            }
            this.Vendor = vendor;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new ArgumentNullException("version is a required property for InstrumentDefinitionFormat and cannot be null");
            }
            this._Version = version;
        }

        /// <summary>
        /// which source system does the format originate from
        /// </summary>
        /// <value>which source system does the format originate from</value>
        [DataMember(Name = "sourceSystem", IsRequired = true, EmitDefaultValue = true)]
        public string SourceSystem { get; set; }

        /// <summary>
        /// An instrument will potentially have been created by any number of different organisations. Some will be understood completely (e.g. LUSID&#39;s), some won&#39;t.              The provenance of an instrument indicates who \&quot;owns\&quot; the associated format.
        /// </summary>
        /// <value>An instrument will potentially have been created by any number of different organisations. Some will be understood completely (e.g. LUSID&#39;s), some won&#39;t.              The provenance of an instrument indicates who \&quot;owns\&quot; the associated format.</value>
        [DataMember(Name = "vendor", IsRequired = true, EmitDefaultValue = true)]
        public string Vendor { get; set; }

        /// <summary>
        /// Version of the document. Would be preferable to avoid the need, but LUSID will not control other organisations&#39; trade formats.
        /// </summary>
        /// <value>Version of the document. Would be preferable to avoid the need, but LUSID will not control other organisations&#39; trade formats.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstrumentDefinitionFormat {\n");
            sb.Append("  SourceSystem: ").Append(SourceSystem).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as InstrumentDefinitionFormat);
        }

        /// <summary>
        /// Returns true if InstrumentDefinitionFormat instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentDefinitionFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentDefinitionFormat input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SourceSystem == input.SourceSystem ||
                    (this.SourceSystem != null &&
                    this.SourceSystem.Equals(input.SourceSystem))
                ) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.SourceSystem != null)
                {
                    hashCode = (hashCode * 59) + this.SourceSystem.GetHashCode();
                }
                if (this.Vendor != null)
                {
                    hashCode = (hashCode * 59) + this.Vendor.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
            // SourceSystem (string) minLength
            if (this.SourceSystem != null && this.SourceSystem.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceSystem, length must be greater than 1.", new [] { "SourceSystem" });
            }

            // Vendor (string) minLength
            if (this.Vendor != null && this.Vendor.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Vendor, length must be greater than 1.", new [] { "Vendor" });
            }

            // _Version (string) minLength
            if (this._Version != null && this._Version.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Version, length must be greater than 1.", new [] { "_Version" });
            }

            yield break;
        }
    }
}
