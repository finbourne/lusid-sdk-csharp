# Lusid.Sdk.Model.CreatePortfolioGroupRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code that the portfolio group will be created with. Together with the scope this uniquely identifies the portfolio group. | 
**Created** | **DateTimeOffset?** | The effective datetime at which the portfolio group was created. Defaults to the current LUSID system datetime if not specified. | [optional] 
**Values** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The resource identifiers of the portfolios to be contained within the portfolio group. | [optional] 
**SubGroups** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The resource identifiers of the portfolio groups to be contained within the portfolio group as sub groups. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of unique group properties to add to the portfolio group. Each property must be from the &#39;PortfolioGroup&#39; domain and should be identified by its key which has the format {domain}/{scope}/{code}, e.g. &#39;PortfolioGroup/Manager/Id&#39;. These properties must be pre-defined. | [optional] 
**DisplayName** | **string** | The name of the portfolio group. | 
**Description** | **string** | A long form description of the portfolio group. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

