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
    /// Class that models a set of instruments of which each has some quantity and can be identified by a unique label.
    /// </summary>
    [DataContract(Name = "WeightedInstruments")]
    public partial class WeightedInstruments : IEquatable<WeightedInstruments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeightedInstruments" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WeightedInstruments() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WeightedInstruments" /> class.
        /// </summary>
        /// <param name="instruments">The instruments that are held in the set. (required).</param>
        public WeightedInstruments(List<WeightedInstrument> instruments = default(List<WeightedInstrument>))
        {
            // to ensure "instruments" is required (not null)
            if (instruments == null)
            {
                throw new ArgumentNullException("instruments is a required property for WeightedInstruments and cannot be null");
            }
            this.Instruments = instruments;
        }

        /// <summary>
        /// The instruments that are held in the set.
        /// </summary>
        /// <value>The instruments that are held in the set.</value>
        [DataMember(Name = "instruments", IsRequired = true, EmitDefaultValue = true)]
        public List<WeightedInstrument> Instruments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WeightedInstruments {\n");
            sb.Append("  Instruments: ").Append(Instruments).Append("\n");
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
            return this.Equals(input as WeightedInstruments);
        }

        /// <summary>
        /// Returns true if WeightedInstruments instances are equal
        /// </summary>
        /// <param name="input">Instance of WeightedInstruments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeightedInstruments input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Instruments == input.Instruments ||
                    this.Instruments != null &&
                    input.Instruments != null &&
                    this.Instruments.SequenceEqual(input.Instruments)
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
                if (this.Instruments != null)
                {
                    hashCode = (hashCode * 59) + this.Instruments.GetHashCode();
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
