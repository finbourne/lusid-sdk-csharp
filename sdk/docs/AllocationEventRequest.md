# Lusid.Sdk.Model.AllocationEventRequest
The request used to raise or replace an Allocation Event. The event is computed against its map straight away.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the event. | 
**AllocationMapId** | [**ResourceId**](ResourceId.md) |  | 
**EventType** | **string** | The type of the event: CapitalCall, Distribution, FeeExpense or ValuationMove. Selects the basis rule from the map. Available values: CapitalCall, Distribution, FeeExpense, ValuationMove. | 
**Amount** | **decimal** | The total amount to be shared across the participants. | 
**Currency** | **string** | The ISO 4217 code of the currency of the amount. The amount may not be finer than the currency&#39;s minor unit: two decimal places for most currencies, none for JPY, three for KWD and BHD. A code with no defined minor unit, such as XAU or XAG, is taken to have two decimal places. | 
**EventDate** | **DateTimeOffset** | The date of the event: the point at which the map, its participants and their basis values are read. | 
**Description** | **string** | A description of the Allocation Event. | [optional] 
**BasisValues** | [**List&lt;AllocationMapBasisValue&gt;**](AllocationMapBasisValue.md) | Optional basis values per investor record, used when the map&#39;s basis is not resolvable from stored data. | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The effective datetime at which the event is created or replaced. Defaults to the earliest effective time on create and the current LUSID system datetime on replace. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
ResourceId allocationMapId = new ResourceId();
string eventType = "eventType";decimal amount = "amount";

string currency = "currency";
string description = "example description";
List<AllocationMapBasisValue> basisValues = new List<AllocationMapBasisValue>();

AllocationEventRequest allocationEventRequestInstance = new AllocationEventRequest(
    code: code,
    allocationMapId: allocationMapId,
    eventType: eventType,
    amount: amount,
    currency: currency,
    eventDate: eventDate,
    description: description,
    basisValues: basisValues,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
