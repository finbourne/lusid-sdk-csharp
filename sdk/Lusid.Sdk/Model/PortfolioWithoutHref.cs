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
    /// A list of portfolios.
    /// </summary>
    [DataContract(Name = "PortfolioWithoutHref")]
    public partial class PortfolioWithoutHref : IEquatable<PortfolioWithoutHref>, IValidatableObject
    {
        /// <summary>
        /// The type of the portfolio. The available values are: Transaction, Reference, DerivedTransaction, SimplePosition
        /// </summary>
        /// <value>The type of the portfolio. The available values are: Transaction, Reference, DerivedTransaction, SimplePosition</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Transaction for value: Transaction
            /// </summary>
            [EnumMember(Value = "Transaction")]
            Transaction = 1,

            /// <summary>
            /// Enum Reference for value: Reference
            /// </summary>
            [EnumMember(Value = "Reference")]
            Reference = 2,

            /// <summary>
            /// Enum DerivedTransaction for value: DerivedTransaction
            /// </summary>
            [EnumMember(Value = "DerivedTransaction")]
            DerivedTransaction = 3,

            /// <summary>
            /// Enum SimplePosition for value: SimplePosition
            /// </summary>
            [EnumMember(Value = "SimplePosition")]
            SimplePosition = 4
        }


        /// <summary>
        /// The type of the portfolio. The available values are: Transaction, Reference, DerivedTransaction, SimplePosition
        /// </summary>
        /// <value>The type of the portfolio. The available values are: Transaction, Reference, DerivedTransaction, SimplePosition</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// . The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency
        /// </summary>
        /// <value>. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountingMethodEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,

            /// <summary>
            /// Enum AverageCost for value: AverageCost
            /// </summary>
            [EnumMember(Value = "AverageCost")]
            AverageCost = 2,

            /// <summary>
            /// Enum FirstInFirstOut for value: FirstInFirstOut
            /// </summary>
            [EnumMember(Value = "FirstInFirstOut")]
            FirstInFirstOut = 3,

            /// <summary>
            /// Enum LastInFirstOut for value: LastInFirstOut
            /// </summary>
            [EnumMember(Value = "LastInFirstOut")]
            LastInFirstOut = 4,

            /// <summary>
            /// Enum HighestCostFirst for value: HighestCostFirst
            /// </summary>
            [EnumMember(Value = "HighestCostFirst")]
            HighestCostFirst = 5,

            /// <summary>
            /// Enum LowestCostFirst for value: LowestCostFirst
            /// </summary>
            [EnumMember(Value = "LowestCostFirst")]
            LowestCostFirst = 6,

            /// <summary>
            /// Enum ProRateByUnits for value: ProRateByUnits
            /// </summary>
            [EnumMember(Value = "ProRateByUnits")]
            ProRateByUnits = 7,

            /// <summary>
            /// Enum ProRateByCost for value: ProRateByCost
            /// </summary>
            [EnumMember(Value = "ProRateByCost")]
            ProRateByCost = 8,

            /// <summary>
            /// Enum ProRateByCostPortfolioCurrency for value: ProRateByCostPortfolioCurrency
            /// </summary>
            [EnumMember(Value = "ProRateByCostPortfolioCurrency")]
            ProRateByCostPortfolioCurrency = 9,

            /// <summary>
            /// Enum IntraDayThenFirstInFirstOut for value: IntraDayThenFirstInFirstOut
            /// </summary>
            [EnumMember(Value = "IntraDayThenFirstInFirstOut")]
            IntraDayThenFirstInFirstOut = 10,

            /// <summary>
            /// Enum LongTermHighestCostFirst for value: LongTermHighestCostFirst
            /// </summary>
            [EnumMember(Value = "LongTermHighestCostFirst")]
            LongTermHighestCostFirst = 11,

            /// <summary>
            /// Enum LongTermHighestCostFirstPortfolioCurrency for value: LongTermHighestCostFirstPortfolioCurrency
            /// </summary>
            [EnumMember(Value = "LongTermHighestCostFirstPortfolioCurrency")]
            LongTermHighestCostFirstPortfolioCurrency = 12,

            /// <summary>
            /// Enum HighestCostFirstPortfolioCurrency for value: HighestCostFirstPortfolioCurrency
            /// </summary>
            [EnumMember(Value = "HighestCostFirstPortfolioCurrency")]
            HighestCostFirstPortfolioCurrency = 13,

            /// <summary>
            /// Enum LowestCostFirstPortfolioCurrency for value: LowestCostFirstPortfolioCurrency
            /// </summary>
            [EnumMember(Value = "LowestCostFirstPortfolioCurrency")]
            LowestCostFirstPortfolioCurrency = 14,

            /// <summary>
            /// Enum MaximumLossMinimumGain for value: MaximumLossMinimumGain
            /// </summary>
            [EnumMember(Value = "MaximumLossMinimumGain")]
            MaximumLossMinimumGain = 15,

            /// <summary>
            /// Enum MaximumLossMinimumGainPortfolioCurrency for value: MaximumLossMinimumGainPortfolioCurrency
            /// </summary>
            [EnumMember(Value = "MaximumLossMinimumGainPortfolioCurrency")]
            MaximumLossMinimumGainPortfolioCurrency = 16
        }


        /// <summary>
        /// . The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency
        /// </summary>
        /// <value>. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency</value>
        [DataMember(Name = "accountingMethod", EmitDefaultValue = false)]
        public AccountingMethodEnum? AccountingMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioWithoutHref" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfolioWithoutHref() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioWithoutHref" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="type">The type of the portfolio. The available values are: Transaction, Reference, DerivedTransaction, SimplePosition (required).</param>
        /// <param name="displayName">The name of the portfolio. (required).</param>
        /// <param name="description">The long form description of the portfolio..</param>
        /// <param name="created">The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date. (required).</param>
        /// <param name="parentPortfolioId">parentPortfolioId.</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="stagedModifications">stagedModifications.</param>
        /// <param name="isDerived">Whether or not this is a derived portfolio..</param>
        /// <param name="baseCurrency">The base currency of the portfolio..</param>
        /// <param name="properties">The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain..</param>
        /// <param name="relationships">A set of relationships associated to the portfolio..</param>
        /// <param name="instrumentScopes">The instrument scope resolution strategy of this portfolio..</param>
        /// <param name="accountingMethod">. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst, ProRateByUnits, ProRateByCost, ProRateByCostPortfolioCurrency, IntraDayThenFirstInFirstOut, LongTermHighestCostFirst, LongTermHighestCostFirstPortfolioCurrency, HighestCostFirstPortfolioCurrency, LowestCostFirstPortfolioCurrency, MaximumLossMinimumGain, MaximumLossMinimumGainPortfolioCurrency.</param>
        /// <param name="amortisationMethod">The amortisation method used by the portfolio for the calculation. The available values are: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate.</param>
        /// <param name="transactionTypeScope">The scope of the transaction types..</param>
        /// <param name="cashGainLossCalculationDate">The scope of the transaction types..</param>
        /// <param name="instrumentEventConfiguration">instrumentEventConfiguration.</param>
        /// <param name="amortisationRuleSetId">amortisationRuleSetId.</param>
        /// <param name="taxRuleSetScope">The scope of the tax rule sets for this portfolio..</param>
        /// <param name="links">links.</param>
        public PortfolioWithoutHref(ResourceId id = default(ResourceId), TypeEnum type = default(TypeEnum), string displayName = default(string), string description = default(string), DateTimeOffset created = default(DateTimeOffset), ResourceId parentPortfolioId = default(ResourceId), ModelVersion varVersion = default(ModelVersion), StagedModificationsInfo stagedModifications = default(StagedModificationsInfo), bool isDerived = default(bool), string baseCurrency = default(string), Dictionary<string, Property> properties = default(Dictionary<string, Property>), List<Relationship> relationships = default(List<Relationship>), List<string> instrumentScopes = default(List<string>), AccountingMethodEnum ?accountingMethod = default(AccountingMethodEnum?), string amortisationMethod = default(string), string transactionTypeScope = default(string), string cashGainLossCalculationDate = default(string), InstrumentEventConfiguration instrumentEventConfiguration = default(InstrumentEventConfiguration), ResourceId amortisationRuleSetId = default(ResourceId), string taxRuleSetScope = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PortfolioWithoutHref and cannot be null");
            }
            this.Id = id;
            this.Type = type;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for PortfolioWithoutHref and cannot be null");
            }
            this.DisplayName = displayName;
            this.Created = created;
            this.Description = description;
            this.ParentPortfolioId = parentPortfolioId;
            this.VarVersion = varVersion;
            this.StagedModifications = stagedModifications;
            this.IsDerived = isDerived;
            this.BaseCurrency = baseCurrency;
            this.Properties = properties;
            this.Relationships = relationships;
            this.InstrumentScopes = instrumentScopes;
            this.AccountingMethod = accountingMethod;
            this.AmortisationMethod = amortisationMethod;
            this.TransactionTypeScope = transactionTypeScope;
            this.CashGainLossCalculationDate = cashGainLossCalculationDate;
            this.InstrumentEventConfiguration = instrumentEventConfiguration;
            this.AmortisationRuleSetId = amortisationRuleSetId;
            this.TaxRuleSetScope = taxRuleSetScope;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The name of the portfolio.
        /// </summary>
        /// <value>The name of the portfolio.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The long form description of the portfolio.
        /// </summary>
        /// <value>The long form description of the portfolio.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date.
        /// </summary>
        /// <value>The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date.</value>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// Gets or Sets ParentPortfolioId
        /// </summary>
        [DataMember(Name = "parentPortfolioId", EmitDefaultValue = false)]
        public ResourceId ParentPortfolioId { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public ModelVersion VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets StagedModifications
        /// </summary>
        [DataMember(Name = "stagedModifications", EmitDefaultValue = false)]
        public StagedModificationsInfo StagedModifications { get; set; }

        /// <summary>
        /// Whether or not this is a derived portfolio.
        /// </summary>
        /// <value>Whether or not this is a derived portfolio.</value>
        [DataMember(Name = "isDerived", EmitDefaultValue = true)]
        public bool IsDerived { get; set; }

        /// <summary>
        /// The base currency of the portfolio.
        /// </summary>
        /// <value>The base currency of the portfolio.</value>
        [DataMember(Name = "baseCurrency", EmitDefaultValue = true)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain.
        /// </summary>
        /// <value>The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// A set of relationships associated to the portfolio.
        /// </summary>
        /// <value>A set of relationships associated to the portfolio.</value>
        [DataMember(Name = "relationships", EmitDefaultValue = true)]
        public List<Relationship> Relationships { get; set; }

        /// <summary>
        /// The instrument scope resolution strategy of this portfolio.
        /// </summary>
        /// <value>The instrument scope resolution strategy of this portfolio.</value>
        [DataMember(Name = "instrumentScopes", EmitDefaultValue = true)]
        public List<string> InstrumentScopes { get; set; }

        /// <summary>
        /// The amortisation method used by the portfolio for the calculation. The available values are: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate
        /// </summary>
        /// <value>The amortisation method used by the portfolio for the calculation. The available values are: NoAmortisation, StraightLine, EffectiveYield, StraightLineSettlementDate, EffectiveYieldSettlementDate</value>
        [DataMember(Name = "amortisationMethod", EmitDefaultValue = true)]
        public string AmortisationMethod { get; set; }

        /// <summary>
        /// The scope of the transaction types.
        /// </summary>
        /// <value>The scope of the transaction types.</value>
        [DataMember(Name = "transactionTypeScope", EmitDefaultValue = true)]
        public string TransactionTypeScope { get; set; }

        /// <summary>
        /// The scope of the transaction types.
        /// </summary>
        /// <value>The scope of the transaction types.</value>
        [DataMember(Name = "cashGainLossCalculationDate", EmitDefaultValue = true)]
        public string CashGainLossCalculationDate { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentEventConfiguration
        /// </summary>
        [DataMember(Name = "instrumentEventConfiguration", EmitDefaultValue = false)]
        public InstrumentEventConfiguration InstrumentEventConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets AmortisationRuleSetId
        /// </summary>
        [DataMember(Name = "amortisationRuleSetId", EmitDefaultValue = false)]
        public ResourceId AmortisationRuleSetId { get; set; }

        /// <summary>
        /// The scope of the tax rule sets for this portfolio.
        /// </summary>
        /// <value>The scope of the tax rule sets for this portfolio.</value>
        [DataMember(Name = "taxRuleSetScope", EmitDefaultValue = true)]
        public string TaxRuleSetScope { get; set; }

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
            sb.Append("class PortfolioWithoutHref {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ParentPortfolioId: ").Append(ParentPortfolioId).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  StagedModifications: ").Append(StagedModifications).Append("\n");
            sb.Append("  IsDerived: ").Append(IsDerived).Append("\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
            sb.Append("  InstrumentScopes: ").Append(InstrumentScopes).Append("\n");
            sb.Append("  AccountingMethod: ").Append(AccountingMethod).Append("\n");
            sb.Append("  AmortisationMethod: ").Append(AmortisationMethod).Append("\n");
            sb.Append("  TransactionTypeScope: ").Append(TransactionTypeScope).Append("\n");
            sb.Append("  CashGainLossCalculationDate: ").Append(CashGainLossCalculationDate).Append("\n");
            sb.Append("  InstrumentEventConfiguration: ").Append(InstrumentEventConfiguration).Append("\n");
            sb.Append("  AmortisationRuleSetId: ").Append(AmortisationRuleSetId).Append("\n");
            sb.Append("  TaxRuleSetScope: ").Append(TaxRuleSetScope).Append("\n");
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
            return this.Equals(input as PortfolioWithoutHref);
        }

        /// <summary>
        /// Returns true if PortfolioWithoutHref instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioWithoutHref to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioWithoutHref input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.ParentPortfolioId == input.ParentPortfolioId ||
                    (this.ParentPortfolioId != null &&
                    this.ParentPortfolioId.Equals(input.ParentPortfolioId))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    (this.VarVersion != null &&
                    this.VarVersion.Equals(input.VarVersion))
                ) && 
                (
                    this.StagedModifications == input.StagedModifications ||
                    (this.StagedModifications != null &&
                    this.StagedModifications.Equals(input.StagedModifications))
                ) && 
                (
                    this.IsDerived == input.IsDerived ||
                    this.IsDerived.Equals(input.IsDerived)
                ) && 
                (
                    this.BaseCurrency == input.BaseCurrency ||
                    (this.BaseCurrency != null &&
                    this.BaseCurrency.Equals(input.BaseCurrency))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Relationships == input.Relationships ||
                    this.Relationships != null &&
                    input.Relationships != null &&
                    this.Relationships.SequenceEqual(input.Relationships)
                ) && 
                (
                    this.InstrumentScopes == input.InstrumentScopes ||
                    this.InstrumentScopes != null &&
                    input.InstrumentScopes != null &&
                    this.InstrumentScopes.SequenceEqual(input.InstrumentScopes)
                ) && 
                (
                    this.AccountingMethod == input.AccountingMethod ||
                    this.AccountingMethod.Equals(input.AccountingMethod)
                ) && 
                (
                    this.AmortisationMethod == input.AmortisationMethod ||
                    (this.AmortisationMethod != null &&
                    this.AmortisationMethod.Equals(input.AmortisationMethod))
                ) && 
                (
                    this.TransactionTypeScope == input.TransactionTypeScope ||
                    (this.TransactionTypeScope != null &&
                    this.TransactionTypeScope.Equals(input.TransactionTypeScope))
                ) && 
                (
                    this.CashGainLossCalculationDate == input.CashGainLossCalculationDate ||
                    (this.CashGainLossCalculationDate != null &&
                    this.CashGainLossCalculationDate.Equals(input.CashGainLossCalculationDate))
                ) && 
                (
                    this.InstrumentEventConfiguration == input.InstrumentEventConfiguration ||
                    (this.InstrumentEventConfiguration != null &&
                    this.InstrumentEventConfiguration.Equals(input.InstrumentEventConfiguration))
                ) && 
                (
                    this.AmortisationRuleSetId == input.AmortisationRuleSetId ||
                    (this.AmortisationRuleSetId != null &&
                    this.AmortisationRuleSetId.Equals(input.AmortisationRuleSetId))
                ) && 
                (
                    this.TaxRuleSetScope == input.TaxRuleSetScope ||
                    (this.TaxRuleSetScope != null &&
                    this.TaxRuleSetScope.Equals(input.TaxRuleSetScope))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.ParentPortfolioId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentPortfolioId.GetHashCode();
                }
                if (this.VarVersion != null)
                {
                    hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                }
                if (this.StagedModifications != null)
                {
                    hashCode = (hashCode * 59) + this.StagedModifications.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDerived.GetHashCode();
                if (this.BaseCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.BaseCurrency.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.Relationships != null)
                {
                    hashCode = (hashCode * 59) + this.Relationships.GetHashCode();
                }
                if (this.InstrumentScopes != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentScopes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountingMethod.GetHashCode();
                if (this.AmortisationMethod != null)
                {
                    hashCode = (hashCode * 59) + this.AmortisationMethod.GetHashCode();
                }
                if (this.TransactionTypeScope != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionTypeScope.GetHashCode();
                }
                if (this.CashGainLossCalculationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CashGainLossCalculationDate.GetHashCode();
                }
                if (this.InstrumentEventConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentEventConfiguration.GetHashCode();
                }
                if (this.AmortisationRuleSetId != null)
                {
                    hashCode = (hashCode * 59) + this.AmortisationRuleSetId.GetHashCode();
                }
                if (this.TaxRuleSetScope != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRuleSetScope.GetHashCode();
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
            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            yield break;
        }
    }
}
