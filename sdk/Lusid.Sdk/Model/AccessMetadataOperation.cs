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
    /// AccessMetadataOperation
    /// </summary>
    [DataContract(Name = "AccessMetadataOperation")]
    public partial class AccessMetadataOperation : IEquatable<AccessMetadataOperation>, IValidatableObject
    {
        /// <summary>
        /// The available values are: add, remove
        /// </summary>
        /// <value>The available values are: add, remove</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OpEnum
        {
            /// <summary>
            /// Enum Add for value: add
            /// </summary>
            [EnumMember(Value = "add")]
            Add = 1,

            /// <summary>
            /// Enum Remove for value: remove
            /// </summary>
            [EnumMember(Value = "remove")]
            Remove = 2
        }


        /// <summary>
        /// The available values are: add, remove
        /// </summary>
        /// <value>The available values are: add, remove</value>
        [DataMember(Name = "op", IsRequired = true, EmitDefaultValue = true)]
        public OpEnum Op { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessMetadataOperation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessMetadataOperation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessMetadataOperation" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="path">path (required).</param>
        /// <param name="op">The available values are: add, remove (required).</param>
        /// <param name="from">from.</param>
        public AccessMetadataOperation(List<AccessMetadataValue> value = default(List<AccessMetadataValue>), string path = default(string), OpEnum op = default(OpEnum), string from = default(string))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for AccessMetadataOperation and cannot be null");
            }
            this.Value = value;
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for AccessMetadataOperation and cannot be null");
            }
            this.Path = path;
            this.Op = op;
            this.From = from;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public List<AccessMetadataValue> Value { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessMetadataOperation {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
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
            return this.Equals(input as AccessMetadataOperation);
        }

        /// <summary>
        /// Returns true if AccessMetadataOperation instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessMetadataOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessMetadataOperation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Op == input.Op ||
                    this.Op.Equals(input.Op)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Op.GetHashCode();
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
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
            // Path (string) maxLength
            if (this.Path != null && this.Path.Length > 1025)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Path, length must be less than 1025.", new [] { "Path" });
            }

            // Path (string) minLength
            if (this.Path != null && this.Path.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Path, length must be greater than 1.", new [] { "Path" });
            }

            // Path (string) pattern
            Regex regexPath = new Regex(@"^/.+", RegexOptions.CultureInvariant);
            if (false == regexPath.Match(this.Path).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Path, must match a pattern of " + regexPath, new [] { "Path" });
            }

            yield break;
        }
    }
}
