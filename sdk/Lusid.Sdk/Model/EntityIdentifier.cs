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
    /// Dto to expose mapped keys to new standardised format
    /// </summary>
    [DataContract(Name = "EntityIdentifier")]
    public partial class EntityIdentifier : IEquatable<EntityIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntityIdentifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityIdentifier" /> class.
        /// </summary>
        /// <param name="identifierScope">The scope of the identifier.</param>
        /// <param name="identifierType">The type of the identifier (required).</param>
        /// <param name="identifierValue">The value of the identifier (required).</param>
        public EntityIdentifier(string identifierScope = default(string), string identifierType = default(string), string identifierValue = default(string))
        {
            // to ensure "identifierType" is required (not null)
            if (identifierType == null)
            {
                throw new ArgumentNullException("identifierType is a required property for EntityIdentifier and cannot be null");
            }
            this.IdentifierType = identifierType;
            // to ensure "identifierValue" is required (not null)
            if (identifierValue == null)
            {
                throw new ArgumentNullException("identifierValue is a required property for EntityIdentifier and cannot be null");
            }
            this.IdentifierValue = identifierValue;
            this.IdentifierScope = identifierScope;
        }

        /// <summary>
        /// The scope of the identifier
        /// </summary>
        /// <value>The scope of the identifier</value>
        [DataMember(Name = "identifierScope", EmitDefaultValue = true)]
        public string IdentifierScope { get; set; }

        /// <summary>
        /// The type of the identifier
        /// </summary>
        /// <value>The type of the identifier</value>
        [DataMember(Name = "identifierType", IsRequired = true, EmitDefaultValue = true)]
        public string IdentifierType { get; set; }

        /// <summary>
        /// The value of the identifier
        /// </summary>
        /// <value>The value of the identifier</value>
        [DataMember(Name = "identifierValue", IsRequired = true, EmitDefaultValue = true)]
        public string IdentifierValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntityIdentifier {\n");
            sb.Append("  IdentifierScope: ").Append(IdentifierScope).Append("\n");
            sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
            sb.Append("  IdentifierValue: ").Append(IdentifierValue).Append("\n");
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
            return this.Equals(input as EntityIdentifier);
        }

        /// <summary>
        /// Returns true if EntityIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of EntityIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntityIdentifier input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IdentifierScope == input.IdentifierScope ||
                    (this.IdentifierScope != null &&
                    this.IdentifierScope.Equals(input.IdentifierScope))
                ) && 
                (
                    this.IdentifierType == input.IdentifierType ||
                    (this.IdentifierType != null &&
                    this.IdentifierType.Equals(input.IdentifierType))
                ) && 
                (
                    this.IdentifierValue == input.IdentifierValue ||
                    (this.IdentifierValue != null &&
                    this.IdentifierValue.Equals(input.IdentifierValue))
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
                if (this.IdentifierScope != null)
                {
                    hashCode = (hashCode * 59) + this.IdentifierScope.GetHashCode();
                }
                if (this.IdentifierType != null)
                {
                    hashCode = (hashCode * 59) + this.IdentifierType.GetHashCode();
                }
                if (this.IdentifierValue != null)
                {
                    hashCode = (hashCode * 59) + this.IdentifierValue.GetHashCode();
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
