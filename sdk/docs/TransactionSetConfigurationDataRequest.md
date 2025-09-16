# Lusid.Sdk.Model.TransactionSetConfigurationDataRequest
A bundle of requests to configure a set of transaction types.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionConfigRequests** | [**List&lt;TransactionConfigurationDataRequest&gt;**](TransactionConfigurationDataRequest.md) | Collection of transaction type models | 
**SideConfigRequests** | [**List&lt;SideConfigurationDataRequest&gt;**](SideConfigurationDataRequest.md) | Collection of side definition requests. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<TransactionConfigurationDataRequest> transactionConfigRequests = new List<TransactionConfigurationDataRequest>();
List<SideConfigurationDataRequest> sideConfigRequests = new List<SideConfigurationDataRequest>();

TransactionSetConfigurationDataRequest transactionSetConfigurationDataRequestInstance = new TransactionSetConfigurationDataRequest(
    transactionConfigRequests: transactionConfigRequests,
    sideConfigRequests: sideConfigRequests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
