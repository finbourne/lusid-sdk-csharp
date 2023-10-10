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
    /// JournalEntryLinesQueryParameters
    /// </summary>
    [DataContract(Name = "JournalEntryLinesQueryParameters")]
    public partial class JournalEntryLinesQueryParameters : IEquatable<JournalEntryLinesQueryParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntryLinesQueryParameters" /> class.
        /// </summary>
        /// <param name="start">start.</param>
        /// <param name="end">end.</param>
        /// <param name="dateMode">The mode of calculation of the journal entry lines..</param>
        /// <param name="generalLedgerProfileCode">The optional code of a general ledger profile used to decorate journal entry lines with levels..</param>
        /// <param name="propertyKeys">A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39; domain to decorate onto the journal entry lines..</param>
        public JournalEntryLinesQueryParameters(DateOrDiaryEntry start = default(DateOrDiaryEntry), DateOrDiaryEntry end = default(DateOrDiaryEntry), string dateMode = default(string), string generalLedgerProfileCode = default(string), List<string> propertyKeys = default(List<string>))
        {
            this.Start = start;
            this.End = end;
            this.DateMode = dateMode;
            this.GeneralLedgerProfileCode = generalLedgerProfileCode;
            this.PropertyKeys = propertyKeys;
        }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        public DateOrDiaryEntry Start { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        public DateOrDiaryEntry End { get; set; }

        /// <summary>
        /// The mode of calculation of the journal entry lines.
        /// </summary>
        /// <value>The mode of calculation of the journal entry lines.</value>
        [DataMember(Name = "dateMode", EmitDefaultValue = true)]
        public string DateMode { get; set; }

        /// <summary>
        /// The optional code of a general ledger profile used to decorate journal entry lines with levels.
        /// </summary>
        /// <value>The optional code of a general ledger profile used to decorate journal entry lines with levels.</value>
        [DataMember(Name = "generalLedgerProfileCode", EmitDefaultValue = true)]
        public string GeneralLedgerProfileCode { get; set; }

        /// <summary>
        /// A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39; domain to decorate onto the journal entry lines.
        /// </summary>
        /// <value>A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39; domain to decorate onto the journal entry lines.</value>
        [DataMember(Name = "propertyKeys", EmitDefaultValue = true)]
        public List<string> PropertyKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JournalEntryLinesQueryParameters {\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  DateMode: ").Append(DateMode).Append("\n");
            sb.Append("  GeneralLedgerProfileCode: ").Append(GeneralLedgerProfileCode).Append("\n");
            sb.Append("  PropertyKeys: ").Append(PropertyKeys).Append("\n");
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
            return this.Equals(input as JournalEntryLinesQueryParameters);
        }

        /// <summary>
        /// Returns true if JournalEntryLinesQueryParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalEntryLinesQueryParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalEntryLinesQueryParameters input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.DateMode == input.DateMode ||
                    (this.DateMode != null &&
                    this.DateMode.Equals(input.DateMode))
                ) && 
                (
                    this.GeneralLedgerProfileCode == input.GeneralLedgerProfileCode ||
                    (this.GeneralLedgerProfileCode != null &&
                    this.GeneralLedgerProfileCode.Equals(input.GeneralLedgerProfileCode))
                ) && 
                (
                    this.PropertyKeys == input.PropertyKeys ||
                    this.PropertyKeys != null &&
                    input.PropertyKeys != null &&
                    this.PropertyKeys.SequenceEqual(input.PropertyKeys)
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
                if (this.Start != null)
                {
                    hashCode = (hashCode * 59) + this.Start.GetHashCode();
                }
                if (this.End != null)
                {
                    hashCode = (hashCode * 59) + this.End.GetHashCode();
                }
                if (this.DateMode != null)
                {
                    hashCode = (hashCode * 59) + this.DateMode.GetHashCode();
                }
                if (this.GeneralLedgerProfileCode != null)
                {
                    hashCode = (hashCode * 59) + this.GeneralLedgerProfileCode.GetHashCode();
                }
                if (this.PropertyKeys != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyKeys.GetHashCode();
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
            // GeneralLedgerProfileCode (string) maxLength
            if (this.GeneralLedgerProfileCode != null && this.GeneralLedgerProfileCode.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GeneralLedgerProfileCode, length must be less than 64.", new [] { "GeneralLedgerProfileCode" });
            }

            // GeneralLedgerProfileCode (string) minLength
            if (this.GeneralLedgerProfileCode != null && this.GeneralLedgerProfileCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GeneralLedgerProfileCode, length must be greater than 1.", new [] { "GeneralLedgerProfileCode" });
            }

            // GeneralLedgerProfileCode (string) pattern
            Regex regexGeneralLedgerProfileCode = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexGeneralLedgerProfileCode.Match(this.GeneralLedgerProfileCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GeneralLedgerProfileCode, must match a pattern of " + regexGeneralLedgerProfileCode, new [] { "GeneralLedgerProfileCode" });
            }

            yield break;
        }
    }
}