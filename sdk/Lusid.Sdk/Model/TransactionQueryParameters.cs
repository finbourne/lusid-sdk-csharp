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
    /// TransactionQueryParameters
    /// </summary>
    [DataContract(Name = "TransactionQueryParameters")]
    public partial class TransactionQueryParameters : IEquatable<TransactionQueryParameters>, IValidatableObject
    {
        /// <summary>
        /// The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate
        /// </summary>
        /// <value>The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QueryModeEnum
        {
            /// <summary>
            /// Enum TradeDate for value: TradeDate
            /// </summary>
            [EnumMember(Value = "TradeDate")]
            TradeDate = 1,

            /// <summary>
            /// Enum SettleDate for value: SettleDate
            /// </summary>
            [EnumMember(Value = "SettleDate")]
            SettleDate = 2
        }


        /// <summary>
        /// The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate
        /// </summary>
        /// <value>The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate</value>
        [DataMember(Name = "queryMode", EmitDefaultValue = false)]
        public QueryModeEnum? QueryMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionQueryParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionQueryParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionQueryParameters" /> class.
        /// </summary>
        /// <param name="startDate">The lower bound effective datetime or cut label (inclusive) from which to build the transactions. (required).</param>
        /// <param name="endDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions. (required).</param>
        /// <param name="queryMode">The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate.</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions in the output. Defaults to False if not specified..</param>
        public TransactionQueryParameters(DateTimeOrCutLabel startDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel endDate = default(DateTimeOrCutLabel), QueryModeEnum ?queryMode = default(QueryModeEnum?), bool showCancelledTransactions = default(bool))
        {
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new ArgumentNullException("startDate is a required property for TransactionQueryParameters and cannot be null");
            }
            this.StartDate = startDate;
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new ArgumentNullException("endDate is a required property for TransactionQueryParameters and cannot be null");
            }
            this.EndDate = endDate;
            this.QueryMode = queryMode;
            this.ShowCancelledTransactions = showCancelledTransactions;
        }

        /// <summary>
        /// The lower bound effective datetime or cut label (inclusive) from which to build the transactions.
        /// </summary>
        /// <value>The lower bound effective datetime or cut label (inclusive) from which to build the transactions.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOrCutLabel StartDate { get; set; }

        /// <summary>
        /// The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.
        /// </summary>
        /// <value>The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.</value>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOrCutLabel EndDate { get; set; }

        /// <summary>
        /// Option to specify whether or not to include cancelled transactions in the output. Defaults to False if not specified.
        /// </summary>
        /// <value>Option to specify whether or not to include cancelled transactions in the output. Defaults to False if not specified.</value>
        [DataMember(Name = "showCancelledTransactions", EmitDefaultValue = true)]
        public bool ShowCancelledTransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionQueryParameters {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  QueryMode: ").Append(QueryMode).Append("\n");
            sb.Append("  ShowCancelledTransactions: ").Append(ShowCancelledTransactions).Append("\n");
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
            return this.Equals(input as TransactionQueryParameters);
        }

        /// <summary>
        /// Returns true if TransactionQueryParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionQueryParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionQueryParameters input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.QueryMode == input.QueryMode ||
                    this.QueryMode.Equals(input.QueryMode)
                ) && 
                (
                    this.ShowCancelledTransactions == input.ShowCancelledTransactions ||
                    this.ShowCancelledTransactions.Equals(input.ShowCancelledTransactions)
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.QueryMode.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowCancelledTransactions.GetHashCode();
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
            // StartDate (DateTimeOrCutLabel) minLength
            if (this.StartDate != null && this.StartDate.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDate, length must be greater than 1.", new [] { "StartDate" });
            }

            // EndDate (DateTimeOrCutLabel) minLength
            if (this.EndDate != null && this.EndDate.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndDate, length must be greater than 1.", new [] { "EndDate" });
            }

            yield break;
        }
    }
}
