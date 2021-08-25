/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3429
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
    /// TransactionConfigurationDataRequest
    /// </summary>
    [DataContract]
    public partial class TransactionConfigurationDataRequest :  IEquatable<TransactionConfigurationDataRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationDataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionConfigurationDataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationDataRequest" /> class.
        /// </summary>
        /// <param name="aliases">List of transaction codes that map to this specific transaction model (required).</param>
        /// <param name="movements">Movement data for the transaction code (required).</param>
        /// <param name="properties">Properties attached to the underlying holding..</param>
        public TransactionConfigurationDataRequest(List<TransactionConfigurationTypeAlias> aliases = default(List<TransactionConfigurationTypeAlias>), List<TransactionConfigurationMovementDataRequest> movements = default(List<TransactionConfigurationMovementDataRequest>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>))
        {
            // to ensure "aliases" is required (not null)
            if (aliases == null)
            {
                throw new InvalidDataException("aliases is a required property for TransactionConfigurationDataRequest and cannot be null");
            }
            else
            {
                this.Aliases = aliases;
            }
            
            // to ensure "movements" is required (not null)
            if (movements == null)
            {
                throw new InvalidDataException("movements is a required property for TransactionConfigurationDataRequest and cannot be null");
            }
            else
            {
                this.Movements = movements;
            }
            
            this.Properties = properties;
            this.Properties = properties;
        }
        
        /// <summary>
        /// List of transaction codes that map to this specific transaction model
        /// </summary>
        /// <value>List of transaction codes that map to this specific transaction model</value>
        [DataMember(Name="aliases", EmitDefaultValue=false)]
        public List<TransactionConfigurationTypeAlias> Aliases { get; set; }

        /// <summary>
        /// Movement data for the transaction code
        /// </summary>
        /// <value>Movement data for the transaction code</value>
        [DataMember(Name="movements", EmitDefaultValue=false)]
        public List<TransactionConfigurationMovementDataRequest> Movements { get; set; }

        /// <summary>
        /// Properties attached to the underlying holding.
        /// </summary>
        /// <value>Properties attached to the underlying holding.</value>
        [DataMember(Name="properties", EmitDefaultValue=true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionConfigurationDataRequest {\n");
            sb.Append("  Aliases: ").Append(Aliases).Append("\n");
            sb.Append("  Movements: ").Append(Movements).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as TransactionConfigurationDataRequest);
        }

        /// <summary>
        /// Returns true if TransactionConfigurationDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionConfigurationDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionConfigurationDataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aliases == input.Aliases ||
                    this.Aliases != null &&
                    input.Aliases != null &&
                    this.Aliases.SequenceEqual(input.Aliases)
                ) && 
                (
                    this.Movements == input.Movements ||
                    this.Movements != null &&
                    input.Movements != null &&
                    this.Movements.SequenceEqual(input.Movements)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.Aliases != null)
                    hashCode = hashCode * 59 + this.Aliases.GetHashCode();
                if (this.Movements != null)
                    hashCode = hashCode * 59 + this.Movements.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                return hashCode;
            }
        }
    }

}
