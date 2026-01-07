# Lusid.Sdk.Model.QuantityInstructed
The quantity of the event that was instructed, represented either as a percentage of the overall holdings or the number of units instructed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of quantity instructed, either Percentage or Units. | 
**Amount** | **decimal** | The actual amount instructed. For Type Percentage, this is between 0 and 100. | 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";decimal amount = "amount";


QuantityInstructed quantityInstructedInstance = new QuantityInstructed(
    type: type,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
