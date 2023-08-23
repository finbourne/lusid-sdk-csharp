# Lusid.Sdk.Model.Account
An account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the account. | 
**Description** | **string** | The description for the account. | [optional] 
**Type** | **string** | The account type. Can have the values: Asset/Liabilities/Income/Expense/Capital/Revenue. | 
**Status** | **string** | The account status. Can be Active, Inactive or Deleted. Defaults to Active. The available values are: Active, Inactive, Deleted | 
**Control** | **string** | This allows users to specify whether this a protected account that prevents direct manual journal adjustment. Can have the values: System/ManualIt will default to “Manual”. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Account properties to add to the account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

