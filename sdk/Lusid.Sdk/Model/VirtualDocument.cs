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
    /// Virtual document consists of (potentially several) upserted documents.                The documents get parsed according to the provided data map on upsert, the collection of resulting values in  aggregated in a virtual document
    /// </summary>
    [DataContract(Name = "VirtualDocument")]
    public partial class VirtualDocument : IEquatable<VirtualDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualDocument" /> class.
        /// </summary>
        /// <param name="documentId">documentId.</param>
        /// <param name="data">The data inside the document.</param>
        public VirtualDocument(StructuredResultDataId documentId = default(StructuredResultDataId), List<VirtualDocumentRow> data = default(List<VirtualDocumentRow>))
        {
            this.DocumentId = documentId;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [DataMember(Name = "documentId", EmitDefaultValue = false)]
        public StructuredResultDataId DocumentId { get; set; }

        /// <summary>
        /// The data inside the document
        /// </summary>
        /// <value>The data inside the document</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<VirtualDocumentRow> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VirtualDocument {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as VirtualDocument);
        }

        /// <summary>
        /// Returns true if VirtualDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualDocument input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.DocumentId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentId.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
