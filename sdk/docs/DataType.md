# Lusid.Sdk.Model.DataType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TypeValueRange** | **string** | The available values are: Open, Closed | 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**ValueType** | **string** | The available values are: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText | 
**AcceptableValues** | **List&lt;string&gt;** |  | [optional] 
**UnitSchema** | **string** | The available values are: NoUnits, Basic, Iso4217Currency | [optional] 
**AcceptableUnits** | [**List&lt;IUnitDefinitionDto&gt;**](IUnitDefinitionDto.md) |  | [optional] 
**ReferenceData** | [**ReferenceData**](ReferenceData.md) |  | [optional] 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

