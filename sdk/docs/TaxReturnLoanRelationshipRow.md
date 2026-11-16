# Lusid.Sdk.Model.TaxReturnLoanRelationshipRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingId** | **string** | The identifier of the holding. For a company this is the pooled LUSID instrument identifier, for a fund the portfolio code and instrument identifier. | [optional] 
**InstrumentId** | **string** | The LUSID unique identifier of the instrument. | [optional] 
**InstrumentName** | **string** | The name of the instrument. | [optional] 
**PortfolioCode** | **string** | The code of the portfolio the holding sits in, or the pooled marker for a company. | [optional] 
**LedgerAmount** | **decimal** | The loan relationship credit or debit recorded in the ledger. | [optional] 
**UpliftExcluded** | **decimal** | The uplift excluded from the loan relationship figure. | [optional] 
**NetCreditDebit** | **decimal** | The net loan relationship credit or debit, after the uplift is excluded. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string holdingId = "example holdingId";
string instrumentId = "example instrumentId";
string instrumentName = "example instrumentName";
string portfolioCode = "example portfolioCode";decimal? ledgerAmount = "example ledgerAmount";decimal? upliftExcluded = "example upliftExcluded";decimal? netCreditDebit = "example netCreditDebit";

TaxReturnLoanRelationshipRow taxReturnLoanRelationshipRowInstance = new TaxReturnLoanRelationshipRow(
    holdingId: holdingId,
    instrumentId: instrumentId,
    instrumentName: instrumentName,
    portfolioCode: portfolioCode,
    ledgerAmount: ledgerAmount,
    upliftExcluded: upliftExcluded,
    netCreditDebit: netCreditDebit);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
