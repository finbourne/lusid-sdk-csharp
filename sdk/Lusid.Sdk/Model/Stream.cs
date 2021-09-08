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
    /// Stream
    /// </summary>
    [DataContract(Name = "Stream")]
    public partial class Stream : IEquatable<Stream>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stream" /> class.
        /// </summary>
        /// <param name="position">position.</param>
        /// <param name="readTimeout">readTimeout.</param>
        /// <param name="writeTimeout">writeTimeout.</param>
        public Stream(long position = default(long), int readTimeout = default(int), int writeTimeout = default(int))
        {
            this.Position = position;
            this.ReadTimeout = readTimeout;
            this.WriteTimeout = writeTimeout;
        }

        /// <summary>
        /// Gets or Sets CanRead
        /// </summary>
        [DataMember(Name = "canRead", EmitDefaultValue = true)]
        public bool CanRead { get; private set; }

        /// <summary>
        /// Returns false as CanRead should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCanRead()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets CanSeek
        /// </summary>
        [DataMember(Name = "canSeek", EmitDefaultValue = true)]
        public bool CanSeek { get; private set; }

        /// <summary>
        /// Returns false as CanSeek should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCanSeek()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets CanTimeout
        /// </summary>
        [DataMember(Name = "canTimeout", EmitDefaultValue = true)]
        public bool CanTimeout { get; private set; }

        /// <summary>
        /// Returns false as CanTimeout should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCanTimeout()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets CanWrite
        /// </summary>
        [DataMember(Name = "canWrite", EmitDefaultValue = true)]
        public bool CanWrite { get; private set; }

        /// <summary>
        /// Returns false as CanWrite should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCanWrite()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name = "length", EmitDefaultValue = false)]
        public long Length { get; private set; }

        /// <summary>
        /// Returns false as Length should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLength()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public long Position { get; set; }

        /// <summary>
        /// Gets or Sets ReadTimeout
        /// </summary>
        [DataMember(Name = "readTimeout", EmitDefaultValue = true)]
        public int ReadTimeout { get; set; }

        /// <summary>
        /// Gets or Sets WriteTimeout
        /// </summary>
        [DataMember(Name = "writeTimeout", EmitDefaultValue = true)]
        public int WriteTimeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Stream {\n");
            sb.Append("  CanRead: ").Append(CanRead).Append("\n");
            sb.Append("  CanSeek: ").Append(CanSeek).Append("\n");
            sb.Append("  CanTimeout: ").Append(CanTimeout).Append("\n");
            sb.Append("  CanWrite: ").Append(CanWrite).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ReadTimeout: ").Append(ReadTimeout).Append("\n");
            sb.Append("  WriteTimeout: ").Append(WriteTimeout).Append("\n");
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
            return this.Equals(input as Stream);
        }

        /// <summary>
        /// Returns true if Stream instances are equal
        /// </summary>
        /// <param name="input">Instance of Stream to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stream input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanRead == input.CanRead ||
                    this.CanRead.Equals(input.CanRead)
                ) && 
                (
                    this.CanSeek == input.CanSeek ||
                    this.CanSeek.Equals(input.CanSeek)
                ) && 
                (
                    this.CanTimeout == input.CanTimeout ||
                    this.CanTimeout.Equals(input.CanTimeout)
                ) && 
                (
                    this.CanWrite == input.CanWrite ||
                    this.CanWrite.Equals(input.CanWrite)
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.ReadTimeout == input.ReadTimeout ||
                    this.ReadTimeout.Equals(input.ReadTimeout)
                ) && 
                (
                    this.WriteTimeout == input.WriteTimeout ||
                    this.WriteTimeout.Equals(input.WriteTimeout)
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
                hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                hashCode = hashCode * 59 + this.CanSeek.GetHashCode();
                hashCode = hashCode * 59 + this.CanTimeout.GetHashCode();
                hashCode = hashCode * 59 + this.CanWrite.GetHashCode();
                hashCode = hashCode * 59 + this.Length.GetHashCode();
                hashCode = hashCode * 59 + this.Position.GetHashCode();
                hashCode = hashCode * 59 + this.ReadTimeout.GetHashCode();
                hashCode = hashCode * 59 + this.WriteTimeout.GetHashCode();
                return hashCode;
            }
        }

    }
}
