# Lusid.Sdk.Model.AborConfigurationRequest
The request used to create an AborConfiguration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the Abor Configuration. | 
**DisplayName** | **string** | The name of the Abor Configuration. | [optional] 
**Description** | **string** | A description for the Abor Configuration. | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**PostingModuleCodes** | **List&lt;string&gt;** | The Posting Module Codes from which the rules to be applied are retrieved. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Abor Configuration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

