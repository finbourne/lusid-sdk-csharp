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
    /// A list of instruments.
    /// </summary>
    [DataContract]
    public partial class Instrument :  IEquatable<Instrument>
    {
        /// <summary>
        /// The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive
        /// </summary>
        /// <value>The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 2

        }

        /// <summary>
        /// The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive
        /// </summary>
        /// <value>The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Instrument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Instrument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Instrument" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="lusidInstrumentId">The unique LUSID Instrument Identifier (LUID) of the instrument. (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="name">The name of the instrument. (required).</param>
        /// <param name="identifiers">The set of identifiers that can be used to identify the instrument. (required).</param>
        /// <param name="properties">The requested instrument properties. These will be from the &#39;Instrument&#39; domain..</param>
        /// <param name="lookthroughPortfolio">lookthroughPortfolio.</param>
        /// <param name="instrumentDefinition">instrumentDefinition.</param>
        /// <param name="state">The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive (required).</param>
        /// <param name="links">Collection of links..</param>
        public Instrument(string href = default(string), string lusidInstrumentId = default(string), Version version = default(Version), string name = default(string), Dictionary<string, string> identifiers = default(Dictionary<string, string>), List<Property> properties = default(List<Property>), ResourceId lookthroughPortfolio = default(ResourceId), LusidInstrument instrumentDefinition = default(LusidInstrument), StateEnum state = default(StateEnum), List<Link> links = default(List<Link>))
        {
            this.Href = href;
            // to ensure "lusidInstrumentId" is required (not null)
            if (lusidInstrumentId == null)
            {
                throw new InvalidDataException("lusidInstrumentId is a required property for Instrument and cannot be null");
            }
            else
            {
                this.LusidInstrumentId = lusidInstrumentId;
            }
            
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for Instrument and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Instrument and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "identifiers" is required (not null)
            if (identifiers == null)
            {
                throw new InvalidDataException("identifiers is a required property for Instrument and cannot be null");
            }
            else
            {
                this.Identifiers = identifiers;
            }
            
            this.Properties = properties;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for Instrument and cannot be null");
            }
            else
            {
                this.State = state;
            }
            
            this.Links = links;
            this.Href = href;
            this.Properties = properties;
            this.LookthroughPortfolio = lookthroughPortfolio;
            this.InstrumentDefinition = instrumentDefinition;
            this.Links = links;
        }
        
        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name="href", EmitDefaultValue=true)]
        public string Href { get; set; }

        /// <summary>
        /// The unique LUSID Instrument Identifier (LUID) of the instrument.
        /// </summary>
        /// <value>The unique LUSID Instrument Identifier (LUID) of the instrument.</value>
        [DataMember(Name="lusidInstrumentId", EmitDefaultValue=false)]
        public string LusidInstrumentId { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }

        /// <summary>
        /// The name of the instrument.
        /// </summary>
        /// <value>The name of the instrument.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The set of identifiers that can be used to identify the instrument.
        /// </summary>
        /// <value>The set of identifiers that can be used to identify the instrument.</value>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public Dictionary<string, string> Identifiers { get; set; }

        /// <summary>
        /// The requested instrument properties. These will be from the &#39;Instrument&#39; domain.
        /// </summary>
        /// <value>The requested instrument properties. These will be from the &#39;Instrument&#39; domain.</value>
        [DataMember(Name="properties", EmitDefaultValue=true)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Gets or Sets LookthroughPortfolio
        /// </summary>
        [DataMember(Name="lookthroughPortfolio", EmitDefaultValue=false)]
        public ResourceId LookthroughPortfolio { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentDefinition
        /// </summary>
        [DataMember(Name="instrumentDefinition", EmitDefaultValue=false)]
        public LusidInstrument InstrumentDefinition { get; set; }


        /// <summary>
        /// Collection of links.
        /// </summary>
        /// <value>Collection of links.</value>
        [DataMember(Name="links", EmitDefaultValue=true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Instrument {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  LusidInstrumentId: ").Append(LusidInstrumentId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  LookthroughPortfolio: ").Append(LookthroughPortfolio).Append("\n");
            sb.Append("  InstrumentDefinition: ").Append(InstrumentDefinition).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Instrument);
        }

        /// <summary>
        /// Returns true if Instrument instances are equal
        /// </summary>
        /// <param name="input">Instance of Instrument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Instrument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.LusidInstrumentId == input.LusidInstrumentId ||
                    (this.LusidInstrumentId != null &&
                    this.LusidInstrumentId.Equals(input.LusidInstrumentId))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
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
                    this.LookthroughPortfolio == input.LookthroughPortfolio ||
                    (this.LookthroughPortfolio != null &&
                    this.LookthroughPortfolio.Equals(input.LookthroughPortfolio))
                ) && 
                (
                    this.InstrumentDefinition == input.InstrumentDefinition ||
                    (this.InstrumentDefinition != null &&
                    this.InstrumentDefinition.Equals(input.InstrumentDefinition))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.LusidInstrumentId != null)
                    hashCode = hashCode * 59 + this.LusidInstrumentId.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.LookthroughPortfolio != null)
                    hashCode = hashCode * 59 + this.LookthroughPortfolio.GetHashCode();
                if (this.InstrumentDefinition != null)
                    hashCode = hashCode * 59 + this.InstrumentDefinition.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
