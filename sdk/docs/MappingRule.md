# Lusid.Sdk.Model.MappingRule
An individual mapping rule, for mapping between a left and right field/property.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | **string** | The name of the field/property in the left resource (e.g. a transaction) | [optional] 
**Right** | **string** | The name of the field/property in the right resource (e.g. a transaction) | [optional] 
**ComparisonType** | **string** | The type of comparison to be performed | [optional] 
**ComparisonValue** | **decimal?** | The (optional) value used with Finbourne.WebApi.Interface.Dto.Mappings.MappingRule.ComparisonType | [optional] 
**Weight** | **decimal** | A factor used to influence the importance of this item. | [optional] 
**MappedStrings** | [**List&lt;MappedString&gt;**](MappedString.md) | The (optional) value used to map string values. | [optional] 
**IsCaseSensitive** | **bool** | Should string comparisons take case into account, defaults to &#x60;false&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

