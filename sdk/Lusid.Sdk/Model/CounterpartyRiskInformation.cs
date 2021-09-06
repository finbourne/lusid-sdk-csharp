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
    /// In the event that the legal entity is a counterparty to an OTC transaction  (as signatory to a counterparty agreement such as an ISDA 2002 Master Agreement),  this information would be needed for calculations  such as Credit-Valuation-Adjustments and Debit-Valuation-Adjustments (CVA, DVA, XVA etc).
    /// </summary>
    [DataContract(Name = "CounterpartyRiskInformation")]
    public partial class CounterpartyRiskInformation : IEquatable<CounterpartyRiskInformation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterpartyRiskInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CounterpartyRiskInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterpartyRiskInformation" /> class.
        /// </summary>
        /// <param name="countryOfRisk">The country to which one would naturally ascribe risk, typically the legal entity&#39;s country of registration. This can be used to infer funding currency and related market data in the absence of a specific preference. (required).</param>
        /// <param name="creditRatings">creditRatings (required).</param>
        /// <param name="industryClassifiers">industryClassifiers (required).</param>
        public CounterpartyRiskInformation(string countryOfRisk = default(string), List<CreditRating> creditRatings = default(List<CreditRating>), List<IndustryClassifier> industryClassifiers = default(List<IndustryClassifier>))
        {
            // to ensure "countryOfRisk" is required (not null)
            this.CountryOfRisk = countryOfRisk ?? throw new ArgumentNullException("countryOfRisk is a required property for CounterpartyRiskInformation and cannot be null");
            // to ensure "creditRatings" is required (not null)
            this.CreditRatings = creditRatings ?? throw new ArgumentNullException("creditRatings is a required property for CounterpartyRiskInformation and cannot be null");
            // to ensure "industryClassifiers" is required (not null)
            this.IndustryClassifiers = industryClassifiers ?? throw new ArgumentNullException("industryClassifiers is a required property for CounterpartyRiskInformation and cannot be null");
        }

        /// <summary>
        /// The country to which one would naturally ascribe risk, typically the legal entity&#39;s country of registration. This can be used to infer funding currency and related market data in the absence of a specific preference.
        /// </summary>
        /// <value>The country to which one would naturally ascribe risk, typically the legal entity&#39;s country of registration. This can be used to infer funding currency and related market data in the absence of a specific preference.</value>
        [DataMember(Name = "countryOfRisk", IsRequired = true, EmitDefaultValue = false)]
        public string CountryOfRisk { get; set; }

        /// <summary>
        /// Gets or Sets CreditRatings
        /// </summary>
        [DataMember(Name = "creditRatings", IsRequired = true, EmitDefaultValue = false)]
        public List<CreditRating> CreditRatings { get; set; }

        /// <summary>
        /// Gets or Sets IndustryClassifiers
        /// </summary>
        [DataMember(Name = "industryClassifiers", IsRequired = true, EmitDefaultValue = false)]
        public List<IndustryClassifier> IndustryClassifiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CounterpartyRiskInformation {\n");
            sb.Append("  CountryOfRisk: ").Append(CountryOfRisk).Append("\n");
            sb.Append("  CreditRatings: ").Append(CreditRatings).Append("\n");
            sb.Append("  IndustryClassifiers: ").Append(IndustryClassifiers).Append("\n");
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
            return this.Equals(input as CounterpartyRiskInformation);
        }

        /// <summary>
        /// Returns true if CounterpartyRiskInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of CounterpartyRiskInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CounterpartyRiskInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryOfRisk == input.CountryOfRisk ||
                    (this.CountryOfRisk != null &&
                    this.CountryOfRisk.Equals(input.CountryOfRisk))
                ) && 
                (
                    this.CreditRatings == input.CreditRatings ||
                    this.CreditRatings != null &&
                    input.CreditRatings != null &&
                    this.CreditRatings.SequenceEqual(input.CreditRatings)
                ) && 
                (
                    this.IndustryClassifiers == input.IndustryClassifiers ||
                    this.IndustryClassifiers != null &&
                    input.IndustryClassifiers != null &&
                    this.IndustryClassifiers.SequenceEqual(input.IndustryClassifiers)
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
                if (this.CountryOfRisk != null)
                    hashCode = hashCode * 59 + this.CountryOfRisk.GetHashCode();
                if (this.CreditRatings != null)
                    hashCode = hashCode * 59 + this.CreditRatings.GetHashCode();
                if (this.IndustryClassifiers != null)
                    hashCode = hashCode * 59 + this.IndustryClassifiers.GetHashCode();
                return hashCode;
            }
        }

    }
}
