# Lusid.Sdk.Model.RateBreakdownComponent
A tax-characterised payout line within a CashElection on a CashDividendEvent.  Each line carries a rate-type classifier and a per-unit amount in the parent election's currency.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RateType** | **string** | Free-string distribution rate-type code (e.g. UNFR, FLFR, PID). | 
**DividendRate** | **decimal** | Per-unit amount for this line, in the parent election&#39;s dividend currency. | 

```csharp
using Lusid.Sdk.Model;
using System;

string rateType = "rateType";decimal dividendRate = "dividendRate";


RateBreakdownComponent rateBreakdownComponentInstance = new RateBreakdownComponent(
    rateType: rateType,
    dividendRate: dividendRate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
