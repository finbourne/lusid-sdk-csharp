# Lusid.Sdk.Model.CreatePropertyDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, InvestorRecord, InvestmentAccount, Placement, Execution, Block, Participation, Package, OrderInstruction, NextBestAction, CustomEntity, InstrumentEvent, Account, ChartOfAccounts, CustodianAccount, CheckDefinition, Abor, AborConfiguration, Fund, FundConfiguration, Fee, Reconciliation, PropertyDefinition, Compliance, DiaryEntry, Leg, DerivedValuation, Timeline, ClosedPeriod, AddressKeyDefinition, AmortisationRuleSet, AnalyticsSetInventory, AtomUnitResult, CleardownModule, ComplexMarketData, ComplianceRunSummary, ComplianceRule, ComplianceRunInfo, CorporateActionSource, CounterpartyAgreement, CustomEntityDefinition, DataType, Dialect, EventHandler, GeneralLedgerProfile, PostingModule, Quote, RecipeComposer, ReconciliationRunBreak, ReferenceList, RelationDefinition, ReturnBlockIndex, SRSDocument, SRSIndex, TransactionTemplate, TransactionTemplateScope, TransactionType, TransactionTypeConfig, TranslationScript, TaskDefinition, TaskInstance, Worker, StagingRuleSet, IdentifierDefinition, SettlementInstruction | 
**Scope** | **string** | The scope that the property exists in. | 
**Code** | **string** | The code of the property. Together with the domain and scope this uniquely identifies the property. | 
**ValueRequired** | **bool** | This field is not implemented and should be disregarded. | [optional] 
**DisplayName** | **string** | The display name of the property. | 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | 
**LifeTime** | **string** | Describes how the property&#39;s values can change over time. The available values are: Perpetual, TimeVariant | [optional] 
**ConstraintStyle** | **string** | Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key. Defaults to \&quot;Property\&quot; if not specified. Valid values for this field are: Property, Collection or Identifier. | [optional] 
**PropertyDescription** | **string** | Describes the property | [optional] 
**CollectionType** | **string** | Describes whether a collection property should behave as a set or as an array. | [optional] 
**CustomEntityTypes** | **List&lt;string&gt;** | The custom entity types that properties relating to this property definition can be applied to. | [optional] 
**ValueFormat** | **string** | The format in which values for this property definition should be represented. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domain = "domain";
string scope = "scope";
string code = "code";
bool valueRequired = //"True";
string displayName = "displayName";
ResourceId dataTypeId = new ResourceId();
string lifeTime = "example lifeTime";
string constraintStyle = "example constraintStyle";
string propertyDescription = "example propertyDescription";
string collectionType = "example collectionType";
List<string> customEntityTypes = new List<string>();
string valueFormat = "example valueFormat";

CreatePropertyDefinitionRequest createPropertyDefinitionRequestInstance = new CreatePropertyDefinitionRequest(
    domain: domain,
    scope: scope,
    code: code,
    valueRequired: valueRequired,
    displayName: displayName,
    dataTypeId: dataTypeId,
    lifeTime: lifeTime,
    constraintStyle: constraintStyle,
    propertyDescription: propertyDescription,
    collectionType: collectionType,
    customEntityTypes: customEntityTypes,
    valueFormat: valueFormat);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
