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
    /// Object describing a particular industry classifier,  which comprises a classification code and the name of the classification system to which the code belongs.
    /// </summary>
    [DataContract(Name = "IndustryClassifier")]
    public partial class IndustryClassifier : IEquatable<IndustryClassifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryClassifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IndustryClassifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryClassifier" /> class.
        /// </summary>
        /// <param name="classificationSystemName">The name of the classification system to which the classification code belongs (e.g. GICS). (required).</param>
        /// <param name="classificationCode">The specific industry classification code assigned to the legal entity. (required).</param>
        public IndustryClassifier(string classificationSystemName = default(string), string classificationCode = default(string))
        {
            // to ensure "classificationSystemName" is required (not null)
            if (classificationSystemName == null)
            {
                throw new ArgumentNullException("classificationSystemName is a required property for IndustryClassifier and cannot be null");
            }
            this.ClassificationSystemName = classificationSystemName;
            // to ensure "classificationCode" is required (not null)
            if (classificationCode == null)
            {
                throw new ArgumentNullException("classificationCode is a required property for IndustryClassifier and cannot be null");
            }
            this.ClassificationCode = classificationCode;
        }

        /// <summary>
        /// The name of the classification system to which the classification code belongs (e.g. GICS).
        /// </summary>
        /// <value>The name of the classification system to which the classification code belongs (e.g. GICS).</value>
        [DataMember(Name = "classificationSystemName", IsRequired = true, EmitDefaultValue = true)]
        public string ClassificationSystemName { get; set; }

        /// <summary>
        /// The specific industry classification code assigned to the legal entity.
        /// </summary>
        /// <value>The specific industry classification code assigned to the legal entity.</value>
        [DataMember(Name = "classificationCode", IsRequired = true, EmitDefaultValue = true)]
        public string ClassificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndustryClassifier {\n");
            sb.Append("  ClassificationSystemName: ").Append(ClassificationSystemName).Append("\n");
            sb.Append("  ClassificationCode: ").Append(ClassificationCode).Append("\n");
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
            return this.Equals(input as IndustryClassifier);
        }

        /// <summary>
        /// Returns true if IndustryClassifier instances are equal
        /// </summary>
        /// <param name="input">Instance of IndustryClassifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndustryClassifier input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClassificationSystemName == input.ClassificationSystemName ||
                    (this.ClassificationSystemName != null &&
                    this.ClassificationSystemName.Equals(input.ClassificationSystemName))
                ) && 
                (
                    this.ClassificationCode == input.ClassificationCode ||
                    (this.ClassificationCode != null &&
                    this.ClassificationCode.Equals(input.ClassificationCode))
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
                if (this.ClassificationSystemName != null)
                {
                    hashCode = (hashCode * 59) + this.ClassificationSystemName.GetHashCode();
                }
                if (this.ClassificationCode != null)
                {
                    hashCode = (hashCode * 59) + this.ClassificationCode.GetHashCode();
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
            // ClassificationSystemName (string) minLength
            if (this.ClassificationSystemName != null && this.ClassificationSystemName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassificationSystemName, length must be greater than 1.", new [] { "ClassificationSystemName" });
            }

            // ClassificationCode (string) maxLength
            if (this.ClassificationCode != null && this.ClassificationCode.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassificationCode, length must be less than 64.", new [] { "ClassificationCode" });
            }

            // ClassificationCode (string) minLength
            if (this.ClassificationCode != null && this.ClassificationCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassificationCode, length must be greater than 1.", new [] { "ClassificationCode" });
            }

            // ClassificationCode (string) pattern
            Regex regexClassificationCode = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexClassificationCode.Match(this.ClassificationCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassificationCode, must match a pattern of " + regexClassificationCode, new [] { "ClassificationCode" });
            }

            yield break;
        }
    }
}
