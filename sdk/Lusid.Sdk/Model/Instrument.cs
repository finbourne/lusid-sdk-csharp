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
    /// A list of instruments.
    /// </summary>
    [DataContract(Name = "Instrument")]
    public partial class Instrument : IEquatable<Instrument>, IValidatableObject
    {
        /// <summary>
        /// The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive, Deleted
        /// </summary>
        /// <value>The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive, Deleted</value>
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
            Inactive = 2,

            /// <summary>
            /// Enum Deleted for value: Deleted
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted = 3

        }


        /// <summary>
        /// The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive, Deleted
        /// </summary>
        /// <value>The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive, Deleted</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public StateEnum State { get; set; }
        /// <summary>
        /// The nominal asset class of the instrument, e.g. InterestRates, FX, Inflation, Equities, Credit, Commodities, etc. The available values are: InterestRates, FX, Inflation, Equities, Credit, Commodities, Money, Unknown
        /// </summary>
        /// <value>The nominal asset class of the instrument, e.g. InterestRates, FX, Inflation, Equities, Credit, Commodities, etc. The available values are: InterestRates, FX, Inflation, Equities, Credit, Commodities, Money, Unknown</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AssetClassEnum
        {
            /// <summary>
            /// Enum InterestRates for value: InterestRates
            /// </summary>
            [EnumMember(Value = "InterestRates")]
            InterestRates = 1,

            /// <summary>
            /// Enum FX for value: FX
            /// </summary>
            [EnumMember(Value = "FX")]
            FX = 2,

            /// <summary>
            /// Enum Inflation for value: Inflation
            /// </summary>
            [EnumMember(Value = "Inflation")]
            Inflation = 3,

            /// <summary>
            /// Enum Equities for value: Equities
            /// </summary>
            [EnumMember(Value = "Equities")]
            Equities = 4,

            /// <summary>
            /// Enum Credit for value: Credit
            /// </summary>
            [EnumMember(Value = "Credit")]
            Credit = 5,

            /// <summary>
            /// Enum Commodities for value: Commodities
            /// </summary>
            [EnumMember(Value = "Commodities")]
            Commodities = 6,

            /// <summary>
            /// Enum Money for value: Money
            /// </summary>
            [EnumMember(Value = "Money")]
            Money = 7,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 8

        }


        /// <summary>
        /// The nominal asset class of the instrument, e.g. InterestRates, FX, Inflation, Equities, Credit, Commodities, etc. The available values are: InterestRates, FX, Inflation, Equities, Credit, Commodities, Money, Unknown
        /// </summary>
        /// <value>The nominal asset class of the instrument, e.g. InterestRates, FX, Inflation, Equities, Credit, Commodities, etc. The available values are: InterestRates, FX, Inflation, Equities, Credit, Commodities, Money, Unknown</value>
        [DataMember(Name = "assetClass", EmitDefaultValue = false)]
        public AssetClassEnum? AssetClass { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Instrument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Instrument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Instrument" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="scope">The scope in which the instrument lies..</param>
        /// <param name="lusidInstrumentId">The unique LUSID Instrument Identifier (LUID) of the instrument. (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="name">The name of the instrument. (required).</param>
        /// <param name="identifiers">The set of identifiers that can be used to identify the instrument. (required).</param>
        /// <param name="properties">The requested instrument properties. These will be from the &#39;Instrument&#39; domain..</param>
        /// <param name="lookthroughPortfolio">lookthroughPortfolio.</param>
        /// <param name="instrumentDefinition">instrumentDefinition.</param>
        /// <param name="state">The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive, Deleted (required).</param>
        /// <param name="assetClass">The nominal asset class of the instrument, e.g. InterestRates, FX, Inflation, Equities, Credit, Commodities, etc. The available values are: InterestRates, FX, Inflation, Equities, Credit, Commodities, Money, Unknown.</param>
        /// <param name="domCcy">The domestic currency, meaning the currency in which the instrument would typically be expected to pay cashflows, e.g. a share in AAPL being USD..</param>
        /// <param name="relationships">A set of relationships associated to the instrument..</param>
        /// <param name="links">links.</param>
        public Instrument(string href = default(string), string scope = default(string), string lusidInstrumentId = default(string), ModelVersion version = default(ModelVersion), string name = default(string), Dictionary<string, string> identifiers = default(Dictionary<string, string>), List<Property> properties = default(List<Property>), ResourceId lookthroughPortfolio = default(ResourceId), LusidInstrument instrumentDefinition = default(LusidInstrument), StateEnum state = default(StateEnum), AssetClassEnum? assetClass = default(AssetClassEnum?), string domCcy = default(string), List<Relationship> relationships = default(List<Relationship>), List<Link> links = default(List<Link>))
        {
            // to ensure "lusidInstrumentId" is required (not null)
            if (lusidInstrumentId == null)
            {
                throw new ArgumentNullException("lusidInstrumentId is a required property for Instrument and cannot be null");
            }
            this.LusidInstrumentId = lusidInstrumentId;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new ArgumentNullException("version is a required property for Instrument and cannot be null");
            }
            this._Version = version;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Instrument and cannot be null");
            }
            this.Name = name;
            // to ensure "identifiers" is required (not null)
            if (identifiers == null)
            {
                throw new ArgumentNullException("identifiers is a required property for Instrument and cannot be null");
            }
            this.Identifiers = identifiers;
            this.State = state;
            this.Href = href;
            this.Scope = scope;
            this.Properties = properties;
            this.LookthroughPortfolio = lookthroughPortfolio;
            this.InstrumentDefinition = instrumentDefinition;
            this.AssetClass = assetClass;
            this.DomCcy = domCcy;
            this.Relationships = relationships;
            this.Links = links;
        }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// The scope in which the instrument lies.
        /// </summary>
        /// <value>The scope in which the instrument lies.</value>
        [DataMember(Name = "scope", EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// The unique LUSID Instrument Identifier (LUID) of the instrument.
        /// </summary>
        /// <value>The unique LUSID Instrument Identifier (LUID) of the instrument.</value>
        [DataMember(Name = "lusidInstrumentId", IsRequired = true, EmitDefaultValue = true)]
        public string LusidInstrumentId { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public ModelVersion _Version { get; set; }

        /// <summary>
        /// The name of the instrument.
        /// </summary>
        /// <value>The name of the instrument.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The set of identifiers that can be used to identify the instrument.
        /// </summary>
        /// <value>The set of identifiers that can be used to identify the instrument.</value>
        [DataMember(Name = "identifiers", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Identifiers { get; set; }

        /// <summary>
        /// The requested instrument properties. These will be from the &#39;Instrument&#39; domain.
        /// </summary>
        /// <value>The requested instrument properties. These will be from the &#39;Instrument&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Gets or Sets LookthroughPortfolio
        /// </summary>
        [DataMember(Name = "lookthroughPortfolio", EmitDefaultValue = false)]
        public ResourceId LookthroughPortfolio { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentDefinition
        /// </summary>
        [DataMember(Name = "instrumentDefinition", EmitDefaultValue = false)]
        public LusidInstrument InstrumentDefinition { get; set; }

        /// <summary>
        /// The domestic currency, meaning the currency in which the instrument would typically be expected to pay cashflows, e.g. a share in AAPL being USD.
        /// </summary>
        /// <value>The domestic currency, meaning the currency in which the instrument would typically be expected to pay cashflows, e.g. a share in AAPL being USD.</value>
        [DataMember(Name = "domCcy", EmitDefaultValue = true)]
        public string DomCcy { get; set; }

        /// <summary>
        /// A set of relationships associated to the instrument.
        /// </summary>
        /// <value>A set of relationships associated to the instrument.</value>
        [DataMember(Name = "relationships", EmitDefaultValue = true)]
        public List<Relationship> Relationships { get; set; }

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
            sb.Append("class Instrument {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  LusidInstrumentId: ").Append(LusidInstrumentId).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  LookthroughPortfolio: ").Append(LookthroughPortfolio).Append("\n");
            sb.Append("  InstrumentDefinition: ").Append(InstrumentDefinition).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  AssetClass: ").Append(AssetClass).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
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
            {
                return false;
            }
            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.LusidInstrumentId == input.LusidInstrumentId ||
                    (this.LusidInstrumentId != null &&
                    this.LusidInstrumentId.Equals(input.LusidInstrumentId))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                    this.State.Equals(input.State)
                ) && 
                (
                    this.AssetClass == input.AssetClass ||
                    this.AssetClass.Equals(input.AssetClass)
                ) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && 
                (
                    this.Relationships == input.Relationships ||
                    this.Relationships != null &&
                    input.Relationships != null &&
                    this.Relationships.SequenceEqual(input.Relationships)
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
                {
                    hashCode = (hashCode * 59) + this.Href.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.LusidInstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.LusidInstrumentId.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Identifiers != null)
                {
                    hashCode = (hashCode * 59) + this.Identifiers.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.LookthroughPortfolio != null)
                {
                    hashCode = (hashCode * 59) + this.LookthroughPortfolio.GetHashCode();
                }
                if (this.InstrumentDefinition != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentDefinition.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                hashCode = (hashCode * 59) + this.AssetClass.GetHashCode();
                if (this.DomCcy != null)
                {
                    hashCode = (hashCode * 59) + this.DomCcy.GetHashCode();
                }
                if (this.Relationships != null)
                {
                    hashCode = (hashCode * 59) + this.Relationships.GetHashCode();
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
            // LusidInstrumentId (string) minLength
            if (this.LusidInstrumentId != null && this.LusidInstrumentId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LusidInstrumentId, length must be greater than 1.", new [] { "LusidInstrumentId" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }
}
