# Lusid.Sdk.Model.CollateralAllocationOverride
An asset and the units of it a user chooses to move for a margin call, validated against the agreement's  constraints as the allocation is.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentId** | **string** | The LUSID instrument identifier of the asset to move, or CCY_ and the currency code for cash. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**Units** | **decimal** | The units to move. | 
**CustodianAccount** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentId = "instrumentId";
ResourceId portfolioId = new ResourceId();decimal units = "units";

ResourceId? custodianAccount = new ResourceId();


CollateralAllocationOverride collateralAllocationOverrideInstance = new CollateralAllocationOverride(
    instrumentId: instrumentId,
    portfolioId: portfolioId,
    units: units,
    custodianAccount: custodianAccount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
