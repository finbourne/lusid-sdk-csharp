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
    /// UpdateFeeTypeRequest
    /// </summary>
    [DataContract(Name = "UpdateFeeTypeRequest")]
    public partial class UpdateFeeTypeRequest : IEquatable<UpdateFeeTypeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFeeTypeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateFeeTypeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFeeTypeRequest" /> class.
        /// </summary>
        /// <param name="displayName">The name of the fee type. (required).</param>
        /// <param name="description">The description of the fee type..</param>
        /// <param name="componentTransactions">A set of component transactions that relate to the fee type to be created. (required).</param>
        public UpdateFeeTypeRequest(string displayName = default(string), string description = default(string), List<ComponentTransaction> componentTransactions = default(List<ComponentTransaction>))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for UpdateFeeTypeRequest and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "componentTransactions" is required (not null)
            if (componentTransactions == null)
            {
                throw new ArgumentNullException("componentTransactions is a required property for UpdateFeeTypeRequest and cannot be null");
            }
            this.ComponentTransactions = componentTransactions;
            this.Description = description;
        }

        /// <summary>
        /// The name of the fee type.
        /// </summary>
        /// <value>The name of the fee type.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description of the fee type.
        /// </summary>
        /// <value>The description of the fee type.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// A set of component transactions that relate to the fee type to be created.
        /// </summary>
        /// <value>A set of component transactions that relate to the fee type to be created.</value>
        [DataMember(Name = "componentTransactions", IsRequired = true, EmitDefaultValue = true)]
        public List<ComponentTransaction> ComponentTransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateFeeTypeRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ComponentTransactions: ").Append(ComponentTransactions).Append("\n");
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
            return this.Equals(input as UpdateFeeTypeRequest);
        }

        /// <summary>
        /// Returns true if UpdateFeeTypeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateFeeTypeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateFeeTypeRequest input)
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
                    this.ComponentTransactions == input.ComponentTransactions ||
                    this.ComponentTransactions != null &&
                    input.ComponentTransactions != null &&
                    this.ComponentTransactions.SequenceEqual(input.ComponentTransactions)
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
                if (this.ComponentTransactions != null)
                {
                    hashCode = (hashCode * 59) + this.ComponentTransactions.GetHashCode();
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
            // DisplayName (string) maxLength
            if (this.DisplayName != null && this.DisplayName.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be less than 256.", new [] { "DisplayName" });
            }

            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
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
