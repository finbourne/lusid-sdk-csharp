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
    /// TaxRule
    /// </summary>
    [DataContract(Name = "TaxRule")]
    public partial class TaxRule : IEquatable<TaxRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRule" /> class.
        /// </summary>
        /// <param name="name">A user-friendly name (required).</param>
        /// <param name="description">A description for this rule (required).</param>
        /// <param name="rate">The rate to be applied if all criteria are met (required).</param>
        /// <param name="matchCriteria">A set of criteria to be met for this rule to be applied (required).</param>
        public TaxRule(string name = default(string), string description = default(string), decimal rate = default(decimal), List<MatchCriterion> matchCriteria = default(List<MatchCriterion>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TaxRule and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for TaxRule and cannot be null");
            }
            this.Description = description;
            this.Rate = rate;
            // to ensure "matchCriteria" is required (not null)
            if (matchCriteria == null)
            {
                throw new ArgumentNullException("matchCriteria is a required property for TaxRule and cannot be null");
            }
            this.MatchCriteria = matchCriteria;
        }

        /// <summary>
        /// A user-friendly name
        /// </summary>
        /// <value>A user-friendly name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A description for this rule
        /// </summary>
        /// <value>A description for this rule</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The rate to be applied if all criteria are met
        /// </summary>
        /// <value>The rate to be applied if all criteria are met</value>
        [DataMember(Name = "rate", IsRequired = true, EmitDefaultValue = true)]
        public decimal Rate { get; set; }

        /// <summary>
        /// A set of criteria to be met for this rule to be applied
        /// </summary>
        /// <value>A set of criteria to be met for this rule to be applied</value>
        [DataMember(Name = "matchCriteria", IsRequired = true, EmitDefaultValue = true)]
        public List<MatchCriterion> MatchCriteria { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxRule {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  MatchCriteria: ").Append(MatchCriteria).Append("\n");
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
            return this.Equals(input as TaxRule);
        }

        /// <summary>
        /// Returns true if TaxRule instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRule input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
                ) && 
                (
                    this.MatchCriteria == input.MatchCriteria ||
                    this.MatchCriteria != null &&
                    input.MatchCriteria != null &&
                    this.MatchCriteria.SequenceEqual(input.MatchCriteria)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                if (this.MatchCriteria != null)
                {
                    hashCode = (hashCode * 59) + this.MatchCriteria.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 64.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Description (string) pattern
            Regex regexDescription = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexDescription.Match(this.Description).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, must match a pattern of " + regexDescription, new [] { "Description" });
            }

            yield break;
        }
    }
}
