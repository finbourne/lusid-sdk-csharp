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
    /// Represents the legal agreement between two parties engaged in an OTC transaction.  A typical example would be a 2002 ISDA Master Agreement, signed by two legal entities on a given date.
    /// </summary>
    [DataContract(Name = "CounterpartyAgreement")]
    public partial class CounterpartyAgreement : IEquatable<CounterpartyAgreement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterpartyAgreement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CounterpartyAgreement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterpartyAgreement" /> class.
        /// </summary>
        /// <param name="displayName">A user-defined display label for the Counterparty Agreement. (required).</param>
        /// <param name="agreementType">A user-defined field to capture the type of agreement this represents. Examples might be \&quot;ISDA 2002 Master Agreement\&quot; or \&quot;ISDA 1992 Master Agreement\&quot;. (required).</param>
        /// <param name="counterpartySignatory">counterpartySignatory (required).</param>
        /// <param name="datedAsOf">The date on which the CounterpartyAgreement was signed by both parties. (required).</param>
        /// <param name="creditSupportAnnexId">creditSupportAnnexId (required).</param>
        /// <param name="id">id (required).</param>
        public CounterpartyAgreement(string displayName = default(string), string agreementType = default(string), CounterpartySignatory counterpartySignatory = default(CounterpartySignatory), DateTimeOffset datedAsOf = default(DateTimeOffset), ResourceId creditSupportAnnexId = default(ResourceId), ResourceId id = default(ResourceId))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for CounterpartyAgreement and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "agreementType" is required (not null)
            if (agreementType == null)
            {
                throw new ArgumentNullException("agreementType is a required property for CounterpartyAgreement and cannot be null");
            }
            this.AgreementType = agreementType;
            // to ensure "counterpartySignatory" is required (not null)
            if (counterpartySignatory == null)
            {
                throw new ArgumentNullException("counterpartySignatory is a required property for CounterpartyAgreement and cannot be null");
            }
            this.CounterpartySignatory = counterpartySignatory;
            this.DatedAsOf = datedAsOf;
            // to ensure "creditSupportAnnexId" is required (not null)
            if (creditSupportAnnexId == null)
            {
                throw new ArgumentNullException("creditSupportAnnexId is a required property for CounterpartyAgreement and cannot be null");
            }
            this.CreditSupportAnnexId = creditSupportAnnexId;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CounterpartyAgreement and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// A user-defined display label for the Counterparty Agreement.
        /// </summary>
        /// <value>A user-defined display label for the Counterparty Agreement.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A user-defined field to capture the type of agreement this represents. Examples might be \&quot;ISDA 2002 Master Agreement\&quot; or \&quot;ISDA 1992 Master Agreement\&quot;.
        /// </summary>
        /// <value>A user-defined field to capture the type of agreement this represents. Examples might be \&quot;ISDA 2002 Master Agreement\&quot; or \&quot;ISDA 1992 Master Agreement\&quot;.</value>
        [DataMember(Name = "agreementType", IsRequired = true, EmitDefaultValue = true)]
        public string AgreementType { get; set; }

        /// <summary>
        /// Gets or Sets CounterpartySignatory
        /// </summary>
        [DataMember(Name = "counterpartySignatory", IsRequired = true, EmitDefaultValue = true)]
        public CounterpartySignatory CounterpartySignatory { get; set; }

        /// <summary>
        /// The date on which the CounterpartyAgreement was signed by both parties.
        /// </summary>
        /// <value>The date on which the CounterpartyAgreement was signed by both parties.</value>
        [DataMember(Name = "datedAsOf", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset DatedAsOf { get; set; }

        /// <summary>
        /// Gets or Sets CreditSupportAnnexId
        /// </summary>
        [DataMember(Name = "creditSupportAnnexId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId CreditSupportAnnexId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CounterpartyAgreement {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  AgreementType: ").Append(AgreementType).Append("\n");
            sb.Append("  CounterpartySignatory: ").Append(CounterpartySignatory).Append("\n");
            sb.Append("  DatedAsOf: ").Append(DatedAsOf).Append("\n");
            sb.Append("  CreditSupportAnnexId: ").Append(CreditSupportAnnexId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CounterpartyAgreement);
        }

        /// <summary>
        /// Returns true if CounterpartyAgreement instances are equal
        /// </summary>
        /// <param name="input">Instance of CounterpartyAgreement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CounterpartyAgreement input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.AgreementType == input.AgreementType ||
                    (this.AgreementType != null &&
                    this.AgreementType.Equals(input.AgreementType))
                ) && 
                (
                    this.CounterpartySignatory == input.CounterpartySignatory ||
                    (this.CounterpartySignatory != null &&
                    this.CounterpartySignatory.Equals(input.CounterpartySignatory))
                ) && 
                (
                    this.DatedAsOf == input.DatedAsOf ||
                    (this.DatedAsOf != null &&
                    this.DatedAsOf.Equals(input.DatedAsOf))
                ) && 
                (
                    this.CreditSupportAnnexId == input.CreditSupportAnnexId ||
                    (this.CreditSupportAnnexId != null &&
                    this.CreditSupportAnnexId.Equals(input.CreditSupportAnnexId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.AgreementType != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementType.GetHashCode();
                }
                if (this.CounterpartySignatory != null)
                {
                    hashCode = (hashCode * 59) + this.CounterpartySignatory.GetHashCode();
                }
                if (this.DatedAsOf != null)
                {
                    hashCode = (hashCode * 59) + this.DatedAsOf.GetHashCode();
                }
                if (this.CreditSupportAnnexId != null)
                {
                    hashCode = (hashCode * 59) + this.CreditSupportAnnexId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            // AgreementType (string) maxLength
            if (this.AgreementType != null && this.AgreementType.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AgreementType, length must be less than 256.", new [] { "AgreementType" });
            }

            // AgreementType (string) minLength
            if (this.AgreementType != null && this.AgreementType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AgreementType, length must be greater than 0.", new [] { "AgreementType" });
            }

            yield break;
        }
    }
}
