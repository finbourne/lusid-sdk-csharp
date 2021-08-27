/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3437
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// InstrumentDefinition
    /// </summary>
    [DataContract]
    public partial class InstrumentDefinition :  IEquatable<InstrumentDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstrumentDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentDefinition" /> class.
        /// </summary>
        /// <param name="name">The name of the instrument. (required).</param>
        /// <param name="identifiers">A set of identifiers that can be used to identify the instrument. At least one of these must be configured to be a unique identifier. (required).</param>
        /// <param name="properties">Set of unique instrument properties and associated values to store with the instrument. Each property must be from the &#39;Instrument&#39; domain..</param>
        /// <param name="lookThroughPortfolioId">lookThroughPortfolioId.</param>
        /// <param name="definition">definition.</param>
        public InstrumentDefinition(string name = default(string), Dictionary<string, InstrumentIdValue> identifiers = default(Dictionary<string, InstrumentIdValue>), List<Property> properties = default(List<Property>), ResourceId lookThroughPortfolioId = default(ResourceId), LusidInstrument definition = default(LusidInstrument))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InstrumentDefinition and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "identifiers" is required (not null)
            if (identifiers == null)
            {
                throw new InvalidDataException("identifiers is a required property for InstrumentDefinition and cannot be null");
            }
            else
            {
                this.Identifiers = identifiers;
            }
            
            this.Properties = properties;
            this.Properties = properties;
            this.LookThroughPortfolioId = lookThroughPortfolioId;
            this.Definition = definition;
        }
        
        /// <summary>
        /// The name of the instrument.
        /// </summary>
        /// <value>The name of the instrument.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A set of identifiers that can be used to identify the instrument. At least one of these must be configured to be a unique identifier.
        /// </summary>
        /// <value>A set of identifiers that can be used to identify the instrument. At least one of these must be configured to be a unique identifier.</value>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public Dictionary<string, InstrumentIdValue> Identifiers { get; set; }

        /// <summary>
        /// Set of unique instrument properties and associated values to store with the instrument. Each property must be from the &#39;Instrument&#39; domain.
        /// </summary>
        /// <value>Set of unique instrument properties and associated values to store with the instrument. Each property must be from the &#39;Instrument&#39; domain.</value>
        [DataMember(Name="properties", EmitDefaultValue=true)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Gets or Sets LookThroughPortfolioId
        /// </summary>
        [DataMember(Name="lookThroughPortfolioId", EmitDefaultValue=false)]
        public ResourceId LookThroughPortfolioId { get; set; }

        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name="definition", EmitDefaultValue=false)]
        public LusidInstrument Definition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstrumentDefinition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  LookThroughPortfolioId: ").Append(LookThroughPortfolioId).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstrumentDefinition);
        }

        /// <summary>
        /// Returns true if InstrumentDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.LookThroughPortfolioId == input.LookThroughPortfolioId ||
                    (this.LookThroughPortfolioId != null &&
                    this.LookThroughPortfolioId.Equals(input.LookThroughPortfolioId))
                ) && 
                (
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
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
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.LookThroughPortfolioId != null)
                    hashCode = hashCode * 59 + this.LookThroughPortfolioId.GetHashCode();
                if (this.Definition != null)
                    hashCode = hashCode * 59 + this.Definition.GetHashCode();
                return hashCode;
            }
        }
    }

}
