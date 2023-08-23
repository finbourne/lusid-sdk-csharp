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
    /// UpdateDerivedPropertyDefinitionRequest
    /// </summary>
    [DataContract(Name = "UpdateDerivedPropertyDefinitionRequest")]
    public partial class UpdateDerivedPropertyDefinitionRequest : IEquatable<UpdateDerivedPropertyDefinitionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDerivedPropertyDefinitionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateDerivedPropertyDefinitionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDerivedPropertyDefinitionRequest" /> class.
        /// </summary>
        /// <param name="displayName">The display name of the property. (required).</param>
        /// <param name="dataTypeId">dataTypeId (required).</param>
        /// <param name="propertyDescription">Describes the property.</param>
        /// <param name="derivationFormula">The rule that defines how data is composed for a derived property. (required).</param>
        public UpdateDerivedPropertyDefinitionRequest(string displayName = default(string), ResourceId dataTypeId = default(ResourceId), string propertyDescription = default(string), string derivationFormula = default(string))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for UpdateDerivedPropertyDefinitionRequest and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "dataTypeId" is required (not null)
            if (dataTypeId == null)
            {
                throw new ArgumentNullException("dataTypeId is a required property for UpdateDerivedPropertyDefinitionRequest and cannot be null");
            }
            this.DataTypeId = dataTypeId;
            // to ensure "derivationFormula" is required (not null)
            if (derivationFormula == null)
            {
                throw new ArgumentNullException("derivationFormula is a required property for UpdateDerivedPropertyDefinitionRequest and cannot be null");
            }
            this.DerivationFormula = derivationFormula;
            this.PropertyDescription = propertyDescription;
        }

        /// <summary>
        /// The display name of the property.
        /// </summary>
        /// <value>The display name of the property.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DataTypeId
        /// </summary>
        [DataMember(Name = "dataTypeId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId DataTypeId { get; set; }

        /// <summary>
        /// Describes the property
        /// </summary>
        /// <value>Describes the property</value>
        [DataMember(Name = "propertyDescription", EmitDefaultValue = true)]
        public string PropertyDescription { get; set; }

        /// <summary>
        /// The rule that defines how data is composed for a derived property.
        /// </summary>
        /// <value>The rule that defines how data is composed for a derived property.</value>
        [DataMember(Name = "derivationFormula", IsRequired = true, EmitDefaultValue = true)]
        public string DerivationFormula { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateDerivedPropertyDefinitionRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DataTypeId: ").Append(DataTypeId).Append("\n");
            sb.Append("  PropertyDescription: ").Append(PropertyDescription).Append("\n");
            sb.Append("  DerivationFormula: ").Append(DerivationFormula).Append("\n");
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
            return this.Equals(input as UpdateDerivedPropertyDefinitionRequest);
        }

        /// <summary>
        /// Returns true if UpdateDerivedPropertyDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateDerivedPropertyDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDerivedPropertyDefinitionRequest input)
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
                    this.DataTypeId == input.DataTypeId ||
                    (this.DataTypeId != null &&
                    this.DataTypeId.Equals(input.DataTypeId))
                ) && 
                (
                    this.PropertyDescription == input.PropertyDescription ||
                    (this.PropertyDescription != null &&
                    this.PropertyDescription.Equals(input.PropertyDescription))
                ) && 
                (
                    this.DerivationFormula == input.DerivationFormula ||
                    (this.DerivationFormula != null &&
                    this.DerivationFormula.Equals(input.DerivationFormula))
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
                if (this.DataTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.DataTypeId.GetHashCode();
                }
                if (this.PropertyDescription != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyDescription.GetHashCode();
                }
                if (this.DerivationFormula != null)
                {
                    hashCode = (hashCode * 59) + this.DerivationFormula.GetHashCode();
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

            // PropertyDescription (string) maxLength
            if (this.PropertyDescription != null && this.PropertyDescription.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PropertyDescription, length must be less than 512.", new [] { "PropertyDescription" });
            }

            // DerivationFormula (string) minLength
            if (this.DerivationFormula != null && this.DerivationFormula.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DerivationFormula, length must be greater than 1.", new [] { "DerivationFormula" });
            }

            yield break;
        }
    }
}
