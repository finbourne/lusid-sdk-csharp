# Lusid.Sdk.Model.AllocationPostingRollUp
One roll-up a booking writes on a vehicle's line on the register above it, summing the lines beneath.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The deterministic identifier of the posting: the booking reference, investor record, commitment line, component and side. | [optional] 
**Line** | **string** | The roll-up line, rendered as the held vehicle and the register above it. | [optional] 
**Portfolio** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Amount** | **decimal** | The amount posted, in the event currency. | [optional] 
**Component** | **string** | The component of the event the posting carries. | [optional] 
**SumOf** | **List&lt;string&gt;** | The identifiers of the postings beneath that the roll-up sums. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "example id";
string line = "example line";
ResourceId? portfolio = new ResourceId();
decimal? amount = "example amount";
string component = "example component";
List<string> sumOf = new List<string>();

AllocationPostingRollUp allocationPostingRollUpInstance = new AllocationPostingRollUp(
    id: id,
    line: line,
    portfolio: portfolio,
    amount: amount,
    component: component,
    sumOf: sumOf);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
