# Lusid.Sdk.Model.CustodianAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustodianAccountId** | [**ResourceId**](ResourceId.md) |  | 
**Status** | **string** | The account status. Can be Active, Inactive or Deleted. Defaults to Active. | 
**AccountNumber** | **string** | The Custodian Account Number | 
**AccountName** | **string** | The identifiable name given to the Custodian Account | 
**AccountingMethod** | **string** | The Accounting method to be used | 
**Currency** | **string** | The Currency for the Account | 
**AccountType** | **string** | The Type of the Custodian Account. Can be Margin, Cash or Swap. Defaults to Margin. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Set of unique Custodian Account properties and associated values to store with the Custodian Account. Each property must be from the &#39;CustodianAccount&#39; domain. | [optional] 
**Custodian** | [**LegalEntity**](LegalEntity.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

