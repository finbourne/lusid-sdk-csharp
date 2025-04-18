# Lusid.Sdk.Model.IdentifierDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Domain** | **string** | The type of entity to which the identifier can be attached. Supported values are \&quot;Instrument\&quot;, \&quot;Person\&quot;, \&quot;LegalEntity\&quot;and \&quot;CustomEntity\&quot;. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, InvestorRecord, Placement, Execution, Block, Participation, Package, OrderInstruction, NextBestAction, CustomEntity, InstrumentEvent, Account, ChartOfAccounts, CustodianAccount, Abor, AborConfiguration, Fund, FundConfiguration, Fee, Reconciliation, PropertyDefinition, Compliance, DiaryEntry, Leg, DerivedValuation, Timeline, ClosedPeriod, AddressKeyDefinition, AmortisationRuleSet, AnalyticsSetInventory, AtomUnitResult, CleardownModule, ComplexMarketData, ComplianceRunSummary, ComplianceRule, ComplianceRunInfo, CorporateActionSource, CounterpartyAgreement, CustomEntityDefinition, DataType, Dialect, EventHandler, GeneralLedgerProfile, PostingModule, Quote, RecipeComposer, ReconciliationRunBreak, ReferenceList, RelationDefinition, ReturnBlockIndex, SRSDocument, SRSIndex, TransactionTemplate, TransactionTemplateScope, TransactionType, TransactionTypeConfig, TranslationScript, TaskDefinition, TaskInstance, Worker, StagingRuleSet, IdentifierDefinition | 
**IdentifierScope** | **string** | The scope that the identifier definition exists in. | 
**IdentifierType** | **string** | What the identifier represents. Together with \&quot;domain\&quot; and \&quot;identifierScope\&quot; this uniquely identifies the identifier definition. | 
**LifeTime** | **string** | Describes whether an identifier value is associated with an entity for all effective dates (“Perpetual”) or applies within a specified effective date range (“TimeVariant”). The available values are: Perpetual, TimeVariant | 
**HierarchyUsage** | **string** | Nullable, defaults to \&quot;MasterIdentifier\&quot; if no value provided. \&quot;MasterIdentifier\&quot; (aka unique) An entity can have one value for this identifier definition on a given effective date. A value for this identifier definition can only be associated with one entity (in a given scope) on a given effective date. \&quot;ParentIdentifier\&quot; (aka non-unique) An entity can have one value for this identifier definition on a given effective date. A value for this identifier definition can be associated with many entities (in a given scope) on a given effective date. | [optional] 
**HierarchyLevel** | **string** | Optional metadata associated with the identifier definition. | [optional] 
**DisplayName** | **string** | A display name for the identifier. E.g. Figi. | [optional] 
**Description** | **string** | An optional description for the identifier. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the identifier definition. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

