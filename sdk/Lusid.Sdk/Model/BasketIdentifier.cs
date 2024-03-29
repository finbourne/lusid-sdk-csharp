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
    /// Descriptive information that describes a particular basket of instruments. Most commonly required with a CDS Index or similarly defined instrument.
    /// </summary>
    [DataContract(Name = "BasketIdentifier")]
    public partial class BasketIdentifier : IEquatable<BasketIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasketIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BasketIdentifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BasketIdentifier" /> class.
        /// </summary>
        /// <param name="index">Index set, e.g. iTraxx or CDX. (required).</param>
        /// <param name="name">The index name within the set, e.g. \&quot;MAIN\&quot; or \&quot;Crossover\&quot;. (required).</param>
        /// <param name="region">Applicable geographic country or region. Typically something like \&quot;Europe\&quot;, \&quot;Asia ex-Japan\&quot;, \&quot;Japan\&quot; or \&quot;Australia\&quot;. (required).</param>
        /// <param name="seriesId">The series identifier. (required).</param>
        public BasketIdentifier(string index = default(string), string name = default(string), string region = default(string), int seriesId = default(int))
        {
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new ArgumentNullException("index is a required property for BasketIdentifier and cannot be null");
            }
            this.Index = index;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for BasketIdentifier and cannot be null");
            }
            this.Name = name;
            // to ensure "region" is required (not null)
            if (region == null)
            {
                throw new ArgumentNullException("region is a required property for BasketIdentifier and cannot be null");
            }
            this.Region = region;
            this.SeriesId = seriesId;
        }

        /// <summary>
        /// Index set, e.g. iTraxx or CDX.
        /// </summary>
        /// <value>Index set, e.g. iTraxx or CDX.</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public string Index { get; set; }

        /// <summary>
        /// The index name within the set, e.g. \&quot;MAIN\&quot; or \&quot;Crossover\&quot;.
        /// </summary>
        /// <value>The index name within the set, e.g. \&quot;MAIN\&quot; or \&quot;Crossover\&quot;.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Applicable geographic country or region. Typically something like \&quot;Europe\&quot;, \&quot;Asia ex-Japan\&quot;, \&quot;Japan\&quot; or \&quot;Australia\&quot;.
        /// </summary>
        /// <value>Applicable geographic country or region. Typically something like \&quot;Europe\&quot;, \&quot;Asia ex-Japan\&quot;, \&quot;Japan\&quot; or \&quot;Australia\&quot;.</value>
        [DataMember(Name = "region", IsRequired = true, EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// The series identifier.
        /// </summary>
        /// <value>The series identifier.</value>
        [DataMember(Name = "seriesId", IsRequired = true, EmitDefaultValue = true)]
        public int SeriesId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BasketIdentifier {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SeriesId: ").Append(SeriesId).Append("\n");
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
            return this.Equals(input as BasketIdentifier);
        }

        /// <summary>
        /// Returns true if BasketIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of BasketIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasketIdentifier input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SeriesId == input.SeriesId ||
                    this.SeriesId.Equals(input.SeriesId)
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
                if (this.Index != null)
                {
                    hashCode = (hashCode * 59) + this.Index.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SeriesId.GetHashCode();
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
