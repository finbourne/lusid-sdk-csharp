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
    /// UpdateReferenceDataRequest
    /// </summary>
    [DataContract(Name = "UpdateReferenceDataRequest")]
    public partial class UpdateReferenceDataRequest : IEquatable<UpdateReferenceDataRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReferenceDataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateReferenceDataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReferenceDataRequest" /> class.
        /// </summary>
        /// <param name="requestDefinitions">Definition of a reference data field. (required).</param>
        /// <param name="requestValues">Reference data. (required).</param>
        public UpdateReferenceDataRequest(List<FieldDefinition> requestDefinitions = default(List<FieldDefinition>), List<FieldValue> requestValues = default(List<FieldValue>))
        {
            // to ensure "requestDefinitions" is required (not null)
            if (requestDefinitions == null)
            {
                throw new ArgumentNullException("requestDefinitions is a required property for UpdateReferenceDataRequest and cannot be null");
            }
            this.RequestDefinitions = requestDefinitions;
            // to ensure "requestValues" is required (not null)
            if (requestValues == null)
            {
                throw new ArgumentNullException("requestValues is a required property for UpdateReferenceDataRequest and cannot be null");
            }
            this.RequestValues = requestValues;
        }

        /// <summary>
        /// Definition of a reference data field.
        /// </summary>
        /// <value>Definition of a reference data field.</value>
        [DataMember(Name = "requestDefinitions", IsRequired = true, EmitDefaultValue = true)]
        public List<FieldDefinition> RequestDefinitions { get; set; }

        /// <summary>
        /// Reference data.
        /// </summary>
        /// <value>Reference data.</value>
        [DataMember(Name = "requestValues", IsRequired = true, EmitDefaultValue = true)]
        public List<FieldValue> RequestValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateReferenceDataRequest {\n");
            sb.Append("  RequestDefinitions: ").Append(RequestDefinitions).Append("\n");
            sb.Append("  RequestValues: ").Append(RequestValues).Append("\n");
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
            return this.Equals(input as UpdateReferenceDataRequest);
        }

        /// <summary>
        /// Returns true if UpdateReferenceDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateReferenceDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateReferenceDataRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestDefinitions == input.RequestDefinitions ||
                    this.RequestDefinitions != null &&
                    input.RequestDefinitions != null &&
                    this.RequestDefinitions.SequenceEqual(input.RequestDefinitions)
                ) && 
                (
                    this.RequestValues == input.RequestValues ||
                    this.RequestValues != null &&
                    input.RequestValues != null &&
                    this.RequestValues.SequenceEqual(input.RequestValues)
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
                if (this.RequestDefinitions != null)
                {
                    hashCode = (hashCode * 59) + this.RequestDefinitions.GetHashCode();
                }
                if (this.RequestValues != null)
                {
                    hashCode = (hashCode * 59) + this.RequestValues.GetHashCode();
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
