# Lusid.Sdk.Model.TaxFundReconciliationResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Period** | [**TaxAccountingPeriod**](TaxAccountingPeriod.md) |  | [optional] 
**CompanyTotal** | **decimal** | The company-level total of lines A, D and LR. | [optional] 
**SumOfFundProxies** | **decimal** | The sum of the member funds&#39; notional totals. | [optional] 
**Differences** | [**List&lt;TaxReconciliationDifferenceRow&gt;**](TaxReconciliationDifferenceRow.md) | The explained differences between the two sides, by holding. | [optional] 
**Unexplained** | **decimal** | The part of the difference not explained by any category. Nil when the reconciliation is complete. | [optional] 
**CompanyLineD** | **decimal** | Line D at company level. | [optional] 
**FundsLineD** | **decimal** | The sum of line D across the member funds. | [optional] 
**CompanyLineLR** | **decimal** | Line LR at company level. | [optional] 
**FundsLineLR** | **decimal** | The sum of line LR across the member funds. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

TaxAccountingPeriod? period = new TaxAccountingPeriod();
decimal? companyTotal = "example companyTotal";decimal? sumOfFundProxies = "example sumOfFundProxies";
List<TaxReconciliationDifferenceRow> differences = new List<TaxReconciliationDifferenceRow>();decimal? unexplained = "example unexplained";decimal? companyLineD = "example companyLineD";decimal? fundsLineD = "example fundsLineD";decimal? companyLineLR = "example companyLineLR";decimal? fundsLineLR = "example fundsLineLR";

TaxFundReconciliationResponse taxFundReconciliationResponseInstance = new TaxFundReconciliationResponse(
    fundId: fundId,
    period: period,
    companyTotal: companyTotal,
    sumOfFundProxies: sumOfFundProxies,
    differences: differences,
    unexplained: unexplained,
    companyLineD: companyLineD,
    fundsLineD: fundsLineD,
    companyLineLR: companyLineLR,
    fundsLineLR: fundsLineLR);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
