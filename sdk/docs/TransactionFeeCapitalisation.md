# Lusid.Sdk.Model.TransactionFeeCapitalisation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capitalisation** | **string** | Whether the transaction fee should be capitalised, not capitalised, or conditionally capitalised. The allowed values are Capitalised, NonCapitalised, Conditional. | [optional] 
**CapitalisedCondition** | **string** | The condition that determines whether the fee is capitalised when applied to the transaction. Required only when Capitalisation is &#39;Conditional&#39;. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string capitalisation = "example capitalisation";
string capitalisedCondition = "example capitalisedCondition";

TransactionFeeCapitalisation transactionFeeCapitalisationInstance = new TransactionFeeCapitalisation(
    capitalisation: capitalisation,
    capitalisedCondition: capitalisedCondition);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
