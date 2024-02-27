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
    /// InstrumentEventConfiguration
    /// </summary>
    [DataContract(Name = "InstrumentEventConfiguration")]
    public partial class InstrumentEventConfiguration : IEquatable<InstrumentEventConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentEventConfiguration" /> class.
        /// </summary>
        /// <param name="transactionTemplateScopes">transactionTemplateScopes.</param>
        public InstrumentEventConfiguration(List<string> transactionTemplateScopes = default(List<string>))
        {
            this.TransactionTemplateScopes = transactionTemplateScopes;
        }

        /// <summary>
        /// Gets or Sets TransactionTemplateScopes
        /// </summary>
        [DataMember(Name = "transactionTemplateScopes", EmitDefaultValue = true)]
        public List<string> TransactionTemplateScopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstrumentEventConfiguration {\n");
            sb.Append("  TransactionTemplateScopes: ").Append(TransactionTemplateScopes).Append("\n");
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
            return this.Equals(input as InstrumentEventConfiguration);
        }

        /// <summary>
        /// Returns true if InstrumentEventConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentEventConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentEventConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionTemplateScopes == input.TransactionTemplateScopes ||
                    this.TransactionTemplateScopes != null &&
                    input.TransactionTemplateScopes != null &&
                    this.TransactionTemplateScopes.SequenceEqual(input.TransactionTemplateScopes)
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
                if (this.TransactionTemplateScopes != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionTemplateScopes.GetHashCode();
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