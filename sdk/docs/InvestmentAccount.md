# Lusid.Sdk.Model.InvestmentAccount
Representation of an Investment Account on the LUSID API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LusidInvestmentAccountId** | **string** | The unique LUSID Investment Account Identifier of the Investment Account. | [optional] 
**DisplayName** | **string** | The display name of the Investment Account | [optional] 
**Description** | **string** | The description of the Investment Account | [optional] 
**Identifiers** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Unique client-defined identifiers of the Investment Account. | [optional] 
**AccountType** | **string** | The type of the of the Investment Account. | [optional] 
**AccountHolders** | [**List&lt;AccountHolder&gt;**](AccountHolder.md) | The Account Holders of the Investment Account. | [optional] 
**InvestmentPortfolios** | [**List&lt;InvestmentPortfolio&gt;**](InvestmentPortfolio.md) | The Investment Portfolios of the Investment Account. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties associated to the Investment Account. | [optional] 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | A set of relationships associated to the Investment Account. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

