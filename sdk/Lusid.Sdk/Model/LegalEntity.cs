/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3448
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
    public partial class LegalEntity : IEquatable<LegalEntity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalEntity" /> class.
        /// </summary>
        /// <param name="displayName">The display name of the Legal Entity.</param>
        /// <param name="description">The description of the Legal Entity.</param>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="lusidLegalEntityId">The unique LUSID Legal Entity Identifier (LULEID) of the Legal Entity. This field is not populated until further notice..</param>
        /// <param name="identifiers">Unique client-defined identifiers of the Legal Entity..</param>
        /// <param name="properties">A set of properties associated to the Legal Entity..</param>
        /// <param name="counterpartyRiskInformation">counterpartyRiskInformation.</param>
        /// <param name="version">version.</param>
        /// <param name="links">Collection of links..</param>
        public LegalEntity(string displayName = default(string), string description = default(string), string href = default(string), string lusidLegalEntityId = default(string), Dictionary<string, Property> identifiers = default(Dictionary<string, Property>), Dictionary<string, Property> properties = default(Dictionary<string, Property>), CounterpartyRiskInformation counterpartyRiskInformation = default(CounterpartyRiskInformation), Version version = default(Version), List<Link> links = default(List<Link>))
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.Href = href;
            this.LusidLegalEntityId = lusidLegalEntityId;
            this.Identifiers = identifiers;
            this.Properties = properties;
            this.CounterpartyRiskInformation = counterpartyRiskInformation;
            this.Version = version;
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
        /// The unique LUSID Legal Entity Identifier (LULEID) of the Legal Entity. This field is not populated until further notice.
        /// </summary>
        /// <value>The unique LUSID Legal Entity Identifier (LULEID) of the Legal Entity. This field is not populated until further notice.</value>
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
        /// Gets or Sets CounterpartyRiskInformation
        /// </summary>
        [DataMember(Name = "counterpartyRiskInformation", EmitDefaultValue = false)]
        public CounterpartyRiskInformation CounterpartyRiskInformation { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version Version { get; set; }

        /// <summary>
        /// Collection of links.
        /// </summary>
        /// <value>Collection of links.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegalEntity {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  LusidLegalEntityId: ").Append(LusidLegalEntityId).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  CounterpartyRiskInformation: ").Append(CounterpartyRiskInformation).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
                return false;

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
                    this.CounterpartyRiskInformation == input.CounterpartyRiskInformation ||
                    (this.CounterpartyRiskInformation != null &&
                    this.CounterpartyRiskInformation.Equals(input.CounterpartyRiskInformation))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.LusidLegalEntityId != null)
                    hashCode = hashCode * 59 + this.LusidLegalEntityId.GetHashCode();
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.CounterpartyRiskInformation != null)
                    hashCode = hashCode * 59 + this.CounterpartyRiskInformation.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
