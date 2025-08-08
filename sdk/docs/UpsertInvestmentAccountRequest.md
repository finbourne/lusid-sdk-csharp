# Lusid.Sdk.Model.UpsertInvestmentAccountRequest
Request to create or update an investor record

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope in which the Investment Account lies. | 
**Identifiers** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Unique client-defined identifiers of the Investment Account. | 
**DisplayName** | **string** | The display name of the Investment Account | 
**Description** | **string** | The description of the Investment Account | [optional] 
**AccountType** | **string** | The type of the of the Investment Account. | 
**AccountHolders** | [**List&lt;AccountHolderIdentifier&gt;**](AccountHolderIdentifier.md) | The identification of the account holders associated with this investment account | [optional] 
**InvestmentPortfolios** | [**List&lt;InvestmentPortfolioIdentifier&gt;**](InvestmentPortfolioIdentifier.md) | The identification of the investment portfolios associated with this investment account | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties associated to the Investment Account. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

