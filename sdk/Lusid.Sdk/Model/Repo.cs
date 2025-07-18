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
    /// LUSID representation of a sale and repurchase agreement, supporting haircut, margin or repo rate methods.
    /// </summary>
    [DataContract(Name = "Repo")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentType")]
    public partial class Repo : LusidInstrument, IEquatable<Repo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Repo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Repo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Repo" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="maturityDate">The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. (required).</param>
        /// <param name="domCcy">The domestic currency of the instrument. (required).</param>
        /// <param name="accrualBasis">For calculation of interest, the accrual basis to be used.  For more information on day counts, see [knowledge base article KA-01798](https://support.lusid.com/knowledgebase/article/KA-01798)                Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM]. (required).</param>
        /// <param name="collateral">The actual collateral in the Repo.  This property is for informational purposes only, Lusid pricing is not affected..</param>
        /// <param name="collateralValue">The full market value of the collateral in domestic currency, before any margin or haircut is applied..</param>
        /// <param name="haircut">The haircut (or margin percentage) applied to the collateral, this should be a number between 0 and 1, i.e. for a 5% haircut this should be 0.05.  This is defined as (CollateralValue - PurchasePrice) / CollateralValue.  If this property is specified, so too must CollateralValue.  While this property is optional, one, and only one, of PurchasePrice, Margin and Haircut must be specified..</param>
        /// <param name="margin">The initial margin (or margin ratio) applied to the collateral, this should be a number greater than or equal to 1.0,  i.e. for a 102% margin this should be 1.02. A value of 1.0 means no margin (100%).  This is defined as CollateralValue / PurchasePrice.  If this property is specified, so too must CollateralValue.  While this property is optional, one, and only one, of PurchasePrice, Margin and Haircut must be specified..</param>
        /// <param name="purchasePrice">The price the collateral is initially purchased for, this property can be used to explicitly set the purchase price and not require  collateral value and a margin or haircut.  While this property is optional, one, and only one, of PurchasePrice, Margin and Haircut must be specified..</param>
        /// <param name="repoRate">The rate at which interest is to be accrue and be paid upon redemption of the collateral at maturity.  This field is used to calculate the Repurchase price.  While this property is optional, one, and only one, of the RepoRate and RepurchasePrice must be specified..</param>
        /// <param name="repurchasePrice">The price at which the collateral is repurchased, this field is optional and can be explicitly set here or will be calculated  from the PurchasePrice and RepoRate.  One, and only one, of the RepoRate and RepurchasePrice must be specified..</param>
        /// <param name="timeZoneConventions">timeZoneConventions.</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo (required) (default to &quot;Repo&quot;).</param>
        public Repo(DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset maturityDate = default(DateTimeOffset), string domCcy = default(string), string accrualBasis = default(string), List<LusidInstrument> collateral = default(List<LusidInstrument>), decimal? collateralValue = default(decimal?), decimal? haircut = default(decimal?), decimal? margin = default(decimal?), decimal? purchasePrice = default(decimal?), decimal? repoRate = default(decimal?), decimal? repurchasePrice = default(decimal?), TimeZoneConventions timeZoneConventions = default(TimeZoneConventions), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            this.StartDate = startDate;
            this.MaturityDate = maturityDate;
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new ArgumentNullException("domCcy is a required property for Repo and cannot be null");
            }
            this.DomCcy = domCcy;
            // to ensure "accrualBasis" is required (not null)
            if (accrualBasis == null)
            {
                throw new ArgumentNullException("accrualBasis is a required property for Repo and cannot be null");
            }
            this.AccrualBasis = accrualBasis;
            this.Collateral = collateral;
            this.CollateralValue = collateralValue;
            this.Haircut = haircut;
            this.Margin = margin;
            this.PurchasePrice = purchasePrice;
            this.RepoRate = repoRate;
            this.RepurchasePrice = repurchasePrice;
            this.TimeZoneConventions = timeZoneConventions;
        }

        /// <summary>
        /// The start date of the instrument. This is normally synonymous with the trade-date.
        /// </summary>
        /// <value>The start date of the instrument. This is normally synonymous with the trade-date.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it.
        /// </summary>
        /// <value>The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it.</value>
        [DataMember(Name = "maturityDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset MaturityDate { get; set; }

        /// <summary>
        /// The domestic currency of the instrument.
        /// </summary>
        /// <value>The domestic currency of the instrument.</value>
        [DataMember(Name = "domCcy", IsRequired = true, EmitDefaultValue = true)]
        public string DomCcy { get; set; }

        /// <summary>
        /// For calculation of interest, the accrual basis to be used.  For more information on day counts, see [knowledge base article KA-01798](https://support.lusid.com/knowledgebase/article/KA-01798)                Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM].
        /// </summary>
        /// <value>For calculation of interest, the accrual basis to be used.  For more information on day counts, see [knowledge base article KA-01798](https://support.lusid.com/knowledgebase/article/KA-01798)                Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365, ActActAFB, Act365Cad, ThirtyActIsda, Thirty365Isda, ThirtyEActIsda, ThirtyE360Isda, ThirtyE365Isda, ThirtyU360EOM].</value>
        [DataMember(Name = "accrualBasis", IsRequired = true, EmitDefaultValue = true)]
        public string AccrualBasis { get; set; }

        /// <summary>
        /// The actual collateral in the Repo.  This property is for informational purposes only, Lusid pricing is not affected.
        /// </summary>
        /// <value>The actual collateral in the Repo.  This property is for informational purposes only, Lusid pricing is not affected.</value>
        [DataMember(Name = "collateral", EmitDefaultValue = true)]
        public List<LusidInstrument> Collateral { get; set; }

        /// <summary>
        /// The full market value of the collateral in domestic currency, before any margin or haircut is applied.
        /// </summary>
        /// <value>The full market value of the collateral in domestic currency, before any margin or haircut is applied.</value>
        [DataMember(Name = "collateralValue", EmitDefaultValue = true)]
        public decimal? CollateralValue { get; set; }

        /// <summary>
        /// The haircut (or margin percentage) applied to the collateral, this should be a number between 0 and 1, i.e. for a 5% haircut this should be 0.05.  This is defined as (CollateralValue - PurchasePrice) / CollateralValue.  If this property is specified, so too must CollateralValue.  While this property is optional, one, and only one, of PurchasePrice, Margin and Haircut must be specified.
        /// </summary>
        /// <value>The haircut (or margin percentage) applied to the collateral, this should be a number between 0 and 1, i.e. for a 5% haircut this should be 0.05.  This is defined as (CollateralValue - PurchasePrice) / CollateralValue.  If this property is specified, so too must CollateralValue.  While this property is optional, one, and only one, of PurchasePrice, Margin and Haircut must be specified.</value>
        [DataMember(Name = "haircut", EmitDefaultValue = true)]
        public decimal? Haircut { get; set; }

        /// <summary>
        /// The initial margin (or margin ratio) applied to the collateral, this should be a number greater than or equal to 1.0,  i.e. for a 102% margin this should be 1.02. A value of 1.0 means no margin (100%).  This is defined as CollateralValue / PurchasePrice.  If this property is specified, so too must CollateralValue.  While this property is optional, one, and only one, of PurchasePrice, Margin and Haircut must be specified.
        /// </summary>
        /// <value>The initial margin (or margin ratio) applied to the collateral, this should be a number greater than or equal to 1.0,  i.e. for a 102% margin this should be 1.02. A value of 1.0 means no margin (100%).  This is defined as CollateralValue / PurchasePrice.  If this property is specified, so too must CollateralValue.  While this property is optional, one, and only one, of PurchasePrice, Margin and Haircut must be specified.</value>
        [DataMember(Name = "margin", EmitDefaultValue = true)]
        public decimal? Margin { get; set; }

        /// <summary>
        /// The price the collateral is initially purchased for, this property can be used to explicitly set the purchase price and not require  collateral value and a margin or haircut.  While this property is optional, one, and only one, of PurchasePrice, Margin and Haircut must be specified.
        /// </summary>
        /// <value>The price the collateral is initially purchased for, this property can be used to explicitly set the purchase price and not require  collateral value and a margin or haircut.  While this property is optional, one, and only one, of PurchasePrice, Margin and Haircut must be specified.</value>
        [DataMember(Name = "purchasePrice", EmitDefaultValue = true)]
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// The rate at which interest is to be accrue and be paid upon redemption of the collateral at maturity.  This field is used to calculate the Repurchase price.  While this property is optional, one, and only one, of the RepoRate and RepurchasePrice must be specified.
        /// </summary>
        /// <value>The rate at which interest is to be accrue and be paid upon redemption of the collateral at maturity.  This field is used to calculate the Repurchase price.  While this property is optional, one, and only one, of the RepoRate and RepurchasePrice must be specified.</value>
        [DataMember(Name = "repoRate", EmitDefaultValue = true)]
        public decimal? RepoRate { get; set; }

        /// <summary>
        /// The price at which the collateral is repurchased, this field is optional and can be explicitly set here or will be calculated  from the PurchasePrice and RepoRate.  One, and only one, of the RepoRate and RepurchasePrice must be specified.
        /// </summary>
        /// <value>The price at which the collateral is repurchased, this field is optional and can be explicitly set here or will be calculated  from the PurchasePrice and RepoRate.  One, and only one, of the RepoRate and RepurchasePrice must be specified.</value>
        [DataMember(Name = "repurchasePrice", EmitDefaultValue = true)]
        public decimal? RepurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets TimeZoneConventions
        /// </summary>
        [DataMember(Name = "timeZoneConventions", EmitDefaultValue = false)]
        public TimeZoneConventions TimeZoneConventions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Repo {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  AccrualBasis: ").Append(AccrualBasis).Append("\n");
            sb.Append("  Collateral: ").Append(Collateral).Append("\n");
            sb.Append("  CollateralValue: ").Append(CollateralValue).Append("\n");
            sb.Append("  Haircut: ").Append(Haircut).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  RepoRate: ").Append(RepoRate).Append("\n");
            sb.Append("  RepurchasePrice: ").Append(RepurchasePrice).Append("\n");
            sb.Append("  TimeZoneConventions: ").Append(TimeZoneConventions).Append("\n");
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
            return this.Equals(input as Repo);
        }

        /// <summary>
        /// Returns true if Repo instances are equal
        /// </summary>
        /// <param name="input">Instance of Repo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Repo input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && base.Equals(input) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && base.Equals(input) && 
                (
                    this.AccrualBasis == input.AccrualBasis ||
                    (this.AccrualBasis != null &&
                    this.AccrualBasis.Equals(input.AccrualBasis))
                ) && base.Equals(input) && 
                (
                    this.Collateral == input.Collateral ||
                    this.Collateral != null &&
                    input.Collateral != null &&
                    this.Collateral.SequenceEqual(input.Collateral)
                ) && base.Equals(input) && 
                (
                    this.CollateralValue == input.CollateralValue ||
                    (this.CollateralValue != null &&
                    this.CollateralValue.Equals(input.CollateralValue))
                ) && base.Equals(input) && 
                (
                    this.Haircut == input.Haircut ||
                    (this.Haircut != null &&
                    this.Haircut.Equals(input.Haircut))
                ) && base.Equals(input) && 
                (
                    this.Margin == input.Margin ||
                    (this.Margin != null &&
                    this.Margin.Equals(input.Margin))
                ) && base.Equals(input) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && base.Equals(input) && 
                (
                    this.RepoRate == input.RepoRate ||
                    (this.RepoRate != null &&
                    this.RepoRate.Equals(input.RepoRate))
                ) && base.Equals(input) && 
                (
                    this.RepurchasePrice == input.RepurchasePrice ||
                    (this.RepurchasePrice != null &&
                    this.RepurchasePrice.Equals(input.RepurchasePrice))
                ) && base.Equals(input) && 
                (
                    this.TimeZoneConventions == input.TimeZoneConventions ||
                    (this.TimeZoneConventions != null &&
                    this.TimeZoneConventions.Equals(input.TimeZoneConventions))
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.MaturityDate != null)
                {
                    hashCode = (hashCode * 59) + this.MaturityDate.GetHashCode();
                }
                if (this.DomCcy != null)
                {
                    hashCode = (hashCode * 59) + this.DomCcy.GetHashCode();
                }
                if (this.AccrualBasis != null)
                {
                    hashCode = (hashCode * 59) + this.AccrualBasis.GetHashCode();
                }
                if (this.Collateral != null)
                {
                    hashCode = (hashCode * 59) + this.Collateral.GetHashCode();
                }
                if (this.CollateralValue != null)
                {
                    hashCode = (hashCode * 59) + this.CollateralValue.GetHashCode();
                }
                if (this.Haircut != null)
                {
                    hashCode = (hashCode * 59) + this.Haircut.GetHashCode();
                }
                if (this.Margin != null)
                {
                    hashCode = (hashCode * 59) + this.Margin.GetHashCode();
                }
                if (this.PurchasePrice != null)
                {
                    hashCode = (hashCode * 59) + this.PurchasePrice.GetHashCode();
                }
                if (this.RepoRate != null)
                {
                    hashCode = (hashCode * 59) + this.RepoRate.GetHashCode();
                }
                if (this.RepurchasePrice != null)
                {
                    hashCode = (hashCode * 59) + this.RepurchasePrice.GetHashCode();
                }
                if (this.TimeZoneConventions != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZoneConventions.GetHashCode();
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
            // AccrualBasis (string) minLength
            if (this.AccrualBasis != null && this.AccrualBasis.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccrualBasis, length must be greater than 1.", new [] { "AccrualBasis" });
            }

            yield break;
        }
    }
}
