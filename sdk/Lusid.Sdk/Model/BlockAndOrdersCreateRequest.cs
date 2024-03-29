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
    /// BlockAndOrdersCreateRequest
    /// </summary>
    [DataContract(Name = "BlockAndOrdersCreateRequest")]
    public partial class BlockAndOrdersCreateRequest : IEquatable<BlockAndOrdersCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockAndOrdersCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BlockAndOrdersCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockAndOrdersCreateRequest" /> class.
        /// </summary>
        /// <param name="requests">A collection of BlockAndOrdersRequest. (required).</param>
        public BlockAndOrdersCreateRequest(List<BlockAndOrdersRequest> requests = default(List<BlockAndOrdersRequest>))
        {
            // to ensure "requests" is required (not null)
            if (requests == null)
            {
                throw new ArgumentNullException("requests is a required property for BlockAndOrdersCreateRequest and cannot be null");
            }
            this.Requests = requests;
        }

        /// <summary>
        /// A collection of BlockAndOrdersRequest.
        /// </summary>
        /// <value>A collection of BlockAndOrdersRequest.</value>
        [DataMember(Name = "requests", IsRequired = true, EmitDefaultValue = true)]
        public List<BlockAndOrdersRequest> Requests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BlockAndOrdersCreateRequest {\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
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
            return this.Equals(input as BlockAndOrdersCreateRequest);
        }

        /// <summary>
        /// Returns true if BlockAndOrdersCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockAndOrdersCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockAndOrdersCreateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Requests == input.Requests ||
                    this.Requests != null &&
                    input.Requests != null &&
                    this.Requests.SequenceEqual(input.Requests)
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
                if (this.Requests != null)
                {
                    hashCode = (hashCode * 59) + this.Requests.GetHashCode();
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
