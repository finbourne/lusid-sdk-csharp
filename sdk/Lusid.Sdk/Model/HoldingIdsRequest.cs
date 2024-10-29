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
    /// HoldingIdsRequest
    /// </summary>
    [DataContract(Name = "HoldingIdsRequest")]
    public partial class HoldingIdsRequest : IEquatable<HoldingIdsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingIdsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HoldingIdsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingIdsRequest" /> class.
        /// </summary>
        /// <param name="holdingIds">The array of unique holding identifiers (required).</param>
        public HoldingIdsRequest(List<long> holdingIds = default(List<long>))
        {
            // to ensure "holdingIds" is required (not null)
            if (holdingIds == null)
            {
                throw new ArgumentNullException("holdingIds is a required property for HoldingIdsRequest and cannot be null");
            }
            this.HoldingIds = holdingIds;
        }

        /// <summary>
        /// The array of unique holding identifiers
        /// </summary>
        /// <value>The array of unique holding identifiers</value>
        [DataMember(Name = "holdingIds", IsRequired = true, EmitDefaultValue = true)]
        public List<long> HoldingIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HoldingIdsRequest {\n");
            sb.Append("  HoldingIds: ").Append(HoldingIds).Append("\n");
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
            return this.Equals(input as HoldingIdsRequest);
        }

        /// <summary>
        /// Returns true if HoldingIdsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HoldingIdsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HoldingIdsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HoldingIds == input.HoldingIds ||
                    this.HoldingIds != null &&
                    input.HoldingIds != null &&
                    this.HoldingIds.SequenceEqual(input.HoldingIds)
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
                if (this.HoldingIds != null)
                {
                    hashCode = (hashCode * 59) + this.HoldingIds.GetHashCode();
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