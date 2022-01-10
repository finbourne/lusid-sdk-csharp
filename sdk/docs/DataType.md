# Lusid.Sdk.Model.DataType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**TypeValueRange** | **string** | The available values are: Open, Closed | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**ValueType** | **string** | The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel | 
**AcceptableValues** | **List&lt;string&gt;** |  | [optional] 
**UnitSchema** | **string** | The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**AcceptableUnits** | [**List&lt;IUnitDefinitionDto&gt;**](IUnitDefinitionDto.md) |  | [optional] 
**ReferenceData** | [**ReferenceData**](ReferenceData.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

