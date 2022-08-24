# Lusid.Sdk.Model.DataTypeSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TypeValueRange** | **string** | Indicates the range of data acceptable by a data type. The available values are: Open, Closed | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The display name of the data type. | 
**Description** | **string** | The description of the data type. | 
**ValueType** | **string** | The expected type of the values. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel | 
**AcceptableValues** | **List&lt;string&gt;** | The acceptable set of values for this data type. Only applies to &#39;open&#39; value type range. | [optional] 
**UnitSchema** | **string** | The schema of the data type&#39;s units. The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**AcceptableUnits** | [**List&lt;IUnitDefinitionDto&gt;**](IUnitDefinitionDto.md) | The definitions of the acceptable units. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

