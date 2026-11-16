# Lusid.Sdk.Model.TaxDeemedDisposalResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The deterministic identifier of the deemed disposal, derived from the holding and date. | [optional] 
**HoldingId** | **string** | The identifier of the holding. For a company this is the pooled LUSID instrument identifier, for a fund the portfolio code and instrument identifier. | [optional] 
**InstrumentId** | **string** | The LUSID unique identifier of the instrument. | [optional] 
**InstrumentName** | **string** | The name of the instrument. | [optional] 
**PortfolioCode** | **string** | The code of the portfolio the holding sits in, or the pooled marker for a company. | [optional] 
**Date** | **DateTimeOffset** | The date the deemed disposal arises, the end of the period. | [optional] 
**Units** | **decimal** | The units disposed of. | [optional] 
**Cost** | **decimal** | The allowable cost of the units disposed of. | [optional] 
**MarketValue** | **decimal** | The market value of the holding at the deemed-disposal date. | [optional] 
**NetAmount** | **decimal** | The net deemed amount, gains less losses. | [optional] 
**Notional** | **bool** | True when the deemed disposal is notional, as it is for a member fund, rather than an actual deemed disposal at company level. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "example id";
string holdingId = "example holdingId";
string instrumentId = "example instrumentId";
string instrumentName = "example instrumentName";
string portfolioCode = "example portfolioCode";decimal? units = "example units";decimal? cost = "example cost";decimal? marketValue = "example marketValue";decimal? netAmount = "example netAmount";
bool notional = //"True";

TaxDeemedDisposalResponse taxDeemedDisposalResponseInstance = new TaxDeemedDisposalResponse(
    id: id,
    holdingId: holdingId,
    instrumentId: instrumentId,
    instrumentName: instrumentName,
    portfolioCode: portfolioCode,
    date: date,
    units: units,
    cost: cost,
    marketValue: marketValue,
    netAmount: netAmount,
    notional: notional);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
