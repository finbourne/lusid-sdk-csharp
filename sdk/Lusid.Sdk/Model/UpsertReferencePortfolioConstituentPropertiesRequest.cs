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
    /// UpsertReferencePortfolioConstituentPropertiesRequest
    /// </summary>
    [DataContract(Name = "UpsertReferencePortfolioConstituentPropertiesRequest")]
    public partial class UpsertReferencePortfolioConstituentPropertiesRequest : IEquatable<UpsertReferencePortfolioConstituentPropertiesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertReferencePortfolioConstituentPropertiesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertReferencePortfolioConstituentPropertiesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertReferencePortfolioConstituentPropertiesRequest" /> class.
        /// </summary>
        /// <param name="identifiers">A set of instrument identifiers that can resolve the constituent to a unique instrument. (required).</param>
        /// <param name="properties">The updated collection of properties of the constituent. (required).</param>
        public UpsertReferencePortfolioConstituentPropertiesRequest(Dictionary<string, string> identifiers = default(Dictionary<string, string>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>))
        {
            // to ensure "identifiers" is required (not null)
            if (identifiers == null)
            {
                throw new ArgumentNullException("identifiers is a required property for UpsertReferencePortfolioConstituentPropertiesRequest and cannot be null");
            }
            this.Identifiers = identifiers;
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new ArgumentNullException("properties is a required property for UpsertReferencePortfolioConstituentPropertiesRequest and cannot be null");
            }
            this.Properties = properties;
        }

        /// <summary>
        /// A set of instrument identifiers that can resolve the constituent to a unique instrument.
        /// </summary>
        /// <value>A set of instrument identifiers that can resolve the constituent to a unique instrument.</value>
        [DataMember(Name = "identifiers", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Identifiers { get; set; }

        /// <summary>
        /// The updated collection of properties of the constituent.
        /// </summary>
        /// <value>The updated collection of properties of the constituent.</value>
        [DataMember(Name = "properties", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpsertReferencePortfolioConstituentPropertiesRequest {\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as UpsertReferencePortfolioConstituentPropertiesRequest);
        }

        /// <summary>
        /// Returns true if UpsertReferencePortfolioConstituentPropertiesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertReferencePortfolioConstituentPropertiesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertReferencePortfolioConstituentPropertiesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.Identifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Identifiers.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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