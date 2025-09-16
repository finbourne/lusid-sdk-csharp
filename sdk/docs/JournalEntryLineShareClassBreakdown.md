# Lusid.Sdk.Model.JournalEntryLineShareClassBreakdown
The apportionment from overall fund level journal entry Line to the share class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShortCode** | **string** | The share class identifier. | [optional] 
**ApportionmentFactor** | **decimal** | The share class apportionment factor (capital ratio). | [optional] 
**LocalValue** | **decimal** | This journal entry line&#39;s local value amount after apportionment is applied. | [optional] 
**BaseValue** | **decimal** | This journal entry line&#39;s base value amount after apportionment is applied | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string shortCode = "example shortCode";decimal? apportionmentFactor = "example apportionmentFactor";decimal? localValue = "example localValue";decimal? baseValue = "example baseValue";

JournalEntryLineShareClassBreakdown journalEntryLineShareClassBreakdownInstance = new JournalEntryLineShareClassBreakdown(
    shortCode: shortCode,
    apportionmentFactor: apportionmentFactor,
    localValue: localValue,
    baseValue: baseValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
