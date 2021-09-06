/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3454
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
    /// Response from upserting Returns
    /// </summary>
    [DataContract(Name = "UpsertReturnsResponse")]
    public partial class UpsertReturnsResponse : IEquatable<UpsertReturnsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertReturnsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertReturnsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertReturnsResponse" /> class.
        /// </summary>
        /// <param name="version">version (required).</param>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="values">The set of values that were successfully retrieved..</param>
        /// <param name="failed">The set of values that could not be retrieved due along with a reason for this, e.g badly formed request..</param>
        /// <param name="links">Collection of links..</param>
        public UpsertReturnsResponse(Version version = default(Version), string href = default(string), List<Dictionary<string, DateTimeOffset>> values = default(List<Dictionary<string, DateTimeOffset>>), List<Dictionary<string, ErrorDetail>> failed = default(List<Dictionary<string, ErrorDetail>>), List<Link> links = default(List<Link>))
        {
            // to ensure "version" is required (not null)
            this.Version = version ?? throw new ArgumentNullException("version is a required property for UpsertReturnsResponse and cannot be null");
            this.Href = href;
            this.Values = values;
            this.Failed = failed;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public Version Version { get; set; }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// The set of values that were successfully retrieved.
        /// </summary>
        /// <value>The set of values that were successfully retrieved.</value>
        [DataMember(Name = "values", EmitDefaultValue = true)]
        public List<Dictionary<string, DateTimeOffset>> Values { get; set; }

        /// <summary>
        /// The set of values that could not be retrieved due along with a reason for this, e.g badly formed request.
        /// </summary>
        /// <value>The set of values that could not be retrieved due along with a reason for this, e.g badly formed request.</value>
        [DataMember(Name = "failed", EmitDefaultValue = true)]
        public List<Dictionary<string, ErrorDetail>> Failed { get; set; }

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
            sb.Append("class UpsertReturnsResponse {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
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
            return this.Equals(input as UpsertReturnsResponse);
        }

        /// <summary>
        /// Returns true if UpsertReturnsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertReturnsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertReturnsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Failed == input.Failed ||
                    this.Failed != null &&
                    input.Failed != null &&
                    this.Failed.SequenceEqual(input.Failed)
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
