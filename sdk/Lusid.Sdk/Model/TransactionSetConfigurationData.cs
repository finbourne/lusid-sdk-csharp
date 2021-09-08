/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3464
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
    /// A collection of the data required to configure transaction types..
    /// </summary>
    [DataContract(Name = "TransactionSetConfigurationData")]
    public partial class TransactionSetConfigurationData : IEquatable<TransactionSetConfigurationData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSetConfigurationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionSetConfigurationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSetConfigurationData" /> class.
        /// </summary>
        /// <param name="transactionConfigs">Collection of transaction type models (required).</param>
        /// <param name="sideDefinitions">Collection of side definitions.</param>
        /// <param name="links">Collection of links..</param>
        public TransactionSetConfigurationData(List<TransactionConfigurationData> transactionConfigs = default(List<TransactionConfigurationData>), List<SideConfigurationData> sideDefinitions = default(List<SideConfigurationData>), List<Link> links = default(List<Link>))
        {
            // to ensure "transactionConfigs" is required (not null)
            this.TransactionConfigs = transactionConfigs ?? throw new ArgumentNullException("transactionConfigs is a required property for TransactionSetConfigurationData and cannot be null");
            this.SideDefinitions = sideDefinitions;
            this.Links = links;
        }

        /// <summary>
        /// Collection of transaction type models
        /// </summary>
        /// <value>Collection of transaction type models</value>
        [DataMember(Name = "transactionConfigs", IsRequired = true, EmitDefaultValue = false)]
        public List<TransactionConfigurationData> TransactionConfigs { get; set; }

        /// <summary>
        /// Collection of side definitions
        /// </summary>
        /// <value>Collection of side definitions</value>
        [DataMember(Name = "sideDefinitions", EmitDefaultValue = true)]
        public List<SideConfigurationData> SideDefinitions { get; set; }

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
            sb.Append("class TransactionSetConfigurationData {\n");
            sb.Append("  TransactionConfigs: ").Append(TransactionConfigs).Append("\n");
            sb.Append("  SideDefinitions: ").Append(SideDefinitions).Append("\n");
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
            return this.Equals(input as TransactionSetConfigurationData);
        }

        /// <summary>
        /// Returns true if TransactionSetConfigurationData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionSetConfigurationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionSetConfigurationData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionConfigs == input.TransactionConfigs ||
                    this.TransactionConfigs != null &&
                    input.TransactionConfigs != null &&
                    this.TransactionConfigs.SequenceEqual(input.TransactionConfigs)
                ) && 
                (
                    this.SideDefinitions == input.SideDefinitions ||
                    this.SideDefinitions != null &&
                    input.SideDefinitions != null &&
                    this.SideDefinitions.SequenceEqual(input.SideDefinitions)
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
                if (this.TransactionConfigs != null)
                    hashCode = hashCode * 59 + this.TransactionConfigs.GetHashCode();
                if (this.SideDefinitions != null)
                    hashCode = hashCode * 59 + this.SideDefinitions.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
