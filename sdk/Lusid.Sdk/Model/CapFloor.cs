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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// LUSID representation of Cap, Floor, or Collar.
    /// </summary>
    [DataContract(Name = "CapFloor")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentType")]
    public partial class CapFloor : LusidInstrument, IEquatable<CapFloor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapFloor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapFloor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapFloor" /> class.
        /// </summary>
        /// <param name="capFloorType">Determine if it&#39;s CAP, FLOOR, or COLLAR.    Supported string (enumeration) values are: [Cap, Floor, Collar]. (required).</param>
        /// <param name="capStrike">Strike rate of the Cap. (required).</param>
        /// <param name="floorStrike">Strike rate of the Floor. (required).</param>
        /// <param name="includeFirstCaplet">Include first caplet flag. (required).</param>
        /// <param name="underlyingFloatingLeg">underlyingFloatingLeg (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan (required) (default to &quot;CapFloor&quot;).</param>
        public CapFloor(string capFloorType = default(string), decimal capStrike = default(decimal), decimal floorStrike = default(decimal), bool includeFirstCaplet = default(bool), FloatingLeg underlyingFloatingLeg = default(FloatingLeg), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            // to ensure "capFloorType" is required (not null)
            if (capFloorType == null)
            {
                throw new ArgumentNullException("capFloorType is a required property for CapFloor and cannot be null");
            }
            this.CapFloorType = capFloorType;
            this.CapStrike = capStrike;
            this.FloorStrike = floorStrike;
            this.IncludeFirstCaplet = includeFirstCaplet;
            // to ensure "underlyingFloatingLeg" is required (not null)
            if (underlyingFloatingLeg == null)
            {
                throw new ArgumentNullException("underlyingFloatingLeg is a required property for CapFloor and cannot be null");
            }
            this.UnderlyingFloatingLeg = underlyingFloatingLeg;
        }

        /// <summary>
        /// Determine if it&#39;s CAP, FLOOR, or COLLAR.    Supported string (enumeration) values are: [Cap, Floor, Collar].
        /// </summary>
        /// <value>Determine if it&#39;s CAP, FLOOR, or COLLAR.    Supported string (enumeration) values are: [Cap, Floor, Collar].</value>
        [DataMember(Name = "capFloorType", IsRequired = true, EmitDefaultValue = true)]
        public string CapFloorType { get; set; }

        /// <summary>
        /// Strike rate of the Cap.
        /// </summary>
        /// <value>Strike rate of the Cap.</value>
        [DataMember(Name = "capStrike", IsRequired = true, EmitDefaultValue = true)]
        public decimal CapStrike { get; set; }

        /// <summary>
        /// Strike rate of the Floor.
        /// </summary>
        /// <value>Strike rate of the Floor.</value>
        [DataMember(Name = "floorStrike", IsRequired = true, EmitDefaultValue = true)]
        public decimal FloorStrike { get; set; }

        /// <summary>
        /// Include first caplet flag.
        /// </summary>
        /// <value>Include first caplet flag.</value>
        [DataMember(Name = "includeFirstCaplet", IsRequired = true, EmitDefaultValue = true)]
        public bool IncludeFirstCaplet { get; set; }

        /// <summary>
        /// Gets or Sets UnderlyingFloatingLeg
        /// </summary>
        [DataMember(Name = "underlyingFloatingLeg", IsRequired = true, EmitDefaultValue = true)]
        public FloatingLeg UnderlyingFloatingLeg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapFloor {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CapFloorType: ").Append(CapFloorType).Append("\n");
            sb.Append("  CapStrike: ").Append(CapStrike).Append("\n");
            sb.Append("  FloorStrike: ").Append(FloorStrike).Append("\n");
            sb.Append("  IncludeFirstCaplet: ").Append(IncludeFirstCaplet).Append("\n");
            sb.Append("  UnderlyingFloatingLeg: ").Append(UnderlyingFloatingLeg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as CapFloor);
        }

        /// <summary>
        /// Returns true if CapFloor instances are equal
        /// </summary>
        /// <param name="input">Instance of CapFloor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CapFloor input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.CapFloorType == input.CapFloorType ||
                    (this.CapFloorType != null &&
                    this.CapFloorType.Equals(input.CapFloorType))
                ) && base.Equals(input) && 
                (
                    this.CapStrike == input.CapStrike ||
                    this.CapStrike.Equals(input.CapStrike)
                ) && base.Equals(input) && 
                (
                    this.FloorStrike == input.FloorStrike ||
                    this.FloorStrike.Equals(input.FloorStrike)
                ) && base.Equals(input) && 
                (
                    this.IncludeFirstCaplet == input.IncludeFirstCaplet ||
                    this.IncludeFirstCaplet.Equals(input.IncludeFirstCaplet)
                ) && base.Equals(input) && 
                (
                    this.UnderlyingFloatingLeg == input.UnderlyingFloatingLeg ||
                    (this.UnderlyingFloatingLeg != null &&
                    this.UnderlyingFloatingLeg.Equals(input.UnderlyingFloatingLeg))
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
                int hashCode = base.GetHashCode();
                if (this.CapFloorType != null)
                {
                    hashCode = (hashCode * 59) + this.CapFloorType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CapStrike.GetHashCode();
                hashCode = (hashCode * 59) + this.FloorStrike.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeFirstCaplet.GetHashCode();
                if (this.UnderlyingFloatingLeg != null)
                {
                    hashCode = (hashCode * 59) + this.UnderlyingFloatingLeg.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            // CapFloorType (string) minLength
            if (this.CapFloorType != null && this.CapFloorType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CapFloorType, length must be greater than 1.", new [] { "CapFloorType" });
            }

            yield break;
        }
    }
}
