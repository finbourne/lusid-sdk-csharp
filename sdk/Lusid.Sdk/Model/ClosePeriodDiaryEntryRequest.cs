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
    /// A definition for the period you wish to close
    /// </summary>
    [DataContract(Name = "ClosePeriodDiaryEntryRequest")]
    public partial class ClosePeriodDiaryEntryRequest : IEquatable<ClosePeriodDiaryEntryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClosePeriodDiaryEntryRequest" /> class.
        /// </summary>
        /// <param name="diaryEntryCode">Unique code assigned to a period. When left blank a code will be created by the system in the format &#39;yyyyMMDD&#39;..</param>
        /// <param name="name">Identifiable Name assigned to the period. Where left blank, the system will generate a name in the format &#39;yyyyMMDD&#39;..</param>
        /// <param name="effectiveAt">The effective time of the diary entry..</param>
        /// <param name="queryAsAt">The query time of the diary entry. Defaults to latest..</param>
        /// <param name="status">The status of a Diary Entry of Type &#39;PeriodBoundary&#39;. Defaults to &#39;Estimate&#39; when closing a period, and supports &#39;Estimate&#39; and &#39;Final&#39; for closing periods and &#39;Final&#39; for locking periods..</param>
        /// <param name="properties">A set of properties for the diary entry..</param>
        /// <param name="closingOptions">The options which will be executed once a period is closed or locked..</param>
        public ClosePeriodDiaryEntryRequest(string diaryEntryCode = default(string), string name = default(string), DateTimeOffset? effectiveAt = default(DateTimeOffset?), DateTimeOffset? queryAsAt = default(DateTimeOffset?), string status = default(string), Dictionary<string, Property> properties = default(Dictionary<string, Property>), List<string> closingOptions = default(List<string>))
        {
            this.DiaryEntryCode = diaryEntryCode;
            this.Name = name;
            this.EffectiveAt = effectiveAt;
            this.QueryAsAt = queryAsAt;
            this.Status = status;
            this.Properties = properties;
            this.ClosingOptions = closingOptions;
        }

        /// <summary>
        /// Unique code assigned to a period. When left blank a code will be created by the system in the format &#39;yyyyMMDD&#39;.
        /// </summary>
        /// <value>Unique code assigned to a period. When left blank a code will be created by the system in the format &#39;yyyyMMDD&#39;.</value>
        [DataMember(Name = "diaryEntryCode", EmitDefaultValue = true)]
        public string DiaryEntryCode { get; set; }

        /// <summary>
        /// Identifiable Name assigned to the period. Where left blank, the system will generate a name in the format &#39;yyyyMMDD&#39;.
        /// </summary>
        /// <value>Identifiable Name assigned to the period. Where left blank, the system will generate a name in the format &#39;yyyyMMDD&#39;.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The effective time of the diary entry.
        /// </summary>
        /// <value>The effective time of the diary entry.</value>
        [DataMember(Name = "effectiveAt", EmitDefaultValue = true)]
        public DateTimeOffset? EffectiveAt { get; set; }

        /// <summary>
        /// The query time of the diary entry. Defaults to latest.
        /// </summary>
        /// <value>The query time of the diary entry. Defaults to latest.</value>
        [DataMember(Name = "queryAsAt", EmitDefaultValue = true)]
        public DateTimeOffset? QueryAsAt { get; set; }

        /// <summary>
        /// The status of a Diary Entry of Type &#39;PeriodBoundary&#39;. Defaults to &#39;Estimate&#39; when closing a period, and supports &#39;Estimate&#39; and &#39;Final&#39; for closing periods and &#39;Final&#39; for locking periods.
        /// </summary>
        /// <value>The status of a Diary Entry of Type &#39;PeriodBoundary&#39;. Defaults to &#39;Estimate&#39; when closing a period, and supports &#39;Estimate&#39; and &#39;Final&#39; for closing periods and &#39;Final&#39; for locking periods.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// A set of properties for the diary entry.
        /// </summary>
        /// <value>A set of properties for the diary entry.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// The options which will be executed once a period is closed or locked.
        /// </summary>
        /// <value>The options which will be executed once a period is closed or locked.</value>
        [DataMember(Name = "closingOptions", EmitDefaultValue = true)]
        public List<string> ClosingOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClosePeriodDiaryEntryRequest {\n");
            sb.Append("  DiaryEntryCode: ").Append(DiaryEntryCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  QueryAsAt: ").Append(QueryAsAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  ClosingOptions: ").Append(ClosingOptions).Append("\n");
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
            return this.Equals(input as ClosePeriodDiaryEntryRequest);
        }

        /// <summary>
        /// Returns true if ClosePeriodDiaryEntryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ClosePeriodDiaryEntryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClosePeriodDiaryEntryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiaryEntryCode == input.DiaryEntryCode ||
                    (this.DiaryEntryCode != null &&
                    this.DiaryEntryCode.Equals(input.DiaryEntryCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
                ) && 
                (
                    this.QueryAsAt == input.QueryAsAt ||
                    (this.QueryAsAt != null &&
                    this.QueryAsAt.Equals(input.QueryAsAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.ClosingOptions == input.ClosingOptions ||
                    this.ClosingOptions != null &&
                    input.ClosingOptions != null &&
                    this.ClosingOptions.SequenceEqual(input.ClosingOptions)
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
                if (this.DiaryEntryCode != null)
                {
                    hashCode = (hashCode * 59) + this.DiaryEntryCode.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.EffectiveAt != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveAt.GetHashCode();
                }
                if (this.QueryAsAt != null)
                {
                    hashCode = (hashCode * 59) + this.QueryAsAt.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.ClosingOptions != null)
                {
                    hashCode = (hashCode * 59) + this.ClosingOptions.GetHashCode();
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
            // DiaryEntryCode (string) maxLength
            if (this.DiaryEntryCode != null && this.DiaryEntryCode.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiaryEntryCode, length must be less than 64.", new [] { "DiaryEntryCode" });
            }

            // DiaryEntryCode (string) minLength
            if (this.DiaryEntryCode != null && this.DiaryEntryCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiaryEntryCode, length must be greater than 1.", new [] { "DiaryEntryCode" });
            }

            // DiaryEntryCode (string) pattern
            Regex regexDiaryEntryCode = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexDiaryEntryCode.Match(this.DiaryEntryCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiaryEntryCode, must match a pattern of " + regexDiaryEntryCode, new [] { "DiaryEntryCode" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 512.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            yield break;
        }
    }
}
