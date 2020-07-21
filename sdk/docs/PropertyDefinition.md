
# Lusid.Sdk.Model.PropertyDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Key** | **string** | The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;. | [optional] 
**ValueType** | **string** | The type of values that can be associated with this property. This is defined by the property&#39;s data type. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, BenchmarkType, Code, Id, Uri, ArrayOfIds, ArrayOfTransactionAliases, ArrayofTransactionMovements, ArrayofUnits, StringArray, CurrencyAndAmount, TradePrice, UnitCreation, Currency, UserId, MetricValue, QuoteId, QuoteSeriesId, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, Transition, StructuredData, StructuredDataId, ConfigurationRecipe, ConfigurationRecipeSnippet, StructuredResultDataId, StructuredResultData, DataMapping, LusidInstrument, WeightedInstrument, Tenor, CdsProtectionDetailSpecification, FlowConventions, CdsFlowConventions, LegDefinition, IndexConvention, OrderId, Order, Quote, WeekendMask, DateAttributes | [optional] 
**ValueRequired** | **bool?** | Whether or not a value is always required for this property. | [optional] 
**DisplayName** | **string** | The display name of the property. | [optional] 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**LifeTime** | **string** | Describes how the property&#39;s values can change over time. The available values are: Perpetual, TimeVariant | [optional] 
**Type** | **string** | The type of the property. The available values are: Label, Metric, Information | [optional] 
**UnitSchema** | **string** | The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type. The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**Domain** | **string** | The domain that the property exists in. The available values are: NotDefined, Transaction, Portfolio, Holding, ReferenceHolding, TransactionConfiguration, Instrument, CutLabelDefinition, Analytic, PortfolioGroup, Person, AccessMetadata, Order, UnitResult, MarketData, ConfigurationRecipe, Allocation, Calendar | [optional] 
**Scope** | **string** | The scope that the property exists in. | [optional] 
**Code** | **string** | The code of the property. Together with the domain and scope this uniquely identifies the property. | [optional] 
**ConstraintStyle** | **string** | Describes the uniqueness and cardinality of the property for entity objects under the property domain specified in Key. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

