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
    /// UpsertReconciliationRunRequest
    /// </summary>
    [DataContract(Name = "UpsertReconciliationRunRequest")]
    public partial class UpsertReconciliationRunRequest : IEquatable<UpsertReconciliationRunRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertReconciliationRunRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertReconciliationRunRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertReconciliationRunRequest" /> class.
        /// </summary>
        /// <param name="date">The effective date of the reconciliation run (required).</param>
        /// <param name="version">The version number for a run (required).</param>
        public UpsertReconciliationRunRequest(DateTimeOffset date = default(DateTimeOffset), int version = default(int))
        {
            this.Date = date;
            this._Version = version;
        }

        /// <summary>
        /// The effective date of the reconciliation run
        /// </summary>
        /// <value>The effective date of the reconciliation run</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// The version number for a run
        /// </summary>
        /// <value>The version number for a run</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpsertReconciliationRunRequest {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as UpsertReconciliationRunRequest);
        }

        /// <summary>
        /// Returns true if UpsertReconciliationRunRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertReconciliationRunRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertReconciliationRunRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
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
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
