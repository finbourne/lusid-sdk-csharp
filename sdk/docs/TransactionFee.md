# Lusid.Sdk.Model.TransactionFee

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Name** | **string** | The display name of the transaction fee. | [optional] 
**Description** | **string** | A description of the transaction fee. | [optional] 
**Calculation** | [**FeeCalculationRequest**](FeeCalculationRequest.md) |  | [optional] 
**Conditions** | **List&lt;string&gt;** | The conditions that the transaction must meet in order for the fee to be applied. | [optional] 
**Capitalised** | **string** | Specifies whether the fee should be capitalised, not capitalised or conditionally capitalised. | [optional] 
**CapitalisationCondition** | **string** | If the fee Capitalisation is Conditional, this condition determines whether the fee is capitalised, when applied to the transaction. | [optional] 
**TxnPropertyKey** | **string** | The property key to which the fee value will be applied and decorated onto the transaction. Must be in the &#39;Transaction&#39; property domain. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the transaction fee. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**IsActive** | **bool** | Indicates whether the transaction fee is currently active and should be applied to transactions. Optional when creating a transaction fee, defaults to true, if a value is not provided. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? id = new ResourceId();

string name = "example name";
string description = "example description";
FeeCalculationRequest? calculation = new FeeCalculationRequest();

List<string> conditions = new List<string>();
string capitalised = "example capitalised";
string capitalisationCondition = "example capitalisationCondition";
string txnPropertyKey = "example txnPropertyKey";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion? varVersion = new ModelVersion();

string href = "example href";
bool isActive = //"True";
List<Link> links = new List<Link>();

TransactionFee transactionFeeInstance = new TransactionFee(
    id: id,
    name: name,
    description: description,
    calculation: calculation,
    conditions: conditions,
    capitalised: capitalised,
    capitalisationCondition: capitalisationCondition,
    txnPropertyKey: txnPropertyKey,
    properties: properties,
    varVersion: varVersion,
    href: href,
    isActive: isActive,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
