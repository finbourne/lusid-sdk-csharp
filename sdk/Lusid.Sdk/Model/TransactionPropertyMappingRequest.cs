/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3480
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
    /// TransactionPropertyMappingRequest
    /// </summary>
    [DataContract(Name = "TransactionPropertyMappingRequest")]
    public partial class TransactionPropertyMappingRequest : IEquatable<TransactionPropertyMappingRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPropertyMappingRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionPropertyMappingRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPropertyMappingRequest" /> class.
        /// </summary>
        /// <param name="propertyKey">Uniquely identifies the property definition and consists of a Domain, Scope and Code. (required).</param>
        /// <param name="mapFrom">The Property Key of the Property to map from..</param>
        /// <param name="setTo">A pointer to the Property being mapped from..</param>
        public TransactionPropertyMappingRequest(string propertyKey = default(string), string mapFrom = default(string), Object setTo = default(Object))
        {
            // to ensure "propertyKey" is required (not null)
            this.PropertyKey = propertyKey ?? throw new ArgumentNullException("propertyKey is a required property for TransactionPropertyMappingRequest and cannot be null");
            this.MapFrom = mapFrom;
            this.SetTo = setTo;
        }

        /// <summary>
        /// Uniquely identifies the property definition and consists of a Domain, Scope and Code.
        /// </summary>
        /// <value>Uniquely identifies the property definition and consists of a Domain, Scope and Code.</value>
        [DataMember(Name = "propertyKey", IsRequired = true, EmitDefaultValue = false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// The Property Key of the Property to map from.
        /// </summary>
        /// <value>The Property Key of the Property to map from.</value>
        [DataMember(Name = "mapFrom", EmitDefaultValue = true)]
        public string MapFrom { get; set; }

        /// <summary>
        /// A pointer to the Property being mapped from.
        /// </summary>
        /// <value>A pointer to the Property being mapped from.</value>
        [DataMember(Name = "setTo", EmitDefaultValue = true)]
        public Object SetTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionPropertyMappingRequest {\n");
            sb.Append("  PropertyKey: ").Append(PropertyKey).Append("\n");
            sb.Append("  MapFrom: ").Append(MapFrom).Append("\n");
            sb.Append("  SetTo: ").Append(SetTo).Append("\n");
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
            return this.Equals(input as TransactionPropertyMappingRequest);
        }

        /// <summary>
        /// Returns true if TransactionPropertyMappingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionPropertyMappingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionPropertyMappingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PropertyKey == input.PropertyKey ||
                    (this.PropertyKey != null &&
                    this.PropertyKey.Equals(input.PropertyKey))
                ) && 
                (
                    this.MapFrom == input.MapFrom ||
                    (this.MapFrom != null &&
                    this.MapFrom.Equals(input.MapFrom))
                ) && 
                (
                    this.SetTo == input.SetTo ||
                    (this.SetTo != null &&
                    this.SetTo.Equals(input.SetTo))
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
                if (this.PropertyKey != null)
                    hashCode = hashCode * 59 + this.PropertyKey.GetHashCode();
                if (this.MapFrom != null)
                    hashCode = hashCode * 59 + this.MapFrom.GetHashCode();
                if (this.SetTo != null)
                    hashCode = hashCode * 59 + this.SetTo.GetHashCode();
                return hashCode;
            }
        }

    }
}
