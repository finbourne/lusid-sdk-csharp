/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3419
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
    /// Object describing a credit rating,  which assesses the stability and credit worthiness of a legal entity  and hence its likelihood of defaulting on its outstanding obligations (typically debt).
    /// </summary>
    [DataContract]
    public partial class CreditRating :  IEquatable<CreditRating>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditRating" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditRating() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditRating" /> class.
        /// </summary>
        /// <param name="ratingSource">The provider of the credit rating, which will typically be an agency such as Moody&#39;s or Standard and Poor. (required).</param>
        /// <param name="rating">The credit rating provided by the rating source. This would expected to be consistent with the rating scheme of that agency/source. (required).</param>
        public CreditRating(string ratingSource = default(string), string rating = default(string))
        {
            // to ensure "ratingSource" is required (not null)
            if (ratingSource == null)
            {
                throw new InvalidDataException("ratingSource is a required property for CreditRating and cannot be null");
            }
            else
            {
                this.RatingSource = ratingSource;
            }
            
            // to ensure "rating" is required (not null)
            if (rating == null)
            {
                throw new InvalidDataException("rating is a required property for CreditRating and cannot be null");
            }
            else
            {
                this.Rating = rating;
            }
            
        }
        
        /// <summary>
        /// The provider of the credit rating, which will typically be an agency such as Moody&#39;s or Standard and Poor.
        /// </summary>
        /// <value>The provider of the credit rating, which will typically be an agency such as Moody&#39;s or Standard and Poor.</value>
        [DataMember(Name="ratingSource", EmitDefaultValue=false)]
        public string RatingSource { get; set; }

        /// <summary>
        /// The credit rating provided by the rating source. This would expected to be consistent with the rating scheme of that agency/source.
        /// </summary>
        /// <value>The credit rating provided by the rating source. This would expected to be consistent with the rating scheme of that agency/source.</value>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public string Rating { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditRating {\n");
            sb.Append("  RatingSource: ").Append(RatingSource).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
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
            return this.Equals(input as CreditRating);
        }

        /// <summary>
        /// Returns true if CreditRating instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditRating to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditRating input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RatingSource == input.RatingSource ||
                    (this.RatingSource != null &&
                    this.RatingSource.Equals(input.RatingSource))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
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
                if (this.RatingSource != null)
                    hashCode = hashCode * 59 + this.RatingSource.GetHashCode();
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                return hashCode;
            }
        }
    }

}
