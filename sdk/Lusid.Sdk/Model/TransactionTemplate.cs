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
    /// TransactionTemplate
    /// </summary>
    [DataContract(Name = "TransactionTemplate")]
    public partial class TransactionTemplate : IEquatable<TransactionTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTemplate" /> class.
        /// </summary>
        /// <param name="instrumentType">A value that represents the instrument type. (required).</param>
        /// <param name="instrumentEventType">A value that represents the instrument event type. (required).</param>
        /// <param name="description">The description of the transaction template. (required).</param>
        /// <param name="scope">The scope in which the transaction template resides. (required).</param>
        /// <param name="componentTransactions">A set of component transactions that relate to the template to be created. (required).</param>
        /// <param name="links">links.</param>
        public TransactionTemplate(string instrumentType = default(string), string instrumentEventType = default(string), string description = default(string), string scope = default(string), List<ComponentTransaction> componentTransactions = default(List<ComponentTransaction>), List<Link> links = default(List<Link>))
        {
            // to ensure "instrumentType" is required (not null)
            if (instrumentType == null)
            {
                throw new ArgumentNullException("instrumentType is a required property for TransactionTemplate and cannot be null");
            }
            this.InstrumentType = instrumentType;
            // to ensure "instrumentEventType" is required (not null)
            if (instrumentEventType == null)
            {
                throw new ArgumentNullException("instrumentEventType is a required property for TransactionTemplate and cannot be null");
            }
            this.InstrumentEventType = instrumentEventType;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for TransactionTemplate and cannot be null");
            }
            this.Description = description;
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new ArgumentNullException("scope is a required property for TransactionTemplate and cannot be null");
            }
            this.Scope = scope;
            // to ensure "componentTransactions" is required (not null)
            if (componentTransactions == null)
            {
                throw new ArgumentNullException("componentTransactions is a required property for TransactionTemplate and cannot be null");
            }
            this.ComponentTransactions = componentTransactions;
            this.Links = links;
        }

        /// <summary>
        /// A value that represents the instrument type.
        /// </summary>
        /// <value>A value that represents the instrument type.</value>
        [DataMember(Name = "instrumentType", IsRequired = true, EmitDefaultValue = true)]
        public string InstrumentType { get; set; }

        /// <summary>
        /// A value that represents the instrument event type.
        /// </summary>
        /// <value>A value that represents the instrument event type.</value>
        [DataMember(Name = "instrumentEventType", IsRequired = true, EmitDefaultValue = true)]
        public string InstrumentEventType { get; set; }

        /// <summary>
        /// The description of the transaction template.
        /// </summary>
        /// <value>The description of the transaction template.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The scope in which the transaction template resides.
        /// </summary>
        /// <value>The scope in which the transaction template resides.</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// A set of component transactions that relate to the template to be created.
        /// </summary>
        /// <value>A set of component transactions that relate to the template to be created.</value>
        [DataMember(Name = "componentTransactions", IsRequired = true, EmitDefaultValue = true)]
        public List<ComponentTransaction> ComponentTransactions { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionTemplate {\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
            sb.Append("  InstrumentEventType: ").Append(InstrumentEventType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ComponentTransactions: ").Append(ComponentTransactions).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as TransactionTemplate);
        }

        /// <summary>
        /// Returns true if TransactionTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionTemplate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstrumentType == input.InstrumentType ||
                    (this.InstrumentType != null &&
                    this.InstrumentType.Equals(input.InstrumentType))
                ) && 
                (
                    this.InstrumentEventType == input.InstrumentEventType ||
                    (this.InstrumentEventType != null &&
                    this.InstrumentEventType.Equals(input.InstrumentEventType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.ComponentTransactions == input.ComponentTransactions ||
                    this.ComponentTransactions != null &&
                    input.ComponentTransactions != null &&
                    this.ComponentTransactions.SequenceEqual(input.ComponentTransactions)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.InstrumentType != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentType.GetHashCode();
                }
                if (this.InstrumentEventType != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentEventType.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.ComponentTransactions != null)
                {
                    hashCode = (hashCode * 59) + this.ComponentTransactions.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
            // InstrumentType (string) minLength
            if (this.InstrumentType != null && this.InstrumentType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentType, length must be greater than 1.", new [] { "InstrumentType" });
            }

            // InstrumentEventType (string) minLength
            if (this.InstrumentEventType != null && this.InstrumentEventType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentEventType, length must be greater than 1.", new [] { "InstrumentEventType" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            // Scope (string) minLength
            if (this.Scope != null && this.Scope.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be greater than 1.", new [] { "Scope" });
            }

            yield break;
        }
    }
}
