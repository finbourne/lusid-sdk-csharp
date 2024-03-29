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
    /// Request to translate financial entities with a given script body.  The output of the translation is validated against a schema specified in the request.
    /// </summary>
    [DataContract(Name = "TranslateEntitiesInlinedRequest")]
    public partial class TranslateEntitiesInlinedRequest : IEquatable<TranslateEntitiesInlinedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateEntitiesInlinedRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TranslateEntitiesInlinedRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateEntitiesInlinedRequest" /> class.
        /// </summary>
        /// <param name="entityPayloads">Entity payloads to be translated indexed by (ephemeral) unique correlation ids. (required).</param>
        /// <param name="scriptBody">The body of the translation script to use for translating the entities. (required).</param>
        /// <param name="schema">schema.</param>
        public TranslateEntitiesInlinedRequest(Dictionary<string, TranslationInput> entityPayloads = default(Dictionary<string, TranslationInput>), string scriptBody = default(string), DialectSchema schema = default(DialectSchema))
        {
            // to ensure "entityPayloads" is required (not null)
            if (entityPayloads == null)
            {
                throw new ArgumentNullException("entityPayloads is a required property for TranslateEntitiesInlinedRequest and cannot be null");
            }
            this.EntityPayloads = entityPayloads;
            // to ensure "scriptBody" is required (not null)
            if (scriptBody == null)
            {
                throw new ArgumentNullException("scriptBody is a required property for TranslateEntitiesInlinedRequest and cannot be null");
            }
            this.ScriptBody = scriptBody;
            this.Schema = schema;
        }

        /// <summary>
        /// Entity payloads to be translated indexed by (ephemeral) unique correlation ids.
        /// </summary>
        /// <value>Entity payloads to be translated indexed by (ephemeral) unique correlation ids.</value>
        [DataMember(Name = "entityPayloads", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, TranslationInput> EntityPayloads { get; set; }

        /// <summary>
        /// The body of the translation script to use for translating the entities.
        /// </summary>
        /// <value>The body of the translation script to use for translating the entities.</value>
        [DataMember(Name = "scriptBody", IsRequired = true, EmitDefaultValue = true)]
        public string ScriptBody { get; set; }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public DialectSchema Schema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TranslateEntitiesInlinedRequest {\n");
            sb.Append("  EntityPayloads: ").Append(EntityPayloads).Append("\n");
            sb.Append("  ScriptBody: ").Append(ScriptBody).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
            return this.Equals(input as TranslateEntitiesInlinedRequest);
        }

        /// <summary>
        /// Returns true if TranslateEntitiesInlinedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TranslateEntitiesInlinedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranslateEntitiesInlinedRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EntityPayloads == input.EntityPayloads ||
                    this.EntityPayloads != null &&
                    input.EntityPayloads != null &&
                    this.EntityPayloads.SequenceEqual(input.EntityPayloads)
                ) && 
                (
                    this.ScriptBody == input.ScriptBody ||
                    (this.ScriptBody != null &&
                    this.ScriptBody.Equals(input.ScriptBody))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
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
                if (this.EntityPayloads != null)
                {
                    hashCode = (hashCode * 59) + this.EntityPayloads.GetHashCode();
                }
                if (this.ScriptBody != null)
                {
                    hashCode = (hashCode * 59) + this.ScriptBody.GetHashCode();
                }
                if (this.Schema != null)
                {
                    hashCode = (hashCode * 59) + this.Schema.GetHashCode();
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
            // ScriptBody (string) maxLength
            if (this.ScriptBody != null && this.ScriptBody.Length > 500000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScriptBody, length must be less than 500000.", new [] { "ScriptBody" });
            }

            // ScriptBody (string) minLength
            if (this.ScriptBody != null && this.ScriptBody.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScriptBody, length must be greater than 0.", new [] { "ScriptBody" });
            }

            yield break;
        }
    }
}
