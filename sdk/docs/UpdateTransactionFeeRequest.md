# Lusid.Sdk.Model.UpdateTransactionFeeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A description of the transaction fee. | [optional] 
**Calculation** | [**FeeCalculationRequest**](FeeCalculationRequest.md) |  | [optional] 
**Condition** | **string** | The condition that the transaction must meet in order for the fee to be applied. | [optional] 
**TxnPropertyKey** | **string** | The property key to which the fee value will be applied and decorated onto the transaction. Must be in the &#39;Transaction&#39; property domain. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the transaction fee. | [optional] 
**IsActive** | **bool?** | Indicates whether the transaction fee is currently active and should be applied to transactions. Optional when creating a transaction fee, defaults to true, if a value is not provided. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string description = "example description";
FeeCalculationRequest? calculation = new FeeCalculationRequest();

string condition = "example condition";
string txnPropertyKey = "example txnPropertyKey";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
bool? isActive = //"True";

UpdateTransactionFeeRequest updateTransactionFeeRequestInstance = new UpdateTransactionFeeRequest(
    description: description,
    calculation: calculation,
    condition: condition,
    txnPropertyKey: txnPropertyKey,
    properties: properties,
    isActive: isActive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
