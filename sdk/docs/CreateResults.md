# Lusid.Sdk.Model.CreateResults
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | **DateTimeOffset** | The effective market date for which results are calculated and are to be stored. | 
**EntityScope** | **string** | Scope of the entity code | 
**EntityCode** | **string** | The code of the entity for which the data has been calculated. | 
**CalculationScope** | **string** | Scope of the calculation code. | 
**CalculationCode** | **string** | This is the identifier which denotes some hash of, or recipe, that cumulatively represents the configuration through which  the results being stored are obtained. For example, the recipe denotes the pricing model, the market data and any other  settings. If the results were calculated externally it should be some repeatable hash or other Id that denotes the particular  configuration under which those results were obtained. | 
**Format** | **string** | The format in which the results are stored/structured. | [optional] 
**Data** | **string** | The data that should be stored in the results cube. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

