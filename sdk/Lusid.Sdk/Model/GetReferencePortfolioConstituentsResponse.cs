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
    /// GetReferencePortfolioConstituentsResponse
    /// </summary>
    [DataContract]
    public partial class GetReferencePortfolioConstituentsResponse :  IEquatable<GetReferencePortfolioConstituentsResponse>
    {
        /// <summary>
        /// The available values are: Static, Floating, Periodical
        /// </summary>
        /// <value>The available values are: Static, Floating, Periodical</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WeightTypeEnum
        {
            /// <summary>
            /// Enum Static for value: Static
            /// </summary>
            [EnumMember(Value = "Static")]
            Static = 1,

            /// <summary>
            /// Enum Floating for value: Floating
            /// </summary>
            [EnumMember(Value = "Floating")]
            Floating = 2,

            /// <summary>
            /// Enum Periodical for value: Periodical
            /// </summary>
            [EnumMember(Value = "Periodical")]
            Periodical = 3

        }

        /// <summary>
        /// The available values are: Static, Floating, Periodical
        /// </summary>
        /// <value>The available values are: Static, Floating, Periodical</value>
        [DataMember(Name="weightType", EmitDefaultValue=false)]
        public WeightTypeEnum WeightType { get; set; }
        /// <summary>
        /// The available values are: Daily, Weekly, Monthly, Quarterly, Annually
        /// </summary>
        /// <value>The available values are: Daily, Weekly, Monthly, Quarterly, Annually</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodTypeEnum
        {
            /// <summary>
            /// Enum Daily for value: Daily
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum Monthly for value: Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly = 3,

            /// <summary>
            /// Enum Quarterly for value: Quarterly
            /// </summary>
            [EnumMember(Value = "Quarterly")]
            Quarterly = 4,

            /// <summary>
            /// Enum Annually for value: Annually
            /// </summary>
            [EnumMember(Value = "Annually")]
            Annually = 5

        }

        /// <summary>
        /// The available values are: Daily, Weekly, Monthly, Quarterly, Annually
        /// </summary>
        /// <value>The available values are: Daily, Weekly, Monthly, Quarterly, Annually</value>
        [DataMember(Name="periodType", EmitDefaultValue=true)]
        public PeriodTypeEnum? PeriodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReferencePortfolioConstituentsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetReferencePortfolioConstituentsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReferencePortfolioConstituentsResponse" /> class.
        /// </summary>
        /// <param name="effectiveFrom">effectiveFrom (required).</param>
        /// <param name="weightType">The available values are: Static, Floating, Periodical (required).</param>
        /// <param name="periodType">The available values are: Daily, Weekly, Monthly, Quarterly, Annually.</param>
        /// <param name="periodCount">periodCount.</param>
        /// <param name="constituents">Set of constituents (instrument/weight pairings) (required).</param>
        /// <param name="href">The Uri that returns the same result as the original request,  but may include resolved as at time(s)..</param>
        /// <param name="links">Collection of links..</param>
        public GetReferencePortfolioConstituentsResponse(DateTimeOffset? effectiveFrom = default(DateTimeOffset?), WeightTypeEnum weightType = default(WeightTypeEnum), PeriodTypeEnum? periodType = default(PeriodTypeEnum?), int? periodCount = default(int?), List<ReferencePortfolioConstituent> constituents = default(List<ReferencePortfolioConstituent>), string href = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "effectiveFrom" is required (not null)
            if (effectiveFrom == null)
            {
                throw new InvalidDataException("effectiveFrom is a required property for GetReferencePortfolioConstituentsResponse and cannot be null");
            }
            else
            {
                this.EffectiveFrom = effectiveFrom;
            }
            
            // to ensure "weightType" is required (not null)
            if (weightType == null)
            {
                throw new InvalidDataException("weightType is a required property for GetReferencePortfolioConstituentsResponse and cannot be null");
            }
            else
            {
                this.WeightType = weightType;
            }
            
            this.PeriodType = periodType;
            this.PeriodCount = periodCount;
            // to ensure "constituents" is required (not null)
            if (constituents == null)
            {
                throw new InvalidDataException("constituents is a required property for GetReferencePortfolioConstituentsResponse and cannot be null");
            }
            else
            {
                this.Constituents = constituents;
            }
            
            this.Href = href;
            this.Links = links;
            this.PeriodType = periodType;
            this.PeriodCount = periodCount;
            this.Href = href;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets EffectiveFrom
        /// </summary>
        [DataMember(Name="effectiveFrom", EmitDefaultValue=false)]
        public DateTimeOffset? EffectiveFrom { get; set; }



        /// <summary>
        /// Gets or Sets PeriodCount
        /// </summary>
        [DataMember(Name="periodCount", EmitDefaultValue=true)]
        public int? PeriodCount { get; set; }

        /// <summary>
        /// Set of constituents (instrument/weight pairings)
        /// </summary>
        /// <value>Set of constituents (instrument/weight pairings)</value>
        [DataMember(Name="constituents", EmitDefaultValue=false)]
        public List<ReferencePortfolioConstituent> Constituents { get; set; }

        /// <summary>
        /// The Uri that returns the same result as the original request,  but may include resolved as at time(s).
        /// </summary>
        /// <value>The Uri that returns the same result as the original request,  but may include resolved as at time(s).</value>
        [DataMember(Name="href", EmitDefaultValue=true)]
        public string Href { get; set; }

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
            sb.Append("class GetReferencePortfolioConstituentsResponse {\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
            sb.Append("  WeightType: ").Append(WeightType).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  PeriodCount: ").Append(PeriodCount).Append("\n");
            sb.Append("  Constituents: ").Append(Constituents).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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
            return this.Equals(input as GetReferencePortfolioConstituentsResponse);
        }

        /// <summary>
        /// Returns true if GetReferencePortfolioConstituentsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetReferencePortfolioConstituentsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetReferencePortfolioConstituentsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EffectiveFrom == input.EffectiveFrom ||
                    (this.EffectiveFrom != null &&
                    this.EffectiveFrom.Equals(input.EffectiveFrom))
                ) && 
                (
                    this.WeightType == input.WeightType ||
                    (this.WeightType != null &&
                    this.WeightType.Equals(input.WeightType))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PeriodCount == input.PeriodCount ||
                    (this.PeriodCount != null &&
                    this.PeriodCount.Equals(input.PeriodCount))
                ) && 
                (
                    this.Constituents == input.Constituents ||
                    this.Constituents != null &&
                    input.Constituents != null &&
                    this.Constituents.SequenceEqual(input.Constituents)
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
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
                if (this.EffectiveFrom != null)
                    hashCode = hashCode * 59 + this.EffectiveFrom.GetHashCode();
                if (this.WeightType != null)
                    hashCode = hashCode * 59 + this.WeightType.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodCount != null)
                    hashCode = hashCode * 59 + this.PeriodCount.GetHashCode();
                if (this.Constituents != null)
                    hashCode = hashCode * 59 + this.Constituents.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
