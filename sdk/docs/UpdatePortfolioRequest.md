# Lusid.Sdk.Model.UpdatePortfolioRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the transaction portfolio. | 
**Description** | **string** | The description of the transaction portfolio. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";

UpdatePortfolioRequest updatePortfolioRequestInstance = new UpdatePortfolioRequest(
    displayName: displayName,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
