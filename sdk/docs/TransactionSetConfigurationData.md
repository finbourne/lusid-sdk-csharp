# Lusid.Sdk.Model.TransactionSetConfigurationData
A collection of the data required to configure transaction types..

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionConfigs** | [**List&lt;TransactionConfigurationData&gt;**](TransactionConfigurationData.md) | Collection of transaction type models | 
**SideDefinitions** | [**List&lt;SideConfigurationData&gt;**](SideConfigurationData.md) | Collection of side definitions | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<TransactionConfigurationData> transactionConfigs = new List<TransactionConfigurationData>();
List<SideConfigurationData> sideDefinitions = new List<SideConfigurationData>();
List<Link> links = new List<Link>();

TransactionSetConfigurationData transactionSetConfigurationDataInstance = new TransactionSetConfigurationData(
    transactionConfigs: transactionConfigs,
    sideDefinitions: sideDefinitions,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
