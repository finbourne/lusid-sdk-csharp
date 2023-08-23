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
    /// Representation of Legal Entity on LUSID API
    /// </summary>
    [DataContract(Name = "LegalEntity")]
    public partial class LegalEntity : IEquatable<LegalEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalEntity" /> class.
        /// </summary>
        /// <param name="displayName">The display name of the Legal Entity.</param>
        /// <param name="description">The description of the Legal Entity.</param>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="lusidLegalEntityId">The unique LUSID Legal Entity Identifier of the Legal Entity..</param>
        /// <param name="identifiers">Unique client-defined identifiers of the Legal Entity..</param>
        /// <param name="properties">A set of properties associated to the Legal Entity..</param>
        /// <param name="relationships">A set of relationships associated to the Legal Entity..</param>
        /// <param name="counterpartyRiskInformation">counterpartyRiskInformation.</param>
        /// <param name="version">version.</param>
        /// <param name="links">links.</param>
        public LegalEntity(string displayName = default(string), string description = default(string), string href = default(string), string lusidLegalEntityId = default(string), Dictionary<string, Property> identifiers = default(Dictionary<string, Property>), Dictionary<string, Property> properties = default(Dictionary<string, Property>), List<Relationship> relationships = default(List<Relationship>), CounterpartyRiskInformation counterpartyRiskInformation = default(CounterpartyRiskInformation), ModelVersion version = default(ModelVersion), List<Link> links = default(List<Link>))
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.Href = href;
            this.LusidLegalEntityId = lusidLegalEntityId;
            this.Identifiers = identifiers;
            this.Properties = properties;
            this.Relationships = relationships;
            this.CounterpartyRiskInformation = counterpartyRiskInformation;
            this._Version = version;
            this.Links = links;
        }

        /// <summary>
        /// The display name of the Legal Entity
        /// </summary>
        /// <value>The display name of the Legal Entity</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description of the Legal Entity
        /// </summary>
        /// <value>The description of the Legal Entity</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// The unique LUSID Legal Entity Identifier of the Legal Entity.
        /// </summary>
        /// <value>The unique LUSID Legal Entity Identifier of the Legal Entity.</value>
        [DataMember(Name = "lusidLegalEntityId", EmitDefaultValue = true)]
        public string LusidLegalEntityId { get; set; }

        /// <summary>
        /// Unique client-defined identifiers of the Legal Entity.
        /// </summary>
        /// <value>Unique client-defined identifiers of the Legal Entity.</value>
        [DataMember(Name = "identifiers", EmitDefaultValue = true)]
        public Dictionary<string, Property> Identifiers { get; set; }

        /// <summary>
        /// A set of properties associated to the Legal Entity.
        /// </summary>
        /// <value>A set of properties associated to the Legal Entity.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// A set of relationships associated to the Legal Entity.
        /// </summary>
        /// <value>A set of relationships associated to the Legal Entity.</value>
        [DataMember(Name = "relationships", EmitDefaultValue = true)]
        public List<Relationship> Relationships { get; set; }

        /// <summary>
        /// Gets or Sets CounterpartyRiskInformation
        /// </summary>
        [DataMember(Name = "counterpartyRiskInformation", EmitDefaultValue = false)]
        public CounterpartyRiskInformation CounterpartyRiskInformation { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public ModelVersion _Version { get; set; }

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
            sb.Append("class LegalEntity {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  LusidLegalEntityId: ").Append(LusidLegalEntityId).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
            sb.Append("  CounterpartyRiskInformation: ").Append(CounterpartyRiskInformation).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as LegalEntity);
        }

        /// <summary>
        /// Returns true if LegalEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of LegalEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.LusidLegalEntityId == input.LusidLegalEntityId ||
                    (this.LusidLegalEntityId != null &&
                    this.LusidLegalEntityId.Equals(input.LusidLegalEntityId))
                ) && 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Relationships == input.Relationships ||
                    this.Relationships != null &&
                    input.Relationships != null &&
                    this.Relationships.SequenceEqual(input.Relationships)
                ) && 
                (
                    this.CounterpartyRiskInformation == input.CounterpartyRiskInformation ||
                    (this.CounterpartyRiskInformation != null &&
                    this.CounterpartyRiskInformation.Equals(input.CounterpartyRiskInformation))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Href != null)
                {
                    hashCode = (hashCode * 59) + this.Href.GetHashCode();
                }
                if (this.LusidLegalEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.LusidLegalEntityId.GetHashCode();
                }
                if (this.Identifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Identifiers.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.Relationships != null)
                {
                    hashCode = (hashCode * 59) + this.Relationships.GetHashCode();
                }
                if (this.CounterpartyRiskInformation != null)
                {
                    hashCode = (hashCode * 59) + this.CounterpartyRiskInformation.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
            yield break;
        }
    }
}
