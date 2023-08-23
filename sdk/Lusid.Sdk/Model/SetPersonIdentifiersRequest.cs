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
    /// SetPersonIdentifiersRequest
    /// </summary>
    [DataContract(Name = "SetPersonIdentifiersRequest")]
    public partial class SetPersonIdentifiersRequest : IEquatable<SetPersonIdentifiersRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPersonIdentifiersRequest" /> class.
        /// </summary>
        /// <param name="identifiers">Identifiers to set for a Person. Identifiers not included in the request will not be amended..</param>
        public SetPersonIdentifiersRequest(Dictionary<string, Property> identifiers = default(Dictionary<string, Property>))
        {
            this.Identifiers = identifiers;
        }

        /// <summary>
        /// Identifiers to set for a Person. Identifiers not included in the request will not be amended.
        /// </summary>
        /// <value>Identifiers to set for a Person. Identifiers not included in the request will not be amended.</value>
        [DataMember(Name = "identifiers", EmitDefaultValue = true)]
        public Dictionary<string, Property> Identifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetPersonIdentifiersRequest {\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
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
            return this.Equals(input as SetPersonIdentifiersRequest);
        }

        /// <summary>
        /// Returns true if SetPersonIdentifiersRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetPersonIdentifiersRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetPersonIdentifiersRequest input)
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
