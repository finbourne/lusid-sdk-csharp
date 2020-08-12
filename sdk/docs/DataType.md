
# Lusid.Sdk.Model.DataType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**TypeValueRange** | **string** | The available values are: Open, Closed | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**ValueType** | **string** | The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, BenchmarkType, Code, Id, Uri, ArrayOfIds, ArrayOfTransactionAliases, ArrayofTransactionMovements, ArrayofUnits, StringArray, CurrencyAndAmount, TradePrice, UnitCreation, Currency, UserId, MetricValue, QuoteId, QuoteSeriesId, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, Transition, StructuredData, StructuredDataId, ConfigurationRecipe, ConfigurationRecipeSnippet, StructuredResultDataId, StructuredResultData, DataMapping, LusidInstrument, WeightedInstrument, Tenor, CdsProtectionDetailSpecification, FlowConventions, CdsFlowConventions, Conventions, LegDefinition, IndexConvention, OrderId, Order, Quote, WeekendMask, DateAttributes | 
**AcceptableValues** | **List&lt;string&gt;** |  | [optional] 
**UnitSchema** | **string** | The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**AcceptableUnits** | [**List&lt;IUnitDefinitionDto&gt;**](IUnitDefinitionDto.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

