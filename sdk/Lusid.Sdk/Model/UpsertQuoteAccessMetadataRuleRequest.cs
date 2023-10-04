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
    /// UpsertQuoteAccessMetadataRuleRequest
    /// </summary>
    [DataContract(Name = "UpsertQuoteAccessMetadataRuleRequest")]
    public partial class UpsertQuoteAccessMetadataRuleRequest : IEquatable<UpsertQuoteAccessMetadataRuleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertQuoteAccessMetadataRuleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertQuoteAccessMetadataRuleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertQuoteAccessMetadataRuleRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="metadata">The access control metadata to assign to quotes that match the identifier (required).</param>
        public UpsertQuoteAccessMetadataRuleRequest(QuoteAccessMetadataRuleId id = default(QuoteAccessMetadataRuleId), Dictionary<string, List<AccessMetadataValue>> metadata = default(Dictionary<string, List<AccessMetadataValue>>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for UpsertQuoteAccessMetadataRuleRequest and cannot be null");
            }
            this.Id = id;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for UpsertQuoteAccessMetadataRuleRequest and cannot be null");
            }
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public QuoteAccessMetadataRuleId Id { get; set; }

        /// <summary>
        /// The access control metadata to assign to quotes that match the identifier
        /// </summary>
        /// <value>The access control metadata to assign to quotes that match the identifier</value>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, List<AccessMetadataValue>> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpsertQuoteAccessMetadataRuleRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as UpsertQuoteAccessMetadataRuleRequest);
        }

        /// <summary>
        /// Returns true if UpsertQuoteAccessMetadataRuleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertQuoteAccessMetadataRuleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertQuoteAccessMetadataRuleRequest input)
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
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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