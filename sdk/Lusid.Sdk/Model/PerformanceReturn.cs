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
    /// A list of Returns.
    /// </summary>
    [DataContract]
    public partial class PerformanceReturn :  IEquatable<PerformanceReturn>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReturn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PerformanceReturn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReturn" /> class.
        /// </summary>
        /// <param name="effectiveAt">The effectiveAt for the return. (required).</param>
        /// <param name="rateOfReturn">The return number. (required).</param>
        /// <param name="openingMarketValue">The opening market value..</param>
        /// <param name="closingMarketValue">The closing market value..</param>
        /// <param name="period">Show the returns on a Daily or Monthly period..</param>
        public PerformanceReturn(DateTimeOffset? effectiveAt = default(DateTimeOffset?), decimal? rateOfReturn = default(decimal?), decimal? openingMarketValue = default(decimal?), decimal? closingMarketValue = default(decimal?), string period = default(string))
        {
            // to ensure "effectiveAt" is required (not null)
            if (effectiveAt == null)
            {
                throw new InvalidDataException("effectiveAt is a required property for PerformanceReturn and cannot be null");
            }
            else
            {
                this.EffectiveAt = effectiveAt;
            }
            
            // to ensure "rateOfReturn" is required (not null)
            if (rateOfReturn == null)
            {
                throw new InvalidDataException("rateOfReturn is a required property for PerformanceReturn and cannot be null");
            }
            else
            {
                this.RateOfReturn = rateOfReturn;
            }
            
            this.OpeningMarketValue = openingMarketValue;
            this.ClosingMarketValue = closingMarketValue;
            this.Period = period;
            this.OpeningMarketValue = openingMarketValue;
            this.ClosingMarketValue = closingMarketValue;
            this.Period = period;
        }
        
        /// <summary>
        /// The effectiveAt for the return.
        /// </summary>
        /// <value>The effectiveAt for the return.</value>
        [DataMember(Name="effectiveAt", EmitDefaultValue=false)]
        public DateTimeOffset? EffectiveAt { get; set; }

        /// <summary>
        /// The return number.
        /// </summary>
        /// <value>The return number.</value>
        [DataMember(Name="rateOfReturn", EmitDefaultValue=false)]
        public decimal? RateOfReturn { get; set; }

        /// <summary>
        /// The opening market value.
        /// </summary>
        /// <value>The opening market value.</value>
        [DataMember(Name="openingMarketValue", EmitDefaultValue=true)]
        public decimal? OpeningMarketValue { get; set; }

        /// <summary>
        /// The closing market value.
        /// </summary>
        /// <value>The closing market value.</value>
        [DataMember(Name="closingMarketValue", EmitDefaultValue=true)]
        public decimal? ClosingMarketValue { get; set; }

        /// <summary>
        /// Show the returns on a Daily or Monthly period.
        /// </summary>
        /// <value>Show the returns on a Daily or Monthly period.</value>
        [DataMember(Name="period", EmitDefaultValue=true)]
        public string Period { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformanceReturn {\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  RateOfReturn: ").Append(RateOfReturn).Append("\n");
            sb.Append("  OpeningMarketValue: ").Append(OpeningMarketValue).Append("\n");
            sb.Append("  ClosingMarketValue: ").Append(ClosingMarketValue).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
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
            return this.Equals(input as PerformanceReturn);
        }

        /// <summary>
        /// Returns true if PerformanceReturn instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformanceReturn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceReturn input)
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
                    this.RateOfReturn == input.RateOfReturn ||
                    (this.RateOfReturn != null &&
                    this.RateOfReturn.Equals(input.RateOfReturn))
                ) && 
                (
                    this.OpeningMarketValue == input.OpeningMarketValue ||
                    (this.OpeningMarketValue != null &&
                    this.OpeningMarketValue.Equals(input.OpeningMarketValue))
                ) && 
                (
                    this.ClosingMarketValue == input.ClosingMarketValue ||
                    (this.ClosingMarketValue != null &&
                    this.ClosingMarketValue.Equals(input.ClosingMarketValue))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
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
                if (this.RateOfReturn != null)
                    hashCode = hashCode * 59 + this.RateOfReturn.GetHashCode();
                if (this.OpeningMarketValue != null)
                    hashCode = hashCode * 59 + this.OpeningMarketValue.GetHashCode();
                if (this.ClosingMarketValue != null)
                    hashCode = hashCode * 59 + this.ClosingMarketValue.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }

}
