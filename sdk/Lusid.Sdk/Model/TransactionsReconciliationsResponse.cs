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
    /// TransactionsReconciliationsResponse
    /// </summary>
    [DataContract(Name = "TransactionsReconciliationsResponse")]
    public partial class TransactionsReconciliationsResponse : IEquatable<TransactionsReconciliationsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsReconciliationsResponse" /> class.
        /// </summary>
        /// <param name="mapping">mapping.</param>
        /// <param name="data">The result of this reconciliation.</param>
        public TransactionsReconciliationsResponse(Mapping mapping = default(Mapping), List<ReconciledTransaction> data = default(List<ReconciledTransaction>))
        {
            this.Mapping = mapping;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Mapping
        /// </summary>
        [DataMember(Name = "mapping", EmitDefaultValue = false)]
        public Mapping Mapping { get; set; }

        /// <summary>
        /// The result of this reconciliation
        /// </summary>
        /// <value>The result of this reconciliation</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<ReconciledTransaction> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionsReconciliationsResponse {\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as TransactionsReconciliationsResponse);
        }

        /// <summary>
        /// Returns true if TransactionsReconciliationsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsReconciliationsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsReconciliationsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mapping == input.Mapping ||
                    (this.Mapping != null &&
                    this.Mapping.Equals(input.Mapping))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Mapping != null)
                {
                    hashCode = (hashCode * 59) + this.Mapping.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
