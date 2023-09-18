# Lusid.Sdk.Model.AborConfigurationRequest
The request used to create an AborConfiguration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the AborConfiguration. | 
**DisplayName** | **string** | The given name for the AborConfiguration. | [optional] 
**Description** | **string** | The description for the AborConfiguration. | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**PostingModuleCodes** | **List&lt;string&gt;** | The Posting Modules Codes from where the rules to be applied are retrieved. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Properties to add to the AborConfiguration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

