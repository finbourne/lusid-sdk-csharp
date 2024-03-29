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
    /// The counterpartyAgreement is signed by two parties, one of which is implicitly the LUSID user.  The CounterpartySignatory represents the &#39;other side&#39; of the agreement.  It comprises a name and identifier for a Legal Entity in LUSID.
    /// </summary>
    [DataContract(Name = "CounterpartySignatory")]
    public partial class CounterpartySignatory : IEquatable<CounterpartySignatory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterpartySignatory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CounterpartySignatory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterpartySignatory" /> class.
        /// </summary>
        /// <param name="name">A user-defined name or label for the counterparty signatory.  There is no requirement for this to match the \&quot;displayName\&quot; of the legal entity. (required).</param>
        /// <param name="legalEntityIdentifier">legalEntityIdentifier (required).</param>
        public CounterpartySignatory(string name = default(string), TypedResourceId legalEntityIdentifier = default(TypedResourceId))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CounterpartySignatory and cannot be null");
            }
            this.Name = name;
            // to ensure "legalEntityIdentifier" is required (not null)
            if (legalEntityIdentifier == null)
            {
                throw new ArgumentNullException("legalEntityIdentifier is a required property for CounterpartySignatory and cannot be null");
            }
            this.LegalEntityIdentifier = legalEntityIdentifier;
        }

        /// <summary>
        /// A user-defined name or label for the counterparty signatory.  There is no requirement for this to match the \&quot;displayName\&quot; of the legal entity.
        /// </summary>
        /// <value>A user-defined name or label for the counterparty signatory.  There is no requirement for this to match the \&quot;displayName\&quot; of the legal entity.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LegalEntityIdentifier
        /// </summary>
        [DataMember(Name = "legalEntityIdentifier", IsRequired = true, EmitDefaultValue = true)]
        public TypedResourceId LegalEntityIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CounterpartySignatory {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LegalEntityIdentifier: ").Append(LegalEntityIdentifier).Append("\n");
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
            return this.Equals(input as CounterpartySignatory);
        }

        /// <summary>
        /// Returns true if CounterpartySignatory instances are equal
        /// </summary>
        /// <param name="input">Instance of CounterpartySignatory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CounterpartySignatory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LegalEntityIdentifier == input.LegalEntityIdentifier ||
                    (this.LegalEntityIdentifier != null &&
                    this.LegalEntityIdentifier.Equals(input.LegalEntityIdentifier))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.LegalEntityIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.LegalEntityIdentifier.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }
}
