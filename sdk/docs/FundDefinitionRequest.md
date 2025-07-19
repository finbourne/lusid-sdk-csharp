# Lusid.Sdk.Model.FundDefinitionRequest
The request used to create a Fund.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the Fund. | 
**DisplayName** | **string** | The name of the Fund. | 
**Description** | **string** | A description for the Fund. | [optional] 
**BaseCurrency** | **string** | The base currency of the Fund in ISO 4217 currency code format. All portfolios must be of a matching base currency. | 
**PortfolioIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | A list of the Portfolio IDs associated with the fund, which are part of the Fund. Note: These must all have the same base currency, which must also much the Fund Base Currency. | 
**FundConfigurationId** | [**ResourceId**](ResourceId.md) |  | 
**ShareClassInstrumentScopes** | **List&lt;string&gt;** | The scopes in which the instruments lie, currently limited to one. | [optional] 
**ShareClassInstruments** | [**List&lt;InstrumentResolutionDetail&gt;**](InstrumentResolutionDetail.md) | Details the user-provided instrument identifiers and the instrument resolved from them. | [optional] 
**Type** | **string** | The type of fund; &#39;Standalone&#39;, &#39;Master&#39; or &#39;Feeder&#39; | 
**InceptionDate** | **DateTimeOffset** | Inception date of the Fund | 
**DecimalPlaces** | **int?** | Number of decimal places for reporting | [optional] 
**PrimaryNavType** | [**NavTypeDefinition**](NavTypeDefinition.md) |  | 
**AdditionalNavTypes** | [**List&lt;NavTypeDefinition&gt;**](NavTypeDefinition.md) | The definitions for any additional NAVs on the Fund. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Fund. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

