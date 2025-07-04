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
    /// TransferAgencyDates
    /// </summary>
    [DataContract(Name = "TransferAgencyDates")]
    public partial class TransferAgencyDates : IEquatable<TransferAgencyDates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAgencyDates" /> class.
        /// </summary>
        /// <param name="priceDate">The date at which the fund is priced, for the order received on ReceivedDate. Can be passed into the request instead of the ReceivedDate to calculate the TransactionDate and ExpectedPaymentDate. If both the received date and price date are given, a failure is returned..</param>
        /// <param name="transactionDate">The date at which the transaction into or out of the fund is made..</param>
        /// <param name="expectedPaymentDate">The date by which the cash is expected to be paid to or from the fund..</param>
        /// <param name="links">links.</param>
        public TransferAgencyDates(DateTimeOffset priceDate = default(DateTimeOffset), DateTimeOffset transactionDate = default(DateTimeOffset), DateTimeOffset expectedPaymentDate = default(DateTimeOffset), List<Link> links = default(List<Link>))
        {
            this.PriceDate = priceDate;
            this.TransactionDate = transactionDate;
            this.ExpectedPaymentDate = expectedPaymentDate;
            this.Links = links;
        }

        /// <summary>
        /// The date at which the fund is priced, for the order received on ReceivedDate. Can be passed into the request instead of the ReceivedDate to calculate the TransactionDate and ExpectedPaymentDate. If both the received date and price date are given, a failure is returned.
        /// </summary>
        /// <value>The date at which the fund is priced, for the order received on ReceivedDate. Can be passed into the request instead of the ReceivedDate to calculate the TransactionDate and ExpectedPaymentDate. If both the received date and price date are given, a failure is returned.</value>
        [DataMember(Name = "priceDate", EmitDefaultValue = false)]
        public DateTimeOffset PriceDate { get; set; }

        /// <summary>
        /// The date at which the transaction into or out of the fund is made.
        /// </summary>
        /// <value>The date at which the transaction into or out of the fund is made.</value>
        [DataMember(Name = "transactionDate", EmitDefaultValue = false)]
        public DateTimeOffset TransactionDate { get; set; }

        /// <summary>
        /// The date by which the cash is expected to be paid to or from the fund.
        /// </summary>
        /// <value>The date by which the cash is expected to be paid to or from the fund.</value>
        [DataMember(Name = "expectedPaymentDate", EmitDefaultValue = false)]
        public DateTimeOffset ExpectedPaymentDate { get; set; }

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
            sb.Append("class TransferAgencyDates {\n");
            sb.Append("  PriceDate: ").Append(PriceDate).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  ExpectedPaymentDate: ").Append(ExpectedPaymentDate).Append("\n");
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
            return this.Equals(input as TransferAgencyDates);
        }

        /// <summary>
        /// Returns true if TransferAgencyDates instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferAgencyDates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferAgencyDates input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PriceDate == input.PriceDate ||
                    (this.PriceDate != null &&
                    this.PriceDate.Equals(input.PriceDate))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.ExpectedPaymentDate == input.ExpectedPaymentDate ||
                    (this.ExpectedPaymentDate != null &&
                    this.ExpectedPaymentDate.Equals(input.ExpectedPaymentDate))
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
                if (this.PriceDate != null)
                {
                    hashCode = (hashCode * 59) + this.PriceDate.GetHashCode();
                }
                if (this.TransactionDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionDate.GetHashCode();
                }
                if (this.ExpectedPaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedPaymentDate.GetHashCode();
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
