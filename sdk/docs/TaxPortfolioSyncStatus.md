# Lusid.Sdk.Model.TaxPortfolioSyncStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**LastTransactionAsAt** | **DateTimeOffset?** | The asAt the latest transaction was booked to the portfolio. Absent when the portfolio has no transactions. | [optional] 
**LastTaxAsAt** | **DateTimeOffset?** | The asAt the tax engine last processed the Fund, taken from its latest valuation point. Absent when no valuation point has been run. | [optional] 
**InSync** | **bool** | True when the tax position is no older than the latest booked transaction, or the portfolio has no transactions. | 
**AssetClass** | **string** | The asset class of the portfolio&#39;s holdings where the holding data carries one. Optional. | [optional] 
**CountryOfDomicile** | **string** | The country of domicile of the portfolio&#39;s holdings where the holding data carries one. Optional. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
bool inSync = //"True";
string assetClass = "example assetClass";
string countryOfDomicile = "example countryOfDomicile";

TaxPortfolioSyncStatus taxPortfolioSyncStatusInstance = new TaxPortfolioSyncStatus(
    portfolioId: portfolioId,
    lastTransactionAsAt: lastTransactionAsAt,
    lastTaxAsAt: lastTaxAsAt,
    inSync: inSync,
    assetClass: assetClass,
    countryOfDomicile: countryOfDomicile);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
