# Lusid.Sdk.Model.MovementSettlementSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**LusidInstrumentId** | **string** |  | [optional] 
**InstrumentScope** | **string** |  | [optional] 
**SettlementMode** | **string** |  | [optional] 
**ContractualSettlementDate** | **string** |  | [optional] 
**Units** | **decimal** |  | [optional] 
**SettledUnits** | **decimal** |  | [optional] 
**UnsettledUnits** | **decimal** |  | [optional] 
**OverdueUnits** | **decimal** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "example name";
string type = "example type";
string lusidInstrumentId = "example lusidInstrumentId";
string instrumentScope = "example instrumentScope";
string settlementMode = "example settlementMode";
string contractualSettlementDate = "example contractualSettlementDate";decimal? units = "example units";decimal? settledUnits = "example settledUnits";decimal? unsettledUnits = "example unsettledUnits";decimal? overdueUnits = "example overdueUnits";

MovementSettlementSummary movementSettlementSummaryInstance = new MovementSettlementSummary(
    name: name,
    type: type,
    lusidInstrumentId: lusidInstrumentId,
    instrumentScope: instrumentScope,
    settlementMode: settlementMode,
    contractualSettlementDate: contractualSettlementDate,
    units: units,
    settledUnits: settledUnits,
    unsettledUnits: unsettledUnits,
    overdueUnits: overdueUnits);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
