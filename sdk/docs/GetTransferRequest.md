# Lusid.Sdk.Model.GetTransferRequest
The transfer to read. Every part of its identity is required: a transfer is identified by its scope, its code  and the two portfolios its in and out transaction are booked into.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransferId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioIdOut** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioIdIn** | [**ResourceId**](ResourceId.md) |  | 
**PropertyKeys** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId transferId = new ResourceId();
ResourceId portfolioIdOut = new ResourceId();
ResourceId portfolioIdIn = new ResourceId();
List<string> propertyKeys = new List<string>();

GetTransferRequest getTransferRequestInstance = new GetTransferRequest(
    transferId: transferId,
    portfolioIdOut: portfolioIdOut,
    portfolioIdIn: portfolioIdIn,
    propertyKeys: propertyKeys);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
