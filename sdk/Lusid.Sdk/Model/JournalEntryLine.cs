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
    /// A Journal Entry line entity.
    /// </summary>
    [DataContract(Name = "JournalEntryLine")]
    public partial class JournalEntryLine : IEquatable<JournalEntryLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntryLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JournalEntryLine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntryLine" /> class.
        /// </summary>
        /// <param name="accountingDate">The Journal Entry Line accounting date. (required).</param>
        /// <param name="activityDate">The actual date of the activity. Differs from the accounting date when creating journals that would occur in a closed period. (required).</param>
        /// <param name="portfolioId">portfolioId (required).</param>
        /// <param name="instrumentId">To indicate the instrument of the transaction that the Journal Entry Line posted for, if applicable. (required).</param>
        /// <param name="instrumentScope">The scope in which the Journal Entry Line instrument is in. (required).</param>
        /// <param name="subHoldingKeys">The sub-holding properties which are part of the AccountingKey..</param>
        /// <param name="taxLotId">The tax lot Id that the Journal Entry Line is impacting. (required).</param>
        /// <param name="generalLedgerAccountCode">The code of the account in the general ledger the Journal Entry was posted to. (required).</param>
        /// <param name="local">local (required).</param>
        /// <param name="_base">_base (required).</param>
        /// <param name="postingModuleCode">The code of the posting module where the posting rules derived the Journal Entry lines..</param>
        /// <param name="postingRule">The rule generating the Journal Entry Line. (required).</param>
        /// <param name="asAtDate">The corresponding input date and time of the Transaction generating the Journal Entry Line. (required).</param>
        /// <param name="activitiesDescription">This would be the description of the business activities this Journal Entry Line is for..</param>
        /// <param name="sourceType">So far are 4 types: LusidTxn, LusidValuation, Manual and External. (required).</param>
        /// <param name="sourceId">For the Lusid Source Type this will be the txn Id. For the rest will be what the user populates. (required).</param>
        /// <param name="properties">A set of properties for the Abor..</param>
        /// <param name="movementName">The name of the movement. (required).</param>
        /// <param name="holdingType">Defines the broad category holding within the portfolio. (required).</param>
        /// <param name="economicBucket">Raw Journal Entry Line details of the economic bucket for the Journal Entry Line. (required).</param>
        /// <param name="levels">Resolved data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body..</param>
        /// <param name="sourceLevels">Source data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body..</param>
        /// <param name="links">links.</param>
        public JournalEntryLine(DateTimeOffset accountingDate = default(DateTimeOffset), DateTimeOffset activityDate = default(DateTimeOffset), ResourceId portfolioId = default(ResourceId), string instrumentId = default(string), string instrumentScope = default(string), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), string taxLotId = default(string), string generalLedgerAccountCode = default(string), CurrencyAndAmount local = default(CurrencyAndAmount), CurrencyAndAmount _base = default(CurrencyAndAmount), string postingModuleCode = default(string), string postingRule = default(string), DateTimeOffset asAtDate = default(DateTimeOffset), string activitiesDescription = default(string), string sourceType = default(string), string sourceId = default(string), Dictionary<string, Property> properties = default(Dictionary<string, Property>), string movementName = default(string), string holdingType = default(string), string economicBucket = default(string), List<string> levels = default(List<string>), List<string> sourceLevels = default(List<string>), List<Link> links = default(List<Link>))
        {
            this.AccountingDate = accountingDate;
            this.ActivityDate = activityDate;
            // to ensure "portfolioId" is required (not null)
            if (portfolioId == null)
            {
                throw new ArgumentNullException("portfolioId is a required property for JournalEntryLine and cannot be null");
            }
            this.PortfolioId = portfolioId;
            // to ensure "instrumentId" is required (not null)
            if (instrumentId == null)
            {
                throw new ArgumentNullException("instrumentId is a required property for JournalEntryLine and cannot be null");
            }
            this.InstrumentId = instrumentId;
            // to ensure "instrumentScope" is required (not null)
            if (instrumentScope == null)
            {
                throw new ArgumentNullException("instrumentScope is a required property for JournalEntryLine and cannot be null");
            }
            this.InstrumentScope = instrumentScope;
            // to ensure "taxLotId" is required (not null)
            if (taxLotId == null)
            {
                throw new ArgumentNullException("taxLotId is a required property for JournalEntryLine and cannot be null");
            }
            this.TaxLotId = taxLotId;
            // to ensure "generalLedgerAccountCode" is required (not null)
            if (generalLedgerAccountCode == null)
            {
                throw new ArgumentNullException("generalLedgerAccountCode is a required property for JournalEntryLine and cannot be null");
            }
            this.GeneralLedgerAccountCode = generalLedgerAccountCode;
            // to ensure "local" is required (not null)
            if (local == null)
            {
                throw new ArgumentNullException("local is a required property for JournalEntryLine and cannot be null");
            }
            this.Local = local;
            // to ensure "_base" is required (not null)
            if (_base == null)
            {
                throw new ArgumentNullException("_base is a required property for JournalEntryLine and cannot be null");
            }
            this.Base = _base;
            // to ensure "postingRule" is required (not null)
            if (postingRule == null)
            {
                throw new ArgumentNullException("postingRule is a required property for JournalEntryLine and cannot be null");
            }
            this.PostingRule = postingRule;
            this.AsAtDate = asAtDate;
            // to ensure "sourceType" is required (not null)
            if (sourceType == null)
            {
                throw new ArgumentNullException("sourceType is a required property for JournalEntryLine and cannot be null");
            }
            this.SourceType = sourceType;
            // to ensure "sourceId" is required (not null)
            if (sourceId == null)
            {
                throw new ArgumentNullException("sourceId is a required property for JournalEntryLine and cannot be null");
            }
            this.SourceId = sourceId;
            // to ensure "movementName" is required (not null)
            if (movementName == null)
            {
                throw new ArgumentNullException("movementName is a required property for JournalEntryLine and cannot be null");
            }
            this.MovementName = movementName;
            // to ensure "holdingType" is required (not null)
            if (holdingType == null)
            {
                throw new ArgumentNullException("holdingType is a required property for JournalEntryLine and cannot be null");
            }
            this.HoldingType = holdingType;
            // to ensure "economicBucket" is required (not null)
            if (economicBucket == null)
            {
                throw new ArgumentNullException("economicBucket is a required property for JournalEntryLine and cannot be null");
            }
            this.EconomicBucket = economicBucket;
            this.SubHoldingKeys = subHoldingKeys;
            this.PostingModuleCode = postingModuleCode;
            this.ActivitiesDescription = activitiesDescription;
            this.Properties = properties;
            this.Levels = levels;
            this.SourceLevels = sourceLevels;
            this.Links = links;
        }

        /// <summary>
        /// The Journal Entry Line accounting date.
        /// </summary>
        /// <value>The Journal Entry Line accounting date.</value>
        [DataMember(Name = "accountingDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset AccountingDate { get; set; }

        /// <summary>
        /// The actual date of the activity. Differs from the accounting date when creating journals that would occur in a closed period.
        /// </summary>
        /// <value>The actual date of the activity. Differs from the accounting date when creating journals that would occur in a closed period.</value>
        [DataMember(Name = "activityDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset ActivityDate { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name = "portfolioId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId PortfolioId { get; set; }

        /// <summary>
        /// To indicate the instrument of the transaction that the Journal Entry Line posted for, if applicable.
        /// </summary>
        /// <value>To indicate the instrument of the transaction that the Journal Entry Line posted for, if applicable.</value>
        [DataMember(Name = "instrumentId", IsRequired = true, EmitDefaultValue = true)]
        public string InstrumentId { get; set; }

        /// <summary>
        /// The scope in which the Journal Entry Line instrument is in.
        /// </summary>
        /// <value>The scope in which the Journal Entry Line instrument is in.</value>
        [DataMember(Name = "instrumentScope", IsRequired = true, EmitDefaultValue = true)]
        public string InstrumentScope { get; set; }

        /// <summary>
        /// The sub-holding properties which are part of the AccountingKey.
        /// </summary>
        /// <value>The sub-holding properties which are part of the AccountingKey.</value>
        [DataMember(Name = "subHoldingKeys", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// The tax lot Id that the Journal Entry Line is impacting.
        /// </summary>
        /// <value>The tax lot Id that the Journal Entry Line is impacting.</value>
        [DataMember(Name = "taxLotId", IsRequired = true, EmitDefaultValue = true)]
        public string TaxLotId { get; set; }

        /// <summary>
        /// The code of the account in the general ledger the Journal Entry was posted to.
        /// </summary>
        /// <value>The code of the account in the general ledger the Journal Entry was posted to.</value>
        [DataMember(Name = "generalLedgerAccountCode", IsRequired = true, EmitDefaultValue = true)]
        public string GeneralLedgerAccountCode { get; set; }

        /// <summary>
        /// Gets or Sets Local
        /// </summary>
        [DataMember(Name = "local", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyAndAmount Local { get; set; }

        /// <summary>
        /// Gets or Sets Base
        /// </summary>
        [DataMember(Name = "base", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyAndAmount Base { get; set; }

        /// <summary>
        /// The code of the posting module where the posting rules derived the Journal Entry lines.
        /// </summary>
        /// <value>The code of the posting module where the posting rules derived the Journal Entry lines.</value>
        [DataMember(Name = "postingModuleCode", EmitDefaultValue = true)]
        public string PostingModuleCode { get; set; }

        /// <summary>
        /// The rule generating the Journal Entry Line.
        /// </summary>
        /// <value>The rule generating the Journal Entry Line.</value>
        [DataMember(Name = "postingRule", IsRequired = true, EmitDefaultValue = true)]
        public string PostingRule { get; set; }

        /// <summary>
        /// The corresponding input date and time of the Transaction generating the Journal Entry Line.
        /// </summary>
        /// <value>The corresponding input date and time of the Transaction generating the Journal Entry Line.</value>
        [DataMember(Name = "asAtDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset AsAtDate { get; set; }

        /// <summary>
        /// This would be the description of the business activities this Journal Entry Line is for.
        /// </summary>
        /// <value>This would be the description of the business activities this Journal Entry Line is for.</value>
        [DataMember(Name = "activitiesDescription", EmitDefaultValue = true)]
        public string ActivitiesDescription { get; set; }

        /// <summary>
        /// So far are 4 types: LusidTxn, LusidValuation, Manual and External.
        /// </summary>
        /// <value>So far are 4 types: LusidTxn, LusidValuation, Manual and External.</value>
        [DataMember(Name = "sourceType", IsRequired = true, EmitDefaultValue = true)]
        public string SourceType { get; set; }

        /// <summary>
        /// For the Lusid Source Type this will be the txn Id. For the rest will be what the user populates.
        /// </summary>
        /// <value>For the Lusid Source Type this will be the txn Id. For the rest will be what the user populates.</value>
        [DataMember(Name = "sourceId", IsRequired = true, EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// A set of properties for the Abor.
        /// </summary>
        /// <value>A set of properties for the Abor.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// The name of the movement.
        /// </summary>
        /// <value>The name of the movement.</value>
        [DataMember(Name = "movementName", IsRequired = true, EmitDefaultValue = true)]
        public string MovementName { get; set; }

        /// <summary>
        /// Defines the broad category holding within the portfolio.
        /// </summary>
        /// <value>Defines the broad category holding within the portfolio.</value>
        [DataMember(Name = "holdingType", IsRequired = true, EmitDefaultValue = true)]
        public string HoldingType { get; set; }

        /// <summary>
        /// Raw Journal Entry Line details of the economic bucket for the Journal Entry Line.
        /// </summary>
        /// <value>Raw Journal Entry Line details of the economic bucket for the Journal Entry Line.</value>
        [DataMember(Name = "economicBucket", IsRequired = true, EmitDefaultValue = true)]
        public string EconomicBucket { get; set; }

        /// <summary>
        /// Resolved data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body.
        /// </summary>
        /// <value>Resolved data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body.</value>
        [DataMember(Name = "levels", EmitDefaultValue = true)]
        public List<string> Levels { get; set; }

        /// <summary>
        /// Source data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body.
        /// </summary>
        /// <value>Source data from the general ledger profile where the GeneralLedgerProfileCode is specified in the GetJournalEntryLines request body.</value>
        [DataMember(Name = "sourceLevels", EmitDefaultValue = true)]
        public List<string> SourceLevels { get; set; }

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
            sb.Append("class JournalEntryLine {\n");
            sb.Append("  AccountingDate: ").Append(AccountingDate).Append("\n");
            sb.Append("  ActivityDate: ").Append(ActivityDate).Append("\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  InstrumentId: ").Append(InstrumentId).Append("\n");
            sb.Append("  InstrumentScope: ").Append(InstrumentScope).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  TaxLotId: ").Append(TaxLotId).Append("\n");
            sb.Append("  GeneralLedgerAccountCode: ").Append(GeneralLedgerAccountCode).Append("\n");
            sb.Append("  Local: ").Append(Local).Append("\n");
            sb.Append("  Base: ").Append(Base).Append("\n");
            sb.Append("  PostingModuleCode: ").Append(PostingModuleCode).Append("\n");
            sb.Append("  PostingRule: ").Append(PostingRule).Append("\n");
            sb.Append("  AsAtDate: ").Append(AsAtDate).Append("\n");
            sb.Append("  ActivitiesDescription: ").Append(ActivitiesDescription).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  MovementName: ").Append(MovementName).Append("\n");
            sb.Append("  HoldingType: ").Append(HoldingType).Append("\n");
            sb.Append("  EconomicBucket: ").Append(EconomicBucket).Append("\n");
            sb.Append("  Levels: ").Append(Levels).Append("\n");
            sb.Append("  SourceLevels: ").Append(SourceLevels).Append("\n");
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
            return this.Equals(input as JournalEntryLine);
        }

        /// <summary>
        /// Returns true if JournalEntryLine instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalEntryLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalEntryLine input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountingDate == input.AccountingDate ||
                    (this.AccountingDate != null &&
                    this.AccountingDate.Equals(input.AccountingDate))
                ) && 
                (
                    this.ActivityDate == input.ActivityDate ||
                    (this.ActivityDate != null &&
                    this.ActivityDate.Equals(input.ActivityDate))
                ) && 
                (
                    this.PortfolioId == input.PortfolioId ||
                    (this.PortfolioId != null &&
                    this.PortfolioId.Equals(input.PortfolioId))
                ) && 
                (
                    this.InstrumentId == input.InstrumentId ||
                    (this.InstrumentId != null &&
                    this.InstrumentId.Equals(input.InstrumentId))
                ) && 
                (
                    this.InstrumentScope == input.InstrumentScope ||
                    (this.InstrumentScope != null &&
                    this.InstrumentScope.Equals(input.InstrumentScope))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.TaxLotId == input.TaxLotId ||
                    (this.TaxLotId != null &&
                    this.TaxLotId.Equals(input.TaxLotId))
                ) && 
                (
                    this.GeneralLedgerAccountCode == input.GeneralLedgerAccountCode ||
                    (this.GeneralLedgerAccountCode != null &&
                    this.GeneralLedgerAccountCode.Equals(input.GeneralLedgerAccountCode))
                ) && 
                (
                    this.Local == input.Local ||
                    (this.Local != null &&
                    this.Local.Equals(input.Local))
                ) && 
                (
                    this.Base == input.Base ||
                    (this.Base != null &&
                    this.Base.Equals(input.Base))
                ) && 
                (
                    this.PostingModuleCode == input.PostingModuleCode ||
                    (this.PostingModuleCode != null &&
                    this.PostingModuleCode.Equals(input.PostingModuleCode))
                ) && 
                (
                    this.PostingRule == input.PostingRule ||
                    (this.PostingRule != null &&
                    this.PostingRule.Equals(input.PostingRule))
                ) && 
                (
                    this.AsAtDate == input.AsAtDate ||
                    (this.AsAtDate != null &&
                    this.AsAtDate.Equals(input.AsAtDate))
                ) && 
                (
                    this.ActivitiesDescription == input.ActivitiesDescription ||
                    (this.ActivitiesDescription != null &&
                    this.ActivitiesDescription.Equals(input.ActivitiesDescription))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.SourceId == input.SourceId ||
                    (this.SourceId != null &&
                    this.SourceId.Equals(input.SourceId))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.MovementName == input.MovementName ||
                    (this.MovementName != null &&
                    this.MovementName.Equals(input.MovementName))
                ) && 
                (
                    this.HoldingType == input.HoldingType ||
                    (this.HoldingType != null &&
                    this.HoldingType.Equals(input.HoldingType))
                ) && 
                (
                    this.EconomicBucket == input.EconomicBucket ||
                    (this.EconomicBucket != null &&
                    this.EconomicBucket.Equals(input.EconomicBucket))
                ) && 
                (
                    this.Levels == input.Levels ||
                    this.Levels != null &&
                    input.Levels != null &&
                    this.Levels.SequenceEqual(input.Levels)
                ) && 
                (
                    this.SourceLevels == input.SourceLevels ||
                    this.SourceLevels != null &&
                    input.SourceLevels != null &&
                    this.SourceLevels.SequenceEqual(input.SourceLevels)
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
                if (this.AccountingDate != null)
                {
                    hashCode = (hashCode * 59) + this.AccountingDate.GetHashCode();
                }
                if (this.ActivityDate != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityDate.GetHashCode();
                }
                if (this.PortfolioId != null)
                {
                    hashCode = (hashCode * 59) + this.PortfolioId.GetHashCode();
                }
                if (this.InstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentId.GetHashCode();
                }
                if (this.InstrumentScope != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentScope.GetHashCode();
                }
                if (this.SubHoldingKeys != null)
                {
                    hashCode = (hashCode * 59) + this.SubHoldingKeys.GetHashCode();
                }
                if (this.TaxLotId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxLotId.GetHashCode();
                }
                if (this.GeneralLedgerAccountCode != null)
                {
                    hashCode = (hashCode * 59) + this.GeneralLedgerAccountCode.GetHashCode();
                }
                if (this.Local != null)
                {
                    hashCode = (hashCode * 59) + this.Local.GetHashCode();
                }
                if (this.Base != null)
                {
                    hashCode = (hashCode * 59) + this.Base.GetHashCode();
                }
                if (this.PostingModuleCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostingModuleCode.GetHashCode();
                }
                if (this.PostingRule != null)
                {
                    hashCode = (hashCode * 59) + this.PostingRule.GetHashCode();
                }
                if (this.AsAtDate != null)
                {
                    hashCode = (hashCode * 59) + this.AsAtDate.GetHashCode();
                }
                if (this.ActivitiesDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ActivitiesDescription.GetHashCode();
                }
                if (this.SourceType != null)
                {
                    hashCode = (hashCode * 59) + this.SourceType.GetHashCode();
                }
                if (this.SourceId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceId.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.MovementName != null)
                {
                    hashCode = (hashCode * 59) + this.MovementName.GetHashCode();
                }
                if (this.HoldingType != null)
                {
                    hashCode = (hashCode * 59) + this.HoldingType.GetHashCode();
                }
                if (this.EconomicBucket != null)
                {
                    hashCode = (hashCode * 59) + this.EconomicBucket.GetHashCode();
                }
                if (this.Levels != null)
                {
                    hashCode = (hashCode * 59) + this.Levels.GetHashCode();
                }
                if (this.SourceLevels != null)
                {
                    hashCode = (hashCode * 59) + this.SourceLevels.GetHashCode();
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
            // InstrumentId (string) minLength
            if (this.InstrumentId != null && this.InstrumentId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentId, length must be greater than 1.", new [] { "InstrumentId" });
            }

            // InstrumentScope (string) minLength
            if (this.InstrumentScope != null && this.InstrumentScope.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentScope, length must be greater than 1.", new [] { "InstrumentScope" });
            }

            // TaxLotId (string) minLength
            if (this.TaxLotId != null && this.TaxLotId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxLotId, length must be greater than 1.", new [] { "TaxLotId" });
            }

            // GeneralLedgerAccountCode (string) minLength
            if (this.GeneralLedgerAccountCode != null && this.GeneralLedgerAccountCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GeneralLedgerAccountCode, length must be greater than 1.", new [] { "GeneralLedgerAccountCode" });
            }

            // PostingRule (string) minLength
            if (this.PostingRule != null && this.PostingRule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostingRule, length must be greater than 1.", new [] { "PostingRule" });
            }

            // ActivitiesDescription (string) maxLength
            if (this.ActivitiesDescription != null && this.ActivitiesDescription.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActivitiesDescription, length must be less than 1024.", new [] { "ActivitiesDescription" });
            }

            // ActivitiesDescription (string) minLength
            if (this.ActivitiesDescription != null && this.ActivitiesDescription.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActivitiesDescription, length must be greater than 0.", new [] { "ActivitiesDescription" });
            }

            // SourceType (string) minLength
            if (this.SourceType != null && this.SourceType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceType, length must be greater than 1.", new [] { "SourceType" });
            }

            // SourceId (string) minLength
            if (this.SourceId != null && this.SourceId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceId, length must be greater than 1.", new [] { "SourceId" });
            }

            // MovementName (string) minLength
            if (this.MovementName != null && this.MovementName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MovementName, length must be greater than 1.", new [] { "MovementName" });
            }

            // HoldingType (string) minLength
            if (this.HoldingType != null && this.HoldingType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HoldingType, length must be greater than 1.", new [] { "HoldingType" });
            }

            // EconomicBucket (string) minLength
            if (this.EconomicBucket != null && this.EconomicBucket.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EconomicBucket, length must be greater than 1.", new [] { "EconomicBucket" });
            }

            yield break;
        }
    }
}