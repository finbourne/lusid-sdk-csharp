/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3440
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
    /// The description of an allowable instrument identifier.
    /// </summary>
    [DataContract(Name = "InstrumentIdTypeDescriptor")]
    public partial class InstrumentIdTypeDescriptor : IEquatable<InstrumentIdTypeDescriptor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentIdTypeDescriptor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstrumentIdTypeDescriptor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentIdTypeDescriptor" /> class.
        /// </summary>
        /// <param name="identifierType">The name of the identifier type. (required).</param>
        /// <param name="propertyKey">The property key that corresponds to the identifier type. (required).</param>
        /// <param name="isUniqueIdentifierType">Whether or not the identifier type is enforced to be unique. (required).</param>
        public InstrumentIdTypeDescriptor(string identifierType = default(string), string propertyKey = default(string), bool isUniqueIdentifierType = default(bool))
        {
            // to ensure "identifierType" is required (not null)
            this.IdentifierType = identifierType ?? throw new ArgumentNullException("identifierType is a required property for InstrumentIdTypeDescriptor and cannot be null");
            // to ensure "propertyKey" is required (not null)
            this.PropertyKey = propertyKey ?? throw new ArgumentNullException("propertyKey is a required property for InstrumentIdTypeDescriptor and cannot be null");
            this.IsUniqueIdentifierType = isUniqueIdentifierType;
        }

        /// <summary>
        /// The name of the identifier type.
        /// </summary>
        /// <value>The name of the identifier type.</value>
        [DataMember(Name = "identifierType", IsRequired = true, EmitDefaultValue = false)]
        public string IdentifierType { get; set; }

        /// <summary>
        /// The property key that corresponds to the identifier type.
        /// </summary>
        /// <value>The property key that corresponds to the identifier type.</value>
        [DataMember(Name = "propertyKey", IsRequired = true, EmitDefaultValue = false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// Whether or not the identifier type is enforced to be unique.
        /// </summary>
        /// <value>Whether or not the identifier type is enforced to be unique.</value>
        [DataMember(Name = "isUniqueIdentifierType", IsRequired = true, EmitDefaultValue = true)]
        public bool IsUniqueIdentifierType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstrumentIdTypeDescriptor {\n");
            sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
            sb.Append("  PropertyKey: ").Append(PropertyKey).Append("\n");
            sb.Append("  IsUniqueIdentifierType: ").Append(IsUniqueIdentifierType).Append("\n");
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
            return this.Equals(input as InstrumentIdTypeDescriptor);
        }

        /// <summary>
        /// Returns true if InstrumentIdTypeDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentIdTypeDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentIdTypeDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentifierType == input.IdentifierType ||
                    (this.IdentifierType != null &&
                    this.IdentifierType.Equals(input.IdentifierType))
                ) && 
                (
                    this.PropertyKey == input.PropertyKey ||
                    (this.PropertyKey != null &&
                    this.PropertyKey.Equals(input.PropertyKey))
                ) && 
                (
                    this.IsUniqueIdentifierType == input.IsUniqueIdentifierType ||
                    this.IsUniqueIdentifierType.Equals(input.IsUniqueIdentifierType)
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
                if (this.IdentifierType != null)
                    hashCode = hashCode * 59 + this.IdentifierType.GetHashCode();
                if (this.PropertyKey != null)
                    hashCode = hashCode * 59 + this.PropertyKey.GetHashCode();
                hashCode = hashCode * 59 + this.IsUniqueIdentifierType.GetHashCode();
                return hashCode;
            }
        }

    }
}
