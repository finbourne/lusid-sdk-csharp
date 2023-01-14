# Lusid.Sdk.Model.PropertyDefinition
A list of property definitions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Key** | **string** | The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;. | [optional] 
**ValueType** | **string** | The type of values that can be associated with this property. This is defined by the property&#39;s data type. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel | [optional] 
**DisplayName** | **string** | The display name of the property. | [optional] 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Type** | **string** | The type of the property. The available values are: Label, Metric, Information | [optional] 
**UnitSchema** | **string** | The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type. The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**Domain** | **string** | The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar, LegalEntity, Placement, Execution, Block, Participation, Package, OrderInstruction, NextBestAction, CustomEntity, InstrumentEvent, Account, ChartOfAccounts, CustodianAccount, Abor, AborConfiguration, Reconciliation | [optional] 
**Scope** | **string** | The scope that the property exists in. | [optional] [readonly] 
**Code** | **string** | The code of the property. Together with the domain and scope this uniquely identifies the property. | [optional] [readonly] 
**ValueRequired** | **bool** | This field is not implemented and should be disregarded. | [optional] 
**LifeTime** | **string** | Describes how the property&#39;s values can change over time. The available values are: Perpetual, TimeVariant | [optional] 
**ConstraintStyle** | **string** | Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key. | [optional] 
**PropertyDefinitionType** | **string** | The definition type (DerivedDefinition or Definition). The available values are: ValueProperty, DerivedDefinition | [optional] 
**PropertyDescription** | **string** | A brief description of what a property of this property definition contains. | [optional] 
**DerivationFormula** | **string** | The rule that defines how data is composed for a derived property. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

