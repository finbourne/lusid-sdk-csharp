# Lusid.Sdk.Model.AllocationMapResolveRequest
A dry run of an Allocation Map: the event to share, and the basis values to share it by.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The kind of allocation event to resolve: CapitalCall, Distribution, FeeExpense or ValuationMove. The map must define a basis for it. Available values: CapitalCall, Distribution, FeeExpense, ValuationMove. | 
**Amount** | **decimal** | The amount of the event to share between the participants, in the event currency. | 
**Currency** | **string** | The currency of the amount. | 
**BasisValues** | [**List&lt;AllocationMapBasisValue&gt;**](AllocationMapBasisValue.md) | For a ValueWeighted or PropertyWeighted basis, the basis value of each participating investor record, supplied by the caller until investor records are read from LUSID. Under the AllCommittedToMembers rule these also name the committed investor records. Not needed for a FixedPercentage basis. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string eventType = "eventType";decimal amount = "amount";

string currency = "currency";
List<AllocationMapBasisValue> basisValues = new List<AllocationMapBasisValue>();

AllocationMapResolveRequest allocationMapResolveRequestInstance = new AllocationMapResolveRequest(
    eventType: eventType,
    amount: amount,
    currency: currency,
    basisValues: basisValues);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
