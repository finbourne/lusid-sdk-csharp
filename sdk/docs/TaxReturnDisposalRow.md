# Lusid.Sdk.Model.TaxReturnDisposalRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingId** | **string** | The identifier of the holding. For a company this is the pooled LUSID instrument identifier, for a fund the portfolio code and instrument identifier. | [optional] 
**InstrumentId** | **string** | The LUSID unique identifier of the instrument. | [optional] 
**InstrumentName** | **string** | The name of the instrument. | [optional] 
**PortfolioCode** | **string** | The code of the portfolio the holding sits in, or the pooled marker for a company. | [optional] 
**DisposalDate** | **DateTimeOffset** | The date of the disposal. | [optional] 
**Units** | **decimal** | The units disposed of. | [optional] 
**Cost** | **decimal** | The allowable cost of the units disposed of. | [optional] 
**IndexationAllowanceTaken** | **decimal** | The indexation allowance deducted when arriving at the chargeable gain. | [optional] 
**ChargeableGain** | **decimal** | The chargeable gain or allowable loss on the disposal, negative for a loss. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string holdingId = "example holdingId";
string instrumentId = "example instrumentId";
string instrumentName = "example instrumentName";
string portfolioCode = "example portfolioCode";decimal? units = "example units";decimal? cost = "example cost";decimal? indexationAllowanceTaken = "example indexationAllowanceTaken";decimal? chargeableGain = "example chargeableGain";

TaxReturnDisposalRow taxReturnDisposalRowInstance = new TaxReturnDisposalRow(
    holdingId: holdingId,
    instrumentId: instrumentId,
    instrumentName: instrumentName,
    portfolioCode: portfolioCode,
    disposalDate: disposalDate,
    units: units,
    cost: cost,
    indexationAllowanceTaken: indexationAllowanceTaken,
    chargeableGain: chargeableGain);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
