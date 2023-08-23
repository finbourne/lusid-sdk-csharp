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
    /// UpdateCustomEntityDefinitionRequest
    /// </summary>
    [DataContract(Name = "UpdateCustomEntityDefinitionRequest")]
    public partial class UpdateCustomEntityDefinitionRequest : IEquatable<UpdateCustomEntityDefinitionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomEntityDefinitionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateCustomEntityDefinitionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomEntityDefinitionRequest" /> class.
        /// </summary>
        /// <param name="displayName">A display label for the custom entity type. (required).</param>
        /// <param name="description">A description for the custom entity type. (required).</param>
        /// <param name="fieldSchema">The description of the fields on the custom entity type. (required).</param>
        public UpdateCustomEntityDefinitionRequest(string displayName = default(string), string description = default(string), List<CustomEntityFieldDefinition> fieldSchema = default(List<CustomEntityFieldDefinition>))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for UpdateCustomEntityDefinitionRequest and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for UpdateCustomEntityDefinitionRequest and cannot be null");
            }
            this.Description = description;
            // to ensure "fieldSchema" is required (not null)
            if (fieldSchema == null)
            {
                throw new ArgumentNullException("fieldSchema is a required property for UpdateCustomEntityDefinitionRequest and cannot be null");
            }
            this.FieldSchema = fieldSchema;
        }

        /// <summary>
        /// A display label for the custom entity type.
        /// </summary>
        /// <value>A display label for the custom entity type.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A description for the custom entity type.
        /// </summary>
        /// <value>A description for the custom entity type.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The description of the fields on the custom entity type.
        /// </summary>
        /// <value>The description of the fields on the custom entity type.</value>
        [DataMember(Name = "fieldSchema", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomEntityFieldDefinition> FieldSchema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateCustomEntityDefinitionRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FieldSchema: ").Append(FieldSchema).Append("\n");
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
            return this.Equals(input as UpdateCustomEntityDefinitionRequest);
        }

        /// <summary>
        /// Returns true if UpdateCustomEntityDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCustomEntityDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCustomEntityDefinitionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FieldSchema == input.FieldSchema ||
                    this.FieldSchema != null &&
                    input.FieldSchema != null &&
                    this.FieldSchema.SequenceEqual(input.FieldSchema)
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
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FieldSchema != null)
                {
                    hashCode = (hashCode * 59) + this.FieldSchema.GetHashCode();
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
            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            // DisplayName (string) pattern
            Regex regexDisplayName = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexDisplayName.Match(this.DisplayName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, must match a pattern of " + regexDisplayName, new [] { "DisplayName" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            // Description (string) pattern
            Regex regexDescription = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexDescription.Match(this.Description).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, must match a pattern of " + regexDescription, new [] { "Description" });
            }

            yield break;
        }
    }
}
