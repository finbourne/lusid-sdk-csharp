/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3476
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
    /// The list of commands.
    /// </summary>
    [DataContract(Name = "ProcessedCommand")]
    public partial class ProcessedCommand : IEquatable<ProcessedCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessedCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProcessedCommand() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessedCommand" /> class.
        /// </summary>
        /// <param name="description">The description of the command issued. (required).</param>
        /// <param name="path">The unique identifier for the command including the request id..</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="processedTime">The asAt datetime that the events published by the processing of this command were committed to LUSID. (required).</param>
        public ProcessedCommand(string description = default(string), string path = default(string), User userId = default(User), DateTimeOffset processedTime = default(DateTimeOffset))
        {
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for ProcessedCommand and cannot be null");
            // to ensure "userId" is required (not null)
            this.UserId = userId ?? throw new ArgumentNullException("userId is a required property for ProcessedCommand and cannot be null");
            this.ProcessedTime = processedTime;
            this.Path = path;
        }

        /// <summary>
        /// The description of the command issued.
        /// </summary>
        /// <value>The description of the command issued.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier for the command including the request id.
        /// </summary>
        /// <value>The unique identifier for the command including the request id.</value>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public User UserId { get; set; }

        /// <summary>
        /// The asAt datetime that the events published by the processing of this command were committed to LUSID.
        /// </summary>
        /// <value>The asAt datetime that the events published by the processing of this command were committed to LUSID.</value>
        [DataMember(Name = "processedTime", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset ProcessedTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessedCommand {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ProcessedTime: ").Append(ProcessedTime).Append("\n");
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
            return this.Equals(input as ProcessedCommand);
        }

        /// <summary>
        /// Returns true if ProcessedCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessedCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessedCommand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ProcessedTime == input.ProcessedTime ||
                    (this.ProcessedTime != null &&
                    this.ProcessedTime.Equals(input.ProcessedTime))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ProcessedTime != null)
                    hashCode = hashCode * 59 + this.ProcessedTime.GetHashCode();
                return hashCode;
            }
        }

    }
}
