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
    /// A structure used to describe the structure of an order or orders that make up a non-trivial trade.
    /// </summary>
    [DataContract(Name = "Package")]
    public partial class Package : IEquatable<Package>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Package() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="orderIds">Related order ids. (required).</param>
        /// <param name="orderInstructionIds">Related order instruction ids. (required).</param>
        /// <param name="properties">Client-defined properties associated with this execution..</param>
        /// <param name="version">version.</param>
        /// <param name="links">links.</param>
        public Package(ResourceId id = default(ResourceId), List<ResourceId> orderIds = default(List<ResourceId>), List<ResourceId> orderInstructionIds = default(List<ResourceId>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), ModelVersion version = default(ModelVersion), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Package and cannot be null");
            }
            this.Id = id;
            // to ensure "orderIds" is required (not null)
            if (orderIds == null)
            {
                throw new ArgumentNullException("orderIds is a required property for Package and cannot be null");
            }
            this.OrderIds = orderIds;
            // to ensure "orderInstructionIds" is required (not null)
            if (orderInstructionIds == null)
            {
                throw new ArgumentNullException("orderInstructionIds is a required property for Package and cannot be null");
            }
            this.OrderInstructionIds = orderInstructionIds;
            this.Properties = properties;
            this._Version = version;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// Related order ids.
        /// </summary>
        /// <value>Related order ids.</value>
        [DataMember(Name = "orderIds", IsRequired = true, EmitDefaultValue = true)]
        public List<ResourceId> OrderIds { get; set; }

        /// <summary>
        /// Related order instruction ids.
        /// </summary>
        /// <value>Related order instruction ids.</value>
        [DataMember(Name = "orderInstructionIds", IsRequired = true, EmitDefaultValue = true)]
        public List<ResourceId> OrderInstructionIds { get; set; }

        /// <summary>
        /// Client-defined properties associated with this execution.
        /// </summary>
        /// <value>Client-defined properties associated with this execution.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

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
            sb.Append("class Package {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
            sb.Append("  OrderInstructionIds: ").Append(OrderInstructionIds).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as Package);
        }

        /// <summary>
        /// Returns true if Package instances are equal
        /// </summary>
        /// <param name="input">Instance of Package to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Package input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrderIds == input.OrderIds ||
                    this.OrderIds != null &&
                    input.OrderIds != null &&
                    this.OrderIds.SequenceEqual(input.OrderIds)
                ) && 
                (
                    this.OrderInstructionIds == input.OrderInstructionIds ||
                    this.OrderInstructionIds != null &&
                    input.OrderInstructionIds != null &&
                    this.OrderInstructionIds.SequenceEqual(input.OrderInstructionIds)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.OrderIds != null)
                {
                    hashCode = (hashCode * 59) + this.OrderIds.GetHashCode();
                }
                if (this.OrderInstructionIds != null)
                {
                    hashCode = (hashCode * 59) + this.OrderInstructionIds.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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