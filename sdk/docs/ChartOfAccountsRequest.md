# Lusid.Sdk.Model.ChartOfAccountsRequest
The request used to create a chart of account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the Chart of Accounts. | 
**DisplayName** | **string** | The name of the Chart of Account. | [optional] 
**Description** | **string** | A description of the Chart of Accounts. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Chart of Accounts. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "example displayName";
string description = "example description";
Dictionary<string, Property> properties = new Dictionary<string, Property>();

ChartOfAccountsRequest chartOfAccountsRequestInstance = new ChartOfAccountsRequest(
    code: code,
    displayName: displayName,
    description: description,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
