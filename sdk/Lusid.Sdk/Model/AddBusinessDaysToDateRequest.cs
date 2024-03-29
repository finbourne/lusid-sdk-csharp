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
    /// AddBusinessDaysToDateRequest
    /// </summary>
    [DataContract(Name = "AddBusinessDaysToDateRequest")]
    public partial class AddBusinessDaysToDateRequest : IEquatable<AddBusinessDaysToDateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddBusinessDaysToDateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddBusinessDaysToDateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddBusinessDaysToDateRequest" /> class.
        /// </summary>
        /// <param name="businessDayOffset">businessDayOffset (required).</param>
        /// <param name="holidayCodes">holidayCodes (required).</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="asAt">asAt.</param>
        public AddBusinessDaysToDateRequest(int businessDayOffset = default(int), List<string> holidayCodes = default(List<string>), DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            this.BusinessDayOffset = businessDayOffset;
            // to ensure "holidayCodes" is required (not null)
            if (holidayCodes == null)
            {
                throw new ArgumentNullException("holidayCodes is a required property for AddBusinessDaysToDateRequest and cannot be null");
            }
            this.HolidayCodes = holidayCodes;
            this.StartDate = startDate;
            this.AsAt = asAt;
        }

        /// <summary>
        /// Gets or Sets BusinessDayOffset
        /// </summary>
        [DataMember(Name = "businessDayOffset", IsRequired = true, EmitDefaultValue = true)]
        public int BusinessDayOffset { get; set; }

        /// <summary>
        /// Gets or Sets HolidayCodes
        /// </summary>
        [DataMember(Name = "holidayCodes", IsRequired = true, EmitDefaultValue = true)]
        public List<string> HolidayCodes { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Gets or Sets AsAt
        /// </summary>
        [DataMember(Name = "asAt", EmitDefaultValue = true)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddBusinessDaysToDateRequest {\n");
            sb.Append("  BusinessDayOffset: ").Append(BusinessDayOffset).Append("\n");
            sb.Append("  HolidayCodes: ").Append(HolidayCodes).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
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
            return this.Equals(input as AddBusinessDaysToDateRequest);
        }

        /// <summary>
        /// Returns true if AddBusinessDaysToDateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AddBusinessDaysToDateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddBusinessDaysToDateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusinessDayOffset == input.BusinessDayOffset ||
                    this.BusinessDayOffset.Equals(input.BusinessDayOffset)
                ) && 
                (
                    this.HolidayCodes == input.HolidayCodes ||
                    this.HolidayCodes != null &&
                    input.HolidayCodes != null &&
                    this.HolidayCodes.SequenceEqual(input.HolidayCodes)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
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
                hashCode = (hashCode * 59) + this.BusinessDayOffset.GetHashCode();
                if (this.HolidayCodes != null)
                {
                    hashCode = (hashCode * 59) + this.HolidayCodes.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.AsAt != null)
                {
                    hashCode = (hashCode * 59) + this.AsAt.GetHashCode();
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
