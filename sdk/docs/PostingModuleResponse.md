# Lusid.Sdk.Model.PostingModuleResponse
A Posting Module definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**PostingModuleCode** | **string** | The code of the Posting Module. | 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Posting Module. | 
**Description** | **string** | A description for the Posting Module. | [optional] 
**Rules** | [**List&lt;PostingModuleRule&gt;**](PostingModuleRule.md) | The Posting Rules that apply for the Posting Module. Rules are evaluated in the order they occur in this collection. | [optional] 
**Status** | **string** | The Posting Module status. Can be Active, Inactive or Deleted. Defaults to Active. | 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

