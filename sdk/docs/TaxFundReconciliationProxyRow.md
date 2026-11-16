# Lusid.Sdk.Model.TaxFundReconciliationProxyRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundCode** | **string** | The code of the member fund. | [optional] 
**Amount** | **decimal** | The amount, in pounds. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string fundCode = "example fundCode";decimal? amount = "example amount";

TaxFundReconciliationProxyRow taxFundReconciliationProxyRowInstance = new TaxFundReconciliationProxyRow(
    fundCode: fundCode,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
