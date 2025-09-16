# Lusid.Sdk.Model.PropertyDefinition
A list of property definitions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Key** | **string** | The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;. | [optional] 
**ValueType** | **string** | The type of values that can be associated with this property. This is defined by the property&#39;s data type. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText | [optional] 
**DisplayName** | **string** | The display name of the property. | [optional] 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Type** | **string** | The type of the property. The available values are: Label, Metric, Information | [optional] 
**UnitSchema** | **string** | The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type. The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**Domain** | **string** | The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, InvestorRecord, InvestmentAccount, Placement, Execution, Block, Participation, Package, OrderInstruction, NextBestAction, CustomEntity, InstrumentEvent, Account, ChartOfAccounts, CustodianAccount, CheckDefinition, Abor, AborConfiguration, Fund, FundConfiguration, Fee, Reconciliation, PropertyDefinition, Compliance, DiaryEntry, Leg, DerivedValuation, Timeline, ClosedPeriod, AddressKeyDefinition, AmortisationRuleSet, AnalyticsSetInventory, AtomUnitResult, CleardownModule, ComplexMarketData, ComplianceRunSummary, ComplianceRule, ComplianceRunInfo, CorporateActionSource, CounterpartyAgreement, CustomEntityDefinition, DataType, Dialect, EventHandler, GeneralLedgerProfile, PostingModule, Quote, RecipeComposer, ReconciliationRunBreak, ReferenceList, RelationDefinition, ReturnBlockIndex, SRSDocument, SRSIndex, TransactionTemplate, TransactionTemplateScope, TransactionType, TransactionTypeConfig, TranslationScript, TaskDefinition, TaskInstance, Worker, StagingRuleSet, IdentifierDefinition | [optional] 
**Scope** | **string** | The scope that the property exists in. | [optional] [readonly] 
**Code** | **string** | The code of the property. Together with the domain and scope this uniquely identifies the property. | [optional] [readonly] 
**ValueRequired** | **bool** | This field is not implemented and should be disregarded. | [optional] 
**LifeTime** | **string** | Describes how the property&#39;s values can change over time. The available values are: Perpetual, TimeVariant | [optional] 
**ConstraintStyle** | **string** | Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key. | [optional] 
**PropertyDefinitionType** | **string** | The definition type (DerivedDefinition or Definition). The available values are: ValueProperty, DerivedDefinition | [optional] 
**PropertyDescription** | **string** | A brief description of what a property of this property definition contains. | [optional] 
**DerivationFormula** | **string** | The rule that defines how data is composed for a derived property. | [optional] 
**CollectionType** | **string** | Describes whether a collection property should behave as a set or as an array. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Set of unique property definition properties and associated values to store with the property definition. Each property must be from the &#39;PropertyDefinition&#39; domain. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**StagedModifications** | [**StagedModificationsInfo**](StagedModificationsInfo.md) |  | [optional] 
**IsFilterable** | **bool** | Bool indicating whether the values of this property are fitlerable, this is true for all non-derived property defintions.  For a derived definition this must be set true to enable filtering. | [optional] 
**CustomEntityTypes** | **List&lt;string&gt;** | The custom entity types that properties relating to this property definition can be applied to. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string key = "example key";
string valueType = "example valueType";
string displayName = "example displayName";
ResourceId? dataTypeId = new ResourceId();

string type = "example type";
string unitSchema = "example unitSchema";
string domain = "example domain";
string scope = "example scope";
string code = "example code";
bool valueRequired = //"True";
string lifeTime = "example lifeTime";
string constraintStyle = "example constraintStyle";
string propertyDefinitionType = "example propertyDefinitionType";
string propertyDescription = "example propertyDescription";
string derivationFormula = "example derivationFormula";
string collectionType = "example collectionType";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion? varVersion = new ModelVersion();

StagedModificationsInfo? stagedModifications = new StagedModificationsInfo();

bool isFilterable = //"True";
List<string> customEntityTypes = new List<string>();
List<Link> links = new List<Link>();

PropertyDefinition propertyDefinitionInstance = new PropertyDefinition(
    href: href,
    key: key,
    valueType: valueType,
    displayName: displayName,
    dataTypeId: dataTypeId,
    type: type,
    unitSchema: unitSchema,
    domain: domain,
    scope: scope,
    code: code,
    valueRequired: valueRequired,
    lifeTime: lifeTime,
    constraintStyle: constraintStyle,
    propertyDefinitionType: propertyDefinitionType,
    propertyDescription: propertyDescription,
    derivationFormula: derivationFormula,
    collectionType: collectionType,
    properties: properties,
    varVersion: varVersion,
    stagedModifications: stagedModifications,
    isFilterable: isFilterable,
    customEntityTypes: customEntityTypes,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
