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
    /// A single transition component request, when grouped with other transition component requests a corporate action  transition request is formed.
    /// </summary>
    [DataContract(Name = "CorporateActionTransitionComponentRequest")]
    public partial class CorporateActionTransitionComponentRequest : IEquatable<CorporateActionTransitionComponentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateActionTransitionComponentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CorporateActionTransitionComponentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateActionTransitionComponentRequest" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">Unique instrument identifiers (required).</param>
        /// <param name="unitsFactor">The factor to scale units by (required).</param>
        /// <param name="costFactor">The factor to scale cost by (required).</param>
        public CorporateActionTransitionComponentRequest(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), decimal unitsFactor = default(decimal), decimal costFactor = default(decimal))
        {
            // to ensure "instrumentIdentifiers" is required (not null)
            if (instrumentIdentifiers == null)
            {
                throw new ArgumentNullException("instrumentIdentifiers is a required property for CorporateActionTransitionComponentRequest and cannot be null");
            }
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.UnitsFactor = unitsFactor;
            this.CostFactor = costFactor;
        }

        /// <summary>
        /// Unique instrument identifiers
        /// </summary>
        /// <value>Unique instrument identifiers</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The factor to scale units by
        /// </summary>
        /// <value>The factor to scale units by</value>
        [DataMember(Name = "unitsFactor", IsRequired = true, EmitDefaultValue = true)]
        public decimal UnitsFactor { get; set; }

        /// <summary>
        /// The factor to scale cost by
        /// </summary>
        /// <value>The factor to scale cost by</value>
        [DataMember(Name = "costFactor", IsRequired = true, EmitDefaultValue = true)]
        public decimal CostFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CorporateActionTransitionComponentRequest {\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  UnitsFactor: ").Append(UnitsFactor).Append("\n");
            sb.Append("  CostFactor: ").Append(CostFactor).Append("\n");
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
            return this.Equals(input as CorporateActionTransitionComponentRequest);
        }

        /// <summary>
        /// Returns true if CorporateActionTransitionComponentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CorporateActionTransitionComponentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorporateActionTransitionComponentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.UnitsFactor == input.UnitsFactor ||
                    this.UnitsFactor.Equals(input.UnitsFactor)
                ) && 
                (
                    this.CostFactor == input.CostFactor ||
                    this.CostFactor.Equals(input.CostFactor)
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
                if (this.InstrumentIdentifiers != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentIdentifiers.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnitsFactor.GetHashCode();
                hashCode = (hashCode * 59) + this.CostFactor.GetHashCode();
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
