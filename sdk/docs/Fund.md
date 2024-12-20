# Lusid.Sdk.Model.Fund
A Fund entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Fund. | [optional] 
**Description** | **string** | A description for the Fund. | [optional] 
**FundConfigurationId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AborId** | [**ResourceId**](ResourceId.md) |  | 
**ShareClassInstruments** | [**List&lt;InstrumentResolutionDetail&gt;**](InstrumentResolutionDetail.md) | Details the user-provided instrument identifiers and the instrument resolved from them. | [optional] 
**Type** | **string** | The type of fund; &#39;Standalone&#39;, &#39;Master&#39; or &#39;Feeder&#39; | 
**InceptionDate** | **DateTimeOffset** | Inception date of the Fund | 
**DecimalPlaces** | **int?** | Number of decimal places for reporting | [optional] 
**YearEndDate** | [**DayMonth**](DayMonth.md) |  | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Fund. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

