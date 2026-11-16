# Lusid.Sdk.Model.TaxReturnExcludedRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingId** | **string** | The identifier of the holding. For a company this is the pooled LUSID instrument identifier, for a fund the portfolio code and instrument identifier. | [optional] 
**InstrumentId** | **string** | The LUSID unique identifier of the instrument. | [optional] 
**InstrumentName** | **string** | The name of the instrument. | [optional] 
**PortfolioCode** | **string** | The code of the portfolio the holding sits in, or the pooled marker for a company. | [optional] 
**Reason** | **string** | Why the holding is outside the return. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string holdingId = "example holdingId";
string instrumentId = "example instrumentId";
string instrumentName = "example instrumentName";
string portfolioCode = "example portfolioCode";
string reason = "example reason";

TaxReturnExcludedRow taxReturnExcludedRowInstance = new TaxReturnExcludedRow(
    holdingId: holdingId,
    instrumentId: instrumentId,
    instrumentName: instrumentName,
    portfolioCode: portfolioCode,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
