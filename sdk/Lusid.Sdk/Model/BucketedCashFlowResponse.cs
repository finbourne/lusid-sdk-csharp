/*
 * LUSID API
 *
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
    /// BucketedCashFlowResponse
    /// </summary>
    [DataContract(Name = "BucketedCashFlowResponse")]
    public partial class BucketedCashFlowResponse : IEquatable<BucketedCashFlowResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucketedCashFlowResponse" /> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="data">List of dictionary bucketed cash flow result set.  Each dictionary represent a bucketed cashflow result set keyed by AddressKeys.  e.g. dictionary[\&quot;Valuation/CashFlowAmount\&quot;] for the aggregated cash flow amount for the bucket.  e.g. suppose \&quot;RoundUp\&quot; method, then dictionary[\&quot;Valuation/CashFlowDate/RoundUp\&quot;] returns the bucketed cashflow date..</param>
        /// <param name="reportCurrency">Three letter ISO currency string indicating what currency to report in for ReportCcy denominated queries.  If not present then the currency of the relevant portfolio will be used in its place where relevant..</param>
        /// <param name="dataSchema">dataSchema.</param>
        /// <param name="failed">Information about where instruments have failed to return cashflows in so far as it is available.  e.g., failure to retrieve a market quote for a floating rate instrument..</param>
        /// <param name="links">links.</param>
        public BucketedCashFlowResponse(string href = default(string), List<Dictionary<string, Object>> data = default(List<Dictionary<string, Object>>), string reportCurrency = default(string), ResultDataSchema dataSchema = default(ResultDataSchema), Dictionary<string, ErrorDetail> failed = default(Dictionary<string, ErrorDetail>), List<Link> links = default(List<Link>))
        {
            this.Href = href;
            this.Data = data;
            this.ReportCurrency = reportCurrency;
            this.DataSchema = dataSchema;
            this.Failed = failed;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// List of dictionary bucketed cash flow result set.  Each dictionary represent a bucketed cashflow result set keyed by AddressKeys.  e.g. dictionary[\&quot;Valuation/CashFlowAmount\&quot;] for the aggregated cash flow amount for the bucket.  e.g. suppose \&quot;RoundUp\&quot; method, then dictionary[\&quot;Valuation/CashFlowDate/RoundUp\&quot;] returns the bucketed cashflow date.
        /// </summary>
        /// <value>List of dictionary bucketed cash flow result set.  Each dictionary represent a bucketed cashflow result set keyed by AddressKeys.  e.g. dictionary[\&quot;Valuation/CashFlowAmount\&quot;] for the aggregated cash flow amount for the bucket.  e.g. suppose \&quot;RoundUp\&quot; method, then dictionary[\&quot;Valuation/CashFlowDate/RoundUp\&quot;] returns the bucketed cashflow date.</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<Dictionary<string, Object>> Data { get; set; }

        /// <summary>
        /// Three letter ISO currency string indicating what currency to report in for ReportCcy denominated queries.  If not present then the currency of the relevant portfolio will be used in its place where relevant.
        /// </summary>
        /// <value>Three letter ISO currency string indicating what currency to report in for ReportCcy denominated queries.  If not present then the currency of the relevant portfolio will be used in its place where relevant.</value>
        [DataMember(Name = "reportCurrency", EmitDefaultValue = true)]
        public string ReportCurrency { get; set; }

        /// <summary>
        /// Gets or Sets DataSchema
        /// </summary>
        [DataMember(Name = "dataSchema", EmitDefaultValue = false)]
        public ResultDataSchema DataSchema { get; set; }

        /// <summary>
        /// Information about where instruments have failed to return cashflows in so far as it is available.  e.g., failure to retrieve a market quote for a floating rate instrument.
        /// </summary>
        /// <value>Information about where instruments have failed to return cashflows in so far as it is available.  e.g., failure to retrieve a market quote for a floating rate instrument.</value>
        [DataMember(Name = "failed", EmitDefaultValue = true)]
        public Dictionary<string, ErrorDetail> Failed { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BucketedCashFlowResponse {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ReportCurrency: ").Append(ReportCurrency).Append("\n");
            sb.Append("  DataSchema: ").Append(DataSchema).Append("\n");
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
            return this.Equals(input as BucketedCashFlowResponse);
        }

        /// <summary>
        /// Returns true if BucketedCashFlowResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BucketedCashFlowResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BucketedCashFlowResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.ReportCurrency == input.ReportCurrency ||
                    (this.ReportCurrency != null &&
                    this.ReportCurrency.Equals(input.ReportCurrency))
                ) && 
                (
                    this.DataSchema == input.DataSchema ||
                    (this.DataSchema != null &&
                    this.DataSchema.Equals(input.DataSchema))
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
                if (this.Href != null)
                {
                    hashCode = (hashCode * 59) + this.Href.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.ReportCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.ReportCurrency.GetHashCode();
                }
                if (this.DataSchema != null)
                {
                    hashCode = (hashCode * 59) + this.DataSchema.GetHashCode();
                }
                if (this.Failed != null)
                {
                    hashCode = (hashCode * 59) + this.Failed.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
