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
    /// BreakCodeSource
    /// </summary>
    [DataContract(Name = "BreakCodeSource")]
    public partial class BreakCodeSource : IEquatable<BreakCodeSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreakCodeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BreakCodeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BreakCodeSource" /> class.
        /// </summary>
        /// <param name="dataTypeId">dataTypeId (required).</param>
        public BreakCodeSource(ResourceId dataTypeId = default(ResourceId))
        {
            // to ensure "dataTypeId" is required (not null)
            if (dataTypeId == null)
            {
                throw new ArgumentNullException("dataTypeId is a required property for BreakCodeSource and cannot be null");
            }
            this.DataTypeId = dataTypeId;
        }

        /// <summary>
        /// Gets or Sets DataTypeId
        /// </summary>
        [DataMember(Name = "dataTypeId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId DataTypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BreakCodeSource {\n");
            sb.Append("  DataTypeId: ").Append(DataTypeId).Append("\n");
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
            return this.Equals(input as BreakCodeSource);
        }

        /// <summary>
        /// Returns true if BreakCodeSource instances are equal
        /// </summary>
        /// <param name="input">Instance of BreakCodeSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreakCodeSource input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataTypeId == input.DataTypeId ||
                    (this.DataTypeId != null &&
                    this.DataTypeId.Equals(input.DataTypeId))
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
                if (this.DataTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.DataTypeId.GetHashCode();
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
