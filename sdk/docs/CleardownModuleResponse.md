# Lusid.Sdk.Model.CleardownModuleResponse
A Cleardown Module definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**CleardownModuleCode** | **string** | The code of the Cleardown Module. | 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Cleardown Module. | 
**Description** | **string** | A description for the Cleardown Module. | [optional] 
**Rules** | [**List&lt;CleardownModuleRule&gt;**](CleardownModuleRule.md) | The Cleardown Rules that apply for the Cleardown Module. Rules are evaluated in the order they occur in this collection. | [optional] 
**Status** | **string** | The Cleardown Module status. Can be Active, Inactive or Deleted. Defaults to Active. | 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

