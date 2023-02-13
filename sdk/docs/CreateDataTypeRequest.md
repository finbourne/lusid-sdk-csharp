# Lusid.Sdk.Model.CreateDataTypeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope that the data type will be created in. | 
**Code** | **string** | The code of the data type. Together with the scope this uniquely defines the data type. | 
**TypeValueRange** | **string** | Indicates the range of data acceptable by a data type. The available values are: Open, Closed | 
**DisplayName** | **string** | The display name of the data type. | 
**Description** | **string** | The description of the data type. | 
**ValueType** | **string** | The expected type of the values. The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText | 
**AcceptableValues** | **List&lt;string&gt;** | The acceptable set of values for this data type. Only applies to &#39;open&#39; value type range. | [optional] 
**UnitSchema** | **string** | The schema of the data type&#39;s units. The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**AcceptableUnits** | [**List&lt;CreateUnitDefinition&gt;**](CreateUnitDefinition.md) | The definitions of the acceptable units. | [optional] 
**ReferenceData** | [**ReferenceData**](ReferenceData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

