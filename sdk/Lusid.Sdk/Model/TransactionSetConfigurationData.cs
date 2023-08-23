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
    /// A collection of the data required to configure transaction types..
    /// </summary>
    [DataContract(Name = "TransactionSetConfigurationData")]
    public partial class TransactionSetConfigurationData : IEquatable<TransactionSetConfigurationData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSetConfigurationData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionSetConfigurationData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSetConfigurationData" /> class.
        /// </summary>
        /// <param name="transactionConfigs">Collection of transaction type models (required).</param>
        /// <param name="sideDefinitions">Collection of side definitions.</param>
        /// <param name="links">links.</param>
        public TransactionSetConfigurationData(List<TransactionConfigurationData> transactionConfigs = default(List<TransactionConfigurationData>), List<SideConfigurationData> sideDefinitions = default(List<SideConfigurationData>), List<Link> links = default(List<Link>))
        {
            // to ensure "transactionConfigs" is required (not null)
            if (transactionConfigs == null)
            {
                throw new ArgumentNullException("transactionConfigs is a required property for TransactionSetConfigurationData and cannot be null");
            }
            this.TransactionConfigs = transactionConfigs;
            this.SideDefinitions = sideDefinitions;
            this.Links = links;
        }

        /// <summary>
        /// Collection of transaction type models
        /// </summary>
        /// <value>Collection of transaction type models</value>
        [DataMember(Name = "transactionConfigs", IsRequired = true, EmitDefaultValue = true)]
        public List<TransactionConfigurationData> TransactionConfigs { get; set; }

        /// <summary>
        /// Collection of side definitions
        /// </summary>
        /// <value>Collection of side definitions</value>
        [DataMember(Name = "sideDefinitions", EmitDefaultValue = true)]
        public List<SideConfigurationData> SideDefinitions { get; set; }

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
            sb.Append("class TransactionSetConfigurationData {\n");
            sb.Append("  TransactionConfigs: ").Append(TransactionConfigs).Append("\n");
            sb.Append("  SideDefinitions: ").Append(SideDefinitions).Append("\n");
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
            return this.Equals(input as TransactionSetConfigurationData);
        }

        /// <summary>
        /// Returns true if TransactionSetConfigurationData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionSetConfigurationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionSetConfigurationData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionConfigs == input.TransactionConfigs ||
                    this.TransactionConfigs != null &&
                    input.TransactionConfigs != null &&
                    this.TransactionConfigs.SequenceEqual(input.TransactionConfigs)
                ) && 
                (
                    this.SideDefinitions == input.SideDefinitions ||
                    this.SideDefinitions != null &&
                    input.SideDefinitions != null &&
                    this.SideDefinitions.SequenceEqual(input.SideDefinitions)
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
                if (this.TransactionConfigs != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionConfigs.GetHashCode();
                }
                if (this.SideDefinitions != null)
                {
                    hashCode = (hashCode * 59) + this.SideDefinitions.GetHashCode();
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
