# Lusid.Sdk.Model.Account
An account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the Account. | 
**Description** | **string** | A description for the Account. | [optional] 
**Type** | **string** | The Account type. Can have the values: Asset/Liabilities/Income/Expense/Capital/Revenue. | 
**Status** | **string** | The Account status. Can be Active, Inactive or Deleted. The available values are: Active, Inactive, Deleted | 
**Control** | **string** | This allows users to specify whether this a protected Account that prevents direct manual journal adjustment. Can have the values: System/ManualIt will default to “Manual”. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Account. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string description = "example description";
string type = "type";
string status = "status";
string control = "example control";
Dictionary<string, Property> properties = new Dictionary<string, Property>();

Account accountInstance = new Account(
    code: code,
    description: description,
    type: type,
    status: status,
    control: control,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
