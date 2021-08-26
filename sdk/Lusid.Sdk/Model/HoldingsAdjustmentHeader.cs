/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3435
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
    /// A record of holdings adjustments made on the transaction portfolio.
    /// </summary>
    [DataContract]
    public partial class HoldingsAdjustmentHeader :  IEquatable<HoldingsAdjustmentHeader>
    {
        /// <summary>
        /// Describes how the holdings were adjusted. If &#39;PositionToZero&#39; the entire transaction portfolio&#39;s holdings were set via a call to &#39;Set holdings&#39;. If &#39;KeepTheSame&#39; only the specified holdings were adjusted via a call to &#39;Adjust holdings&#39;. The available values are: PositionToZero, KeepTheSame
        /// </summary>
        /// <value>Describes how the holdings were adjusted. If &#39;PositionToZero&#39; the entire transaction portfolio&#39;s holdings were set via a call to &#39;Set holdings&#39;. If &#39;KeepTheSame&#39; only the specified holdings were adjusted via a call to &#39;Adjust holdings&#39;. The available values are: PositionToZero, KeepTheSame</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnmatchedHoldingMethodEnum
        {
            /// <summary>
            /// Enum PositionToZero for value: PositionToZero
            /// </summary>
            [EnumMember(Value = "PositionToZero")]
            PositionToZero = 1,

            /// <summary>
            /// Enum KeepTheSame for value: KeepTheSame
            /// </summary>
            [EnumMember(Value = "KeepTheSame")]
            KeepTheSame = 2

        }

        /// <summary>
        /// Describes how the holdings were adjusted. If &#39;PositionToZero&#39; the entire transaction portfolio&#39;s holdings were set via a call to &#39;Set holdings&#39;. If &#39;KeepTheSame&#39; only the specified holdings were adjusted via a call to &#39;Adjust holdings&#39;. The available values are: PositionToZero, KeepTheSame
        /// </summary>
        /// <value>Describes how the holdings were adjusted. If &#39;PositionToZero&#39; the entire transaction portfolio&#39;s holdings were set via a call to &#39;Set holdings&#39;. If &#39;KeepTheSame&#39; only the specified holdings were adjusted via a call to &#39;Adjust holdings&#39;. The available values are: PositionToZero, KeepTheSame</value>
        [DataMember(Name="unmatchedHoldingMethod", EmitDefaultValue=false)]
        public UnmatchedHoldingMethodEnum UnmatchedHoldingMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingsAdjustmentHeader" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HoldingsAdjustmentHeader() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingsAdjustmentHeader" /> class.
        /// </summary>
        /// <param name="effectiveAt">The effective datetime from which the adjustment is valid. There can only be one holdings adjustment for a transaction portfolio at a specific effective datetime, so this uniquely identifies the adjustment. (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="unmatchedHoldingMethod">Describes how the holdings were adjusted. If &#39;PositionToZero&#39; the entire transaction portfolio&#39;s holdings were set via a call to &#39;Set holdings&#39;. If &#39;KeepTheSame&#39; only the specified holdings were adjusted via a call to &#39;Adjust holdings&#39;. The available values are: PositionToZero, KeepTheSame (required).</param>
        /// <param name="links">Collection of links..</param>
        public HoldingsAdjustmentHeader(DateTimeOffset? effectiveAt = default(DateTimeOffset?), Version version = default(Version), UnmatchedHoldingMethodEnum unmatchedHoldingMethod = default(UnmatchedHoldingMethodEnum), List<Link> links = default(List<Link>))
        {
            // to ensure "effectiveAt" is required (not null)
            if (effectiveAt == null)
            {
                throw new InvalidDataException("effectiveAt is a required property for HoldingsAdjustmentHeader and cannot be null");
            }
            else
            {
                this.EffectiveAt = effectiveAt;
            }
            
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for HoldingsAdjustmentHeader and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            
            // to ensure "unmatchedHoldingMethod" is required (not null)
            if (unmatchedHoldingMethod == null)
            {
                throw new InvalidDataException("unmatchedHoldingMethod is a required property for HoldingsAdjustmentHeader and cannot be null");
            }
            else
            {
                this.UnmatchedHoldingMethod = unmatchedHoldingMethod;
            }
            
            this.Links = links;
            this.Links = links;
        }
        
        /// <summary>
        /// The effective datetime from which the adjustment is valid. There can only be one holdings adjustment for a transaction portfolio at a specific effective datetime, so this uniquely identifies the adjustment.
        /// </summary>
        /// <value>The effective datetime from which the adjustment is valid. There can only be one holdings adjustment for a transaction portfolio at a specific effective datetime, so this uniquely identifies the adjustment.</value>
        [DataMember(Name="effectiveAt", EmitDefaultValue=false)]
        public DateTimeOffset? EffectiveAt { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }


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
            sb.Append("class HoldingsAdjustmentHeader {\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  UnmatchedHoldingMethod: ").Append(UnmatchedHoldingMethod).Append("\n");
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
            return this.Equals(input as HoldingsAdjustmentHeader);
        }

        /// <summary>
        /// Returns true if HoldingsAdjustmentHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of HoldingsAdjustmentHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HoldingsAdjustmentHeader input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.UnmatchedHoldingMethod == input.UnmatchedHoldingMethod ||
                    (this.UnmatchedHoldingMethod != null &&
                    this.UnmatchedHoldingMethod.Equals(input.UnmatchedHoldingMethod))
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
                if (this.EffectiveAt != null)
                    hashCode = hashCode * 59 + this.EffectiveAt.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.UnmatchedHoldingMethod != null)
                    hashCode = hashCode * 59 + this.UnmatchedHoldingMethod.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
