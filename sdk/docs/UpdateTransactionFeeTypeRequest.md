# Lusid.Sdk.Model.UpdateTransactionFeeTypeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A description of the transaction fee type. | [optional] 
**Calculation** | [**FeeCalculationRequest**](FeeCalculationRequest.md) |  | [optional] 
**Condition** | **string** | The condition that the transaction must meet in order for the fee to be applied. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the transaction fee type. | [optional] 
**IsActive** | **bool?** | Indicates whether the transaction fee type is currently active and should be applied to transactions. Optional when creating a transaction fee type, defaults to true, if a value is not provided. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string description = "example description";
FeeCalculationRequest? calculation = new FeeCalculationRequest();

string condition = "example condition";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
bool? isActive = //"True";

UpdateTransactionFeeTypeRequest updateTransactionFeeTypeRequestInstance = new UpdateTransactionFeeTypeRequest(
    description: description,
    calculation: calculation,
    condition: condition,
    properties: properties,
    isActive: isActive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
