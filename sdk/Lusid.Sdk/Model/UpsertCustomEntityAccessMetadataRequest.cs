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
    /// UpsertCustomEntityAccessMetadataRequest
    /// </summary>
    [DataContract(Name = "UpsertCustomEntityAccessMetadataRequest")]
    public partial class UpsertCustomEntityAccessMetadataRequest : IEquatable<UpsertCustomEntityAccessMetadataRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertCustomEntityAccessMetadataRequest" /> class.
        /// </summary>
        /// <param name="metadata">The access control metadata to assign to a CustomEntity that matches the identifier.</param>
        public UpsertCustomEntityAccessMetadataRequest(List<AccessMetadataValue> metadata = default(List<AccessMetadataValue>))
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// The access control metadata to assign to a CustomEntity that matches the identifier
        /// </summary>
        /// <value>The access control metadata to assign to a CustomEntity that matches the identifier</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public List<AccessMetadataValue> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpsertCustomEntityAccessMetadataRequest {\n");
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
            return this.Equals(input as UpsertCustomEntityAccessMetadataRequest);
        }

        /// <summary>
        /// Returns true if UpsertCustomEntityAccessMetadataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertCustomEntityAccessMetadataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertCustomEntityAccessMetadataRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
