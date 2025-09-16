# Lusid.Sdk.Model.ReconciliationBreak
A reconciliation break

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentScope** | **string** | The scope in which the instrument lies. | [optional] 
**InstrumentUid** | **string** | Unique instrument identifier | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Any other properties that comprise the Sub-Holding Key | 
**LeftUnits** | **decimal** | Units from the left hand side | 
**RightUnits** | **decimal** | Units from the right hand side | 
**DifferenceUnits** | **decimal** | Difference in units | 
**LeftCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**RightCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**DifferenceCost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**InstrumentProperties** | [**List&lt;Property&gt;**](Property.md) | Additional features relating to the instrument | 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentScope = "example instrumentScope";
string instrumentUid = "instrumentUid";
Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();decimal leftUnits = "leftUnits";
decimal rightUnits = "rightUnits";
decimal differenceUnits = "differenceUnits";

CurrencyAndAmount leftCost = new CurrencyAndAmount();
CurrencyAndAmount rightCost = new CurrencyAndAmount();
CurrencyAndAmount differenceCost = new CurrencyAndAmount();
List<Property> instrumentProperties = new List<Property>();

ReconciliationBreak reconciliationBreakInstance = new ReconciliationBreak(
    instrumentScope: instrumentScope,
    instrumentUid: instrumentUid,
    subHoldingKeys: subHoldingKeys,
    leftUnits: leftUnits,
    rightUnits: rightUnits,
    differenceUnits: differenceUnits,
    leftCost: leftCost,
    rightCost: rightCost,
    differenceCost: differenceCost,
    instrumentProperties: instrumentProperties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
