# Lusid.Sdk.Model.TaxDeemedDisposalsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Period** | [**TaxAccountingPeriod**](TaxAccountingPeriod.md) |  | [optional] 
**Disposals** | [**List&lt;TaxDeemedDisposalResponse&gt;**](TaxDeemedDisposalResponse.md) | The deemed disposals at the end of the period. | [optional] 
**Vintages** | [**List&lt;TaxReturnVintage&gt;**](TaxReturnVintage.md) | The deemed-disposal vintages, one per period, that feed line D. | [optional] 
**Matrix** | [**List&lt;TaxReturnSpreadInstalment&gt;**](TaxReturnSpreadInstalment.md) | The seven-period spreading matrix for the vintages. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

TaxAccountingPeriod? period = new TaxAccountingPeriod();

List<TaxDeemedDisposalResponse> disposals = new List<TaxDeemedDisposalResponse>();
List<TaxReturnVintage> vintages = new List<TaxReturnVintage>();
List<TaxReturnSpreadInstalment> matrix = new List<TaxReturnSpreadInstalment>();

TaxDeemedDisposalsResponse taxDeemedDisposalsResponseInstance = new TaxDeemedDisposalsResponse(
    fundId: fundId,
    period: period,
    disposals: disposals,
    vintages: vintages,
    matrix: matrix);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
